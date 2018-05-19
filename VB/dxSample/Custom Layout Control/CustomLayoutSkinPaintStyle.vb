Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraLayout.Registrator

Namespace dxSample
    Public Class CustomLayoutSkinPaintStyle
        Inherits LayoutSkinPaintStyle

        Public Sub New(ByVal owner As DevExpress.LookAndFeel.ISupportLookAndFeel)
            MyBase.New(owner)
        End Sub
        Public Overrides Function GetControlItemSkinPainter() As DevExpress.XtraLayout.Painting.LayoutControlItemSkinPainter
            If layoutControlItemSkinPainter Is Nothing Then
                layoutControlItemSkinPainter = New CustomLayoutControlItemSkinPainter()
            End If
            Return layoutControlItemSkinPainter
        End Function
    End Class
End Namespace
