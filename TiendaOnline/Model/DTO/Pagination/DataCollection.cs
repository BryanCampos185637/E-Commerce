using System.Collections.Generic;

namespace Model.DTO.Pagination
{
    public class DataCollection<T> where T : class
    {
        public int Take { get; set; } = 8;
        public int Page { get; set; } = 1;
        public int Pages { get; set; }
        public int Total { get; set; }
        public List<T>Items { get; set; }
        public DataCollection()
        {

        }
        public DataCollection(int page, int pages, int take)
        {
            Take = take;
            Page = page;
            Pages = pages;
        }
    }
}
