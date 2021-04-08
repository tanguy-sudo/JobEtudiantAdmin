Public Class FormAnn
    Private Sub FormAnn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FormParent
        FormParent.IsMdiContainer = True
        Dim i As Integer
        If (detail = 1) Then
            For Each uneCateg In Colcateg
                cboCateg.Items.Add(uneCateg.getCateg())
            Next
            For Each uneAnn In ColAnn
                If uneAnn.getId() = numAnn Then
                    cboCateg.Text = uneAnn.GetCateg().GetCateg()
                    txtTitre.Text = uneAnn.titre()
                    DteAnn.Value = uneAnn.dateDebut()
                    txtDuree.Text = uneAnn.LaDuree()
                    txtDesc.Text = uneAnn.Description()
                    txtLieu.Text = uneAnn.LieuAnnonce()
                    txtTarif.Text = uneAnn.tarif()
                    txtOff.Text = uneAnn.getOff().getnom() & " " & uneAnn.getOff().getprenom()
                    TextBoxidAn.Text = uneAnn.getId
                    detail = 0
                End If
            Next
            i = 0
            For Each uneAnn In ColAnn
                DGVAnn.Rows.Add(1)
                DGVAnn.Rows(i).Cells(0).Value = uneAnn.getId()
                DGVAnn.Rows(i).Cells(1).Value = uneAnn.titre()
                DGVAnn.Rows(i).Cells(2).Value = uneAnn.getOff().getnom() & " " & uneAnn.getOff().getprenom()
                If (uneAnn.getId = TextBoxidAn.Text) Then
                    DGVAnn.CurrentCell = DGVAnn.Rows(i).Cells(1)
                End If
                i = i + 1
            Next
        Else
            i = 0
            For Each uneAnn In ColAnn
                DGVAnn.Rows.Add(1)
                DGVAnn.Rows(i).Cells(0).Value = uneAnn.getId()
                DGVAnn.Rows(i).Cells(1).Value = uneAnn.titre()
                DGVAnn.Rows(i).Cells(2).Value = uneAnn.getOff().getnom() & " " & uneAnn.getOff().getprenom()
                i = i + 1
            Next
            For Each uneCateg In Colcateg
                cboCateg.Items.Add(uneCateg.getCateg())
            Next
            For Each uneAnn In ColAnn
                If uneAnn.getId() = DGVAnn.Rows(0).Cells(0).Value Then
                    cboCateg.Text = uneAnn.GetCateg().GetCateg()
                    txtTitre.Text = uneAnn.titre()
                    DteAnn.Value = uneAnn.dateDebut()
                    txtDuree.Text = uneAnn.LaDuree()
                    txtDesc.Text = uneAnn.Description()
                    txtLieu.Text = uneAnn.LieuAnnonce()
                    txtTarif.Text = uneAnn.tarif()
                    txtOff.Text = uneAnn.getOff().getnom() & " " & uneAnn.getOff().getprenom()
                    TextBoxidAn.Text = uneAnn.getId
                End If
            Next
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtRecherche.TextChanged
        DGVAnn.Rows.Clear()
        Dim i As Integer
        i = 0
        For Each uneAnn In ColAnn
            If InStr(uneAnn.titre.ToLower, txtRecherche.Text.ToLower) > 0 Then
                DGVAnn.Rows.Add(1)
                DGVAnn.Rows(i).Cells(0).Value = uneAnn.getId()
                DGVAnn.Rows(i).Cells(1).Value = uneAnn.titre()
                DGVAnn.Rows(i).Cells(2).Value = uneAnn.getOff().getnom() & " " & uneAnn.getOff().getprenom()
                i = i + 1
            End If

        Next
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAnn.CellClick
        For Each uneAnn In ColAnn
            If uneAnn.getId() = DGVAnn.CurrentRow.Cells(0).Value Then
                cboCateg.Text = uneAnn.GetCateg().GetCateg()
                txtTitre.Text = uneAnn.titre()
                DteAnn.Value = uneAnn.dateDebut()
                txtDuree.Text = uneAnn.LaDuree()
                txtDesc.Text = uneAnn.Description()
                txtLieu.Text = uneAnn.LieuAnnonce()
                txtTarif.Text = uneAnn.tarif()
                txtOff.Text = uneAnn.getOff().getnom() & " " & uneAnn.getOff().getprenom()
                TextBoxidAn.Text = uneAnn.getId
            End If

        Next
    End Sub

    Private Sub btnSupp_Click(sender As Object, e As EventArgs) Handles btnSupp.Click
        Dim result As Integer = MessageBox.Show("Etes-vous sûr de supprimer cette annonce ?", "confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim j As Integer = 1
            For Each uneAnn In ColAnn
                If uneAnn.getId() = DGVAnn.CurrentRow.Cells(0).Value Then
                    uneAnn.DeleteAnn()
                    ColAnn.Remove(j)
                End If
                j = j + 1
            Next


            DGVAnn.Rows.Clear()
            Dim i As Integer
            i = 0
            For Each uneAnn In ColAnn
                If InStr(uneAnn.titre.ToLower, txtRecherche.Text.ToLower) > 0 Then
                    DGVAnn.Rows.Add(1)
                    DGVAnn.Rows(i).Cells(0).Value = uneAnn.getId()
                    DGVAnn.Rows(i).Cells(1).Value = uneAnn.titre()
                    DGVAnn.Rows(i).Cells(2).Value = uneAnn.getOff().getnom() & " " & uneAnn.getOff().getprenom()
                    i = i + 1
                End If
            Next
            For Each uneAnn In ColAnn
                If uneAnn.getId() = DGVAnn.Rows(0).Cells(0).Value Then
                    cboCateg.Text = uneAnn.GetCateg().GetCateg()
                    txtTitre.Text = uneAnn.titre()
                    DteAnn.Value = uneAnn.dateDebut()
                    txtDuree.Text = uneAnn.LaDuree()
                    txtDesc.Text = uneAnn.Description()
                    txtLieu.Text = uneAnn.LieuAnnonce()
                    txtTarif.Text = uneAnn.tarif()
                    txtOff.Text = uneAnn.getOff().getnom() & " " & uneAnn.getOff().getprenom()
                    TextBoxidAn.Text = uneAnn.getId
                End If
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        For Each uneAnn In ColAnn
            If uneAnn.getId() = DGVAnn.CurrentRow.Cells(0).Value Then
                For Each categ In Colcateg
                    If categ.GetCateg() = cboCateg.Text Then
                        uneAnn.GetCateg = categ
                    End If
                Next
                uneAnn.titre = txtTitre.Text
                uneAnn.dateDebut = DteAnn.Value
                uneAnn.LaDuree = txtDuree.Text
                uneAnn.Description = txtDesc.Text
                uneAnn.LieuAnnonce = txtLieu.Text
                uneAnn.tarif = txtTarif.Text
            End If

            uneAnn.ModifAnn()



        Next
        DGVAnn.Rows.Clear()
        Dim i As Integer
        i = 0
        For Each uneAnn In ColAnn
            DGVAnn.Rows.Add(1)
            DGVAnn.Rows(i).Cells(0).Value = uneAnn.getId()
            DGVAnn.Rows(i).Cells(1).Value = uneAnn.titre()
            DGVAnn.Rows(i).Cells(2).Value = uneAnn.getOff().getnom() & " " & uneAnn.getOff().getprenom()
            If (uneAnn.getId = TextBoxidAn.Text) Then
                DGVAnn.CurrentCell = DGVAnn.Rows(i).Cells(1)
            End If
            i = i + 1
        Next
        MsgBox("Annonce modifiée")
    End Sub
End Class