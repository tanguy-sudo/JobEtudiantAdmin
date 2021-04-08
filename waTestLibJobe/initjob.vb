Imports LibrairieJobs
Imports MySql.Data.MySqlClient
Module initjob
    Public cnn As New MySqlConnection("Server=localhost;Port=3306;User Id=root;Password=;DataBase=bdjobe")
    Public colEtudiant As New Collection
    Public colAnEtu As New Collection
    Public Colcateg As New Collection
    Public ColOff As New Collection
    Public idEtudiantAnnonce As Integer
    Public ColAnn As New Collection
    Public detail As String
    Public numAnn As Integer
End Module
