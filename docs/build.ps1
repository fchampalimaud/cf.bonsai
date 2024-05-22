$baseFolder = @("..\")

Write-Host ("Generate SVGs for all examples found..." )
.\docfx-tools\modules\Export-Image.ps1 -libPath $baseFolder -bootstrapperPath "..\.bonsai\Bonsai.exe" -workflowPath "..\workflows"

# Build documentation
dotnet docfx @args