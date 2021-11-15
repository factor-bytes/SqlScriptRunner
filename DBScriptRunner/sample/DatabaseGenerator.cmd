@echo off
echo.
echo Creating Database.......
D:\Projects\SqlDbScriptCreator\DBScriptRunner\bin\Debug\netcoreapp3.1\DBScriptRunner.exe -scriptfile "D:\Projects\SqlDbScriptRunner\DBScriptCreator\sample\data\TableGenerator.sql" -servername "localhost" -dbname "SampleDb" -username "user" -password "password"
if ERRORLEVEL 1 goto error
goto ok
:error
echo.
echo Error while updating DB.
if not "%1"=="-noninteractive" (pause)
if "%1"=="" goto end

goto end

:ok
echo.
echo Database updated succesfully.
if not "%1"=="-noninteractive" (pause)
if "%1"=="" goto end

:end