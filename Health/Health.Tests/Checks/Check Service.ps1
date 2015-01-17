#########################################################
#
# BizTalk Service monitoring script
#
#########################################################


[CmdletBinding()]
Param(
  [Parameter(Mandatory=$True)]
  [service] $service
)

$instance = get-Service $name

if($instance.Status -ne "Running")
{
	throw -join($service, " is in a ", $instance.Status, " state.")
}

# End of Script