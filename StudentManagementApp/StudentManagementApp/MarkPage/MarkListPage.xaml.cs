using Microsoft.Maui.Controls;

namespace StudentManagementApp;

public partial class MarkListPage : ContentPage
{
    public MarkListPage()
    {
        InitializeComponent();
    }

    private void OnCalculate(object sender, EventArgs e)
    {
        int a = int.Parse(m1.Text ?? "0");
        int b = int.Parse(m2.Text ?? "0");
        int c = int.Parse(m3.Text ?? "0");

        result.Text = "Total: " + (a + b + c);
    }
}