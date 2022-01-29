using Microsoft.AspNetCore.Http;
using Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Response
{
    public class Response<T>
    {
        public Response()
        {
            Code = StatusCodes.Status200OK;
        }
        public int Code { get; set; }
        public string Message { get; set; }
        //public string DataError { get; set; }
        public T Data { get; set; }
        public List<T> DataList { get; set; }
    }
    public class TableResponse<T>
    {
        public TableResponse()
        {
            Code = StatusCodes.Status200OK;
            RecordsTotal = RecordsFiltered = 0;
            Data = new List<T>();
        }
        public int Code { get; set; }
        public Boolean Success { get; set; }
        public string Message { get; set; }
        public string DataError { get; set; }
        public int Draw { get; set; }
        public int RecordsTotal { get; set; }
        public int RecordsFiltered { get; set; }
        public List<T> Data { get; set; }
        public void setDraw(TableSearchModel search)
        {
            Draw = search.Draw;
        }
    }
}
