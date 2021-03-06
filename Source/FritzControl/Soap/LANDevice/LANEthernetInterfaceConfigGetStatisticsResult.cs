// <copyright file="LANEthernetInterfaceConfigGetStatisticsResult.cs" company="ContextQuickie">
// MIT License
//
// Copyright (c) 2018
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// </copyright>
namespace FritzControl.Soap.LANDevice
{
  /// <summary>
  /// Result type for GetStatistics in service LANEthernetInterfaceConfig.
  /// </summary>
  public class LANEthernetInterfaceConfigGetStatisticsResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewBytesSent.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewBytesSent")]
    public uint NewBytesSent { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewBytesReceived.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewBytesReceived")]
    public uint NewBytesReceived { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPacketsSent.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPacketsSent")]
    public uint NewPacketsSent { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPacketsReceived.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPacketsReceived")]
    public uint NewPacketsReceived { get; set; }
  }
}
