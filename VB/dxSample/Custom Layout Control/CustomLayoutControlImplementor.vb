Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Registrator

Namespace dxSample
    Friend Class CustomLayoutControlImplementor
        Inherits LayoutControlImplementor

        Public Sub New(ByVal owner As ILayoutControlOwner)
            MyBase.New(owner)
        End Sub

        Public Overrides Function CreateLayoutItem(ByVal parent As LayoutGroup) As BaseLayoutItem
            Return New CustomLayoutControlItem(CType(parent, LayoutControlGroup))
        End Function
        Protected Overrides Sub InitializePaintStyles()
            Dim lookAndFeelOwner As ISupportLookAndFeel = owner.GetISupportLookAndFeel()
            If lookAndFeelOwner IsNot Nothing Then
                PaintStyles.Add(New LayoutOffice2003PaintStyle(lookAndFeelOwner))
                PaintStyles.Add(New LayoutWindowsXPPaintStyle(lookAndFeelOwner))
                PaintStyles.Add(New CustomLayoutSkinPaintStyle(lookAndFeelOwner))
                PaintStyles.Add(New Style3DPaintStyle(lookAndFeelOwner))
                PaintStyles.Add(New UltraFlatPaintStyle(lookAndFeelOwner))
                PaintStyles.Add(New FlatPaintStyle(lookAndFeelOwner))
            End If
            lookAndFeelOwner = Nothing
        End Sub
    End Class
End Namespace
