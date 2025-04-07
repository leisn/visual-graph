using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Leisn.VisualGraph;

[AttributeUsage(AttributeTargets.All, Inherited = true)]
public class IgnoreAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Property, Inherited = true)]
public class InAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Property, Inherited = true)]
public class OutAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Method, Inherited = true)]
public class InvokeAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Method, Inherited = true)]
public class InitAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Method, Inherited = true)]
public class FinalAttribute : Attribute { }
