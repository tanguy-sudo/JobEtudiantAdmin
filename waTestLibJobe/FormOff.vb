Public Class FormOff
    Private Sub offreurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FormParent
        FormParent.IsMdiContainer = True


        Dim i As Integer = 0

        For Each offreur In colOff
            Dim txt As String
            Dim num As Integer

            txt = offreur.getnom
            txt = txt + " " + offreur.getprenom

            num = offreur.getId


            DGVOffreur.Rows.Add(1)
            DGVOffreur.Rows(i).Cells(0).Value = num
            DGVOffreur.Rows(i).Cells(1).Value = txt

            i = i + 1
        Next

        CBIdCivilite.Items.Add("1")
        CBIdCivilite.Items.Add("2")
        CBIdCivilite.Items.Add("3")

        CBIdType.Items.Add("1")
        CBIdType.Items.Add("2")
        CBIdType.Items.Add("3")

        For Each offreur In ColOff
            Dim Id As String
            Id = offreur.getId
            If Id = DGVOffreur.Rows(0).Cells(0).Value Then
                TBNom.Text = offreur.getnom
                TBPrenom.Text = offreur.getprenom
                TBID.Text = offreur.getId
                TBAdresse.Text = offreur.getadresse
                TBVille.Text = offreur.getville
                TBCP.Text = offreur.getcp
                TBMail.Text = offreur.getmail
                TBLogo.Text = offreur.getlogo
                TBTel.Text = offreur.gettel
                TBMdp.Text = offreur.Getmdp
                TBSite.Text = offreur.getsite

                Dim civ As String = offreur.getidCiv
                CBIdCivilite.SelectedItem = civ
                CBIdType.SelectedItem = offreur.getidType
                If CBIdType.SelectedItem = "1" Then
                    TBType.Text = "Étudiant"
                ElseIf CBIdType.SelectedItem = "2" Then
                    TBType.Text = "Professionnel"
                ElseIf CBIdType.SelectedItem = "3" Then
                    TBType.Text = "Particulier"
                End If
                If CBIdCivilite.SelectedItem = "1" Then
                    TBCivilite.Text = "Madame"
                ElseIf CBIdCivilite.SelectedItem = "2" Then
                    TBCivilite.Text = "Monsieur"
                ElseIf CBIdCivilite.SelectedItem = "3" Then
                    TBCivilite.Text = "Entreprise"
                End If
            End If
            Refresh()
        Next

    End Sub

    Private Sub TBoff_TextChanged(sender As Object, e As EventArgs) Handles TBoff.TextChanged

        DGVOffreur.Rows.Clear()

        Dim i As Integer

        i = 0

        For Each uneAnn In colOff
            Dim titre As String
            titre = uneAnn.getnom
            titre = titre + " " + uneAnn.getprenom

            If InStr(titre.ToLower, TBoff.Text.ToLower) > 0 Then

                DGVOffreur.Rows.Add(1)

                DGVOffreur.Rows(i).Cells(0).Value = uneAnn.getId()

                DGVOffreur.Rows(i).Cells(1).Value = uneAnn.getnom() & " " & uneAnn.getprenom()

                i = i + 1

            End If


        Next


    End Sub

    Private Sub DGVOffreur_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOffreur.CellClick


        For Each offreur In colOff
            Dim Id As String
            Id = offreur.getId



            If Id = DGVOffreur.CurrentRow.Cells(0).Value Then
                TBNom.Text = offreur.getnom
                TBPrenom.Text = offreur.getprenom
                TBID.Text = offreur.getId
                TBAdresse.Text = offreur.getadresse
                TBVille.Text = offreur.getville
                TBCP.Text = offreur.getcp
                TBMail.Text = offreur.getmail
                TBLogo.Text = offreur.getlogo
                TBTel.Text = offreur.gettel
                TBMdp.Text = offreur.Getmdp
                TBSite.Text = offreur.getsite

                Dim civ As String = offreur.getidCiv

                CBIdCivilite.SelectedItem = civ
                CBIdType.SelectedItem = offreur.getidType


                If CBIdType.SelectedItem = "1" Then
                    TBType.Text = "Étudiant"
                ElseIf CBIdType.SelectedItem = "2" Then
                    TBType.Text = "Professionnel"
                ElseIf CBIdType.SelectedItem = "3" Then
                    TBType.Text = "Particulier"
                End If

                If CBIdCivilite.SelectedItem = "1" Then
                    TBCivilite.Text = "Madame"
                ElseIf CBIdCivilite.SelectedItem = "2" Then
                    TBCivilite.Text = "Monsieur"
                ElseIf CBIdCivilite.SelectedItem = "3" Then
                    TBCivilite.Text = "Entreprise"
                End If

            End If

            Refresh()


        Next
    End Sub
    Private Sub BtnSupp_Click(sender As Object, e As EventArgs) Handles BtnSupp.Click
        Dim result As Integer = MessageBox.Show("Etes-vous sûr de supprimer cet offreur ?", "confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim id As Integer
            Dim j As Integer
            id = TBID.Text
            j = 1
            For Each unEtu In colOff
                If unEtu.getId() = id Then
                    unEtu.supprimer()
                    colOff.Remove(j)
                    DGVOffreur.Rows.Clear()
                End If
                j = j + 1
            Next
            Dim i As Integer
            For Each unEtu In colOff
                DGVOffreur.Rows.Add(1)
                DGVOffreur.Rows(i).Cells(0).Value = unEtu.getId()
                DGVOffreur.Rows(i).Cells(1).Value = unEtu.nom + " " + unEtu.prenom
                i = i + 1
            Next
            For Each unEtu In colOff
                id = unEtu.getId()
                If id = DGVOffreur.Rows(0).Cells(0).Value Then
                    TBNom.Text = unEtu.getnom
                    TBPrenom.Text = unEtu.getprenom
                    TBID.Text = unEtu.getId
                    TBAdresse.Text = unEtu.getadresse
                    TBVille.Text = unEtu.getville
                    TBCP.Text = unEtu.getcp
                    TBMail.Text = unEtu.getmail
                    TBLogo.Text = unEtu.getlogo
                    TBTel.Text = unEtu.gettel
                    TBMdp.Text = unEtu.Getmdp
                    TBSite.Text = unEtu.getsite
                End If
            Next
        End If
    End Sub

    Private Sub BtnModif_Click(sender As Object, e As EventArgs) Handles BtnModif.Click

        For Each unEtu In colOff
                Dim id As String
                id = unEtu.getId()
                If id = TBID.Text Then
                    unEtu.nom = TBNom.Text
                    unEtu.prenom = TBPrenom.Text
                    unEtu.mail = TBMail.Text
                    unEtu.tel = TBTel.Text
                    unEtu.mdp = TBMdp.Text
                    unEtu.logo = TBLogo.Text
                    unEtu.cp = TBCP.Text
                    unEtu.ville = TBVille.Text
                    unEtu.civ = CBIdCivilite.Text
                    unEtu.type = CBIdType.Text
                    unEtu.site = TBSite.Text
                    unEtu.save()
                End If
            Next
            DGVOffreur.Rows.Clear()
            Dim i As Integer
            For Each unEtu In colOff
                DGVOffreur.Rows.Add(1)
                DGVOffreur.Rows(i).Cells(0).Value = unEtu.getId()
                DGVOffreur.Rows(i).Cells(1).Value = unEtu.nom + " " + unEtu.prenom
                If (unEtu.getId() = TBID.Text) Then
                    DGVOffreur.CurrentCell = DGVOffreur.Rows(i).Cells(1)
                End If
                i = i + 1
            Next
        MsgBox("Offreur modifié")
    End Sub

End Class