

Option Strict On
Option Infer Off
Option Compare Text
Option Explicit On
'#Const MINEDEBUG = 50


Public Class FileInputOutputWindow
    Friend Const ShowWindow As Int32 = 1
    Friend Const HideWindow As Int32 = 0
    Friend Const LeaveWindow As Int32 = -1
    Dim IndexOfFlowChart As Int32 = 1


    Dim Columns(18) As Int32

    Private Sub SetColumns(Optional A As Int32 = 8, Optional B As Int32 = 8, Optional C As Int32 = 8, Optional D As Int32 = 8, Optional E As Int32 = 8, Optional F As Int32 = 8, Optional G As Int32 = 8, Optional H As Int32 = 8, Optional I As Int32 = 8, Optional J As Int32 = 8, Optional K As Int32 = 8, Optional L As Int32 = 8, Optional M As Int32 = 8, Optional N As Int32 = 8, Optional O As Int32 = 8, Optional P As Int32 = 8, Optional Q As Int32 = 8, Optional R As Int32 = 8)
        Columns(1) = A
        Columns(2) = B
        Columns(3) = C
        Columns(4) = D
        Columns(5) = E
        Columns(6) = F
        Columns(7) = G
        Columns(8) = H
        Columns(9) = I
        Columns(10) = J
        Columns(11) = K
        Columns(12) = L
        Columns(13) = M
        Columns(14) = N
        Columns(15) = O
        Columns(16) = P
        Columns(17) = Q
        Columns(18) = R
    End Sub


    '2********************************************************************************************
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButtonOpenFile.Click
        'Open File
        Const ButtonStartedName As String = " Opening FlowChart " '& MyFlowChartNameSpace.F_C.DrillDown_FileName & "."
        MyFlowChartNameSpace.F_C.Follow(2934, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyOpen("read")
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub

    '**************************************************************************
    Private Sub ToolStripButtonSaveFileAs_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSaveFileAs.Click
        'Save file
        Const ButtonStartedName As String = " Saving the FlowChart into " ''& MyFlowChartNameSpace.F_C.DrillDown_FileName & "."
        MyFlowChartNameSpace.F_C.Follow(2932, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyOpen("write")
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub
    '***********************************************************************
    Private Sub ToolStripButtonFlowChartToSourceCode_Click(sender As Object, e As EventArgs) Handles ToolStripButtonFlowChartToSourceCode.Click
        'Compile
        Const ButtonStartedName As String = " Converting from the FlowChart to Source Code.File Save as " ''& MyFlowChartNameSpace.F_C.DrillDown_FileName & "."
        MyFlowChartNameSpace.F_C.Follow(2930, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyCompile(FlowChartWindow.PictureBox1)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub

    '1**************************************************************
    'Show FlowChart Window
    Private Sub ToolStripButtonShowFlowChart_Click(sender As Object, e As EventArgs) Handles ToolStripButtonShowFlowChart.Click
        Const ButtonStartedName As String = " Showing FlowChart Window."
        MyFlowChartNameSpace.F_C.Follow(2928, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.ShowAllForms(ShowWindow, HideWindow, HideWindow, HideWindow)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub
    '*************************************************************
    Private Sub ToolStripButtonSourceCodeToFlowChartCode_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSourceCodeToFlowChartCode.Click
        Const ButtonStartedName As String = "Converting from source code into the FlowChart."
        If MyFlowChartNameSpace.F_C.MyDebug(6) = True Then MyFlowChartNameSpace.F_C.Follow(2926, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.MyDeCompile(FlowChartWindow.PictureBox1, "")
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub

    Private Sub ToolStripButtonShowOptionsWindow_Click(sender As Object, e As EventArgs) Handles ToolStripButtonShowOptionsWindow.Click
        Const ButtonStartedName As String = " Showing Option Window."
        MyFlowChartNameSpace.F_C.Follow(2924, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.ShowAllForms(HideWindow, HideWindow, ShowWindow, HideWindow)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub

    Private Sub ToolStripButtonShowSymbolWindow_Click(sender As Object, e As EventArgs) Handles ToolStripButtonShowSymbolWindow.Click
        Const ButtonStartedName As String = " Showing Symbol Window."
        MyFlowChartNameSpace.F_C.Follow(2922, 6, ButtonStartedName)
        If MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName) = False Then Return
        MyFlowChartNameSpace.F_C.ShowAllForms(HideWindow, ShowWindow, HideWindow, HideWindow)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub


    Private Sub FileInputOutputWindow_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If MyFlowChartNameSpace.F_C.MyUniverse.MySystem.WindowsStatus(3) = "Closed" Then Return
        SetColumns()
        MyFlowChartNameSpace.F_C.MyUniverse.MySystem.WindowsStatus(3) = "Closed"
        FlowChartWindow.Close()
        SymbolWindow.Close()
        OptionsWindow.Close()
    End Sub

    Private Sub RadioButtonColor_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonColor.CheckedChanged
        Dim I As Int32
        If Me.RadioButtonColor.Checked = False Then
            Return
        End If
        TextBoxDetails.Text = ""
        SetColumns(32, 5, 5, 5, 5, 10, 14, 24)
        For I = 1 To MyFlowChartNameSpace.F_C.TopOfFile("Color")
            TextBoxDetails.Text &= MyFlowChartNameSpace.F_C.MyShowColumns(MyFlowChartNameSpace.F_C.MyShowColor(False, I), Columns) & vbCrLf
        Next I

    End Sub

    Private Sub RadioButtonFlowChart_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonFlowChart.CheckedChanged
        Dim I As Int32
        If Me.RadioButtonFlowChart.Checked = False Then
            Return
        End If
        TextBoxDetails.Text = ""
        SetColumns(32, 8, 8, 16, 16, 16, 16, 16)
        For I = 1 To MyFlowChartNameSpace.F_C.TopOfFile("FlowChart")
            TextBoxDetails.Text &= MyFlowChartNameSpace.F_C.MyShowColumns(MyFlowChartNameSpace.F_C.MyShowFlowChartRecord(False, I), Columns) & vbCrLf
        Next I
    End Sub

    Private Sub RadioButtonDataTypes_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDataTypes.CheckedChanged
        Dim I As Int32
        If Me.RadioButtonDataTypes.Checked = False Then
            Return
        End If
        SetColumns(32, 4, 16, 4, 128)
        TextBoxDetails.Text = ""
        For I = 1 To MyFlowChartNameSpace.F_C.TopOfFile("DataType")
            TextBoxDetails.Text &= MyFlowChartNameSpace.F_C.MyShowColumns(MyFlowChartNameSpace.F_C.MyShowDataType(False, I), Columns) & vbCrLf
        Next I
    End Sub

    Private Sub RadioButtonSymbol_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSymbol.CheckedChanged
        Dim I As Int32
        Dim S As String
        If Me.RadioButtonSymbol.Checked = False Then
            Return
        End If
        TextBoxDetails.Text = ""
        '           1  2  3  4  5    6  7   8  9
        SetColumns(16, 6, 6, 12, 16, 16, 16, 16, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18)
        For I = 1 To MyFlowChartNameSpace.F_C.TopOfFile("Symbol")
            S = MyFlowChartNameSpace.F_C.MyTrim(MyFlowChartNameSpace.F_C.MyShowSymbolRecord(False, I))
            TextBoxDetails.Text &= MyFlowChartNameSpace.F_C.MyShowColumns(S, Columns) & vbCrLf
        Next I
    End Sub

    Private Sub RadioButtonKeyWords_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonKeyWords.CheckedChanged
        Dim I As Int32
        If Me.RadioButtonKeyWords.Checked = False Then
            Return
        End If
        TextBoxDetails.Text = ""
        SetColumns(32, 0)
        For I = 1 To MyFlowChartNameSpace.F_C.TopOfFile("KeyWord")
            TextBoxDetails.Text &= MyFlowChartNameSpace.F_C.MyShowColumns(MyFlowChartNameSpace.F_C.Language_KeyWord(I), Columns) & vbCrLf
        Next I
    End Sub

    Private Sub RadioButtonOperators_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOperators.CheckedChanged
        Dim I As Int32
        If Me.RadioButtonOperators.Checked = False Then
            Return
        End If
        TextBoxDetails.Text = ""
        SetColumns(32)
        For I = 1 To MyFlowChartNameSpace.F_C.TopOfFile("Operator")
            TextBoxDetails.Text &= MyFlowChartNameSpace.F_C.MyShowColumns(MyFlowChartNameSpace.F_C.Language_Operator(I), Columns) & vbCrLf
        Next I
    End Sub

    Private Sub RadioButtonFunctions_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonFunctions.CheckedChanged
        Dim I As Int32
        If Me.RadioButtonFunctions.Checked = False Then
            Return
        End If
        TextBoxDetails.Text = ""
        SetColumns(32)
        For I = 1 To MyFlowChartNameSpace.F_C.TopOfFile("Function")
            TextBoxDetails.Text &= MyFlowChartNameSpace.F_C.MyShowColumns(MyFlowChartNameSpace.F_C.Language_Function(I), Columns) & vbCrLf
        Next I
    End Sub

    Private Sub RadioButtonBNF_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonBNF.CheckedChanged
        Dim I As Int32
        If Me.RadioButtonBNF.Checked = False Then
            Return
        End If
        TextBoxDetails.Text = ""
        SetColumns(256, 16, 16, 16, 16, 16)
        For I = 1 To MyFlowChartNameSpace.F_C.TopOfFile("Grammar")
            TextBoxDetails.Text &= MyFlowChartNameSpace.F_C.MyShowColumns(MyFlowChartNameSpace.F_C.Language_Grammar(I), Columns) & vbCrLf
        Next I
    End Sub

    Private Sub RadioButtonOptions_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptions.CheckedChanged
        Dim I As Int32
        If Me.RadioButtonOptions.Checked = False Then
            Return
        End If
        TextBoxDetails.Text = ""
        SetColumns(64)
        For I = 1 To UBound(MyFlowChartNameSpace.F_C.MyMessageBits) * 8
            If MyFlowChartNameSpace.F_C.IsBitSet(I) = False Then TextBoxDetails.Text &= I.ToString & " is on " & vbCrLf
        Next I
    End Sub

    Private Sub RadioButtonDirection_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDirection.CheckedChanged
        Dim I As Int32
        If Me.RadioButtonDirection.Checked = False Then
            Return
        End If
        TextBoxDetails.Text = ""
        SetColumns(16, 4, 4, 4, 4)
        For I = 0 To 16
            TextBoxDetails.Text &= I.ToString & vbTab & " = " & vbTab &
            MyFlowChartNameSpace.F_C.MyDirections(I, 1, 1).ToString & vbTab &
            MyFlowChartNameSpace.F_C.MyDirections(I, 1, 2).ToString & vbTab &
            MyFlowChartNameSpace.F_C.MyDirections(I, 2, 1).ToString & vbTab &
            MyFlowChartNameSpace.F_C.MyDirections(I, 2, 2).ToString & vbCrLf
        Next I

    End Sub

    Private Sub RadioButtonRotations_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonRotations.CheckedChanged
        Dim I, J As Int32
        Dim T1 As String
        Dim T2 As String
        If Me.RadioButtonRotations.Checked = False Then
            Return
        End If
        TextBoxDetails.Text = ""
        SetColumns()
        For I = 1 To 12
            T1 = SymbolWindow.ToolStripDropDownRotation.DropDownItems.Item(I).Text
            T1 = MyFlowChartNameSpace.F_C.Spaced(12, T1) & vbTab
            TextBoxDetails.Text &= T1
        Next I
        TextBoxDetails.Text &= vbCrLf
        For J = 1 To 12
            T2 = MyFlowChartNameSpace.F_C.MyRotation(1, J).ToString & " "
            T2 &= MyFlowChartNameSpace.F_C.MyRotation(2, J).ToString & " "
            T2 &= MyFlowChartNameSpace.F_C.MyRotation(3, J).ToString & " "
            T2 &= MyFlowChartNameSpace.F_C.MyRotation(4, J).ToString
            TextBoxDetails.Text &= MyFlowChartNameSpace.F_C.Spaced(12, T2) & vbTab
        Next J
        TextBoxDetails.Text &= vbCrLf
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonCompiled.CheckedChanged
        Dim I As Int32
        If Me.RadioButtonCompiled.Checked = False Then
            Return
        End If
        TextBoxDetails.Text = ""
        SetColumns(64, 64, 64, 64)
        For I = 1 To MyFlowChartNameSpace.F_C.TopOfFile("FlowChart")
            If MyFlowChartNameSpace.F_C.FlowChart_TableCode(I) = "/use" Then
                TextBoxDetails.Text &= MyFlowChartNameSpace.F_C.MyShowAndUpDateProperties(I) & vbCrLf
                TextBoxDetails.Text &= MyFlowChartNameSpace.F_C.CompileThisSymbolText(I) & vbCrLf
            End If
        Next I
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonUp.CheckedChanged
        'todo this needs to be change so that you can get any symbol up or down
        If Me.RadioButtonUp.Checked = False Then
            Return
        End If
        IndexOfFlowChart -= 1
        SetColumns()
        While IndexOfFlowChart >= 1 And MyFlowChartNameSpace.F_C.FlowChart_TableCode(IndexOfFlowChart) <> "/use"
            IndexOfFlowChart -= 1
        End While
        If IndexOfFlowChart < 1 Then IndexOfFlowChart = 1
        TextBoxDetails.Text = IndexOfFlowChart.ToString & vbCrLf & MyFlowChartNameSpace.F_C.MyShowAndUpDateProperties(IndexOfFlowChart)
    End Sub

    Private Sub RadioButtonReplacementDown_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonReplacementDown.CheckedChanged
        'todo this needs to be change so that you can get any symbol up or down
        If Me.RadioButtonReplacementDown.Checked = False Then
            Return
        End If
        IndexOfFlowChart += 1
        SetColumns()
        While IndexOfFlowChart < MyFlowChartNameSpace.F_C.TopOfFile("flowchart") And MyFlowChartNameSpace.F_C.FlowChart_TableCode(IndexOfFlowChart) <> "/use"
            IndexOfFlowChart += 1
        End While
        If IndexOfFlowChart > MyFlowChartNameSpace.F_C.TopOfFile("flowchart") Then IndexOfFlowChart = MyFlowChartNameSpace.F_C.TopOfFile("flowchart")
        TextBoxDetails.Text = IndexOfFlowChart.ToString & vbCrLf & MyFlowChartNameSpace.F_C.MyShowAndUpDateProperties(IndexOfFlowChart)
    End Sub

    Private Sub RadioButtonNamed_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonNamed.CheckedChanged
        Dim I As Int32
        Dim S1, S2 As String
        If Me.RadioButtonNamed.Checked = False Then
            Return
        End If
        TextBoxDetails.Text = ""
        '          (1, 2, 3,  4,  5, 6,  7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8)
        SetColumns(32, 2, 32, 4, 32, 6, 32, 8, 32, 10)
        For I = 1 To MyFlowChartNameSpace.F_C.TopOfFile("Named")
            S1 = MyFlowChartNameSpace.F_C.MyShowNamedRecords(True, I)
            While Len(S1) > 1
                S2 = MyFlowChartNameSpace.F_C.MyTrim(MyFlowChartNameSpace.F_C.PopLine(S1))
                TextBoxDetails.Text &= MyFlowChartNameSpace.F_C.MyShowColumns(S2, Columns) & vbCrLf
            End While
        Next I
    End Sub

    Private Sub FileInputOutputWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width + Me.TextBoxDetails.Left > 110 Then
            Me.TextBoxDetails.Width = Me.Width - 100
        End If
    End Sub


    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonNets.CheckedChanged
        'list all nets (variables)
        Dim I As Int32
        If Me.RadioButtonNets.Checked = False Then
            Return
        End If
        SetColumns(96)
        TextBoxDetails.Text = ""
        For I = 1 To UBound(MyFlowChartNameSpace.F_C.Net_FileLinks)
            MyFlowChartNameSpace.F_C.DebugPrint(MyFlowChartNameSpace.F_C.MyShowColumns(MyFlowChartNameSpace.F_C.MyShowAllNet(I), Columns))
            TextBoxDetails.Text &= MyFlowChartNameSpace.F_C.MyShowColumns(MyFlowChartNameSpace.F_C.MyShowAllNet(I), Columns) & vbCrLf
        Next I
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        TextBoxDetails.Text = "Reserved"
        If Me.RadioButton5.Checked = False Then
            Return
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBoxDetails.Text = "Reserved"
        If Me.RadioButton3.Checked = False Then
            Return
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        TextBoxDetails.Text = "Reserved"
        If Me.RadioButton11.Checked = False Then
            Return
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        TextBoxDetails.Text = "Reserved"
        If Me.RadioButton8.Checked = False Then
            Return
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        TextBoxDetails.Text = "Reserved"
        If Me.RadioButton12.Checked = False Then
            Return
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        Dim I As Int32
        TextBoxDetails.Text = ""
        If Me.RadioButton10.Checked = False Then
            Return
        End If
        SetColumns(64, 10, 6)
        For I = 1 To UBound(MyFlowChartNameSpace.F_C.Net_FileLinks)
            MyFlowChartNameSpace.F_C.DebugPrint(MyFlowChartNameSpace.F_C.MyShowColumns(MyFlowChartNameSpace.F_C.MyShowNetLnks(I), Columns))
            TextBoxDetails.Text &= MyFlowChartNameSpace.F_C.MyShowColumns(MyFlowChartNameSpace.F_C.MyShowNetLnks(I), Columns) & vbCrLf
        Next I
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint
        MyFlowChartNameSpace.F_C.DebugPrint(Me.FlowLayoutPanel1.BackColor.ToKnownColor().ToString)
        MyFlowChartNameSpace.F_C.DebugPrint(Me.FlowLayoutPanel1.BackColor.Name)
        MyFlowChartNameSpace.F_C.DebugPrint(Me.FlowLayoutPanel1.BackColor.IsKnownColor.ToString)
        MyFlowChartNameSpace.F_C.DebugPrint(Me.FlowLayoutPanel1.BackColor.IsNamedColor.ToString)
        MyFlowChartNameSpace.F_C.DebugPrint(Me.FlowLayoutPanel1.BackColor.IsSystemColor.ToString)
        MyFlowChartNameSpace.F_C.DebugPrint(Me.FlowLayoutPanel1.AccessibleDescription)
        Me.FlowLayoutPanel1.CreateGraphics.Clear(Color.Blue)
        MyFlowChartNameSpace.F_C.DebugPrint(Me.FlowLayoutPanel1.Name)
        MyFlowChartNameSpace.F_C.DebugPrint(Me.FlowLayoutPanel1.Parent.Name)
    End Sub
End Class