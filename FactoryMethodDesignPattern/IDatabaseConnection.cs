using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    // Veritabanı bağlantı arayüzü
    public interface IDatabaseConnection
    {
        void Connect();
    }
}
