// <copyright file="X_AVM_DE_OnTelGetPhonebookResult.cs" company="ContextQuickie">
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
  /// Result type for GetPhonebook in service X_AVM_DE_OnTel.
  /// </summary>
  public class X_AVM_DE_OnTelGetPhonebookResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewPhonebookName.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPhonebookName")]
    public string NewPhonebookName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPhonebookExtraID.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPhonebookExtraID")]
    public string NewPhonebookExtraID { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPhonebookURL.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPhonebookURL")]
    public string NewPhonebookURL { get; set; }
  }
}
