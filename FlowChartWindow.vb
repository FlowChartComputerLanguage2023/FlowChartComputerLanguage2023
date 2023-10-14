


Option Strict On
Option Infer Off
Option Compare Text
Option Explicit On

Imports System.ComponentModel
'#Const DebugCompile = 50



Public Class FlowChartWindow

    'DONE KINDA, NEEDS WORK todo added splash Window (do above, or OK button to start up window.

    Friend Const ShowWindow As Int32 = 1
    Friend Const HideWindow As Int32 = 0
    Friend Const LeaveWindow As Int32 = -1
    'flow10'This belongs in status or option Window*************************???????

    Private Sub ButtonCheck_Click(sender As Object, e As EventArgs)
        Const ButtonStartedName As String = "Flow Chart  CheckAll."
        MyFlowChartNameSpace.F_C.Follow(2607, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.CheckAll()
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub



    '****************************************************************
    ' 10 This is used to redraw the FlowChart (Cause it gets messed up, and I have to fix that one of these days)
    Private Sub ToolStripButtonRedraw_Click(sender As Object, e As EventArgs) Handles ToolStripButtonRedraw.Click
        Const ButtonStartedName As String = "Flow Chart  Redraw."
        MyFlowChartNameSpace.F_C.Follow(2608, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.Clear_Window(Me.PictureBox1)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
    End Sub

    '****************************************************************
    ' 11 This is used to enlarge the FlowChart.(You see a part of the picture)
    Private Sub ToolStripButtonZoomIn_Click(sender As Object, e As EventArgs) Handles ToolStripButtonZoomIn.Click
        Const ButtonStartedName As String = "Flow Chart  Zoom in."
        MyFlowChartNameSpace.F_C.Follow(2609, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyUniverse.SysGen.MyFlowChartScale *= MyFlowChartNameSpace.F_C.ConstantFlowChartScaleChange
        MyFlowChartNameSpace.F_C.LimitScale()
        MyFlowChartNameSpace.F_C.Clear_Window(Me.PictureBox1)

        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
        MyFlowChartNameSpace.F_C.Follow(2609, 3, ButtonStartedName & " " & MyFlowChartNameSpace.F_C.MyUniverse.SysGen.MyFlowChartScale)
    End Sub
    '****************************************************************
    ' 12 This is used to reduce the FlowChart on the Window (You can see more of the picture)
    Private Sub ToolStripButtonZoomOut_Click(sender As Object, e As EventArgs) Handles ToolStripButtonZoomOut.Click
        Const ButtonStartedName As String = "Flow Chart  Zoom Out."
        MyFlowChartNameSpace.F_C.Follow(2610, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyUniverse.SysGen.MyFlowChartScale /= MyFlowChartNameSpace.F_C.ConstantFlowChartScaleChange
        MyFlowChartNameSpace.F_C.LimitScale()
        MyFlowChartNameSpace.F_C.Clear_Window(Me.PictureBox1)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
        MyFlowChartNameSpace.F_C.Follow(2610, 3, ButtonStartedName & " " & MyFlowChartNameSpace.F_C.MyUniverse.SysGen.MyFlowChartScale)
    End Sub


    '****************************************************************
    ' 8 This is used to put a Constant (entered in the textbox on the toolstrip)
    'You should/(Must?) place it on a path (end points or turn of a path)
    Private Sub ToolStripButtonAddConstant_Click(sender As Object, e As EventArgs) Handles ToolStripButtonAddConstant.Click
        Const ButtonStartedName As String = "Flow Chart  Command Add Constant."
        MyFlowChartNameSpace.F_C.Follow(2611, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.MyCmdModeString = "CommandAddConstant"
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub

    Private Sub FlowChartWindow_Load(sender As Object, e As EventArgs) Handles Me.Load
        Const ButtonStartedName As String = "Flow Chart Window Starting"
        If MyFlowChartNameSpace.F_C.MyDebug(6) = True Then MyFlowChartNameSpace.F_C.Follow(2612, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        'MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ProgramBuzzy("Begin") Then
            MyFlowChartNameSpace.F_C.Init()
        End If
        MyFlowChartNameSpace.F_C.ShowAllForms(HideWindow, LeaveWindow, ShowWindow, LeaveWindow)
    End Sub



    '****************************************************************
    'This go to the FlowChartWindow
    Private Sub ButtonSymbolForm_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSymbolForm.Click
        Const ButtonStartedName As String = "Flow Chart  Showing the Symbol Window."
        MyFlowChartNameSpace.F_C.Follow(2613, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.MyCmdModeString = "Command_Add_Symbol"
        MyFlowChartNameSpace.F_C.ShowAllForms(HideWindow, ShowWindow, HideWindow, LeaveWindow)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub


    '****************************************************************
    '6 This moves what ever is closest to where the MouseUp is
    Private Sub ButtonMoveObject_Click(sender As Object, e As EventArgs) Handles ToolStripButtonMoveObject.Click
        Const ButtonStartedName As String = "Flow Chart  Command Move Object."
        MyFlowChartNameSpace.F_C.Follow(2614, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.MyCmdModeString = "CmdMove"
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub

    '****************************************************************
    ' This will delete what ever is closest to the mouse down
    ' Advise that you move first to somewhere that is clear, and then delete it.
    Private Sub ButtonDeleteObject_Click(sender As Object, e As EventArgs) Handles ToolStripButtonDeleteobject.Click
        Const ButtonStartedName As String = "Flow Chart  Command Delete Object."
        MyFlowChartNameSpace.F_C.Follow(2615, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.MyCmdModeString = "CmdDelete"
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub



    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Const ButtonStartedName As String = "Flow Chart FlowChart Window H Scroll"
        MyFlowChartNameSpace.F_C.Follow(2616, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.Clear_Window(Me.PictureBox1)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Const ButtonStartedName As String = "Flow Chart FlowChart Window V scroll"
        MyFlowChartNameSpace.F_C.Follow(2617, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.Clear_Window(Me.PictureBox1)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
    End Sub


    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Const ButtonStartedName As String = "Flow Chart FlowChart Window Mouse Down"
        MyFlowChartNameSpace.F_C.Follow(2618, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyUniverse.MyMouseAndDrawing.MouseStatus = "MouseDown"
        MyFlowChartNameSpace.F_C.MyMouseDown(e) 'Me.PictureBox1, e)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        Const ButtonStartedName As String = "Flow Chart FlowChart Window Mouse Up"
        If MyFlowChartNameSpace.F_C.MyDebug(6) = True Then MyFlowChartNameSpace.F_C.Follow(2619, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyUniverse.MyMouseAndDrawing.MouseStatus = "MouseUp"
        MyFlowChartNameSpace.F_C.MyMouseUp(Me.PictureBox1, e)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Const ButtonStartedName As String = "Flow Chart FlowChart Window Mouse Move"
        If MyFlowChartNameSpace.F_C.MyDebug(6) = True Then MyFlowChartNameSpace.F_C.Follow(2620, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyUniverse.MyMouseAndDrawing.MouseStatus = "MouseMove"
        MyFlowChartNameSpace.F_C.MyMouseMove(Me.PictureBox1, e)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName & ".Command set to " & MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.MyCmdModeString & ", " & e.X.ToString & "," & e.Y.ToString & " (" & e.Button.ToString & ", " & e.Clicks.ToString & ")")
    End Sub

    Private Sub PictureBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseWheel
        Const ButtonStartedName As String = "FlowChart Window Mouse Wheel Moved"
        MyFlowChartNameSpace.F_C.Follow(2621, 3, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyMouseWheel(e)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName & " Scale set to  " & MyFlowChartNameSpace.F_C.MyUniverse.SysGen.MyFlowChartScale.ToString)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub

    '****************************************************************
    '3 This goes to the FileInputOutput Window
    Private Sub ToolStripButtonOpen_Click(sender As Object, e As EventArgs) Handles ToolStripButtonOpenForm.Click
        Const ButtonStartedName As String = "Flow Chart  Displaying File Input/Output and status'."
        MyFlowChartNameSpace.F_C.Follow(2622, 3, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.ShowAllForms(LeaveWindow, LeaveWindow, LeaveWindow, ShowWindow)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
    End Sub
    '****************************************************************
    '2This goes to the optionWindow
    Private Sub ToolStripButtonOptions_Click(sender As Object, e As EventArgs) Handles ToolStripButtonOptionForm.Click
        Const ButtonStartedName As String = "Flow Chart  Displaying Options."
        MyFlowChartNameSpace.F_C.Follow(2623, 3, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.ShowAllForms(HideWindow, HideWindow, ShowWindow, LeaveWindow)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
    End Sub
    '****************************************************************
    '4 This set the mode to add a path when clicking the first end of the line, holding to the last end of the line
    Private Sub ToolStripButtonAddPath_Click(sender As Object, e As EventArgs) Handles ToolStripButtonAddPath.Click
        Const ButtonStartedName As String = "Flow Chart  AddPath."
        MyFlowChartNameSpace.F_C.Follow(2624, 3, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.MyCmdModeString = "CmdAddPath"
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
    End Sub




    Private Sub FlowChartWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'FIXED ?this caused recursion and needs to be repaired
        Const ButtonStartedName As String = "FlowChart Window Redraw from Resize"
        If MyFlowChartNameSpace.F_C.MyDebug(11) = True Then MyFlowChartNameSpace.F_C.Follow(2779, 11, MyFlowChartNameSpace.F_C.MyShowAForm(Me) & " " & ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        ResizeMe()
        'MyFlowChartNameSpace.F_C.PaintAll(Me.PictureBox1, 1, MyFlowChartNameSpace.F_C.TopOfFile("FlowChart"))
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
    End Sub

    Private Sub ResizeMe()
        Dim X As Int32
        If MyFlowChartNameSpace.F_C.MyDebug(11) = True Then MyFlowChartNameSpace.F_C.Follow(2627, 11, "ResizeMe:")

        Me.VScrollBar1.Left = X
        Me.HScrollBar1.Left = Me.VScrollBar1.Width + X
        Me.PictureBox1.Left = Me.HScrollBar1.Left

        Me.HScrollBar1.Top = Me.ToolStripFlowChart.Height + X
        Me.VScrollBar1.Top = Me.HScrollBar1.Top + Me.HScrollBar1.Height
        Me.PictureBox1.Top = Me.HScrollBar1.Top + Me.HScrollBar1.Height

        Me.HScrollBar1.Width = Me.Width - (Me.VScrollBar1.Left + Me.VScrollBar1.Width) - X * 6
        Me.PictureBox1.Width = Me.Width - (Me.VScrollBar1.Left + Me.VScrollBar1.Width) - X * 6

        Me.VScrollBar1.Height = Me.Height - Me.VScrollBar1.Top - X * 10
        Me.PictureBox1.Height = Me.VScrollBar1.Height

        ' Now Set the scroll bars 

        Me.HScrollBar1.Minimum = 1
        Me.HScrollBar1.Maximum = 1000
        Me.HScrollBar1.LargeChange = 100
        Me.HScrollBar1.SmallChange = 10

        Me.VScrollBar1.Minimum = Me.HScrollBar1.Minimum
        Me.VScrollBar1.Maximum = Me.HScrollBar1.Maximum
        Me.VScrollBar1.LargeChange = Me.HScrollBar1.LargeChange
        Me.VScrollBar1.SmallChange = Me.HScrollBar1.SmallChange

        Me.HScrollBar1.Enabled = False
        Me.VScrollBar1.Enabled = False
        If MyFlowChartNameSpace.F_C.MyDebug(11) = True Then MyFlowChartNameSpace.F_C.Follow(2771, 11, MyFlowChartNameSpace.F_C.MyShowAForm(Me))
        'MyFlowChartNameSpace.F_C.PaintAll(Me.PictureBox1, 1, MyFlowChartNameSpace.F_C.TopOfFile("FlowChart"))

    End Sub

    Private Sub ToolStripDropDownSelectSymbol_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStripDropDownSelectSymbol.DropDownItemClicked
        Const ButtonStartedName As String = "FlowChart Window Select Symbol Drop Down Button"
        MyFlowChartNameSpace.F_C.Follow(2628, 3, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        Me.ToolStripDropDownSelectSymbol.Text = e.ClickedItem.ToString()
        MyFlowChartNameSpace.F_C.MyUniverse.ProgramOptions.SelectedSymbolName = e.ClickedItem.ToString()
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub


    Private Sub ToolStripTextBoxMyInputText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ToolStripTextBoxMyInputText.KeyPress
        Const ButtonStartedName As String = "Flow Chart  MyDeCompile."
        MyFlowChartNameSpace.F_C.Follow(2629, 3, ButtonStartedName)
        MyFlowChartNameSpace.F_C.WhatKey(e) ' Do something with any special keys
        If e.KeyChar <> vbCr Then Return
        MyFlowChartNameSpace.F_C.MyUniverse.ProgramOptions.FlowChartTextBox = Me.ToolStripTextBoxMyInputText.ToString
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyDeCompileLine(MyFlowChartNameSpace.F_C.MyUniverse.ProgramOptions.FlowChartTextBox) 'MyUniverse.MySS.Inputs.KeyFile)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        Me.ToolStripTextBoxMyInputText.Text = "" 'clear out the line that was just compiled
        Me.LabelProgramStatus.Text = "" ' Blank out the syntax also
    End Sub

    Private Sub ToolStripDropDownSelectSymbol_TextChanged(sender As Object, e As EventArgs) Handles ToolStripDropDownSelectSymbol.TextChanged

        If MyFlowChartNameSpace.F_C.MyUniverse.MySystem.Dumps.OutputFileName3 = "" Then
            MyFlowChartNameSpace.F_C.MyUniverse.MySystem.Dumps.OutputFileName3 = FileIO.FileSystem.CurrentDirectory & "\DumpStartup.txt"
            If Dir(MyFlowChartNameSpace.F_C.MyUniverse.MySystem.Dumps.OutputFileName3) <> "" Then Kill(MyFlowChartNameSpace.F_C.MyUniverse.MySystem.Dumps.OutputFileName3)
        End If

        If MyFlowChartNameSpace.F_C.ProgramBuzzy("") Then
            MyFlowChartNameSpace.F_C.MyUniverse.MyProgramStatus = "Begin"
            MyFlowChartNameSpace.F_C.MyUniverse.FCCLDebugLevel = 4 'MyFlowChartNameSpace.F_C.DefaultDebugLevel 'todo use the Constant from shared
        End If
        ReDim Preserve MyFlowChartNameSpace.F_C.MyUniverse.DebugCount(100)
        If MyFlowChartNameSpace.F_C.MyDebug(11) = True Then MyFlowChartNameSpace.F_C.Follow(2939, 11, " ToolStripDropDownSelectSymbol_TextChanged")

        MyFlowChartNameSpace.F_C.MSG_AInfo(2630, "FlowChart window Symbol_TextChanged, ", MyFlowChartNameSpace.F_C.SHL(sender.ToString), "")
        If MyFlowChartNameSpace.F_C.ProgramBuzzy("Begin") Then Return
        If Me.ToolStripDropDownSelectSymbol.Text <> sender.ToString Then 'if it's not already done
            Me.ToolStripDropDownSelectSymbol.Text = sender.ToString
            Return
        End If
        MyFlowChartNameSpace.F_C.MyUniverse.ProgramOptions.SelectedSymbolName = sender.ToString
        If SymbolWindow.ToolStripDropDownSelectSymbol.Text <> sender.ToString Then
            SymbolWindow.ToolStripDropDownSelectSymbol.Text = sender.ToString
        End If

    End Sub

    Private Sub ToolStripButtonMoveHand_Click(sender As Object, e As EventArgs) Handles ToolStripButtonMoveHand.Click
        Const ButtonStartedName As String = "FlowChart Window Hand Movement"
        MyFlowChartNameSpace.F_C.Follow(2631, 3, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.MyCmdModeString = "CmdMoveHand"
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
    End Sub





    Private Sub FlowChartWindow_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim Old As String
        If MyFlowChartNameSpace.F_C.MyDebug(8) = True Then MyFlowChartNameSpace.F_C.Follow(2733, 8, "PaintAll Starting ")
        If MyFlowChartNameSpace.F_C.ProgramBuzzy("Begin") Then Return
        If MyFlowChartNameSpace.F_C.ProgramBuzzy("Painting") Then Return
        Old = MyFlowChartNameSpace.F_C.MyUniverse.MyProgramStatus
        MyFlowChartNameSpace.F_C.MyUniverse.MyProgramStatus = "Painting"
        If MyFlowChartNameSpace.F_C.MyDebug(10) Then MyFlowChartNameSpace.F_C.Follow(2734, 8, "PaintAll ")
        MyFlowChartNameSpace.F_C.DoThisEvent(2768)
        MyFlowChartNameSpace.F_C.DoEvents(2768)
        If MyFlowChartNameSpace.F_C.FMBRecurse("PaintAll") > 1 Then Return
        If e.ClipRectangle.X = 0 And e.ClipRectangle.Y = 0 And e.ClipRectangle.Height = 0 And e.ClipRectangle.Width = 0 Then
            Return
        Else
            If MyFlowChartNameSpace.F_C.MyDebug(7) Then MyFlowChartNameSpace.F_C.Follow(2606, 7, " " &'"FC_Paint sender, " & sender.ToString() & vbTab & '" Type= " & sender.GetType.ToString &            '" full= " & sender.GetType.FullName &
            " Assembly= " & sender.GetType.Assembly.ToString &
            " Empty=" & e.ClipRectangle.IsEmpty.ToString() &
            SHL(" Top=" & e.ClipRectangle.Top.ToString() &
            " Left=" & e.ClipRectangle.Left.ToString()) &
            SHL(" LY=" & e.ClipRectangle.Location.Y.ToString() &
            " LX=" & e.ClipRectangle.Location.X.ToString()) &
            SHL(" X=" & e.ClipRectangle.X.ToString() &
            " Y=" & e.ClipRectangle.Y.ToString()) &
            SHL(" Width=" & e.ClipRectangle.Width.ToString() &
            " Height=" & e.ClipRectangle.Height.ToString()) &
            SHL(" Right=" & e.ClipRectangle.Right.ToString() &
            " Bottom=" & e.ClipRectangle.Bottom.ToString()) &
            SHL(" Record #s=1-" & MyFlowChartNameSpace.F_C.TopOfFile("FlowChart")) &
            ". ")
        End If
        MyFlowChartNameSpace.F_C.PaintAll(Me.PictureBox1, 1, MyFlowChartNameSpace.F_C.TopOfFile("FlowChart"))
        'MyFlowChartNameSpace.F_C.TopOfFile("FlowChart"),
        'end of paint event 
        MyFlowChartNameSpace.F_C.MyUniverse.MyProgramStatus = Old
        'todo need to clear out any paint messages on the top of the stack coming in next


        'DebugPrint(MyFlowChartNameSpace.F_C.bin2hex(MyFlowChartNameSpace.F_C.NextEvent("Peek")))
        'DebugPrint(MyFlowChartNameSpace.F_C.PopMessage().ToString)

    End Sub ' PAINT


    Public Shared Function SHL(A As String) As String
        Return "{{" & A & "}}"
    End Function

    Private Sub FlowChartWindow_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If MyFlowChartNameSpace.F_C.MyUniverse.MySystem.WindowsStatus(1) = "Closed" Then Return
        MyFlowChartNameSpace.F_C.MyUniverse.MySystem.WindowsStatus(1) = "Closed"
        FileInputOutputWindow.Close()
        OptionsWindow.Close()
        SymbolWindow.Close()
    End Sub

End Class
