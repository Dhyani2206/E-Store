Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32


Public Class update2

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim dtA As New MySqlDataAdapter
    Dim sqlQuery As String


    Private bitmap As Bitmap


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlConn = New MySqlConnection
        sqlConn.ConnectionString = "server = localhost; user id  = root; password = Shambhoo@2206; database = grocery1"

        Dim READER As MySqlDataReader

        Try
            sqlConn.Open()
            Dim Query As String
            Query = "update grocery1.stock set description = '" & TextBox3.Text & "', quantity = '" & TextBox2.Text & "', DOF = '" & DateTimePicker1.Text & "', Price = '" & TextBox4.Text & "', Category = '" & TextBox1.Text & "' where id = '" & TextBox8.Text & "' "
            sqlCmd = New MySqlCommand(Query, sqlConn)
            READER = sqlCmd.ExecuteReader

            MessageBox.Show("Data updated")
            sqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub


End Class