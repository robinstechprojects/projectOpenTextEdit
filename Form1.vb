Public Class Form1

    Private Sub DateiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateiToolStripMenuItem.Click

    End Sub

    Private Sub NeuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeuToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        System.IO.File.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text)
    End Sub

    Private Sub DruckenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DruckenToolStripMenuItem.Click
        MsgBox("Dieses Feature steht erst demnächst zur Verfügung! ", MsgBoxStyle.Information)
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub RückgängigToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RückgängigToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub KopierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KopierenToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub EinfügenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinfügenToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub AllesMakierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllesMakierenToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub AusschneidenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AusschneidenToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        MsgBox("Entwickelt von Robin S. ©2014 -Version Alpha 0.0.3-")
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub ÖffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖffnenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        Dim text As String = System.IO.File.ReadAllText(OpenFileDialog1.FileName)
        RichTextBox1.Text = text
    End Sub
End Class
