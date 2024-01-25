<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128585302/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T478161)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF DiagramControl - Register and Use SVG Shapes

[Diagram Control](https://docs.devexpress.com/WPF/115046/controls-and-libraries/diagram-control) allows you to use SVG images as shapes. This example demonstrates how to create diagram shapes based on SVG images, register them, and use SVG shapes in the diagram. The [ShapeDescription.CreateSvgShape](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.ShapeDescription.CreateSvgShape(String--String--Stream--Boolean--Func-Size--IEnumerable-Point----String--String)) method creates a shape from a stream that contains an SVG image.

![image](https://github.com/DevExpress-Examples/wpf-diagram-register-and-use-svg-shapes/assets/65009440/93bcaf31-a520-42d4-8070-ecb7f7f8e9ea)

The sample project uses icons from IcoMoon's "Free Shapes" pack.

## Files to Review

* [MainWindow.xaml.cs](./CS/DiagramSVGItemsWpf/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DiagramSVGItemsWpf/MainWindow.xaml.vb))

## Documentation

* [SVG Shapes](https://docs.devexpress.com/WPF/117321/controls-and-libraries/diagram-control/diagram-items/svg-shapes)
* [Shapes](https://docs.devexpress.com/WPF/116099/controls-and-libraries/diagram-control/diagram-items/shapes)

## More Examples

* [WPF DiagramControl - Create Custom Shapes with Connection Points](https://github.com/DevExpress-Examples/wpf-diagramdesigner-create-custom-shapes-with-connection-points)
* [WPF DiagramControl - Create Items with Custom Content](https://github.com/DevExpress-Examples/wpf-diagramcontrol-create-items-with-custom-content)
* [WPF DiagramControl - Create Custom Shapes Based on Diagram Containers](https://github.com/DevExpress-Examples/wpf-diagram-create-custom-shapes-based-on-diagram-containers)
* [WPF DiagramControl - Register FactoryItemTools for Regular and Custom Shapes](https://github.com/DevExpress-Examples/wpf-diagram-register-factoryitemtools-for-shapes)
