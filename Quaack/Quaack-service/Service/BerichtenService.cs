using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quaack_domein.model;

namespace Quaack_service.Service
{
    public interface BerichtenService
    {
        List<Bericht> find(string userId);
        Bericht find(int bericht_id);
        void save(Bericht bericht);
 
    }
}
