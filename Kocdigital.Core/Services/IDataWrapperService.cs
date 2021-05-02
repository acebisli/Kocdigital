using Kocdigital.Core.Model;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kocdigital.Core.Services
{
    public interface IDataWrapperService
    {
        Task<IEnumerable<DataWrapperModel>> Search(SearchModel searchModel);
        Task<IndexResponse> SaveAsync(DataWrapperModel model);
    }
}
