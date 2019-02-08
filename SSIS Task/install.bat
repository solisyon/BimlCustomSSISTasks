"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.2 Tools\gacutil.exe" -u ICSharpCode.SharpZipLib
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.2 Tools\gacutil.exe" -u Newtonsoft.Json
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.2 Tools\gacutil.exe" -u oh22is.DTS.Task.ZIP2017

copy "C:\Projects\ssiscomponents.visualstudio.com\SSIS ZIP\oh22is.SSIS.Task.ZIP\bin\Debug\ICSharpCode.SharpZipLib.dll" "C:\Program Files (x86)\Microsoft SQL Server\140\DTS\Tasks" /y
copy "C:\Projects\ssiscomponents.visualstudio.com\SSIS ZIP\oh22is.SSIS.Task.ZIP\bin\Debug\Newtonsoft.Json.dll" "C:\Program Files (x86)\Microsoft SQL Server\140\DTS\Tasks" /y
copy "C:\Projects\ssiscomponents.visualstudio.com\SSIS ZIP\oh22is.SSIS.Task.ZIP\bin\Debug\oh22is.DTS.Task.ZIP2017.dll" "C:\Program Files (x86)\Microsoft SQL Server\140\DTS\Tasks" /y

"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.2 Tools\gacutil.exe" -i "C:\Projects\ssiscomponents.visualstudio.com\SSIS ZIP\oh22is.SSIS.Task.ZIP\bin\Debug\ICSharpCode.SharpZipLib.dll"
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.2 Tools\gacutil.exe" -i "C:\Projects\ssiscomponents.visualstudio.com\SSIS ZIP\oh22is.SSIS.Task.ZIP\bin\Debug\Newtonsoft.Json.dll"
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.2 Tools\gacutil.exe" -i "C:\Projects\ssiscomponents.visualstudio.com\SSIS ZIP\oh22is.SSIS.Task.ZIP\bin\Debug\oh22is.DTS.Task.ZIP2017.dll"