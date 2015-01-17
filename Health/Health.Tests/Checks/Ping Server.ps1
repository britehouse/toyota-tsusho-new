#########################################################
#
# Ping Server script
#
#########################################################
 
# Set the Server to ping
[string] $server = "www.google.co.za"

$result = (Test-Connection $server).StatusCode

if($result -ne 0)
{
	throw -join ("Ping to ", $server, " failed.")
}