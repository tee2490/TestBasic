using ConsoleApp5.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.Interfaces
{
    public interface IServices //What
    {
        void Mock(int n);
        void Create(Product product);
        void Read();
        void Update(int id);
        void Delete(int id);
        Product Search(int id);
    }
}
