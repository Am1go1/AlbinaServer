using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.DataAccess.Core.Interfaces
{
    public interface IContext : IDisposable, IAsyncDisposable
    {
    }
}
