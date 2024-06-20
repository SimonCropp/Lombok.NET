﻿//HintName: Test_Person.g.cs
// <auto-generated/>
using Lombok.NET;

namespace Test;
#nullable enable
internal partial class Person
{
    public Person WithId(int id)
    {
        this._id = id;
        return this;
    }

    public Person WithName(string name)
    {
        this._name = name;
        return this;
    }

    public Person WithAge(int age)
    {
        this._age = age;
        return this;
    }
}