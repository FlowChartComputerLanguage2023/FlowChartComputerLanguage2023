
find dump3.txt /I "ABug" >0ABug.txt
find dump3.txt /I "Error" >0Error.txt
find dump3.txt /I "Warning" >0Warning.txt
find dump3.txt /I "FMB:" >0FMB.txt
find dump3.txt /I "FindingMyBugs:" >0FindingMyBugs.txt
pause
sort <0abug.txt >1abug.txt /rec 32000 
sort <0Error.txt >1Error.txt /rec 32000 
sort <0Warning.txt >1Warning.txt /rec 32000 
sort <0FMB.txt >1FMB.txt /rec 32000 
sort <0FindingMyBugs.txt >1FindingMyBugs.txt /rec 32000 
sort <dump3.txt >1Dump3.txt /rec 32000 

