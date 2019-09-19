namespace KeyValueStore
{
    struct KeyValue<T>
    {
        public readonly string key;
        public readonly T value;

        public KeyValue(string k, T v)
        {
            this.key = k;
            this.value = v;
        }
    }
}
