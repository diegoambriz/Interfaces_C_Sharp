using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourExample
{
    public class Car
    {
        public IDriver Driver { get; set; }

        public void Start()
        {
            this.Driver.Drive();
        }

    }
}
