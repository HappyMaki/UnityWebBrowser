git clone https://gitlab.com/Voltstro-Studios/WebBrowser/Package.git

if(Compare-Object -ReferenceObject $(Get-Content UnityWebBrowserSource/src/CefBrowser/package.json) -DifferenceObject $(Get-Content Package/package.json))
{
    Write-Host "Changes in package.json, deploying..."

    Remove-Item -Recurse Package/* -Exclude .git

    Get-ChildItem -Path UnityWebBrowserSource/src/CefBrowser/ | Copy-Item -Destination Package/ -Recurse -Container -Force -PassThru

    Get-ChildItem -Path Linux-CefBrowserProcess/ | Copy-Item -Destination Package/Plugins/CefBrowser/linux-x64 -Recurse -Container -Force -PassThru
    Get-ChildItem -Path Windows-CefBrowserProcess/ | Copy-Item -Destination Package/Plugins/CefBrowser/win-x64 -Recurse -Container -Force -PassThru

    Remove-Item -Path Package/Plugins/CefBrowser/.gitignore -Force

    #Set-Location -path "Package/"
    #git config --global user.name "Voltstro"
    #git config --global user.email "me@voltstro.dev"
    #git remote set-url origin git@gitlab.com:Voltstro-Studios/WebBrowser/Package.git
    #git add *
    #git commit -m "Update"
    #git push
}
else 
{
    Write-Host "No changes in package.json."
}