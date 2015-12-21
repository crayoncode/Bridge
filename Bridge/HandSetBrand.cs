using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// 手机品牌类
    /// </summary>
    abstract class HandSetBrand
    {
        protected HandSetSoft soft;
        //设置手机软件
        public void SetHandsetSoft(HandSetSoft soft)
        {
            this.soft = soft;
        }

        public abstract void Run();
    }
}
