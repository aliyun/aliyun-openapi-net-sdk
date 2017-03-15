@echo off&setlocal enabledelayedexpansion
%~dp0nuget.exe setApiKey <nuget_api_key> -source https://www.nuget.org
for /f %%a in ('dir *.nupkg /a/s/b') do (
%~dp0nuget.exe push %%a -Source https://www.nuget.org/api/v2/package
)