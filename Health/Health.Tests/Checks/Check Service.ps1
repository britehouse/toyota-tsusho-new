#########################################################
#
# BizTalk Service monitoring script
#
#########################################################

$name = 'BTSSvc$BizTalkServerApplication'

$service = get-Service $name

if($service.Status -ne "Running")
{
	throw -join($name, " is in a ", $service.Status, " state.")
}

# End of Script