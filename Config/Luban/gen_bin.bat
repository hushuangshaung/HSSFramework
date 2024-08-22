echo off
set LUBAN_DLL=..\..\Tools\Luban\Luban.dll
set CONF_ROOT=..\
set CODE_PATH=..\..\HotUpdate\Code\Config
set JSON_PATH=..\Json
set Bytes_PATH=..\Bytes
set LanguageTable_PATH = ..\LanguageTable\LanguageTable_zh.xlsx
	
dotnet %LUBAN_DLL% ^
    -t all ^
    -c cs-bin ^
    -d bin ^
    --conf %CONF_ROOT%\luban.conf ^
    -x outputCodeDir=%CODE_PATH% ^
    -x outputDataDir=%Bytes_PATH% 

pause
:end
exit