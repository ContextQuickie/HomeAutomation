// <copyright file="UserInterfaceX_AVM_DE_GetInfoResult.cs" company="ContextQuickie">
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
  /// Result type for X_AVM_DE_GetInfo in service UserInterface.
  /// </summary>
  public class UserInterfaceX_AVM_DE_GetInfoResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_AutoUpdateMode.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_AutoUpdateMode")]
    public string NewX_AVM_DE_AutoUpdateMode { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_UpdateTime.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_UpdateTime")]
    public System.DateTime NewX_AVM_DE_UpdateTime { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_LastFwVersion.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_LastFwVersion")]
    public string NewX_AVM_DE_LastFwVersion { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_LastInfoUrl.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_LastInfoUrl")]
    public string NewX_AVM_DE_LastInfoUrl { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_CurrentFwVersion.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_CurrentFwVersion")]
    public string NewX_AVM_DE_CurrentFwVersion { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_UpdateSuccessful.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_UpdateSuccessful")]
    public string NewX_AVM_DE_UpdateSuccessful { get; set; }
  }
}
