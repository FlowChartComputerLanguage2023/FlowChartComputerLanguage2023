

Option Strict Off
Imports System.Management
Imports System.Reflection.Emit
Imports System.Text



Imports System
Imports System.Drawing
Imports System.Collections.Generic
Imports System.Reflection
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles

Module CPUID0001
    '#Const MINEDEBUG =50

    Structure POINTAPI
        Dim x As Long
        Dim y As Long
    End Structure

    '    Structure MSG
    '    Dim Handle2Window As Long
    '    Dim message As Long
    '    Dim wParam As Long
    '    Dim lParam As Long
    '    Dim time As Long
    '    Dim pt As POINTAPI
    '    End Structure

    Class CPUID1





        Public Function CPU_ID_do_not_use() As String
            'On Error Resume Next
            Dim debug1 As Object
            Dim RTN As String = ""
            Dim strComputer = My.Computer.Name.ToString()
            Dim objWMIService As Object
            Dim colSMBIOS As Object
            Dim debug2 As Object
            'fc12.MyFlowChartNameSpace.F_C.FollowLog(2746, Now() & " Starting WindowManagement ")
            'changed winmgmts: to winmgmts
            objWMIService = GetObject("winmgmts" & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")
            colSMBIOS = objWMIService.ExecQuery("Select * from Win32_SystemEnclosure")
            For Each debug2 In colSMBIOS
                RTN &= strComputer & ": " & debug2.SerialNumber & vbCrLf
                'MsgBox(strComputer & ": " & objSMBIOS.SerialNumber)
            Next
            For Each debug1 In colSMBIOS
                MyFlowChartNameSpace.F_C.DebugWrite("10014" & debug1.GetType.FullName)
                MyFlowChartNameSpace.F_C.DebugWrite("10015" & debug1.GetType.IsArray.ToString)
                MyFlowChartNameSpace.F_C.DebugWrite("10016" & debug1.GetType.Name)
                MyFlowChartNameSpace.F_C.follow(5, "10017" & debug1.GetType.Namespace.ToString)
            Next

            MyFlowChartNameSpace.F_C.FollowLog(2747, 1, Now() & " finished Window Management  " & RTN)
            Return RTN
        End Function


        Public Shared Function CPU_ID() As String
            Return Environment.UserName & ", " & Environment.UserDomainName & ", " & My.User.Name & Environment.CurrentDirectory & ", " & Environment.UserDomainName

            ' Get the Windows Management Instrumentation object.
            Dim wmi As Object = GetObject("WinMgmts:")

            ' Get the "base boards" (mother boards).
            Dim serial_numbers As String = ""
            Dim mother_boards As Object =
                wmi.InstancesOf("Win32_BaseBoard")
            For Each board As Object In mother_boards
                serial_numbers &= ", " & board.SerialNumber
            Next board
            If serial_numbers.Length > 0 Then serial_numbers =
                serial_numbers.Substring(2)
            Return serial_numbers
        End Function
    End Class
End Module
