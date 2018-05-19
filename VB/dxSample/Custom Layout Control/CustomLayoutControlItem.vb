Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraLayout

Namespace dxSample
    Friend Class CustomLayoutControlItem
        Inherits LayoutControlItem

        Private _HighlightFocusedItemEx As Boolean
        Public Property HighlightFocusedItemEx() As Boolean
            Get
                Return _HighlightFocusedItemEx
            End Get
            Set(ByVal value As Boolean)
                If HighlightFocusedItemEx = value Then
                    Return
                End If
                _HighlightFocusedItemEx = value
            End Set
        End Property
        Public Sub New(ByVal parent As LayoutControlGroup)
            MyBase.New(parent)

            _HighlightFocusedItemEx = parent.Owner.OptionsView.HighlightFocusedItem
        End Sub
    End Class
End Namespace
