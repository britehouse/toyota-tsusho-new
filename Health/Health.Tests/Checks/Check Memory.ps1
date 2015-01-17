#########################################################
#
# Available Memory monitoring script
#
#########################################################
 
# Set memory threshold below in percent (default at 20%)
[decimal] $threshold = 20


$free = (Get-WmiObject -Class Win32_OperatingSystem | Select-Object FreePhysicalMemory).FreePhysicalMemory

$physical = (Get-WmiObject -Class CIM_PhysicalMemory | Measure-Object -Property capacity -Sum).Sum / 1024

# Display free memory on Server

$percentage = (($free/$physical*100))

if($percentage -lt $threshold)
{
	throw -join ("Less than ", $threshold, "% physical memory available.")
}