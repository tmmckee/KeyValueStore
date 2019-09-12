using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStore
{
    class MyDictionary
    {
        private int length
        {
            get { return this.keyValues.Length; }
        }

        KeyValue[] keyValues = new KeyValue[]
        {
            new KeyValue("Jubilee", 5),
            new KeyValue("Cyclops", "bzzz"),
            new KeyValue("Jean Gray", 3),
            new KeyValue("Commander X", 10),
            new KeyValue("Gambit", 4)
        };
        
        

        public object this[string index]
        {
            //search array for key and return associated value
            //throw KeyNotFoundException if key doesn't exist
            get
            {
                for (int i = 0; i < keyValues.Length; i++)
                {
                    if(index==keyValues[i].key)
                    {
                        return keyValues[i].value;
                    }
                }
                throw new KeyNotFoundException("Key not found.");
            }
            //search array for key and replace the KeyValue with new one
            //new KeyValue if doesn't exist
            //not found, make new array one above old array, copy to new array, add the new values, 
            //clear the old array, resize the old array and then copy the new array into the old array
            set
            {
                
                for (int i = 0; i < keyValues.Length; i++)
                {
                    if (index == keyValues[i].key)
                    {
                        keyValues[i] = new KeyValue(index, value);
                    }
                }
                KeyValue[] keyValuesCopy = new KeyValue[keyValues.Length + 1];
                for (int j = 0; j < keyValuesCopy.Length-1; j++)
                {
                    keyValuesCopy[j] = keyValues[j];
                }
                keyValuesCopy[keyValuesCopy.Length-1] = new KeyValue(index, value);
                keyValues = keyValuesCopy;
            }
        }
    }
}
