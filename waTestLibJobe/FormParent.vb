Imports LibrairieJobs
Imports MySql.Data.MySqlClient

Public Class FormParent
    Private Sub FormParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        Me.Visible = True

        '***********************ETUDIANTS***************************

        cnn.Open()
        Dim cmd As New MySqlCommand("Select * from ETUDIANT", cnn)
        Dim jeuEnr As MySqlDataReader
        jeuEnr = cmd.ExecuteReader()
        While jeuEnr.Read
            Dim unEtudient As New Etudiant(jeuEnr.GetValue(0), jeuEnr.GetValue(1),
                                           jeuEnr.GetValue(2), jeuEnr.GetValue(3),
                                           jeuEnr.GetValue(4), jeuEnr.GetValue(5),
                                           jeuEnr.GetValue(6), jeuEnr.GetValue(7),
                                           jeuEnr.GetValue(8), jeuEnr.GetValue(9))
            colEtudiant.Add(unEtudient)
        End While
        cnn.Close()

        cnn.Open()
        Dim cmd2 As New MySqlCommand("Select * from anetudiant", cnn)
        Dim jeuEnr2 As MySqlDataReader
        jeuEnr2 = cmd2.ExecuteReader()
        While jeuEnr2.Read
            Dim uneAnEtu As New AnEtudiant(jeuEnr2.GetValue(0), jeuEnr2.GetValue(1),
                                           jeuEnr2.GetValue(2), jeuEnr2.GetValue(3))
            colAnEtu.Add(uneAnEtu)
        End While
        cnn.Close()

        '***********************CATEGORIES***********************

        cnn.Open()
        cmd = New MySqlCommand("SELECT * FROM Categorie ORDER BY libCateg", cnn)
        jeuEnr = cmd.ExecuteReader
        While JeuEnr.Read
            Dim Categ As New Categorie(JeuEnr.GetValue(0), JeuEnr.GetValue(1))

            Colcateg.Add(Categ)
        End While
        cnn.Close()

        '***********************OFFREURS**************************

        cnn.Open()
        cmd = New MySqlCommand("SELECT * FROM offreur", cnn)
        jeuEnr = cmd.ExecuteReader
        Dim prenom As String
        Dim logo As String
        Dim site As String
        While jeuEnr.Read
            If IsDBNull(JeuEnr.GetValue(2)) Then
                prenom = ""
            Else
                prenom = JeuEnr.GetValue(2)
            End If

            If IsDBNull(JeuEnr.GetValue(8)) Then
                logo = ""
            Else
                logo = JeuEnr.GetValue(8)
            End If

            If IsDBNull(JeuEnr.GetValue(11)) Then
                site = ""
            Else
                site = JeuEnr.GetValue(11)
            End If
            Dim Offreur As New Offreur(jeuEnr.GetValue(0), jeuEnr.GetValue(1), prenom, jeuEnr.GetValue(3), jeuEnr.GetValue(4), jeuEnr.GetValue(5), jeuEnr.GetValue(6), jeuEnr.GetValue(7), logo, jeuEnr.GetValue(9), jeuEnr.GetValue(10), site, jeuEnr.GetValue(12))
            ColOff.Add(Offreur)
        End While
        cnn.Close()

        '***********************ANNONCES**************************

        cnn.Open()
        cmd = New MySqlCommand("SELECT * FROM Annonce ORDER BY titreAn", cnn)
        jeuEnr = cmd.ExecuteReader
        While JeuEnr.Read
            Dim laCateg As Categorie
            Dim lOffreur As Offreur
            For Each uneCateg In Colcateg
                If uneCateg.getIdCateg() = JeuEnr.GetValue(8) Then
                    laCateg = uneCateg
                End If
            Next
            For Each unOff In ColOff
                If unOff.getId() = JeuEnr.GetValue(7) Then
                    lOffreur = unOff
                End If
            Next
            Dim Annonce As New Annonce(jeuEnr.GetValue(0), jeuEnr.GetValue(1), jeuEnr.GetValue(2), jeuEnr.GetValue(3), jeuEnr.GetValue(4), jeuEnr.GetValue(5), jeuEnr.GetValue(6), lOffreur, laCateg)
            ColAnn.Add(Annonce)
        End While
        cnn.Close()
        FormEtudiant.Show()
    End Sub

    Private Sub btnAnn_Click(sender As Object, e As EventArgs) Handles btnAnn.Click
        FormAnn.Show()
        FormCateg.Close()
        FormEtudiant.Close()
        FormOff.Close()
    End Sub

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        FormOff.Show()
        FormCateg.Close()
        FormAnn.Close()
        FormEtudiant.Close()
    End Sub

    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        FormAnn.Close()
        FormEtudiant.Close()
        FormOff.Close()
        FormCateg.Show()
    End Sub

    Private Sub btnEtu_Click(sender As Object, e As EventArgs) Handles btnEtu.Click
        FormEtudiant.Show()
        FormCateg.Close()
        FormAnn.Close()
        FormOff.Close()
    End Sub
End Class
