using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanterna.Model
{
    class ClassLanterna
    {
        public bool Status
        {
            get;
            set;
        }

        public ClassBateria Bateria
        {
            get;
            set;
        }

        public ClassLanterna()
        {
            Status = false;
            Bateria = new ClassBateria();
        }

        public void LigaDesliga()
        {

            if (Status == true)
            {
                Status = false;
            }
            else
            {
                Status = true;
            }

        }

        public void TrocarBateria()
        {
            Bateria = new ClassBateria();
        }
    }
}
