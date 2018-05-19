Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraLayout

Namespace dxSample
    Friend Class CustomLayoutControl
        Inherits LayoutControl

        Protected Overrides Sub CreateILayoutControlImplementor()
            MyBase.CreateILayoutControlImplementor()
        End Sub
        Protected Overrides Function CreateILayoutControlImplementorCore() As LayoutControlImplementor
            Return New CustomLayoutControlImplementor(Me)
        End Function
    End Class
End Namespace
