using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDataStockAccess.models
{
    public class CStock
    {
        private string _sAccount;

        // 流水號 (對應 sId)
        public int sId { get; set; }

        // 股票代號 (對應 sStockCode)
        public string sStockCode { get; set; }

        // 股票名稱 (對應 sName)
        public string sName { get; set; }

        // 市場別 (對應 sMarket)
        public string sMarket { get; set; }

        // 產業類別 (對應 sCategory)
        public string sCategory { get; set; }

        // 買進價格 (對應 sBuyPrice)
        public decimal sBuyPrice { get; set; }

        // 目前價格 (對應 sCurrentPrice)
        public decimal sCurrentPrice { get; set; }

        // 持股股數 (對應 sShare)
        public int sShare { get; set; }

        // 買進日期 (對應 sBuyDate)
        public DateTime sBuyDate { get; set; }

        // 券商帳號 (對應 sAccount，保留原本的遮罩處理邏輯)
        public string sAccount
        {
            get
            {
                if (string.IsNullOrEmpty(_sAccount))
                    return "";

                if (_sAccount.Length <= 6)
                    return new string('*', _sAccount.Length);

                return $"{_sAccount.Substring(0, 3)}" +
                       $"{new string('*', _sAccount.Length - 6)}" +
                       $"{_sAccount.Substring(_sAccount.Length - 3, 3)}";
            }
            set
            {
                _sAccount = value;
            }
        }
    }
}

