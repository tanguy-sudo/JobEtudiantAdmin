Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class Categorie
    Private idCateg As Integer
    Private libCateg As String

    Public Sub New(unidCateg As Integer, unlibCateg As String)
        idCateg = unidCateg
        libCateg = unlibCateg
    End Sub

    Public Function getCateg() As String
        Return libCateg
    End Function

    Public Sub setCateg(newCateg)
        libCateg = newCateg
    End Sub


    Public Function getIdCateg() As String
        Return idCateg
    End Function

    Public Sub DeleteCateg()
        cnn.Open()
        Dim cmd As New MySqlCommand
        Dim JeuEnr As MySqlDataReader
        cmd = New MySqlCommand("DELETE FROM categorie WHERE idCateg =" & idCateg, cnn)
        JeuEnr = cmd.ExecuteReader
        cnn.Close()
    End Sub

    Public Sub ModifCateg()
        cnn.Open()
        Dim cmd As New MySqlCommand
        Dim JeuEnr As MySqlDataReader
        cmd = New MySqlCommand("UPDATE categorie SET libCateg = '" & libCateg & "' WHERE idCateg = " & CInt(idCateg), cnn)
        JeuEnr = cmd.ExecuteReader
        cnn.Close()
    End Sub

    Public Sub NewCateg()
        cnn.Open()
        Dim cmd As New MySqlCommand
        Dim JeuEnr As MySqlDataReader
        cmd = New MySqlCommand("INSERT INTO categorie (libCateg) VALUES ('" & libCateg & "') ", cnn)
        JeuEnr = cmd.ExecuteReader
        cnn.Close()
    End Sub
End Class
