using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01.Test
{
    /// <summary>字串的測試專案</summary>
    public class StringTest
    {
        /// <summary>
        /// 字串共用測試方法
        /// </summary>
        /// <param name="inputText">輸入的字串</param>
        /// <param name="index">開始位置</param>
        /// <param name="length">長度</param>
        /// <param name="totalLength">總長度</param>
        /// <param name="outputText">預期的結果字串</param>
        /// <param name="outputIndex">預期的結果位置</param>
        private void CheckGetPartString(string inputText, int index, int length, int totalLength, string outputText, int outputIndex)
        {
            //建立物件
            StringProcess process = new StringProcess();
            //顯示結果
            var result = process.GetPartString(inputText, index, length, totalLength);
            //驗證結果是否正確
            Assert.AreEqual(outputText, result.Item1);
            Assert.AreEqual(outputIndex, result.Item2);
        }

        /// <summary>
        /// 字串的測試
        /// </summary>
        /// <param name="inputText">輸入的字串</param>
        /// <param name="index">開始位置</param>
        /// <param name="length">長度</param>
        /// <param name="totalLength">總長度</param>
        /// <param name="outputText">預期的結果字串</param>
        /// <param name="outputIndex">預期的結果位置</param>
        [TestCase("Hello", 0, 11, 11, "HelloHelloH", 1)]
        [TestCase("Hello", 1, 10, 11, " elloHelloH", 1)]
        [TestCase("Hello", 1, 9, 11, "  elloHello", 0)]
        [TestCase("Hello", 0, 8, 11, "   HelloHel", 3)]
        [TestCase("Hello", 3, 7, 11, "    loHello", 0)]
        [Test]
        public void GetPartString_InputStringInt_ReturnStringInt(string inputText, int index, int length, int totalLength, string outputText, int outputIndex)
        {
            CheckGetPartString(inputText, index, length, totalLength, outputText, outputIndex);
        }

        /// <summary>
        /// 超出範圍的測試
        /// </summary>
        /// <param name="inputText">輸入的字串</param>
        /// <param name="index">開始位置</param>
        /// <param name="length">長度</param>
        /// <param name="totalLength">總長度</param>
        /// <param name="result">預期的結果字串</param>
        [TestCase("Hello" , -1, 11, 11, "輸入位置超出範圍")]
        [TestCase("Hello", 5, 11, 11, "輸入位置超出範圍")]
        [TestCase("Hello", 6, 11, 11, "輸入位置超出範圍")]
        [Test]
        public void GetPartString_InputStringInt_ReturnOutOfRange(string inputText, int index, int length, int totalLength, string result)
        {
            string m_result = "";
            try
            {
                CheckGetPartString(inputText, index, length, totalLength, string.Empty, 0);
            }
            catch (Exception ex)
            {
                m_result = ex.Message;
            }
            //驗證結果是否正確
            Assert.AreEqual(result, m_result);
        }

        /// <summary>
        /// 超出範圍的測試
        /// </summary>
        /// <param name="inputText">輸入的字串</param>
        /// <param name="index">開始位置</param>
        /// <param name="length">長度</param>
        /// <param name="totalLength">總長度</param>
        /// <param name="result">預期的結果字串</param>
        [TestCase("", 1, 11, 11, "輸入字串有誤")]
        [TestCase(null, 0, 11, 11, "輸入字串有誤")]
        [Test]
        public void GetPartString_InputStringInt_ReturnOutOfRange2(string inputText, int index, int length, int totalLength, string result)
        {
            string m_result = "";
            try
            {
                CheckGetPartString(inputText, index, length, totalLength, string.Empty, 0);
            }
            catch (Exception ex)
            {
                m_result = ex.Message;
            }
            //驗證結果是否正確
            Assert.AreEqual(result, m_result);
        }

        /// <summary>
        /// 超出範圍的測試
        /// </summary>
        /// <param name="inputText">輸入的字串</param>
        /// <param name="index">開始位置</param>
        /// <param name="length">長度</param>
        /// <param name="totalLength">總長度</param>
        /// <param name="result">預期的結果字串</param>
        [TestCase("Hello", 1, -1, 11, "輸入長度超出範圍")]
        [TestCase("Hello", 0, 11, -1, "輸入長度超出範圍")]
        [Test]
        public void GetPartString_InputStringInt_ReturnOutOfRange3(string inputText, int index, int length, int totalLength, string result)
        {
            string m_result = "";
            try
            {
                CheckGetPartString(inputText, index, length, totalLength, string.Empty, 0);
            }
            catch (Exception ex)
            {
                m_result = ex.Message;
            }
            //驗證結果是否正確
            Assert.AreEqual(result, m_result);
        }
    }
}
