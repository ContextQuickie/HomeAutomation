﻿// <copyright file="ISoapXmlElement.cs" company="ContextQuickie">
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

namespace FritzControl.Tr064.ServiceHandling
{
  using System.Xml;
  using System.Xml.Linq;

  /// <summary>
  /// Interface for reading/writing SOAP XML.
  /// </summary>
  public interface ISoapXmlElement
  {
    /// <summary>
    /// Generates an object from its SOAP XML representation.
    /// </summary>
    /// <param name="element">The <see cref="XElement"/> element from which the object is deserialized.</param>
    void ReadXml(XElement element);

    /// <summary>
    /// Converts an object into its SOAP XML representation.
    /// </summary>
    /// <param name="writer">The <see cref="XmlReader"/> stream to which the object is serialized.</param>
    void WriteXml(XmlWriter writer);
  }
}