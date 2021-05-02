using Kocdigital.Core.Model;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kocdigital.Core
{
    public static class ElasticExtensions
    {
        public static SearchDescriptor<DataWrapperModel> SearchDataWrapperModel(this SearchDescriptor<DataWrapperModel> searchDescriptor, SearchModel model)
        {
            if (model.StartDate > DateTime.MinValue)
            {
                searchDescriptor.PostFilter(f => f.DateRange(r => r.Field(f2 => f2.CreatedTime).GreaterThanOrEquals(model.StartDate)));
            }
            if (model.EndDate > DateTime.MinValue)
            {
                searchDescriptor.PostFilter(f => f.DateRange(r => r.Field(f2 => f2.CreatedTime).LessThanOrEquals(model.EndDate)));
            }
            if (!string.IsNullOrEmpty(model.ClientName))
            {
                searchDescriptor.PostFilter(f => f.Match(m => m.Field(f2 => f2.ClienName).Query(model.ClientName)));
            }
            if (!string.IsNullOrEmpty(model.Status))
            {
                searchDescriptor.PostFilter(f => f.Match(m => m.Field(new Field("data.status")).Query(model.Status)));
            }
            return searchDescriptor;
        }
    }
}
