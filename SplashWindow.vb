﻿

Imports System.ComponentModel
'#Const MINEDEBUG = 50

Public NotInheritable Class SplashWindow

    'TODO: This form can easily be set as the splash Window for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashWindow1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        Me.Show()
        Me.BringToFront()
        MyFlowChartNameSpace.F_C.MyTraceSystem()
        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's design time text to "Version {0}.{1:00}.{2}.{3}" or something similar.See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
    End Sub


    Private Sub UpdateTextBox(ByVal NewText As String)
        If Me.InvokeRequired Then
            Dim MyString() As String = {NewText}
            Me.Invoke(New Action(Of String)(AddressOf UpdateTextBox), MyString)
            Return
        End If
        'Label_caller.Text = phone_number
        FlowChartWindow.Show()
    End Sub

End Class
