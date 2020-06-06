using System;
using System.Collections.Generic;

namespace LAB_6_2_
{
    class TemplateCollection<T>
    {
        private List<T> objects;
        public int Count => objects.Count;

        public TemplateCollection()
        {
            objects = new List<T>();
        }

        public void Add(T newObject)
        {
            objects.Add(newObject);
        }

        public T this[int index]
        {
            set
            {
                if (value is T)
                {
                    objects[index] = value;
                }
                else
                {
                    throw (new Exception("Incorrect type!"));
                }
            }
            get
            {
                return objects[index];
            }
        }
    }
}
