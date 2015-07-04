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

namespace WpfToolkitChart
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      showColumnChart();
    }

    private void showColumnChart()
    {
      List<KeyValuePair<string, double>> valueList = new List<KeyValuePair<string, double>>();
      valueList.Add(new KeyValuePair<string, double>("6:11",1.2));
      valueList.Add(new KeyValuePair<string, double>("6:27", 1.45));
      valueList.Add(new KeyValuePair<string, double>("6:37", 1.3));
      valueList.Add(new KeyValuePair<string, double>("6:55", .2));
      valueList.Add(new KeyValuePair<string, double>("7:03", .23));

      //Setting data for column chart
      columnChart.DataContext = valueList;

      // Setting data for pie chart
      pieChart.DataContext = valueList;

      //Setting data for area chart
      areaChart.DataContext = valueList;

      //Setting data for bar chart
      barChart.DataContext = valueList;

      //Setting data for line chart
      lineChart.DataContext = valueList;
    }

  }
}
