#########################################################
#
# Ping Service script
#
#########################################################
 
[CmdletBinding()]
Param(
  [Parameter(Mandatory=$True)]
  [service] $url
)

$result = Invoke-WebRequest $url

if($result.StatusCode -ne 200)
{
	throw -join ("Invoke to ", $url, " failed.")
}