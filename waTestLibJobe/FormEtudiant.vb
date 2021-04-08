Imports LibrairieJobs
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class FormEtudiant
    Private Sub FormEtudiant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FormParent
        FormParent.IsMdiContainer = True
        Dim i As Integer
        For Each unEtu In colEtudiant
            SelectEtudiant.Rows.Add(1)
            SelectEtudiant.Rows(i).Cells(0).Value = unEtu.getId()
            SelectEtudiant.Rows(i).Cells(1).Value = unEtu.nom
            SelectEtudiant.Rows(i).Cells(2).Value = unEtu.prenom
            i = i + 1
        Next
        For Each unEtu In colEtudiant
            Dim id As Integer
            Dim civ As Integer
            id = unEtu.getId()
            If id = SelectEtudiant.Rows(0).Cells(0).Value Then
                TextBoxId.Text = unEtu.getId()
                TextBoxNom.Text = unEtu.nom
                TextBoxPrenom.Text = unEtu.prenom
                TextBoxDateNaiss.Value = unEtu.uneDate
                TextBoxMail.Text = unEtu.mail
                TextBoxTel.Text = unEtu.tel
                TextBoxMdp.Text = unEtu.mdp
                TextBoxCV.Text = unEtu.getCvEtu
                civ = unEtu.getIdCiv()
                idEtudiantAnnonce = TextBoxId.Text
                If (civ = "1") Then
                    TextBoxIdCiv.Text = "Madame"
                End If
                If (civ = "2") Then
                    TextBoxIdCiv.Text = "Monsieur"
                End If
            End If
        Next
        TextBoxId.Visible = False
    End Sub

    Private Sub ButtonAnnonceEtu_Click(sender As Object, e As EventArgs) Handles ButtonAnnonceEtu.Click
        FormAnnonceEtudiantvb.Show()
    End Sub

    Private Sub ButtonModifier_Click(sender As Object, e As EventArgs) Handles ButtonModifier.Click
        Dim id As Integer
        For Each unEtu In colEtudiant
            id = unEtu.getId()
            If id = TextBoxId.Text Then
                unEtu.nom = TextBoxNom.Text
                unEtu.prenom = TextBoxPrenom.Text
                unEtu.uneDate = TextBoxDateNaiss.Value
                unEtu.mail = TextBoxMail.Text
                unEtu.tel = TextBoxTel.Text
                unEtu.mdp = TextBoxMdp.Text
                unEtu.save()
                idEtudiantAnnonce = TextBoxId.Text
            End If
        Next
        SelectEtudiant.Rows.Clear()
        Dim i As Integer
        For Each unEtu In colEtudiant
            SelectEtudiant.Rows.Add(1)
            SelectEtudiant.Rows(i).Cells(0).Value = unEtu.getId()
            SelectEtudiant.Rows(i).Cells(1).Value = unEtu.nom
            SelectEtudiant.Rows(i).Cells(2).Value = unEtu.prenom
            If (unEtu.getId() = TextBoxId.Text) Then
                SelectEtudiant.CurrentCell = SelectEtudiant.Rows(i).Cells(1)
            End If
            i = i + 1
        Next
        MsgBox("Étudiant modifié")
    End Sub

    Private Sub SelectEtudiant_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SelectEtudiant.CellClick
        For Each unEtu In colEtudiant
            Dim id As String
            Dim civ As Integer
            id = unEtu.getId()
            If id = SelectEtudiant.CurrentRow.Cells(0).Value Then
                TextBoxId.Text = unEtu.getId()
                TextBoxNom.Text = unEtu.nom
                TextBoxPrenom.Text = unEtu.prenom
                TextBoxDateNaiss.Value = unEtu.uneDate
                TextBoxMail.Text = unEtu.mail
                TextBoxTel.Text = unEtu.tel
                TextBoxMdp.Text = unEtu.mdp
                TextBoxCV.Text = unEtu.getCvEtu
                civ = unEtu.getIdCiv()
                idEtudiantAnnonce = TextBoxId.Text
                If (civ = "1") Then
                    TextBoxIdCiv.Text = "Madame"
                End If
                If (civ = "2") Then
                    TextBoxIdCiv.Text = "Monsieur"
                End If
            End If
        Next
    End Sub

    Private Sub BTNsupprimer_Click(sender As Object, e As EventArgs) Handles BTNsupprimer.Click
        Dim result As Integer = MessageBox.Show("Etes-vous sûr de supprimer cet étudiant ?", "confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim id As Integer
            Dim j As Integer
            id = TextBoxId.Text
            j = 1
            For Each unEtu In colEtudiant
                If unEtu.getId() = id Then
                    unEtu.supprimer()
                    colEtudiant.Remove(j)
                    SelectEtudiant.Rows.Clear()
                End If
                j = j + 1
            Next
            Dim i As Integer
            For Each unEtu In colEtudiant
                SelectEtudiant.Rows.Add(1)
                SelectEtudiant.Rows(i).Cells(0).Value = unEtu.getId()
                SelectEtudiant.Rows(i).Cells(1).Value = unEtu.nom
                SelectEtudiant.Rows(i).Cells(2).Value = unEtu.prenom
                i = i + 1
            Next
            For Each unEtu In colEtudiant
                id = unEtu.getId()
                Dim civ As Integer
                If id = SelectEtudiant.Rows(0).Cells(0).Value Then
                    TextBoxId.Text = unEtu.getId()
                    TextBoxNom.Text = unEtu.nom
                    TextBoxPrenom.Text = unEtu.prenom
                    TextBoxDateNaiss.Value = unEtu.uneDate
                    TextBoxMail.Text = unEtu.mail
                    TextBoxTel.Text = unEtu.tel
                    TextBoxMdp.Text = unEtu.mdp
                    TextBoxCV.Text = unEtu.getCvEtu
                    civ = unEtu.getIdCiv()
                    idEtudiantAnnonce = TextBoxId.Text
                    If (civ = "1") Then
                        TextBoxIdCiv.Text = "Madame"
                    End If
                    If (civ = "2") Then
                        TextBoxIdCiv.Text = "Monsieur"
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub TxtRecherche_TextChanged(sender As Object, e As EventArgs) Handles TxtRecherche.TextChanged
        Dim recherche As String
        Dim i As Integer
        i = 0
        recherche = TxtRecherche.Text.ToLower
        SelectEtudiant.Rows.Clear()
        For Each unEtu In colEtudiant
            If (InStr(unEtu.nom.toLower, recherche) Or InStr(unEtu.prenom.toLower, recherche)) > 0 Then
                SelectEtudiant.Rows.Add(1)
                SelectEtudiant.Rows(i).Cells(0).Value = unEtu.getId()
                SelectEtudiant.Rows(i).Cells(1).Value = unEtu.nom
                SelectEtudiant.Rows(i).Cells(2).Value = unEtu.prenom
                i = i + 1
            End If
        Next
    End Sub
End Class