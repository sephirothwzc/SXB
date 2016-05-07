using SXBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXB.ViewModel.Pages
{
    /// <summary>
    /// 列表对象
    /// </summary>
    public class SYS_USERS_PageModel:PageViewModel
    {
        public SYS_USERS_PageModel(string title= null)
        {
            Title = title??"用户列表";
        }

        /// <summary>
        /// 异步加载数据列表
        /// </summary>
        /// <param name="loadTask"></param>
        public async void LoadItemsAsync(Task<List<SYS_USER>> loadTask)
        {
            //开启loading
            IsLoading = true;
            try
            {
                //异步加载
                Items = await loadTask;
            }
            catch (Exception)
            {
                Items = null;
            }
            //关闭loading
            IsLoading = false;
        }

        /// <summary>
        /// 数据源
        /// </summary>
        private List<SXBModels.SYS_USER> _items;
        /// <summary>
        /// 用户列表
        /// </summary>
        public IEnumerable<SXBModels.SYS_USER> Items
        {
            get
            {
                return _items;
            }

            private set
            {
                if (_items != value)
                {
                    _items = value.ToList();
                    OnPropertyChanged();//调用更新
                }
            }
        }

        private bool _isLoading;
        public bool IsLoading
        {
            get { return _isLoading; }

            private set
            {
                if (_isLoading != value)
                {
                    _isLoading = value;
                    OnPropertyChanged();
                }
            }
        }

        private Xamarin.Forms.Command _itemSelectedCommand;
        /// <summary>
        /// 单个对象选择提交
        /// </summary>
        public System.Windows.Input.ICommand ItemSelectedCommand
        {
            get
            {
                if (_itemSelectedCommand == null)
                {
                    _itemSelectedCommand = new Xamarin.Forms.Command(HandleItemSelected);
                }

                return _itemSelectedCommand;
            }
        }

        /// <summary>
        /// 选中事件
        /// </summary>
        /// <param name="parameter"></param>
        private void HandleItemSelected(object parameter)
        {
            ViewModelNavigation.PushAsync(new SYS_USER_PageModel() { Sys_user = parameter as SXBModels.SYS_USER });
        }
    }
}
