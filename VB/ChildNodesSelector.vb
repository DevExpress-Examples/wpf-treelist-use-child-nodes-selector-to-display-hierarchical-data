Imports DevExpress.Xpf.Grid
Imports System.Collections

Namespace ChildNodesSelector

    Public Class CustomChildrenSelector
        Implements IChildNodesSelector

        Public Function SelectChildren(ByVal item As Object) As IEnumerable Implements IChildNodesSelector.SelectChildren
            If TypeOf item Is ProjectStage Then
                Return TryCast(item, ProjectStage).Tasks
            ElseIf TypeOf item Is ProjectObject Then
                Return TryCast(item, ProjectObject).Stages
            End If

            Return Nothing
        End Function
    End Class
End Namespace
