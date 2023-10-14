
echo on
pause
for %%f in (\..\..\*.VB) do pause %%f
pause
for %%f in (\..\..\*.VB) do dir %%f
pause
Echo "Start" >0Messages.txt
for %%f in (\..\..\*.VB) do Find /I  "Follow" <%%F >>0messages.txt
pause
for %%f in (\..\..\*.VB) do Find /I  "MSG_" <%%F >>0messages.txt
pause
for %%f in (\..\..\*.VB) do Find /I  "Debug.Print" <%%F >>0messages.txt
pause
sort <0Messages.txt >1Messages.txt

dir
pause