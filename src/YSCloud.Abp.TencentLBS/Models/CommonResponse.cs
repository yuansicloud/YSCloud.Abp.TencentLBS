using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace YSCloud.Abp.TencentLBS.Models
{
    public class CommonResponse<T>
    {
        public string Message { get; set; }

        public int Status { get; set; }

        public T Result { get; set; }

        public void CheckStatus()
        {
            if (Status != 0)
            {
                throw new UserFriendlyException(Message, Status.ToString());
            }
        }
    }
}
