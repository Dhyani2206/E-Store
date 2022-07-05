Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class Cart
    Dim MysqlConn As New MySqlConnection
    Dim MysqlCmd As New MySqlCommand
    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server = localhost; userid = root; password = Shambhoo@2206;database = grocery1"


        MysqlConn.Open()

        MysqlConn.Close()

        Dim Item As New ListViewItem(electronics.ComboBox1.Text)
        Item.SubItems.Add(electronics.TextBox1.Text) 'productname
        Item.SubItems.Add(electronics.NumericUpDown1.Value)

        ListView1.Items.Add(Item)

        Dim Item1 As New ListViewItem(electronics.ComboBox2.Text)
        Item1.SubItems.Add(electronics.TextBox2.Text) 'productname
        Item1.SubItems.Add(electronics.NumericUpDown2.Value)

        ListView1.Items.Add(Item1)

        Dim Item2 As New ListViewItem(electronics.ComboBox3.Text)
        Item2.SubItems.Add(electronics.TextBox3.Text) 'productname
        Item2.SubItems.Add(electronics.NumericUpDown3.Value)

        ListView1.Items.Add(Item2)





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Billings.Show()
    End Sub


End Class