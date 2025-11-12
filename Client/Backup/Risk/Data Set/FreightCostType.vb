Public Class FreightCostType
    Private m_Index As String
    Private m_FreightType As String
    Public Sub New(ByVal Index As String, ByVal FreightType As String)
        m_Index = Index
        m_FreightType = FreightType
    End Sub
    Public ReadOnly Property Index() As String
        Get
            Return m_Index
        End Get
    End Property
    Public ReadOnly Property FreightType() As String
        Get
            Return m_FreightType
        End Get
    End Property
    Public Shared ReadOnly Property FreightCostTypes()
        Get
            Dim ft(2) As FreightCostType
            ft(0) = New FreightCostType("1", "Phone & Sim")
            ft(1) = New FreightCostType("2", "Phone Only")
            ft(2) = New FreightCostType("3", "Sim Only")
            Return ft
        End Get
    End Property
End Class
