﻿namespace Shouldly.Tests.TestHelpers;

internal class UncomparableClass
{
    private readonly string _description;

    public UncomparableClass(string description)
    {
        _description = description;
    }

    public override string ToString()
    {
        return _description;
    }
}