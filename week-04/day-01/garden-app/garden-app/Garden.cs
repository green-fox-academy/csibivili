using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garden_app
{
    public class Garden
    {
        private List<Plant> plants = new List<Plant>();
        private string name;

        public Garden (string name)
        {
            this.name = name;
        }

        public void AddPlant (Plant plant)
        {
            plants.Add(new Plant());
        }
    }
}
