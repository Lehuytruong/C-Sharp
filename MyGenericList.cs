using System;
using System.Collections.Generic;
using T1807M1.Properties.Session6;

namespace T1807M1.Properties.Assignment6
{
    public class MyGenericList<K,V>
    {
       private K key;

       private V value;

        
        public MyGenericList(K key, V value)
        {
            this.key = key;
            this.value = value;
        }
 
        public K GetKey()
        {
            return key;
        }
 
        public void SetKey(K key)
        {
            this.key = key;
        }
 
        public V GetValue()
        {
            return value;
        }
 
        public void SetValue(V value)
        {
            this.value = value;
        }
        
       
        

    }
}