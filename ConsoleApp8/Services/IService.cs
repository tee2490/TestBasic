using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Services
{
    public interface IService
    {
        void MockData(int n);
        void Display();

        void Summary();
    }
}
