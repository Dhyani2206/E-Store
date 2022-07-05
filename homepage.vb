Public Class homepage

    Private Sub MyBillsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyBillsToolStripMenuItem.Click
        Billings.Show()
    End Sub

    Private Sub ElectronicsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElectronicsToolStripMenuItem.Click
        electronics.Show()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AccessoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccessoriesToolStripMenuItem.Click
        Clothing.Show()
    End Sub

    Private Sub EditMyCartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditMyCartToolStripMenuItem.Click
        Cart.Show()
    End Sub

    Private Sub NewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
        Profile.Show()
    End Sub
End Class