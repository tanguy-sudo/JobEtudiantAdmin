Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class Annonce
    Private idAn As Integer
    Private titreAn As String
    Private dateDe As Date
    Private duree As String
    Private descAn As String
    Private lieu As String
    Private tarifHoraire As Integer
    Private Offreur As Offreur
    Private Categ As Categorie

    Public Sub New(unidAn As Integer, untitreAn As String, unedateDe As Date, uneduree As String, unedescAn As String, unlieu As String, untarif As Integer, unOffreur As Offreur, uneCateg As Categorie)
        idAn = unidAn
        titreAn = untitreAn
        dateDe = unedateDe
        duree = uneduree
        descAn = unedescAn
        lieu = unlieu
        tarifHoraire = untarif
        Offreur = unOffreur
        Categ = uneCateg
    End Sub

    Public ReadOnly Property getId
        Get
            Return idAn
        End Get
    End Property

    Public Property titre
        Get
            Return titreAn
        End Get
        Set(untitre)
            titreAn = untitre
        End Set
    End Property

    Public Property dateDebut
        Get
            Return dateDe
        End Get
        Set(uneDate)
            dateDe = uneDate
        End Set
    End Property

    Public Property LaDuree
        Get
            Return duree
        End Get
        Set(uneDuree)
            duree = uneDuree
        End Set
    End Property

    Public Property Description
        Get
            Return descAn
        End Get
        Set(uneDesc)
            descAn = uneDesc
        End Set
    End Property

    Public Property LieuAnnonce
        Get
            Return lieu
        End Get
        Set(unlieu)
            lieu = unlieu
        End Set
    End Property


    Public Property tarif
        Get
            Return tarifHoraire
        End Get
        Set(untarif)
            tarifHoraire = untarif
        End Set
    End Property

    Public ReadOnly Property getOff
        Get
            Return Offreur
        End Get
    End Property

    Public Property getCateg
        Get
            Return Categ
        End Get
        Set(uneCategorie)
            Categ = uneCategorie
        End Set
    End Property

    Public Sub DeleteAnn()
        cnn.Open()
        Dim cmd As New MySqlCommand
        Dim JeuEnr As MySqlDataReader
        cmd = New MySqlCommand("DELETE FROM Annonce WHERE idAn =" & idAn, cnn)
        JeuEnr = cmd.ExecuteReader
        cnn.Close()
    End Sub

    Public Sub ModifAnn()
        cnn.Open()
        Dim cmd As New MySqlCommand
        Dim JeuEnr As MySqlDataReader
        Dim laDate As String
        laDate = dateDe.ToString("yyyyMMdd", CultureInfo.InvariantCulture)
        cmd = New MySqlCommand("UPDATE Annonce SET titreAn = '" & titreAn & "', dateDe = '" & laDate & "', duree = '" & duree & "', descAn = '" & descAn & "', lieu = '" & lieu & "', tariHoraire = " & tarifHoraire & ", idCateg = " & Categ.getIdCateg & " WHERE idAn = " & CInt(idAn), cnn)
        JeuEnr = cmd.ExecuteReader
        cnn.Close()
    End Sub
End Class
