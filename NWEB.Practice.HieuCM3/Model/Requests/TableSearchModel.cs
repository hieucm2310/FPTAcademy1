using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Requests
{
    public class TableSearchModel
    {
        public int Draw { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }
        public int OrderColumn { get; set; }
        public string OrderDir { get; set; }
        public string SearchValue { get; set; }

        public T Get<T>()
        {
            T obj = default(T);
            try
            {
                string rs = JsonConvert.SerializeObject(this);
                obj = JsonConvert.DeserializeObject<T>(rs);
            }
            catch (Exception ex)
            {
                return obj;
            }
            return obj;
        }

    }

    public class SearchCategoryModel : TableSearchModel
    {
        public string CategoryName { get; set; }
    }
    public class SearchFlowerModel : TableSearchModel
    {
        public string FlowerName { get; set; }
    }
}
