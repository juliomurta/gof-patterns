﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Behavioural.Observer.Interface
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
