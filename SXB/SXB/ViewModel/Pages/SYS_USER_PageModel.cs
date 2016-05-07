using SXBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXB.ViewModel.Pages
{
    /// <summary>
    /// 实体对象sysuser
    /// </summary>
    public class SYS_USER_PageModel:PageViewModel
    {
        private SXBModels.SYS_USER sys_user;

        public SYS_USER Sys_user
        {
            get
            {
                return sys_user;
            }

            set
            {
                if (!value.Equals(sys_user))
                {
                    sys_user = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
