#########################################################
#
# Ping Server script
#
#########################################################
 
[CmdletBinding()]
Param(
  [Parameter(Mandatory=$True)]
  [service] $server
)

$result = (Test-Connection $server).StatusCode

if($result -ne 0)
{
	throw -join ("Ping to ", $server, " failed.")
}