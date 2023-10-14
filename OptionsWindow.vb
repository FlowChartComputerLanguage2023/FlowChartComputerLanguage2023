
'#Const MINEDEBUG = 50

Public Class OptionsWindow
    Friend Const ShowWindow As Int32 = 1
    Friend Const HideWindow As Int32 = 0
    Friend Const LeaveWindow As Int32 = -1

    'todo No selection on the line/widths on the option Window

    '5********************************************
    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCheckAllData.Click
        Const ButtonStartedName As String = " Checking All information."
        If MyFlowChartNameSpace.F_C.MyDebug(6) Then MyFlowChartNameSpace.F_C.Follow(3509, 6, ButtonStartedName)
        MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName)
        MyFlowChartNameSpace.F_C.MSG_ABug(2000, " Click Check All Button ", "Started ", Now.ToString)
        MyFlowChartNameSpace.F_C.CheckAll()
        MyFlowChartNameSpace.F_C.MSG_ABug(2001, " Click Check All Button ", "Finished", Now.ToString)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub

    '1*********************************************
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButtonFlowChartForm_FromOptionsWindow.Click
        Const ButtonStartedName As String = "Displaying FlowChart Window."
        If MyFlowChartNameSpace.F_C.MyDebug(6) Then MyFlowChartNameSpace.F_C.Follow(3510, 6, ButtonStartedName)
        MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName)
        MyFlowChartNameSpace.F_C.ShowAllForms(ShowWindow, HideWindow, HideWindow, LeaveWindow)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub
    '2************************************************
    Private Sub ToolStripButtonSymbolForm_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSymbolForm_FromOptionsWindow.Click
        Const ButtonStartedName As String = " Displaying Symbol Window."
        If MyFlowChartNameSpace.F_C.MyDebug(6) Then MyFlowChartNameSpace.F_C.Follow(3511, 6, ButtonStartedName)
        MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName)
        MyFlowChartNameSpace.F_C.MSG_AInfo(2003, "Switching to Symbol Window from Option Window ", MyFlowChartNameSpace.F_C.MyUniverse.ProgramOptions.SelectedSymbolName, ButtonStartedName)
        MyFlowChartNameSpace.F_C.ShowAllForms(HideWindow, ShowWindow, HideWindow, LeaveWindow)
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub
    '3****************************************************
    Private Sub ToolStripButtonDeleteErrorMsgs_Click(sender As Object, e As EventArgs) Handles ToolStripButtonDeleteErrorMsgs.Click
        Const ButtonStartedName As String = " Deleting all Error Messages in the FlowChart."
        If MyFlowChartNameSpace.F_C.MyDebug(6) Then MyFlowChartNameSpace.F_C.Follow(3512, 6, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MSG_ABug(2004, "", "", ButtonStartedName)
        MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DeleteAllErrorMessages()
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub
    '4******************************************************
    Private Sub ToolStripButtonDeleteUnusedSymbols_Click(sender As Object, e As EventArgs) Handles ToolStripButtonDeleteUnusedSymbols.Click
        Const ButtonStartedName As String = " Deleting all Symbols that were not used in the FlowChart."
        If MyFlowChartNameSpace.F_C.MyDebug(6) Then MyFlowChartNameSpace.F_C.Follow(3513, 6, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MSG_ABug(2005, "", "", ButtonStartedName)
        MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyRemoveAllUnusedSymbols()
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub
    '6*******************************************************
    Private Sub ToolStripButtonDump_Click(sender As Object, e As EventArgs) Handles ToolStripButtonDump.Click
        Dim ButtonStartedName As String = ".CHECK:   " & MyFlowChartNameSpace.F_C.MyUniverse.MySystem.Dumps.OutputFileName1 & ", " & MyFlowChartNameSpace.F_C.MyUniverse.MySystem.Dumps.OutputFileName2 & ", " & MyFlowChartNameSpace.F_C.MyUniverse.MySystem.Dumps.OutputFileName3
        If MyFlowChartNameSpace.F_C.MyDebug(6) Then MyFlowChartNameSpace.F_C.Follow(3514, 6, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MSG_ABug(2006, "", "", ButtonStartedName)
        MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName)
        MyFlowChartNameSpace.F_C.Dump3(2313, "ButtonPressed")
        MyFlowChartNameSpace.F_C.Dump1()
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
        MyFlowChartNameSpace.F_C.MyButtonsEnableRules()
    End Sub

    Private Sub OptionsWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Const ButtonStartedName As String = "Resize Option Window"
        If MyFlowChartNameSpace.F_C.MyDebug(10) Then MyFlowChartNameSpace.F_C.Follow(2779, 10, MyFlowChartNameSpace.F_C.MyShowAForm(Me))

        MyFlowChartNameSpace.F_C.ButtonStarted(ButtonStartedName)
        ResizeMe()
        MyFlowChartNameSpace.F_C.ButtonFinished(ButtonStartedName)
        'MyFlowChartNameSpace.F_C.DisplayStatus(Me.LabelProgramStatus, ButtonStartedName)
    End Sub


    Private Sub ResizeMe() 'Option Window
        If MyFlowChartNameSpace.F_C.MyDebug(6) Then MyFlowChartNameSpace.F_C.Follow(2778, 6, MyFlowChartNameSpace.F_C.MyShowAForm(Me))
        Me.CheckedListBoxOptionSelection.Top = Me.ToolStripOption.Top + Me.ToolStripOption.Height + MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.ConstantDistanceBetweenControls
        Me.ComboBoxDebug.Top = Me.ToolStripOption.Top + Me.ToolStripOption.Height + MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.ConstantDistanceBetweenControls

        Me.CheckedListBoxOptionSelection.Width = CInt(Me.Width / 3 - MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.ConstantDistanceBetweenControls)
        Me.ComboBoxDebug.Width = CInt((Me.Width / 3) * 2 - MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.ConstantDistanceBetweenControls * 10)

        Me.ComboBoxDebug.Left = Me.CheckedListBoxOptionSelection.Left + Me.CheckedListBoxOptionSelection.Width + MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.ConstantDistanceBetweenControls * 4

        Me.CheckedListBoxOptionSelection.Height = Me.Height - Me.CheckedListBoxOptionSelection.Top - MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.ConstantDistanceBetweenControls * 10

        Me.ListBoxLanguage.Left = Me.CheckedListBoxOptionSelection.Left + Me.CheckedListBoxOptionSelection.Width + MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.ConstantDistanceBetweenControls
        Me.ListBoxLanguage.Top = Me.ComboBoxDebug.Top + Me.ComboBoxDebug.Height + MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.ConstantDistanceBetweenControls
        Me.ListBoxLanguage.Height = Me.CheckedListBoxOptionSelection.Top + Me.CheckedListBoxOptionSelection.Height - Me.ListBoxLanguage.Top
        Me.ListBoxLanguage.Width = CInt((Me.Width - Me.CheckedListBoxOptionSelection.Width - MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.ConstantDistanceBetweenControls) / 2)

        Me.ListBoxDialect.Left = Me.ListBoxLanguage.Left + Me.ListBoxLanguage.Width + MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.ConstantDistanceBetweenControls
        Me.ListBoxDialect.Top = Me.ComboBoxDebug.Top + Me.ComboBoxDebug.Height + MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.ConstantDistanceBetweenControls
        Me.ListBoxDialect.Height = Me.ListBoxLanguage.Height
        Me.ListBoxDialect.Width = Me.ListBoxLanguage.Width
    End Sub






    ' removed when I changed to have sub items (Dialects) of the computer languages 
    Private Sub ListBoxLanguage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxLanguage.SelectedValueChanged
        Dim X As String
        If MyFlowChartNameSpace.F_C.MyDebug(6) Then MyFlowChartNameSpace.F_C.Follow(3515, 6, "List Box Language Selected:")
        MyFlowChartNameSpace.F_C.MyUniverse.ProgramOptions.FCCL_LanguageClassName = CStr(Me.ListBoxLanguage.SelectedItem)
        X = MyFlowChartNameSpace.F_C.FindLanguageClassName(MyFlowChartNameSpace.F_C.MyUniverse.ProgramOptions.FCCL_Directory)
        MyFlowChartNameSpace.F_C.MakeDialectListFromFile(X)
    End Sub

    Private Sub ListboxDialect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxDialect.SelectedIndexChanged
        If MyFlowChartNameSpace.F_C.MyDebug(6) Then MyFlowChartNameSpace.F_C.Follow(3516, 6, "List Box Dialect Selected:")
        MyFlowChartNameSpace.F_C.MyUniverse.ProgramOptions.FCCL_DialectName = CStr(Me.ListBoxDialect.SelectedItem)
        MyFlowChartNameSpace.F_C.ListBoxLanguageDialect()
        MyFlowChartNameSpace.F_C.FindingMyBugsGrammar(MyFlowChartNameSpace.F_C.MyUniverse.SysGen.Constants.SyntaxGrammar, MyFlowChartNameSpace.F_C.Language_Grammar)
    End Sub


    Private Sub OptionsWindow_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If MyFlowChartNameSpace.F_C.MyUniverse.MySystem.WindowsStatus(4) = "Closed" Then Return
        MyFlowChartNameSpace.F_C.MyUniverse.MySystem.WindowsStatus(4) = "Closed"
        FlowChartWindow.Close()
        FileInputOutputWindow.Close()
        SymbolWindow.Close()

    End Sub
End Class
