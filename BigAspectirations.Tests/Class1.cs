﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BigAspectirations.Tests
{
    public class Class1
    {
        [Fact]
        public void Bind_test_class()
        {

            using (var kernel = new StandardKernel(new ServiceModule()))
            {
            }
        }
    }
}
