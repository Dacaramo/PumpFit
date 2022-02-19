using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PumpFit.MenuItems;

namespace PumpFit
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        MainMenuMaster masterPage;

        public MainPage()
        {
            InitializeComponent();

            /*PODRIA SOLO DEJARSE Detail = new NavigationPage(new TrainingMainPage()) 
             * PERO TENIENDO EN CUENTA QUE EL COLOR DE LA BARRA DE NAVEGACION
             * ES UNA PROPIEDAD DE NavigationPage, LA FORMA MAS FACIL DE CAMBIAR ESE COLOR ES DE UNA VEZ YA QUE LA BUENA PRACTICA ES INDICAR
             LAS NavigationPage EN CODIGO Y NO EN XAML*/

            masterPage = new MainMenuMaster();
            Master = masterPage;
            Detail = new NavigationPage(new TrainingMainPage()) 
            {
                BarBackgroundColor = Color.FromHex("#2C2C2C"),
                BarTextColor = Color.White
            };

            masterPage.masterListView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.masterListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
