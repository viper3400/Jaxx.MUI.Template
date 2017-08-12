$NewSolutionName = (Get-Item * | Select Parent).Parent.Name
Write-Host "Gathered new solution name from parent folder: $NewSolutionName."

If (Test-Path ".git")
{
    Write-Host "Remove .git path"
    Remove-Item -Recurse -Force ".git"
}

If (Test-Path ".vs")
{
    Write-Host "Remove .vs path"
    Remove-Item -Recurse -Force ".vs"
}

If (Test-Path "src\Jaxx.MUI.Template\bin")
{
    Write-Host "Remove path src\Jaxx.MUI.Template\bin"
    Remove-Item -Recurse -Force "src\Jaxx.MUI.Template\bin"
}

If (Test-Path "src\Jaxx.MUI.Template\obj")
{
    Write-Host "Remove path src\Jaxx.MUI.Template\obj"
    Remove-Item -Recurse -Force "src\Jaxx.MUI.Template\obj"
}

Rename-Item -NewName "$NewSolutionName.sln" -Path Jaxx.MUI.Template.sln -Force
Rename-Item -NewName "$NewSolutionName.csproj" -Path src\Jaxx.MUI.Template\Jaxx.MUI.Template.csproj -Force
Rename-Item -NewName "$NewSolutionName" -Path src\Jaxx.MUI.Template -Force

 Write-Host "Replace Jaxx.MUI.Template in files"
Get-ChildItem * -recurse  | Where-Object {$_.Attributes -ne "Directory"} | ForEach-Object {  (Get-Content $_.FullName) -replace "Jaxx.MUI.Template","$NewSolutionName" | Set-Content -path $_.FullName }
