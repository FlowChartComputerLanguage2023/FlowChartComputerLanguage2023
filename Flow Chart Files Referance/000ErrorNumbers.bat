echo on
Echo "                         Start" >0Messages.txt
Echo "Follow"
for %%f in (..\..\*.VB) do Find /I  "Follow" <%%f >>0messages.txt
pause
Echo "MSG_"
for %%f in (..\..\*.VB) do Find /I  "MSG_" <%%f >>0messages.txt
pause
Echo "debug.print"
for %%f in (..\..\*.VB) do Find /I  "Debug.Print" <%%f >>0messages.txt
pause
Echo "Sorting"
sort <0Messages.txt >1Messages.txt

pause