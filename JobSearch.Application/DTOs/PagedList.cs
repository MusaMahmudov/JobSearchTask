using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Application.DTOs;

public class PagedList<T>
{ 
    public List<T> Items { get; set; }
    public int Page {  get; set; }
    public int Take { get; set; }
    public int TotalCount { get; set; }
    public int TotalPages { get; set; }
    public bool HasNext { get; set; }
    public bool HasPrevious { get; set; } 
    public PagedList(List<T> items, int page, int take, int totalCount)
    {
        Items = items;
        Page = page;
        Take = take;
        TotalCount = totalCount;
        TotalPages = (int)Math.Ceiling(totalCount / (double)take); 
        HasNext = Page < TotalPages;
        HasPrevious = Page > 1;
    }
}
