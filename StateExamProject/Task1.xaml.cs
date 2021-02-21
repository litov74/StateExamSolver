using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StateExamProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Task1 : ContentPage
    {
        public Task1()
        {
            InitializeComponent();


        }

        public async void textInsertBtn_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textEntry.Text))
            {
                await DisplayAlert("Ошибка.", "Не введен текст!", "OK");
            }
            else
            {
                textLbl.Text = textEntry.Text;
            }
        }
    }
}