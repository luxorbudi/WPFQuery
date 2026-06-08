using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Lens.ViewModels;

namespace Lens;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
        
        InitEnvironments();
        InitQueries();
        InitRowsShown();
    }

    private void InitEnvironments() {
        EnvironmentGrid.DataContext = new EnvironmentViewModel();
    }

    private void InitQueries() {
        QueryGrid.DataContext = new QueryViewModel();
    }

    private void InitRowsShown() {
        RowsShownGrid.DataContext = new RowsShownViewModel();
    }

    private void StartDatePicker_Loaded(object sender, RoutedEventArgs e) {
        DatePicker? dp = sender as DatePicker;

        if (dp?.Template.
            FindName("PART_TextBox", dp) is 
                not DatePickerTextBox tb) return;

        tb.Loaded += (s, args) => {
            if (tb.Template.FindName("PART_Watermark", tb) is 
                ContentControl watermark) watermark.Visibility = Visibility.Collapsed;
        };
    }

    private void EndDatePicker_Loaded(object sender, RoutedEventArgs e) {
        DatePicker? dp = sender as DatePicker;

        if (dp?.Template.
            FindName("PART_TextBox", dp) is 
                not DatePickerTextBox tb) return;

        tb.Loaded += (s, args) => {
            if (tb.Template.FindName("PART_Watermark", tb) is 
                ContentControl watermark) watermark.Visibility = Visibility.Collapsed;
        };
    }

    private void ConsultButton_Click(object sender, RoutedEventArgs e) {
        int envId = int.Parse(EnvCbo.SelectedValue.ToString()!);
        int queryId = int.Parse(QueryCbo.SelectedValue.ToString()!);
        string agreement = AgreementTxt.Text;



        
        // Your click logic goes here
        MessageBox.Show("Button was clicked!");
    }
}