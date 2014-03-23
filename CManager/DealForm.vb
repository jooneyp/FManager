Imports System.Data.OleDb

Public Class DealForm
    Private myConn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=.\SourceDB.mdb")

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cmdText = "INSERT INTO [deal] (d_client, d_user, d_date, d_cost, d_tons, d_qty) VALUES (?, ?, ?, ?, ?, ?)"
        Dim myCmd = New OleDbCommand(cmdText, myConn)
        myCmd.Parameters.AddWithValue("@name", cBoxc_name.Text)
        myCmd.Parameters.AddWithValue("@idnum", cBoxu_name.Text)
        myCmd.Parameters.AddWithValue("@head", DateTimePicker1.Text)
        myCmd.Parameters.AddWithValue("@addr", cBox_Cost.Text)
        myCmd.Parameters.AddWithValue("@type", cBox_Tons.Text)
        myCmd.Parameters.AddWithValue("@jongmok", cBox_Qty.Text)
        myCmd.ExecuteNonQuery()

        lblFCostR.Text = (cBox_Cost.Text * cBox_Qty.Text)
        lblDutyR.Text = (lblFCostR.Text * 0.1)
        lblFCostR.Visible = True
        lblDutyR.Visible = True

        MessageBox.Show("입력되었습니다.", "확인", MessageBoxButtons.OK)
    End Sub

    Private Sub DealForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UserTableAdapter.Fill(Me.DBDataSet.user)
        Me.ClientTableAdapter.Fill(Me.DBDataSet.client)
        myConn.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        PrintForm.Show()
    End Sub

    Private Sub DealFrom_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myConn.Close()
    End Sub
End Class