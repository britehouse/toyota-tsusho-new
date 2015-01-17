#########################################################
#
# BizTalk Receive Location monitoring script
#
#########################################################

$name = "Toyota.Tsusho.CRM.Services.Generic.WCF-WSHTTP"

$location = Get-WMIObject  -Class MSBTS_ReceiveLocation -namespace "root\MicrosoftBizTalkServer" -Filter "Name = '$name'"

if($location.IsDisabled)
{
	throw -join("BizTalk Receive Location ", $name, " is disabled.")
}

# End of Script