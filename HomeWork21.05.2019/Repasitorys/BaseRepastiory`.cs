using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork21._05._2019
{
    public class BaseRepastiory<T>
    {
        public BaseRepastiory(string fileName, IFormatProvider<T> provider)
        {
            this.fileName = fileName;
            this.provider = provider;
            _cache = new List<T>();
        }
        public readonly string fileName;
        public readonly IFormatProvider<T> provider;
        private List<T> _cache;

        public int SaveChanges()
        {
            int count = 0;
            using (var sw = new StreamWriter(fileName))
            {
                foreach (T item in _cache)
                {
                    string value = provider.Serialize(item);
                    sw.WriteLine(value);
                    count++;
                }
                _cache.Clear();
            }
            return count;
        }
        public void Add(IEnumerable<T> source)
        {
            _cache.AddRange(source);
        }

        public void Add(T model)
        {
            _cache.Add(model);
        }

        public IEnumerable<T> Read()
        {
            using (var sr = new StreamReader(fileName))
            {
                var value = "";
                while ((value = sr.ReadLine()) != null)
                {
                    T model = provider.Deserialize(value);
                    yield return model;
                }
            }
        }


        public List<T> ReadAllToList()
        {
            var srlist = new List<T>();
            using (var sr = new StreamReader(fileName))
            {
                var value = "";
                while ((value = sr.ReadLine()) != null)
                {
                    T model = provider.Deserialize(value);
                    srlist.Add(model);
                }
            }
            return srlist;
        }
    }
}
