@echo off

rem Environment variables are local only and thus forgotten when script exits
setlocal

title msbuilr
set DOTNET_FRAMEWORK=4.0.30319
set MSBUILD=%SYSTEMROOT%\Microsoft.NET\Framework\v%DOTNET_FRAMEWORK%\MSBuild.exe
set OUTPUT=build
SET CONFIG=%1
IF NOT DEFINED CONFIG SET CONFIG="Release"
SET PLATFORM=%2
IF NOT DEFINED PLATFORM SET PLATFORM="x64"

echo compilation configuration: %CONFIG%

if not exist %MSBUILD% goto :requirements_missing

if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://nuget.org/nuget.exe', '.\nuget.exe')"
.\nuget.exe restore src\\NPrintingRestClient\packages.config -o packages
.\nuget.exe restore src\\ADSyncDemoApp\packages.config -o packages

:build
set LOG=build.log
if exist %LOG% del %LOG%

call %MSBUILD%  src\ADSyncDemoApp\ADSyncDemoApp.csproj /m /verbosity:normal /p:Configuration=%CONFIG%;Platform=%PLATFORM%;OutputPath=%OUTPUT% /t:rebuild

goto end

:requirements_missing
echo ###############################################################################
echo  You don't seem to have MSBuild or you have the wrong version.
echo  Was looking for:
echo   %MSBUILD%
echo ###############################################################################
goto end

:goto end

:end