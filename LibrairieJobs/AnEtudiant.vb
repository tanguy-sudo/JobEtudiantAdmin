Public Class AnEtudiant
    Private idanetudiant As Integer
    Private idAn As Integer
    Private idEtu As Integer
    Private idEta As Integer

    Public Sub New(id As Integer, An As Integer, etu As Integer, eta As Integer)
        idanetudiant = id
        idAn = An
        idEtu = etu
        idEta = eta
    End Sub

    Public Property idanetu
        Get
            Return idanetudiant
        End Get
        Set(value)
            idanetudiant = value
        End Set
    End Property

    Public Property idannonce
        Get
            Return idAn
        End Get
        Set(value)
            idAn = value
        End Set
    End Property

    Public Property idEtudiant
        Get
            Return idEtu
        End Get
        Set(value)
            idEtu = value
        End Set
    End Property

    Public Property idEtatAn
        Get
            Return idEta
        End Get
        Set(value)
            idEta = value
        End Set
    End Property
End Class
