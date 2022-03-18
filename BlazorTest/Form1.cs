
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using BlazorTest.Components;
using MudBlazor.Services;

namespace BlazorTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBlazorWebView();
            serviceCollection.AddMudServices();
            var serviceProvider = serviceCollection.BuildServiceProvider();

            blazorWebView1.HostPage =  "wwwroot\\index.html";
            blazorWebView1.Services = serviceProvider;
            blazorWebView1.RootComponents.Add<TestComponent>("#app");

        }

        protected override void OnClosed(EventArgs e)
        {
            blazorWebView1.Dispose();
            base.OnClosed(e);
        }

    }
}