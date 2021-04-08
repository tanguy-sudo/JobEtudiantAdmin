Imports MySql.Data.MySqlClient
Imports LibrairieJobs

Public Class FormCateg
    Private Sub FormCateg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FormParent
        FormParent.IsMdiContainer = True

        cnn.Open()

        Dim i As Integer
        i = 0

        For Each uneCateg In Colcateg
            DGVCateg.Rows.Add(1)
            DGVCateg.Rows(i).Cells(0).Value = uneCateg.getIdCateg()
            DGVCateg.Rows(i).Cells(1).Value = uneCateg.getCateg()
            i = i + 1
        Next

        For Each uneCateg In Colcateg
            If uneCateg.getIdCateg() = DGVCateg.Rows(0).Cells(0).Value Then
                txtCateg.Text = uneCateg.GetCateg
                TextBoxidCateg.Text = uneCateg.getIdCateg()
            End If
        Next
        cnn.Close()
    End Sub

    Private Sub DGVCateg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCateg.CellClick
        For Each uneCateg In Colcateg
            If uneCateg.getIdCateg() = DGVCateg.CurrentRow.Cells(0).Value Then
                txtCateg.Text = uneCateg.GetCateg
                TextBoxidCateg.Text = uneCateg.getIdCateg()
            End If

        Next

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtRecherche.TextChanged
        DGVCateg.Rows.Clear()
        Dim i As Integer
        i = 0
        For Each uneCateg In Colcateg
            If InStr(uneCateg.getCateg.ToLower, txtRecherche.Text.ToLower) > 0 Then
                DGVCateg.Rows.Add(1)
                DGVCateg.Rows(i).Cells(0).Value = uneCateg.getIdCateg()
                DGVCateg.Rows(i).Cells(1).Value = uneCateg.getCateg()
                i = i + 1
            End If

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer = MessageBox.Show("Etes-vous sûr de supprimer cette catégorie ?", "confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim j As Integer = 1
            For Each uneCateg In Colcateg
                If uneCateg.getIdCateg() = DGVCateg.CurrentRow.Cells(0).Value Then
                    uneCateg.DeleteCateg()
                    Colcateg.Remove(j)
                End If
                j = j + 1
            Next


            DGVCateg.Rows.Clear()
            Dim i As Integer
            i = 0
            For Each uneCateg In Colcateg
                If InStr(uneCateg.getCateg.ToLower, txtRecherche.Text.ToLower) > 0 Then
                    DGVCateg.Rows.Add(1)
                    DGVCateg.Rows(i).Cells(0).Value = uneCateg.getIdCateg()
                    DGVCateg.Rows(i).Cells(1).Value = uneCateg.getCateg()
                    i = i + 1
                End If

            Next

            txtCateg.Clear()
            For Each uneCateg In Colcateg
                If uneCateg.getIdCateg() = DGVCateg.Rows(0).Cells(0).Value Then
                    txtCateg.Text = uneCateg.GetCateg
                    TextBoxidCateg.Text = uneCateg.getIdCateg()
                End If
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each uneCateg In Colcateg
            If uneCateg.getIdCateg() = DGVCateg.CurrentRow.Cells(0).Value Then
                uneCateg.setCateg(txtCateg.Text)
            End If

            uneCateg.ModifCateg()

        Next
        DGVCateg.Rows.Clear()
        Dim i As Integer
        For Each uneCateg In Colcateg
            DGVCateg.Rows.Add(1)
            DGVCateg.Rows(i).Cells(0).Value = uneCateg.getIdCateg()
            DGVCateg.Rows(i).Cells(1).Value = uneCateg.getCateg()
            If (uneCateg.getIdCateg() = TextBoxidCateg.Text) Then
                DGVCateg.CurrentCell = DGVCateg.Rows(i).Cells(1)
            End If
            i = i + 1
        Next
        MsgBox("Catégorie modifiée")
    End Sub

    Private Sub btnSupp_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        Dim Categ As New Categorie(0, txtNewCateg.Text)
        Categ.NewCateg()
        Colcateg.Add(Categ)

        cnn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM Categorie ORDER BY libCateg", cnn)
        Dim JeuEnr As MySqlDataReader

        JeuEnr = cmd.ExecuteReader
        Colcateg.Clear()

        While JeuEnr.Read
            Dim uneCateg As New Categorie(JeuEnr.GetValue(0), JeuEnr.GetValue(1))

            Colcateg.Add(uneCateg)
        End While
        cnn.Close()

        DGVCateg.Rows.Clear()
        Dim i As Integer
        For Each uneCateg In Colcateg
            DGVCateg.Rows.Add(1)
            DGVCateg.Rows(i).Cells(0).Value = uneCateg.getIdCateg()
            DGVCateg.Rows(i).Cells(1).Value = uneCateg.getCateg()
            i = i + 1
        Next
        For Each uneCateg In Colcateg
            If uneCateg.getIdCateg() = DGVCateg.Rows(0).Cells(0).Value Then
                txtCateg.Text = uneCateg.GetCateg
                TextBoxidCateg.Text = uneCateg.getIdCateg()
            End If
        Next
        txtNewCateg.Clear()
        MsgBox("Catégorie ajoutée")
    End Sub

    Private Sub DGVCateg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCateg.CellContentClick

    End Sub
End Class