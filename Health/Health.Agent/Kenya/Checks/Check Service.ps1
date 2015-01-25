#########################################################
#
# BizTalk Service monitoring script
#
#########################################################


[CmdletBinding()]
Param(
  [Parameter(Mandatory=$True)]
  [string] $Service
)

$instance = get-Service $Service

if($instance.Status -ne "Running")
{
	throw -join($Service, " is in a ", $instance.Status, " state.")
}

# End of Script