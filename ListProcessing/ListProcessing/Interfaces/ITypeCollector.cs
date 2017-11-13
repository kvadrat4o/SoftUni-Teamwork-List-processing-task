﻿namespace ListProcessing.Interfaces
{
    using System;

    public interface ITypeCollector
    {
        Type[] GetAllInheritingTypes<T>()
            where T : class;
    }
}
