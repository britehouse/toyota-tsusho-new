using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Toyota.Tsusho.CRM.API.DataContracts;

namespace Toyota.Tsusho.CRM.API.ServiceImplementation
{
    [ServiceBehavior(Name = "OrderService",
        Namespace = "http://www.ttaf.co.za/crm/api/2014/08",
        InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Single)]
    public abstract class OrderServiceBase : Toyota.Tsusho.CRM.API.ServiceContracts.IOrderService
    {
        public void Notify(Toyota.Tsusho.CRM.API.MessageContracts.OrderNotifyRequestMessage request)
        {
            using (OrganizationServiceProxy proxy = CRMHelper.Connect())
            {
                ServiceContext context = new ServiceContext(proxy);

                foreach (OrderItemDataContract item in request.Items)
                {
                    bool add = false;

                    Entity entity = null;

                    Invoice record = (from a in context.InvoiceSet
                                      where a.new_saporderno == item.Invoice.new_saporderno
                                      select a).FirstOrDefault();

                    if (record == null)
                    {
                        add = true;

                        record = new Invoice();
                    }

                    //CustomerId Lookup

                    Contact contact = (from c in context.ContactSet
                                       where c.new_customeraccountnumber == item.Invoice.CustomerId.Name
                                       select c).FirstOrDefault();

                    if (contact == null)
                        throw new Exception(String.Format("No Contact could be retrieved for {0}", item.Invoice.CustomerId.Name));

                    //SalesOrder

                    SalesOrder order = null;

                    if (item.Invoice.SalesOrderId != null)
                    {
                        order = (from o in context.SalesOrderSet
                                            where o.new_DBMOrderNumber == item.Invoice.SalesOrderId.Name
                                            select o).FirstOrDefault();
                    }

                    //SalesOffice

                    Territory salesOffice = null;

                    if (item.Invoice.new_salesoffice != null)
                    {
                        entity = (from s in context.CreateQuery("territory")
                                     where s["new_sapcode"] == item.Invoice.new_salesoffice.Name
                                     select s).FirstOrDefault();

                        if (entity != null)
                            salesOffice = entity.ToEntity<Territory>();
                    }

                    //Plant

                   entity = (from p in context.CreateQuery("territory")
                                     where p["new_sapcode"] == item.Invoice.new_plant.Name
                                     select p).FirstOrDefault();

                   Territory plant = null;
                   
                    if(entity != null)
                        plant = entity.ToEntity<Territory>();

                    //new_invoicetype

                    new_invoicetype invoiceType = null;

                    if(item.Invoice.new_invoicetype != null)
                    {
                        entity = (from it in context.CreateQuery("new_invoicetype")
                                     where it["new_typeidinvoice"] == item.Invoice.new_invoicetype.Name
                                     select it).FirstOrDefault();

                        if(entity != null)
                            invoiceType = entity.ToEntity<new_invoicetype>();
                    }

                    //Populate Order Fields

                    record.new_saporderno = item.Invoice.new_saporderno;

                    record.new_client = item.Invoice.new_client;

                    if (contact != null)
                        record.CustomerId = contact.ToEntityReference();

                    if (order != null)
                        record.SalesOrderId = order.ToEntityReference();

                    record.new_precedingdocument = item.Invoice.new_precedingdocument;

                    if (salesOffice != null)
                        record.new_salesoffice = salesOffice.ToEntityReference();

                    if(plant != null)
                        record.new_plant = plant.ToEntityReference();

                    record.new_customeradviser = item.Invoice.new_customeradviser;
                    record.new_billingdate = item.Invoice.new_billingdate;
                    record.new_licenseplatenumber = item.Invoice.new_licenseplatenumber;
                    record.new_country = item.Invoice.new_country;
                    record.new_counterreading = item.Invoice.new_counterreading;
                    record.new_counterunit = item.Invoice.new_counterunit;
                    record.new_orderstatus = item.Invoice.new_orderstatus;
                    record.new_netvalue = item.Invoice.new_netvalue;
                    record.new_vehicleguid = item.Invoice.new_vehicleguid;

                    if (invoiceType != null)
                        record.new_invoicetype = invoiceType.ToEntityReference();

                    if (add)
                        context.AddObject(record);
                    else
                        context.UpdateObject(record);

                    //Invoice Detail

                    //We will nowdelete all line item s and readd them
                    //if we do not do this we will get duplicate records.

                    if (record.invoice_details != null)
                    {
                        foreach (InvoiceDetail detail in record.invoice_details)
                            context.DeleteObject(detail);
                    }

                    foreach (InvoiceDetail lineItem in item.InvoiceDetails)
                    {
                        InvoiceDetail detail = new InvoiceDetail();

                        //new_material

                        new_modelsalescode material = null;

                        if(detail.new_material != null)
                        {
                            material = (from m in context.new_modelsalescodeSet
                                            where m.new_name == lineItem.new_material.Name
                                        select m).FirstOrDefault();
                        }

                        //Plant

                        Territory detailPlant = null;

                        if (lineItem.new_plant != null)
                        {
                            entity = (from p in context.CreateQuery("territory")
                                      where p["new_sapcode"] == lineItem.new_plant.Name
                                      select p).FirstOrDefault();

                            if (entity != null)
                                detailPlant = entity.ToEntity<Territory>();
                        }

                        //Populate Invoice Detail

                        detail.LineItemNumber = lineItem.LineItemNumber;
                        detail.new_pricingreferencematerial = lineItem.new_pricingreferencematerial;
                        detail.new_lvhierno = lineItem.new_lvhierno;

                        if (material != null)
                            detail.new_material = material.ToEntityReference();

                        detail.new_materialgroup = lineItem.new_materialgroup;
                        detail.ProductDescription = lineItem.ProductDescription;
                        detail.IsPriceOverridden = lineItem.IsPriceOverridden;
                        detail.IsProductOverridden = lineItem.IsProductOverridden;
                        detail.new_description1 = lineItem.new_description1;
                        detail.new_itemcategory = lineItem.new_itemcategory;
                        detail.new_deleteitem = lineItem.new_deleteitem;
                        detail.Quantity = lineItem.Quantity;
                        detail.new_targetqtyuom = lineItem.new_targetqtyuom;
                        detail.new_baseunit = lineItem.new_baseunit;
                        detail.new_targetqtyuom = lineItem.new_targetqtyuom;
                        detail.new_division = lineItem.new_division;
                        detail.PricePerUnit = lineItem.PricePerUnit;
                        detail.new_salesunit = lineItem.new_salesunit;

                        if (detailPlant != null)
                            detail.new_plant = detailPlant.ToEntityReference();

                        detail.new_storagelocation = lineItem.new_storagelocation;

                        context.AddRelatedObject(record, new Relationship("invoice_details"), detail);
                    }
                }

                context.SaveChanges();
            }

        }
    }

    public partial class OrderService : OrderServiceBase
    {

    }
}
