using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Abstract
{
   public interface IChunkArray<T>
    {
        public int Length { get;}

        void Add(T[] a);

        T this[int index] { get;set; }
    }
}
