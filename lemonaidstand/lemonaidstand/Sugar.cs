﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace lemonaidstand
{
    public class Sugar
    {
        private double price;

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;

            }
        }

        public Sugar()
        {
            price = 2;
        }

    }
}