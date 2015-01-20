#########################################################
#
# BizTalk Receive Location monitoring script
#
#########################################################

[CmdletBinding()]
Param(
  [Parameter(Mandatory=$True)]
  [string] $ReceiveLocationName
)

$name = "Toyota.Tsusho.CRM.Services.Generic.WCF-WSHTTP"

$location = Get-WMIObject  -Class MSBTS_ReceiveLocation -namespace "root\MicrosoftBizTalkServer" -Filter "Name = '$ReceiveLocationName'"

if($location.IsDisabled)
{
	throw -join("BizTalk Receive Location ", $ReceiveLocationName, " is disabled.")
}

# End of Script