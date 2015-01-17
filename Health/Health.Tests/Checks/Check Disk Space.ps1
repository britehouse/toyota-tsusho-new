#########################################################
#
# Disk space monitoring script
#
#########################################################
 
# Set free disk space threshold below in percent (default at 10%)
[decimal] $threshold = 10
 
#assemble together all of the free disk space data and only include it if the percentage free is below the threshold we set above.

Get-WMIObject  -Class Win32_LogicalDisk `
| Select-Object DriveType, VolumeName, Name, @{n='Size (Gb)' ;e={"{0:n2}" -f ($_.size/1gb)}},@{n='FreeSpace (Gb)';e={"{0:n2}" -f ($_.freespace/1gb)}}, @{n='PercentFree';e={"{0:n2}" -f ($_.freespace/$_.size*100)}}  `
| Where-Object {$_.DriveType -eq 3 -and [decimal]$_.PercentFree -lt [decimal]$threshold} `
| ForEach-Object {throw -join(("Volume ", $_.Name), " has less than ", $threshold, "% free space available.")}

# End of Script