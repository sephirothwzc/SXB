using Xamarin.Forms;
using System.Windows.Input;

namespace SXB.View.Pages
{
    [Navigation.RegisterViewModel(typeof(SXB.ViewModel.Pages.SYS_USERS_PageModel))]
    public partial class SYSUSERS_Page : ContentPage
    {
        public SYSUSERS_Page()
        {
            InitializeComponent();
        }

        public const string ItemSelectedCommandPropertyName = "ItemSelectedCommand";
        public static BindableProperty ItemSelectedCommandProperty = BindableProperty.Create(
            propertyName: "ItemSelectedCommand",
            returnType: typeof(ICommand),
            declaringType: typeof(SYSUSER_Page),
            defaultValue: null);

        public ICommand ItemSelectedCommand
        {
            get { return (ICommand)GetValue(ItemSelectedCommandProperty); }
            set { SetValue(ItemSelectedCommandProperty, value); }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            RemoveBinding(ItemSelectedCommandProperty);
            SetBinding(ItemSelectedCommandProperty, new Binding(ItemSelectedCommandPropertyName));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _listView.SelectedItem = null;
        }

        private void HandleItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            var command = ItemSelectedCommand;
            if (command != null && command.CanExecute(e.SelectedItem))
            {
                command.Execute(e.SelectedItem);
            }
        }
    }
}
