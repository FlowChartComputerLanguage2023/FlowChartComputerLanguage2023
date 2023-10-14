
'#Const MINEDEBUG = 50
Public Class SelectionOption

    Friend Const ShowWindow As Int32 = 1
    Friend Const HideWindow As Int32 = 0
    Friend Const LeaveWindow As Int32 = -1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyFlowChartNameSpace.F_C.Follow(3435, 10, "10013 selection option : ")
    End Sub

    Private Sub SelectionListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectionListBox.SelectedIndexChanged
        MyFlowChartNameSpace.F_C.MyUniverse.MySystem.SelectionOption = SelectionListBox.SelectedIndex
        Me.Visible = False
        Hide()
        Me.Close()
    End Sub

    Public Sub MyClear()
        SelectionListBox.Items.Clear()
    End Sub
    Public Sub MyAdd(A As String)
        SelectionListBox.Items.Add(A)
    End Sub
End Class

