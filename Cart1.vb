Public Class Cart1
    Private Sub Cart1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Item As New ListViewItem(Clothing.ComboBox1.Text)
        Item.SubItems.Add(Clothing.TextBox1.Text) 'productname
        Item.SubItems.Add(Clothing.NumericUpDown1.Value)

        ListView1.Items.Add(Item)

        Dim Item1 As New ListViewItem(Clothing.ComboBox2.Text)
        Item1.SubItems.Add(Clothing.TextBox2.Text) 'productname
        Item1.SubItems.Add(Clothing.NumericUpDown2.Value)

        ListView1.Items.Add(Item1)

        Dim Item2 As New ListViewItem(Clothing.ComboBox3.Text)
        Item2.SubItems.Add(Clothing.TextBox3.Text) 'productname
        Item2.SubItems.Add(Clothing.NumericUpDown3.Value)

        ListView1.Items.Add(Item2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Billings1.Show()
    End Sub
End Class