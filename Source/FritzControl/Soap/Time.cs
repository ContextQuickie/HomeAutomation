// <copyright file="Time.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:Time:1.
  /// </summary>
  public class Time : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:Time:1";

    /// <summary>
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (TimeGetInfoResult) of the action.</returns>
    public TimeGetInfoResult GetInfo()
    {
      return this.SendRequest<TimeGetInfoResult>("GetInfo");
    }

    /// <summary>
    /// Wrapper for the action SetNTPServers.
    /// </summary>
    /// <param name="newNTPServer1">The SOAP parameter NewNTPServer1.</param>
    /// <param name="newNTPServer2">The SOAP parameter NewNTPServer2.</param>
    public void SetNTPServers(string newNTPServer1, string newNTPServer2)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewNTPServer1", newNTPServer1);
      arguments.Add("NewNTPServer2", newNTPServer2);
      this.SendRequest("SetNTPServers", arguments);
    }
  }
}
