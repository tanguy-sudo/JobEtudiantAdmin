Imports LibrairieJobs
Imports MySql.Data.MySqlClient
Public Class FormAnnonceEtudiantvb
    Private Sub FormAnnonceEtudiantvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Dim i As Integer
        For Each uneAnEtu In colAnEtu
            If uneAnEtu.idEtudiant = idEtudiantAnnonce Then
                For Each uneAnnonce In ColAnn
                    If uneAnnonce.getId = uneAnEtu.idannonce Then
                        DataGridViewAnnonce.Rows.Add(1)
                        DataGridViewAnnonce.Rows(i).Cells(0).Value = uneAnnonce.getId
                        DataGridViewAnnonce.Rows(i).Cells(1).Value = uneAnnonce.titre
                        If uneAnEtu.idEtatAn = 1 Then
                            DataGridViewAnnonce.Rows(i).Cells(3).Value = "En cours"
                        End If
                        If uneAnEtu.idEtatAn = 2 Then
                            DataGridViewAnnonce.Rows(i).Cells(3).Value = "Refusé"
                        End If
                        If uneAnEtu.idEtatAn = 3 Then
                            DataGridViewAnnonce.Rows(i).Cells(3).Value = "Accepté"
                        End If
                        For Each unOff In ColOff
                            If unOff.getId() = uneAnnonce.GetOff.Getid() Then
                                DataGridViewAnnonce.Rows(i).Cells(2).Value = unOff.getnom()
                            End If
                        Next
                        i = i + 1
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub ButtonAfficher_Click(sender As Object, e As EventArgs) Handles ButtonAfficher.Click
        detail = 1
        numAnn = DataGridViewAnnonce.CurrentRow.Cells(0).Value
        FormAnn.Show()
        FormEtudiant.Close()
        Me.Close()
    End Sub
End Class