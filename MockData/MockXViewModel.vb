Public Class MockXViewModel
    Inherits NotifyBase

    Private _DummyDataGridData As ObservableCollectionEx(Of DummyData)
    Public Property DummyDataGridData As ObservableCollectionEx(Of DummyData)
        Get
            Return _DummyDataGridData
        End Get
        Set
            SetProperty(_DummyDataGridData, Value)
        End Set
    End Property

    Public Sub New()

        Dim dl As New ObservableCollectionEx(Of String) From {"ComboBoxText1", "ComboBoxText2", "ComboBoxText3"}

        DummyDataGridData = New ObservableCollectionEx(Of DummyData) From {
            New DummyData With {.DummyBool = False, .DummyString = "TestString1", .DummyList = dl},
            New DummyData With {.DummyBool = True, .DummyString = "TestString2", .DummyList = dl},
            New DummyData With {.DummyBool = False, .DummyString = "Teststring3", .DummyList = dl},
            New DummyData With {.DummyBool = False, .DummyString = "TestString4", .DummyList = dl}
        }

    End Sub


End Class

Public Class DummyData
    Inherits NotifyBase
    Private _DummyBool As Boolean
    Public Property DummyBool As Boolean
        Get
            Return _DummyBool
        End Get
        Set
            SetProperty(_DummyBool, Value)
        End Set
    End Property

    Private _DummyString As String
    Public Property DummyString As String
        Get
            Return _DummyString
        End Get
        Set
            SetProperty(_DummyString, Value)
        End Set
    End Property

    Private _DummyList As ObservableCollectionEx(Of String)
    Public Property DummyList As ObservableCollectionEx(Of String)
        Get
            Return _DummyList
        End Get
        Set
            SetProperty(_DummyList, Value)
        End Set
    End Property

    Private _ComboBoxSelected As String
    Public Property ComboBoxSelected As String
        Get
            Return _ComboBoxSelected
        End Get
        Set
            SetProperty(_ComboBoxSelected, Value)
        End Set
    End Property
End Class

