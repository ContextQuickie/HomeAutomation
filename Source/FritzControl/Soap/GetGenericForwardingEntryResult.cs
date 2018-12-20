// <copyright file="GetGenericForwardingEntryResult.cs" company="ContextQuickie">
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
namespace FritzControl.Soap
{
  /// <summary>
  /// Result type for GetGenericForwardingEntry.
  /// </summary>
  public class GetGenericForwardingEntryResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewEnable
    /// </summary>
    public bool NewEnable { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewStatus
    /// </summary>
    public string NewStatus { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewType
    /// </summary>
    public string NewType { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDestIPAddress
    /// </summary>
    public string NewDestIPAddress { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDestSubnetMask
    /// </summary>
    public string NewDestSubnetMask { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSourceIPAddress
    /// </summary>
    public string NewSourceIPAddress { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSourceSubnetMask
    /// </summary>
    public string NewSourceSubnetMask { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewGatewayIPAddress
    /// </summary>
    public string NewGatewayIPAddress { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewInterface
    /// </summary>
    public string NewInterface { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewForwardingMetric
    /// </summary>
    public int NewForwardingMetric { get; set; }
  }
}