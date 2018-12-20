// <copyright file="X_AVM_DE_GetClientByClientIdResult.cs" company="ContextQuickie">
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
  /// Result type for X_AVM_DE_GetClientByClientId.
  /// </summary>
  public class X_AVM_DE_GetClientByClientIdResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientId.
    /// </summary>
    public string NewX_AVM_DE_ClientId { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientIndex.
    /// </summary>
    public ushort NewX_AVM_DE_ClientIndex { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientUsername.
    /// </summary>
    public string NewX_AVM_DE_ClientUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientRegistrar.
    /// </summary>
    public string NewX_AVM_DE_ClientRegistrar { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientRegistrarPort.
    /// </summary>
    public ushort NewX_AVM_DE_ClientRegistrarPort { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_PhoneName.
    /// </summary>
    public string NewX_AVM_DE_PhoneName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_OutGoingNumber.
    /// </summary>
    public string NewX_AVM_DE_OutGoingNumber { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_InComingNumbers.
    /// </summary>
    public string NewX_AVM_DE_InComingNumbers { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewX_AVM-DE_ExternalRegistration is set or not.
    /// </summary>
    public bool NewX_AVM_DE_ExternalRegistration { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_InternalNumber.
    /// </summary>
    public string NewX_AVM_DE_InternalNumber { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewX_AVM-DE_DelayedCallNotification is set or not.
    /// </summary>
    public bool NewX_AVM_DE_DelayedCallNotification { get; set; }
  }
}
