using System;
using System.Collections.Generic;
using System.Text;

namespace Leisn.VisualGraph;
/// <summary>
/// 连接端口
/// </summary>
public interface IPort
{
    PortType Type { get; }
}

public enum PortType
{
    Input, Output
}
