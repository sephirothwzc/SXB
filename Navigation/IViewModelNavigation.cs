using System.Threading.Tasks;

namespace Navigation
{
	/// <summary>
	/// 导航model接口
	/// </summary>
    public interface IViewModelNavigation
    {
        Task<object> PopAsync();

        Task<object> PopModalAsync();

        Task PopToRootAsync();

        Task PushAsync(object viewModel);

        Task PushModalAsync(object viewModel);
    }
}

