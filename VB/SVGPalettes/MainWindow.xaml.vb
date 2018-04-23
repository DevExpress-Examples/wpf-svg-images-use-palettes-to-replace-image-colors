Imports DevExpress.Xpf.Core

Namespace SVGPalettes
    Partial Public Class MainWindow
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnOffice2016WhiteBarItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            ThemeManager.SetThemeName(Me, "Office2016White")
        End Sub

        Private Sub OnOffice2016BlackBarItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            ThemeManager.SetThemeName(Me, "Office2016Black")
        End Sub
    End Class
End Namespace
