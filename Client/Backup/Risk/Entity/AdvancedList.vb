Imports System.ComponentModel

<Serializable()> Public Class AdvancedList(Of T)
    Inherits BindingList(Of T)
    Implements IBindingListView
    Protected Overrides ReadOnly Property IsSortedCore() As Boolean
        Get
            Return sorts IsNot Nothing
        End Get
    End Property
    Protected Overrides Sub RemoveSortCore()
        sorts = Nothing
    End Sub
    Protected Overrides ReadOnly Property SupportsSortingCore() As Boolean
        Get
            Return True
        End Get
    End Property
    Protected Overrides ReadOnly Property SortDirectionCore() As ListSortDirection
        Get
            Return If(sorts Is Nothing, ListSortDirection.Ascending, sorts.PrimaryDirection)
        End Get
    End Property
    Protected Overrides ReadOnly Property SortPropertyCore() As PropertyDescriptor
        Get
            Return If(sorts Is Nothing, Nothing, sorts.PrimaryProperty)
        End Get
    End Property
    Protected Overrides Sub ApplySortCore(ByVal prop As PropertyDescriptor, ByVal direction As ListSortDirection)
        Dim arr As ListSortDescription() = {New ListSortDescription(prop, direction)}
        ApplySort(New ListSortDescriptionCollection(arr))
    End Sub
    Private sorts As PropertyComparerCollection(Of T)
    Public Sub ApplySort(ByVal sortCollection As ListSortDescriptionCollection) Implements IBindingListView.ApplySort
        Dim oldRaise As Boolean = RaiseListChangedEvents
        RaiseListChangedEvents = False
        Try
            Dim tmp As New PropertyComparerCollection(Of T)(sortCollection)
            Dim items As New List(Of T)(Me)
            items.Sort(tmp)
            Dim index As Integer = 0
            For Each item As T In items
                SetItem(index, item)
                index += 1
            Next
            sorts = tmp
        Finally
            RaiseListChangedEvents = oldRaise
            ResetBindings()
        End Try
    End Sub
    Private Property IBindingListView_Filter() As String Implements IBindingListView.Filter
        Get
            Throw New NotImplementedException()
        End Get
        Set(ByVal value As String)
            Throw New NotImplementedException()
        End Set
    End Property
    Private Sub IBindingListView_RemoveFilter() Implements IBindingListView.RemoveFilter
        Throw New NotImplementedException()
    End Sub
    Private ReadOnly Property IBindingListView_SortDescriptions() As ListSortDescriptionCollection Implements IBindingListView.SortDescriptions
        Get
            Return sorts.Sorts
        End Get
    End Property
    Private ReadOnly Property IBindingListView_SupportsAdvancedSorting() As Boolean Implements IBindingListView.SupportsAdvancedSorting
        Get
            Return True
        End Get
    End Property
    Private ReadOnly Property IBindingListView_SupportsFiltering() As Boolean Implements IBindingListView.SupportsFiltering
        Get
            Return False
        End Get
    End Property
End Class

<Serializable()> Public Class PropertyComparerCollection(Of T)
    Implements IComparer(Of T)
    Private ReadOnly m_sorts As ListSortDescriptionCollection
    Private ReadOnly comparers As PropertyComparer(Of T)()
    Public ReadOnly Property Sorts() As ListSortDescriptionCollection
        Get
            Return m_sorts
        End Get
    End Property
    Public Sub New(ByVal sorts As ListSortDescriptionCollection)
        If sorts Is Nothing Then
            Throw New ArgumentNullException("sorts")
        End If
        Me.m_sorts = sorts
        Dim list As New List(Of PropertyComparer(Of T))()
        For Each item As ListSortDescription In sorts
            list.Add(New PropertyComparer(Of T)(item.PropertyDescriptor, item.SortDirection = ListSortDirection.Descending))
        Next
        comparers = list.ToArray()
    End Sub
    Public ReadOnly Property PrimaryProperty() As PropertyDescriptor
        Get
            Return If(comparers.Length = 0, Nothing, comparers(0).[Property])
        End Get
    End Property
    Public ReadOnly Property PrimaryDirection() As ListSortDirection
        Get
            Return If(comparers.Length = 0, ListSortDirection.Ascending, If(comparers(0).Descending, ListSortDirection.Descending, ListSortDirection.Ascending))
        End Get
    End Property

    Private Function IComparer_Compare(ByVal x As T, ByVal y As T) As Integer Implements IComparer(Of T).Compare
        Dim result As Integer = 0
        For i As Integer = 0 To comparers.Length - 1
            result = comparers(i).Compare(x, y)
            If result <> 0 Then
                Exit For
            End If
        Next
        Return result
    End Function

End Class

<Serializable()> Public Class PropertyComparer(Of T)
    Implements IComparer(Of T)
    Private ReadOnly m_descending As Boolean
    Public ReadOnly Property Descending() As Boolean
        Get
            Return m_descending
        End Get
    End Property
    Private ReadOnly m_property As PropertyDescriptor
    Public ReadOnly Property [Property]() As PropertyDescriptor
        Get
            Return m_property
        End Get
    End Property
    Public Sub New(ByVal [property] As PropertyDescriptor, ByVal descending As Boolean)
        If [property] Is Nothing Then
            Throw New ArgumentNullException("property")
        End If
        Me.m_descending = descending
        Me.m_property = [property]
    End Sub
    Public Function Compare(ByVal x As T, ByVal y As T) As Integer Implements IComparer(Of T).Compare
        ' todo; some null cases
        Dim value As Integer = Comparer.[Default].Compare(m_property.GetValue(x), m_property.GetValue(y))
        Return If(m_descending, -value, value)
    End Function
End Class
