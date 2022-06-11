using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    public class Actions
    {
        public Result First()
        {
            Logger.Instance.Log(DateTime.Now, LogType.Info, $"{nameof(First)}");
            return new Result { Status = true };
        }

        public Result Second()
        {
            Logger.Instance.Log(DateTime.Now, LogType.Warning, $"{nameof(Second)}");
            return new Result { Status = true };
        }

        public Result Third()
        {
            Logger.Instance.Log(DateTime.Now, LogType.Error, $"{nameof(Third)}");
            return new Result { Status = false, Message = "I broke a logic" };
        }
    }
}