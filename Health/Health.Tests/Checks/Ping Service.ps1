#########################################################
#
# Ping Service script
#
#########################################################
 
[CmdletBinding()]
Param(
  [Parameter(Mandatory=$True)]
  [string] $Url
)

$result = Invoke-WebRequest $Url

if($result.StatusCode -ne 200)
{
	throw -join ("Invoke to ", $Url, " failed.")
}