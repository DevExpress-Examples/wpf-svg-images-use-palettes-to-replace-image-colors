<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128642210/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T615789)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF SVG Images - Use Palettes to Replace Image Colors

This example demonstrates how to change SVG image colors for a theme.

![image](https://user-images.githubusercontent.com/65009440/227927881-0a1a5a49-dbf6-4384-95b1-2ccb583106d8.png)

The following code sample adds an additional image state. The `dx:SvgImageHelper.State` attached property applies this state if the application theme name equals the `WpfSvgPalette.Key` property value (**Office2016Black** in this example). The `SolidColorBrush.Key` property specifies the color replaced with the `SolidColorBrush.Color` property. This example changes the color from **#333333** to **#FFFFFE**:

```xaml
<Image Source="{dx:SvgImageSource Uri=Images/logo.svg}" Width="164" 
       dx:SvgImageHelper.State="{Binding Path=(dx:ThemeManager.TreeWalker).ThemeName, RelativeSource={RelativeSource Self}}">
    <dx:WpfSvgPalette.Palette>
        <dx:WpfSvgPalette>
            <dx:WpfSvgPalette.States>
                <dx:WpfSvgPalette x:Key="Office2016Black">
                    <SolidColorBrush x:Key="#333333" Color="#FFFFFE"/>
                </dx:WpfSvgPalette>
            </dx:WpfSvgPalette.States>
        </dx:WpfSvgPalette>
    </dx:WpfSvgPalette.Palette>
</Image>
```

## Files to Review

* [MainWindow.xaml](./CS/SVGPalettes/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/SVGPalettes/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/SVGPalettes/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/SVGPalettes/MainWindow.xaml.vb))

## Documentation

* [SVG Images](https://docs.devexpress.com/WPF/120131/common-concepts/images/svg-images)
* [SVG Image Palettes](https://docs.devexpress.com/WPF/120131/common-concepts/images/svg-images#svg-image-palettes)
* [WpfSvgPalette](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.WpfSvgPalette)
* [SvgImageHelper](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.SvgImageHelper)
* [SvgImageSourceExtension](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.SvgImageSourceExtension)

## More Examples

* [WPF SvgImageSource Extension - Specify a Vector Image as a Glyph](https://github.com/DevExpress-Examples/wpf-svgimagesource-extension-specify-vector-image-as-glyph)
* [Specify SVG Images Manually](https://github.com/DevExpress-Examples/how-to-specify-svg-images-manually-t612359)
