#########################################################
#
# Ping Service script
#
#########################################################
 
# Set the Server to ping
[string] $url = "http://localhost/Toyota.Tsusho.TALO.API/CustomerNotifyService.svc"

$result = Invoke-WebRequest $url

if($result.StatusCode -ne 200)
{
	throw -join ("Invoke to ", $url, " failed.")
}