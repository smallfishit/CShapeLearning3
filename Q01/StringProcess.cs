using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01
{
    /// <summary>字串處理類別</summary>
    public class StringProcess
    {
        /// <summary>
        /// 取得部分字串
        /// </summary>
        /// <param name="origin">輸入字串</param>
        /// <param name="index">開始位置</param>
        /// <param name="length">長度</param>
        /// <param name="totalLength">總長度</param>
        /// <returns></returns>
        public (string, int) GetPartString(string origin, int index, int length, int totalLength)
        {
            if (string.IsNullOrWhiteSpace(origin))
            {
                throw new Exception("輸入字串有誤");
            }

            if (index >= origin.Length || index < 0)
            {
                throw new Exception("輸入位置超出範圍");
            }

            if (length < 0 || totalLength < 0)
            {
                throw new Exception("輸入長度超出範圍");
            }

            int pos = index;
            string result = string.Empty;
            for(int i=0;i<totalLength-length;i++)
            {
                result += " ";
            }
            for(int i=0;i<length;i++)
            {
                result += origin[pos];
                pos++;
                if (pos >= origin.Length) pos = 0;
            }

            return (result, pos);
        }
    }
}
