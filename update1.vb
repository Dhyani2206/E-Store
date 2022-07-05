Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32


Public Class update1

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim dtA As New MySqlDataAdapter
    Dim sqlQuery As String


    Private bitmap As Bitmap


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlConn = New MySqlConnection
        sqlConn.ConnectionString = "server = localhost; user id  = root; password = Shambhoo@2206; database = grocery"

        Dim READER As MySqlDataReader

        Try
            sqlConn.Open()
            Dim Query As String
            Query = "update grocery.customer set name = '" & TextBox8.Text & "', phone = '" & TextBox2.Text & "', DOB = '" & DateTimePicker1.Text & "', country = '" & TextBox4.Text & "', State = '" & TextBox9.Text & "', pincode = '" & TextBox6.Text & "', address = '" & TextBox7.Text & "' where id = '" & TextBox3.Text & "' "
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