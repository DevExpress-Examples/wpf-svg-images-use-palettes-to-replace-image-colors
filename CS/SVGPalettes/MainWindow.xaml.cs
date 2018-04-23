using DevExpress.Xpf.Core;

namespace SVGPalettes {
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();
        }

        void OnOffice2016WhiteBarItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            ThemeManager.SetThemeName(this, "Office2016White");
        }

        void OnOffice2016BlackBarItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            ThemeManager.SetThemeName(this, "Office2016Black");
        }
    }
}
