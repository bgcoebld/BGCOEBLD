<#                                   
.SYNOPSIS
Generic script to run PublishDrop
.DESCRIPTION
Generic script to run PublishDrop
.EXAMPLE
.\PublishDrop.ps1 -SourcesDirectory "D:\TB\Project\Branch\Sources" -DestinationPath "\\BuildMachineName\Release\Project\Branch"

.EXAMPLE

Version History  
v1.0   - ESIT Build Team - Initial Release
#>

param(
         [String]$SourcesDirectory=$(throw "pass: Sources directory.  Root location of bits to drop")
         ,[String]$DestinationPath=$(throw "Pass : Destination (UNC) path")
                  
		 
     )


    
try {
#$SourcesDirectory="D:\ESIT_BuildManagement"
& "C:\Program Files (x86)\MSBuild\12.0\Bin\MSBuild.exe" "$SourcesDirectory\PilotProjects\GenericSolution\GenericTestCases.sln" /t:rebuild /p:Configuration=Release
$BuildError1 = $LASTEXITCODE

#Robocopy.exe "$SourcesDirectory\PilotProjects\GenericSolution\GenericTestCases\bin\Release" "$DestinationPath"

exit 0;
}

catch{
[System.Exception]
 Write-Output $_.Exception.Message
}

finally{
if ($BuildError1) { throw "msbuild failed to build GenericTestCases sln" }
write-OutPut "pre compile executed successfully!"
}