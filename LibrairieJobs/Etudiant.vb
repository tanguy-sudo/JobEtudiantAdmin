Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class Etudiant
    Private idEtu As Integer
    Private nomEtu As String
    Private prenomEtu As String
    Private dateNaiss As Date
    Private mailEtu As String
    Private telEtu As String
    Private mdpEtu As String
    Private cvEtu As String
    Private idCiv As Integer
    Private idType As Integer

    Public Sub New(id As Integer, nom As String, prenom As String, dateEtu As Date, mail As String, tel As String, mdp As String, cv As String, civ As Integer, type As Integer)
        idEtu = id
        nomEtu = nom
        prenomEtu = prenom
        dateNaiss = dateEtu
        mailEtu = mail
        telEtu = tel
        mdpEtu = mdp
        cvEtu = cv
        idCiv = civ
        idType = type
    End Sub

    Public Function getId()
        Return idEtu
    End Function

    Public Property nom
        Get
            Return nomEtu
        End Get
        Set(value)
            nomEtu = value
        End Set
    End Property

    Public Property prenom
        Get
            Return prenomEtu
        End Get
        Set(value)
            prenomEtu = value
        End Set
    End Property

    Public Property uneDate
        Get
            Return dateNaiss
        End Get
        Set(value)
            dateNaiss = value
        End Set
    End Property

    Public Property mail
        Get
            Return mailEtu
        End Get
        Set(value)
            mailEtu = value
        End Set
    End Property

    Public Property tel
        Get
            Return telEtu
        End Get
        Set(value)
            telEtu = value
        End Set
    End Property

    Public Property mdp
        Get
            Return mdpEtu
        End Get
        Set(value)
            mdpEtu = value
        End Set
    End Property

    Public Function getCvEtu()
        Return cvEtu
    End Function

    Public Function getIdCiv()
        Return idCiv
    End Function
    Public Function getIdType()
        Return idType
    End Function

    Public Sub save()
        cnn.Open()
        Dim dateN As String
        dateN = dateNaiss.ToString("yyyyMMdd", CultureInfo.InvariantCulture)
        Dim cmd As New MySqlCommand("UPDATE etudiant SET nomEtu ='" & nomEtu & "', prenomEtu ='" & prenomEtu & "', dateNaiss ='" & dateN & "', mailEtu ='" & mailEtu & "', telEtu ='" & telEtu & "', mdpEtu ='" & mdpEtu & "', cvEtu ='" & cvEtu & "', idCiv =" & idCiv & ", idType =" & idType & " where idEtu = " & CInt(idEtu), cnn)
        cmd.ExecuteNonQuery()
        cnn.Close()
    End Sub

    Public Sub supprimer()
        cnn.Open()
        Dim cmd As New MySqlCommand("DELETE FROM etudiant where idEtu = " & idEtu, cnn)
        cmd.ExecuteNonQuery()
        cnn.Close()
    End Sub
End Class
