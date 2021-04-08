Public Class AnnoncePostulee
    Private id As Integer
    Private etat As String
    Private letudiant As Etudiant
    Private lannonce As Annonce


    Public Sub New(unId As Integer, unEtat As String, unetudiant As Etudiant, uneannonce As Annonce)
        id = unId
        etat = unEtat
        letudiant = unetudiant
        lannonce = uneannonce
    End Sub

    Public Sub New(unId As Integer)
        id = unId
        etat = "en attente"
    End Sub

End Class
