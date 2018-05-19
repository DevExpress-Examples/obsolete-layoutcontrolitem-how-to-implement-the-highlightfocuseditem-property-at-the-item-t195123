Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors

Namespace dxSample
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            InitLayoutControl()
        End Sub
        Private Sub InitLayoutControl()
            customLayoutControl1.OptionsView.HighlightFocusedItem = True
            InitItems()
        End Sub
        Private Sub InitItems()
            layoutControlGroup1.AddItem("TestItem 0", New TextEdit())

            Dim item As CustomLayoutControlItem = CType(layoutControlGroup1.AddItem("TestItem 1 ", New TextEdit()), CustomLayoutControlItem)
            item.HighlightFocusedItemEx = False

            layoutControlGroup1.AddItem("TestItem 2 ", New TextEdit())
        End Sub
    End Class
End Namespace
