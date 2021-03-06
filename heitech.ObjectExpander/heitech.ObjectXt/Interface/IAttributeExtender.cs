﻿using heitech.ObjectXt.Interface;
using System;
using System.Collections.Generic;

namespace heitech.ObjectXt.Interfaces
{
    public interface IAttributeExtender<T>: IEnumerable<IAttributeExtenderItem<T>>, IEquatable<IAttributeExtender<T>>
    {
        object this[T attribute_name] { get; set; }
        void Add(T attribute_name, object obj);
        void Remove(T key);

        bool TryGetAttribute<A>(T key, out A attribute);
        (bool hasValue, T key, A attribute) GetKeyAttributePair<A>(T key);

        bool HasAttribute(T key);
        bool HasAttributeOfType<A>(out T key);
    }
}
