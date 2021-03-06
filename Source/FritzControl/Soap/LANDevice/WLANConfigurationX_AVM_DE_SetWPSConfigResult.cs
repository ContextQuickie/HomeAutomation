// <copyright file="WLANConfigurationX_AVM_DE_SetWPSConfigResult.cs" company="ContextQuickie">
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
  /// Result type for X_AVM_DE_SetWPSConfig in service WLANConfiguration.
  /// </summary>
  public class WLANConfigurationX_AVM_DE_SetWPSConfigResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_WPSAPPIN.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_WPSAPPIN")]
    public string NewX_AVM_DE_WPSAPPIN { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_WPSStatus.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_WPSStatus")]
    public string NewX_AVM_DE_WPSStatus { get; set; }
  }
}
