using System.Collections.Generic;

namespace KeyValueStore
{
    class MyDictionary
    {
        private int length
        {
            get { return this.keyValues.Length; }
        }

        KeyValue<int>[] keyValues = new KeyValue<int>[]
        {
            new KeyValue<int>("Jubilee", 5),
            new KeyValue<int>("Cyclops", 10),
            new KeyValue<int>("Jean Gray", 3),
            new KeyValue<int>("Commander X", 10),
            new KeyValue<int>("Gambit", 4)
        };

        public int this[string index]
        {
            //search array for key and return associated value
            //throw KeyNotFoundException if key doesn't exist
            get
            {
                for (int i = 0; i < keyValues.Length; i++)
                {
                    if (index == keyValues[i].key)
                    {
                        return keyValues[i].value;
                    }
                }
                throw new KeyNotFoundException("Key not found.");
            }
            //search array for key and replace the KeyValue with new one
            //new KeyValue if doesn't exist

            set
            {

                for (int i = 0; i < keyValues.Length; i++)
                {
                    if (index == keyValues[i].key)
                    {
                        keyValues[i] = new KeyValue<int>(index, value);
                    }
                }
                KeyValue<int>[] keyValuesCopy = new KeyValue<int>[keyValues.Length + 1];
                for (int j = 0; j < keyValuesCopy.Length - 1; j++)
                {
                    keyValuesCopy[j] = keyValues[j];
                }
                keyValuesCopy[keyValuesCopy.Length - 1] = new KeyValue<int>(index, value);
                keyValues = keyValuesCopy;
            }
        }
    }
}
