using System.Collections.Generic;

namespace jPoor.Common
{
    public enum SortTypes
    {
        Ascending = 0,
        Descending = 1
    }

    public class searchParam
    {
        public searchParam() { Name = null; Value = null; }
        public searchParam(string name, string value) { Name = name; Value = value; }

        public string Name { get; set; }
        public object Value { get; set; }
    }

    public class PagingInfo
    {
        public PagingInfo()
        {
            sortType = SortTypes.Ascending;
        }
        public PagingInfo(int PageSize, int PageNo)
        {
            pageNo = PageNo;
            pageSize = PageSize;
            sortType = SortTypes.Ascending;
        }
        public PagingInfo(SortTypes SortType, string SortColumn)
        {
            sortType = SortTypes.Ascending;
            sortColumn = SortColumn;
        }

        public int pageSize { get; set; }

        public int pageNo { get; set; }

        public SortTypes sortType { get; set; }

        public string sortColumn { get; set; }

        public List<searchParam> searchParams { get; set; }
    }
}
