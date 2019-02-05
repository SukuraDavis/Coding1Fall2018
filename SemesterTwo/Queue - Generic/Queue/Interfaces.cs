using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    interface IEmptyable
    {
        void Empty();
    }

    interface IPrintable
    {
        void Print();
    }

    interface ICountable
    {
        int Count();
    }
}
