Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class electronics
    Dim MysqlConn As New MySqlConnection
    Dim MysqlCmd As New MySqlCommand
    Private Sub electronics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server = localhost; userid = root; password = Shambhoo@2206;database = grocery1"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Dim Query1 As String
            Dim Query2 As String

            Query = "select * from grocery1.stock where category = 'Mobile'"
            MysqlCmd = New MySqlCommand(Query, MysqlConn)
            READER = MysqlCmd.ExecuteReader

            While READER.Read
                Dim category = READER.GetString("description")

                ComboBox1.Items.Add(category)

            End While

            MysqlConn.Close()

            MysqlConn.Open()

            Query1 = "select * from grocery1.stock where category = 'Laptop'"
            MysqlCmd = New MySqlCommand(Query1, MysqlConn)
            READER = MysqlCmd.ExecuteReader
            While READER.Read
                Dim category = READER.GetString("description")

                ComboBox2.Items.Add(category)

            End While

            MysqlConn.Close()

            MysqlConn.Open()

            Query2 = "select * from grocery1.stock where category = 'Earphones'"
            MysqlCmd = New MySqlCommand(Query2, MysqlConn)
            READER = MysqlCmd.ExecuteReader
            While READER.Read
                Dim category = READER.GetString("description")
                ComboBox3.Items.Add(category)

            End While
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter
            MysqlConn.Open()

            sql = "SELECT * FROM grocery1.stock WHERE description LIKE '%" & ComboBox1.Text & "%'"
            cmd.Connection = MysqlConn
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                TextBox1.Text = dt.Rows(0).Item("Price").ToString
            End If

            MysqlConn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter
            MysqlConn.Open()

            sql = "SELECT * FROM grocery1.stock WHERE description LIKE '%" & ComboBox2.Text & "%'"
            cmd.Connection = MysqlConn
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                TextBox2.Text = dt.Rows(0).Item("Price").ToString
            End If

            MysqlConn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter
            MysqlConn.Open()

            sql = "SELECT * FROM grocery1.stock WHERE description LIKE '%" & ComboBox3.Text & "%'"
            cmd.Connection = MysqlConn
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                TextBox3.Text = dt.Rows(0).Item("Price").ToString
            End If

            MysqlConn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Cart.Show()
    End Sub





End Class