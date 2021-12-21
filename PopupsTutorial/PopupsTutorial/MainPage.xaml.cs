using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopupsTutorial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnDisplayAlertButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Внимание", "Это Внимание.", "OK");
        }

        async void OnDisplayAlertQuestionButtonClicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert("Сохранить?", "Хоттие сохранить свои данные?", "Yes", "No");
            Console.WriteLine("Сохраненны данные: " + response);
        }

        async void OnDisplayActionSheetButtonClicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Отправить куда?", "Отмена", null, "Email", "Twitter", "Facebook");
            Console.WriteLine("Action: " + action);
        }
    }
}
