using System;
using System.Collections.Generic;
using UnityEngine;

namespace com.Curseling.ExtraSerializeables
{
    [Serializable]
    public class SerializableHashset<T> : HashSet<T>, ISerializationCallbackReceiver, ICanHaveDuplicates
    {
        [SerializeField]
        private T[] entries;

        public bool HasDuplicates => Count < entries.Length;

        public void OnAfterDeserialize()
        {
            Clear();

            foreach (var entry in entries)
                Add(entry);
        }

        public void OnBeforeSerialize()
        {

        }

        public void RemoveDuplicates()
        {
            entries = new T[Count];

            int i = 0;
            foreach (var entry in this)
                entries[i++] = entry;
        }
    }
}