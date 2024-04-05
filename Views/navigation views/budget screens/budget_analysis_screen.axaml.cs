using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace StellarMVVM_2024;

public partial class budget_analysis_screen : UserControl
{
    public budget_analysis_screen()
    {
        InitializeComponent();
    }

    private double averageSpentPerDay(double[] spending, double[] times)
    {
        double sum = 0;
        //timeRange is measured in days
        double timeRange = 0;
        for (int i = 0; i < spending.Length; i++)
        {
            sum += spending[i];
        }

        timeRange 
    }
}