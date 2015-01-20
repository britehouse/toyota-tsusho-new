#########################################################
#
# Ping Server script
#
#########################################################
 
[CmdletBinding()]
Param(
  [Parameter(Mandatory=$True)]
  [string] $Server
)

$result = (Test-Connection $Server).StatusCode

if($result -ne 0)
{
	throw -join ("Ping to ", $Server, " failed.")
}