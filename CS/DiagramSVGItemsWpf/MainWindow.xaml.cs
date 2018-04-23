using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using System.IO;
using DevExpress.Xpf.Diagram;
using DevExpress.Diagram.Core;

namespace DiagramSVGItemsWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow
    {
        private string path;
        public MainWindow()
        {
            InitializeComponent();
            path = @"..\..\Icons";
            CreateToolboxItems(path);
        }

        void CreateToolboxItems(string path)
        {
            var stencil = new DevExpress.Diagram.Core.DiagramStencil("SVGStencil", "IcoMoon - Free Shapes");
            string name = string.Empty;
            foreach (string file in Directory.GetFiles(path))
            {
                try
                {
                    name = System.IO.Path.GetFileNameWithoutExtension(file);
                    using (FileStream stream = File.Open(file, FileMode.Open))
                    {
                        var shape = DevExpress.Diagram.Core.ShapeDescription.CreateSvgShape(name, name, stream)
                            .Update(getDefaultSize: () => new System.Windows.Size(100, 100))
                            .Update(getConnectionPoints: (w, h, p) => new[] { new System.Windows.Point(w / 2, h / 2) });
                        stencil.RegisterShape(shape);
                    }
                }
                catch (Exception)
                {
                    //some SVG files cannot be parsed, so swallow the exception for now.
                    //throw;
                }
            }
            DevExpress.Diagram.Core.DiagramToolboxRegistrator.RegisterStencil(stencil);
            diagramDesignerControl1.SelectedStencils.Add("SVGStencil");


            diagramDesignerControl1.Items.Add(new DiagramShape() { Shape = stencil.GetShape("aid-kit"), Width = 100, Height = 100, Position = new Point(300,300) });
        }
    }
}
