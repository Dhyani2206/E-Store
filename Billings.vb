Public Class Billings
    Private Sub Billings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Item As New ListViewItem(electronics.ComboBox1.Text)
        Item.SubItems.Add(electronics.TextBox1.Text) 'productname
        Item.SubItems.Add(electronics.NumericUpDown1.Value)
        Item.SubItems.Add((electronics.TextBox1.Text) * (electronics.NumericUpDown1.Value))
        ListView1.Items.Add(Item)

        Dim Item1 As New ListViewItem(electronics.ComboBox2.Text)
        Item1.SubItems.Add(electronics.TextBox2.Text) 'productname
        Item1.SubItems.Add(electronics.NumericUpDown2.Value)
        Item1.SubItems.Add((electronics.TextBox2.Text) * (electronics.NumericUpDown2.Value))
        ListView1.Items.Add(Item1)

        Dim Item2 As New ListViewItem(electronics.ComboBox3.Text)
        Item2.SubItems.Add(electronics.TextBox3.Text) 'productname
        Item2.SubItems.Add(electronics.NumericUpDown3.Value)
        Item2.SubItems.Add((electronics.TextBox3.Text) * (electronics.NumericUpDown3.Value))
        ListView1.Items.Add(Item2)



        Dim TotalAmt = ((electronics.TextBox1.Text) * (electronics.NumericUpDown1.Value)) + ((electronics.TextBox2.Text) * (electronics.NumericUpDown2.Value)) + ((electronics.TextBox3.Text) * (electronics.NumericUpDown3.Value))

        TextBox1.Text = TotalAmt


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()

    End Sub


End Class