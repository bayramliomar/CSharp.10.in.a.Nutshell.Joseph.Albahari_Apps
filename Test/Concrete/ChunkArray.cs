using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.Abstract;

namespace Test.Concrete
{
    public class ChunkArray<T> : IChunkArray<T>
    {
        private List<T[]> list = new List<T[]>();
        public T this[int index] { get => GetValue(index); set { GetValue(index) = value; } }
        public int Length => list.Sum(x => x.Length);

        public void Add(T[] a)
        {
            list.Add(a);
        }

        //public T GetValue(int index,T newValue)
        //{
        //    foreach (var item in list)
        //    {
        //        if (item.Length - 1 >= index)
        //        {
        //            var result=object.Equals(newValue, default(T)) ? item[index] :item[index]=newValue;
        //            return result;
        //        }
        //        else
        //        {
        //            index -= item.Length;
        //        }
        //    }
        //    return default(T);
        //} 

        public ref T GetValue(int index)
        {
            foreach (var item in list)
            {
                if (item.Length - 1 >= index)
                {
                    return ref item[index];
                }
                else
                {
                    index -= item.Length;
                }
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}
