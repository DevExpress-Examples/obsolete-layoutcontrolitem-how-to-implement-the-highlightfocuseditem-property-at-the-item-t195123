Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Painting

Namespace dxSample
    Friend Class CustomLayoutControlItemSkinPainter
        Inherits LayoutControlItemSkinPainter

        Protected Overrides Sub PatchImageIndexCore(ByVal e As DevExpress.XtraLayout.ViewInfo.BaseLayoutItemViewInfo, ByVal info As SkinElementInfo, ByVal controlItem As LayoutControlItem)
            info.Bounds = GetPaintBounds(e)
            info.ImageIndex = -1
            If e.OwnerILayoutControl.OptionsView.DrawItemBorders Then
                info.ImageIndex = 0
            End If
            If e.State = ObjectState.Hot AndAlso (e.OwnerILayoutControl.OptionsView.AllowHotTrack) Then
                info.ImageIndex = 1
            End If
            If controlItem IsNot Nothing AndAlso controlItem.Control IsNot Nothing Then
                Dim highlightFocusedItemEx As Boolean = (TryCast(controlItem, CustomLayoutControlItem)).HighlightFocusedItemEx
                If (controlItem.Control.ContainsFocus OrElse IsPopupOpen(controlItem.Control)) AndAlso highlightFocusedItemEx Then
                    info.ImageIndex = 2
                End If
                If (Not controlItem.Control.Enabled) AndAlso (highlightFocusedItemEx) Then
                    info.ImageIndex = 3
                End If
            Else
                If e.OwnerILayoutControl.EnableCustomizationMode Then
                    info.ImageIndex = 3
                End If
            End If
            If info.ImageIndex > 0 AndAlso Not(e.OwnerILayoutControl.OptionsView.DrawItemBorders) Then
                Dim rect As Rectangle = info.Bounds
                rect.Inflate(-1, -1)
                info.Bounds = rect
            End If
            PatchImageIndex(info, e)
            If info.ImageIndex >= 0 Then
                ObjectPainter.DrawObject(e.Cache, SkinElementPainter.Default, info)
            End If
        End Sub
    End Class
End Namespace
