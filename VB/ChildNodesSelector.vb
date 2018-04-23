Imports DevExpress.Xpf.Grid
Imports System.Collections

Namespace HierarchicalDataBinding
    Public Class CustomChildrenSelector
        Implements IChildNodesSelector
        Public Function SelectChildren(ByVal item As Object) As IEnumerable Implements DevExpress.Xpf.Grid.IChildNodesSelector.SelectChildren
            If TypeOf item Is Task Then
                Return Nothing
            ElseIf TypeOf item Is ProjectStage Then
                Return (TryCast(item, ProjectStage)).Tasks
            ElseIf TypeOf item Is ProjectObject Then
                Return (TryCast(item, ProjectObject)).Stages
            End If
            Return Nothing
        End Function
    End Class
End Namespace

