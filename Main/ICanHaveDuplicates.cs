using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace com.Curseling.ExtraSerializeables
{
    public interface ICanHaveDuplicates
    {
        bool HasDuplicates { get; }

        void RemoveDuplicates();
    }
}