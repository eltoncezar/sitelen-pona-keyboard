using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Themes.Fluent;
using SitelenPonaKeyboard.Resources;
using SitelenPonaKeyboard.ViewModels;

namespace SitelenPonaKeyboard.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            this.FontFamily = new FontFamily("avares://SitelenPonaKeyboard/Fonts#nasin-nanpa");
            // this.FindControl<TextBox>("_textBox").AddHandler(TextInputEvent, MyTextInput_InputHandler, RoutingStrategies.Tunnel);
        }

        private void MyTextInput_InputHandler(object? sender, TextInputEventArgs e)
        {
            var vm = DataContext as MainWindowViewModel;
            // if (e.Text == " ")
            // {
                vm.Parse((sender as TextBox).Text);
                // (sender as TextBox).Text = vm.Content;
            // }
        }

        private void _textBox_OnKeyUp(object? sender, KeyEventArgs e)
        {
            var vm = DataContext as MainWindowViewModel;
            vm.Parse((sender as TextBox).Text);
            // var vm = this.DataContext as MainWindowViewModel;
            // var textBox = sender as TextBox;
            // var text = textBox.Text;
            // var words = text.Split(" ");
            //
            // if (words.Length < vm.Result.Count)
            // {
            //     //render everything again
            //     return;
            // }
            //
            // for (var i = 0; i < vm.Result.Count; i++)
            // {
            //     var word = words[i];
            //     var glyph = vm.Result[i];
            //
            //     if (word != glyph.Name)
            //     {
            //         var parsed = Glyphs.TryParse(word, out var result);
            //         if (parsed)
            //         {
            //             vm.Result.Insert(i,Glyphs.li);
            //             i++;
            //         }
            //     }
            // }

        }

        private void Button_OnClick(object? sender, RoutedEventArgs e)
        {
            // var vm = this.DataContext as MainWindowViewModel;
            // var control = this.FindControl<TextBox>("_textBox");
            //
            // var index = control.CaretIndex > 0 ? control.CaretIndex : control.Text.Length;
            // vm.CaretPosition = index;
        }
    }
}