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

 $SourcesDirectory=$Env:BUILD_SOURCESDIRECTORY
 Write-Host "SourcesDirectory : $SourcesDirectory"
try {
#$SourcesDirectory="D:\ESIT_BuildManagement1"

& "C:\Program Files (x86)\MSBuild\12.0\Bin\MSBuild.exe" "$SourcesDirectory\PilotProjects\GenericSolution\GenericTestCases.sln" /t:rebuild /p:Configuration=Release
#$BuildError1=$LASTEXITCODE

Robocopy.exe "$SourcesDirectory\PilotProjects\GenericSolution\GenericTestCases\bin\Release" "$SourcesDirectory\Drop"


exit 0;
}
catch {
[system.exception]
write-output $_.exception.message
}
finally
{
# if (build error1) { throw "msbuild failed to build generictestcases sln"}
Write-Output "precompile executed successfully!"


}