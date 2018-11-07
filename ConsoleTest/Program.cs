using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public IEnumerable<int> YieldDemo()
        {
            int counter = 0;
            int result = 1;
            while (counter++ < 10)
            {
                result = result * 2;
                yield return result;
            }
        }
    }


    // 用户自定义的带有可选命名参数的 MyStringLenthAttribute 特性类。
    // 该特性通过AttributeUsage限制它只能用在属性和字段上。
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class MyStringLenthAttribute : Attribute
    {
        public MyStringLenthAttribute(string displayName, int maxLength)
        {
            this.MaxLength = maxLength;
            this.DisplayName = displayName;
        }
        //显示的名称，对外是只读的，所以不能通过可选参数来赋值，必须在构造函数中对其初始化。
        public string DisplayName { get; private set; }

        //长度最大值，对外是只读的，所以不能通过可选参数来赋值，必须在构造函数中对其初始化。
        public int MaxLength { get; private set; }

        //错误信息，标注时可作为可选命名参数来使用。
        public string ErrorMessage { get; set; }

        //长度最小值，标注时可作为可选命名参数来使用。
        public int MinLength { get; set; }

    }

    public class Order
    {
        [MyStringLenth("订单号", 6, MinLength = 3, ErrorMessage = "{0}的长度必须在{1}和{2}之间，请重新输入！")]
        public string OrderID { get; set; }
    }



}
