Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Collections
Imports System.Xml.Serialization
Imports System.Reflection
Imports System.Windows.Media.Imaging
Imports System.Windows.Media

Namespace HierarchicalDataBinding
	Public Class BaseObject
		Implements INotifyPropertyChanged
		Private nameCore As String
		Public Property Name() As String
			Get
				Return nameCore
			End Get
			Set(ByVal value As String)
				If Name = value Then
					Return
				End If
				nameCore = value
				OnPropertyChanged("Name")
			End Set
		End Property

		Private executorCore As String
		Public Property Executor() As String
			Get
				Return executorCore
			End Get
			Set(ByVal value As String)
				If ReferenceEquals(Executor, value) Then
					Return
				End If
				executorCore = value
				OnPropertyChanged("Executor")
			End Set
		End Property

		Private stateCore As State
		Public Property State() As State
			Get
				Return stateCore
			End Get
			Set(ByVal value As State)
				If ReferenceEquals(State, value) Then
					Return
				End If
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
		Private privateStages As ObservableCollection(Of ProjectStage)
		Public Property Stages() As ObservableCollection(Of ProjectStage)
			Get
				Return privateStages
			End Get
			Set(ByVal value As ObservableCollection(Of ProjectStage))
				privateStages = value
			End Set
		End Property
	End Class

	Public Class ProjectStage
		Inherits BaseObject
		Private privateTasks As ObservableCollection(Of Task)
		Public Property Tasks() As ObservableCollection(Of Task)
			Get
				Return privateTasks
			End Get
			Set(ByVal value As ObservableCollection(Of Task))
				privateTasks = value
			End Set
		End Property
	End Class

	Public Class Task
		Inherits BaseObject
		Private startDateCore As DateTime
		Public Property StartDate() As DateTime
			Get
				Return startDateCore
			End Get
			Set(ByVal value As DateTime)
				If StartDate = value Then
					Return
				End If
				startDateCore = value
				OnPropertyChanged("StartDate")
			End Set
		End Property
		Private endDateCore As DateTime
		Public Property EndDate() As DateTime
			Get
				Return endDateCore
			End Get
			Set(ByVal value As DateTime)
				If EndDate = value Then
					Return
				End If
				endDateCore = value
				OnPropertyChanged("EndDate")
			End Set
		End Property
	End Class

	Public Class State
		Implements IComparable
        Private privateTextValue As String
		Public Property TextValue() As String
			Get
				Return privateTextValue
			End Get
			Set(ByVal value As String)
				privateTextValue = value
			End Set
		End Property
		Private privateStateValue As Integer
		Public Property StateValue() As Integer
			Get
				Return privateStateValue
			End Get
			Set(ByVal value As Integer)
				privateStateValue = value
			End Set
		End Property
		Public Overrides Function ToString() As String
			Return TextValue
		End Function

		Public Function CompareTo(ByVal obj As Object) As Integer Implements IComparable.CompareTo
			Return Comparer(Of Integer).Default.Compare(StateValue, (CType(obj, State)).StateValue)
		End Function
	End Class

    Public Class States
        Private Shared src As List(Of State)
        Public Shared ReadOnly Property DataSource() As List(Of State)
            Get
                If src Is Nothing Then
                    src = New List(Of State)()
                    src.Add(New State() With {.TextValue = "Not started", .StateValue = 0})
                    src.Add(New State() With {.TextValue = "In progress", .StateValue = 1})
                    src.Add(New State() With {.TextValue = "Completed", .StateValue = 2})
                End If
                Return src
            End Get
        End Property
    End Class
End Namespace