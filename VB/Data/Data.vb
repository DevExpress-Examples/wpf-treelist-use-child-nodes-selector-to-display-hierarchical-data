Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel

Namespace HierarchicalDataBinding

    Public Class BaseObject
        Implements INotifyPropertyChanged

        Private nameCore As String

        Public Property Name As String
            Get
                Return nameCore
            End Get

            Set(ByVal value As String)
                If Equals(Name, value) Then Return
                nameCore = value
                OnPropertyChanged("Name")
            End Set
        End Property

        Private executorCore As String

        Public Property Executor As String
            Get
                Return executorCore
            End Get

            Set(ByVal value As String)
                If ReferenceEquals(Executor, value) Then Return
                executorCore = value
                OnPropertyChanged("Executor")
            End Set
        End Property

        Private stateCore As State

        Public Property State As State
            Get
                Return stateCore
            End Get

            Set(ByVal value As State)
                If ReferenceEquals(State, value) Then Return
                stateCore = value
                OnPropertyChanged("State")
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return Name
        End Function

        Protected Sub OnPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    End Class

    Public Class ProjectObject
        Inherits BaseObject

        Public Property Stages As ObservableCollection(Of ProjectStage)
    End Class

    Public Class ProjectStage
        Inherits BaseObject

        Public Property Tasks As ObservableCollection(Of Task)
    End Class

    Public Class Task
        Inherits BaseObject

        Private startDateCore As Date

        Public Property StartDate As Date
            Get
                Return startDateCore
            End Get

            Set(ByVal value As Date)
                If StartDate = value Then Return
                startDateCore = value
                OnPropertyChanged("StartDate")
            End Set
        End Property

        Private endDateCore As Date

        Public Property EndDate As Date
            Get
                Return endDateCore
            End Get

            Set(ByVal value As Date)
                If EndDate = value Then Return
                endDateCore = value
                OnPropertyChanged("EndDate")
            End Set
        End Property
    End Class

    Public Class State
        Implements IComparable

        Public Property TextValue As String

        Public Property StateValue As Integer

        Public Overrides Function ToString() As String
            Return TextValue
        End Function

        Public Function CompareTo(ByVal obj As Object) As Integer Implements IComparable.CompareTo
            Return Comparer(Of Integer).Default.Compare(StateValue, CType(obj, State).StateValue)
        End Function
    End Class

    Public Class States

        Private Shared src As List(Of State)

        Public Shared ReadOnly Property DataSource As List(Of State)
            Get
                If src Is Nothing Then
                    src = New List(Of State)()
                    Call src.Add(New State() With {.TextValue = "Not started", .StateValue = 0})
                    Call src.Add(New State() With {.TextValue = "In progress", .StateValue = 1})
                    Call src.Add(New State() With {.TextValue = "Completed", .StateValue = 2})
                End If

                Return src
            End Get
        End Property
    End Class
End Namespace
