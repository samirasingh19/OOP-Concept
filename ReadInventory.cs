using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace OOP_concept
{
    public class ReadInventory
    {

        public InventoryDetails Read(string path)
        {
            try
            {
                using (StreamReader file = new StreamReader(path))
                {
                    string jason = file.ReadToEnd();

                    return JasonConvert.DeserializeObject<InventoryDetails>(json);
                }
            }
        Catch(Exception e)
        {
                return null;
            }

        }

    }
}
