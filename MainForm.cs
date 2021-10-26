#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorWebViewApp
{
    public partial class MainForm : Form
    {
        MenuStrip _menu;
        Control _webView;

        public MainForm()
        {
            this.SuspendLayout();
            InitializeComponent();

            _menu = new MenuStrip();
            this.MainMenuStrip = _menu;
            _menu.Name = "Main menu";
            _menu.Dock = DockStyle.Top;
            this.Controls.Add(_menu);

            var fileMenuItem = new ToolStripMenuItem("File");
            _menu.Items.Add(fileMenuItem);
            var exitMenuItem = new ToolStripMenuItem("Exit") { ShortcutKeys = Keys.Alt | Keys.X };
            exitMenuItem.Click += (_, _) => this.Close();
            fileMenuItem.DropDownItems.Add(exitMenuItem);

            var textBox = new TextBox() 
            {
                Text = "Native TextBox",
                TabStop = true,
                Multiline = true,
                TabIndex = 1,
                Dock = DockStyle.Fill,
            };

            this.tableLayoutPanel.Controls.Add(textBox);
            this.tableLayoutPanel.SetCellPosition(textBox,
                new TableLayoutPanelCellPosition { Row = 0, Column = 0 });

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBlazorWebView();
            var blazor = new BlazorWebView()
            {
                Dock = DockStyle.Fill,
                HostPage = "wwwroot/index.html",
                Services = serviceCollection.BuildServiceProvider(),
            };
            blazor.RootComponents.Add<Counter>("#app");
            blazor.TabStop = true;
            blazor.TabIndex = 2;

            this.tableLayoutPanel.Controls.Add(blazor);
            this.tableLayoutPanel.SetCellPosition(blazor, 
                new TableLayoutPanelCellPosition { Row = 1, Column = 0 });

            _webView = blazor;
            this.ResumeLayout();
        }
    }
}
