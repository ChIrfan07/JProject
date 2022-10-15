@ECHO OFF
ECHO JProject



set dllpath=D:\JProject\JProject\bin\Debug\JProject.dll

set SummaryReportPath=D:\JProject\JProject\SummaryReportPath


call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"


VSTest.Console.exe  %dllpath% /Logger:"trx;LogFileName=%SummaryReportPath%\irfan.trx"

cd D:\JProject\JProject\bin\Debug

TrxToHTML %SummaryReportPath%

PAUSE