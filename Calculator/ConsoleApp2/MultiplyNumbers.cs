﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MultiplyNumbers : Chain
    {

        private Chain nextInChain;

        public void setNextChain(Chain nextChain)
        {
            this.nextInChain = nextChain;
        }

        public void calculate(Numbers request)
        {
            if (request.getOperation() == "mult")
            {
                Console.WriteLine(request.getNum1() * request.getNum2());
            }
            else
            {
                nextInChain.calculate(request);
            }
        }
    }
}

