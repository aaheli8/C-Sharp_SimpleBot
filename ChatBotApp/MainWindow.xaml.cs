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

namespace ChatBotApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void SendButton_Click(object sender, RoutedEventArgs e)
    {
        string userInput = userInputBox.Text;
        AppendMessage($"You: {userInput}");

        string botResponse = "Chatbot: Thanks for your message!";
        AppendMessage(botResponse);

        userInputBox.Clear();
    }

    private void AppendMessage(string message)
    {
        chatBox.AppendText(message + "\n");
        chatBox.ScrollToEnd();
    }

    private void UserInputBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
    {
        if (e.Key == System.Windows.Input.Key.Enter)
        {
            SendButton_Click(sender, e);
        }
    }
}

