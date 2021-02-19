using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ScrapeFinal.Utility
{

    public static class HTMLLoader
    {
        public static string LoadUrl(string url)
        {

            string HTMLString = "";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = client.GetAsync(url)?.Result)
                    {
                        using (HttpContent content = response?.Content)
                        {
                            HTMLString = content?.ReadAsStringAsync()?.Result;
                        }
                    }
                }
            }
            catch (Exception ex) {
                return null;
            }
            return HTMLString;
        }
    }

}
