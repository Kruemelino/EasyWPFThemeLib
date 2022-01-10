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
        DummyDataGridData = New ObservableCollectionEx(Of DummyData) From {
            New DummyData With {.DummyBool = False, .DummyString = "TestString1"},
            New DummyData With {.DummyBool = True, .DummyString = "TestString1"},
            New DummyData With {.DummyBool = False, .DummyString = "Teststring3"},
            New DummyData With {.DummyBool = False, .DummyString = "TestString1"}
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

End Class

