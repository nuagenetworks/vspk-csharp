/*
  Copyright (c) 2017, Nokia
  All rights reserved.

  Redistribution and use in source and binary forms, with or without
  modification, are permitted provided that the following conditions are met:
      * Redistributions of source code must retain the above copyright
        notice, this list of conditions and the following disclaimer.
      * Redistributions in binary form must reproduce the above copyright
        notice, this list of conditions and the following disclaimer in the
        documentation and/or other materials provided with the distribution.
      * Neither the name of the copyright holder nor the names of its contributors
        may be used to endorse or promote products derived from this software without
        specific prior written permission.

  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
  DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY
  DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
  (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
  LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
  ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
  (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
  SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/


using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using net.nuagenetworks.bambou;

using net.nuagenetworks.vspk.v6.fetchers;

namespace net.nuagenetworks.vspk.v6
{

public class UnderlayTest: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum ETestResult {DEGRADED,FAIL,NOT_APPLICABLE,PASS };
   public enum EUnderlayTestType {BIRTH_CERTIFICATE,ON_DEMAND,PRE_BOOTSTRAP };

   
   [JsonProperty("associatedDataPathID")]
   protected String _associatedDataPathID;
   
   [JsonProperty("associatedNSGatewayID")]
   protected String _associatedNSGatewayID;
   
   [JsonProperty("associatedNSGatewayName")]
   protected String _associatedNSGatewayName;
   
   [JsonProperty("associatedSystemID")]
   protected String _associatedSystemID;
   
   [JsonProperty("associatedTestSuiteRunID")]
   protected String _associatedTestSuiteRunID;
   
   [JsonProperty("associatedUplinkConnectionID")]
   protected String _associatedUplinkConnectionID;
   
   [JsonProperty("associatedUplinkInterface")]
   protected String _associatedUplinkInterface;
   
   [JsonProperty("createOnly")]
   protected bool _createOnly;
   
   [JsonProperty("duration")]
   protected long? _duration;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("runBandwidthTest")]
   protected bool _runBandwidthTest;
   
   [JsonProperty("runConnectivityTest")]
   protected bool _runConnectivityTest;
   
   [JsonProperty("runMTUDiscoveryTest")]
   protected bool _runMTUDiscoveryTest;
   
   [JsonProperty("startDateTime")]
   protected long? _startDateTime;
   
   [JsonProperty("stopDateTime")]
   protected long? _stopDateTime;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("testResult")]
   protected ETestResult? _testResult;
   
   [JsonProperty("underlayTestServer")]
   protected String _underlayTestServer;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("underlayTestType")]
   protected EUnderlayTestType? _underlayTestType;
   

   
   public UnderlayTest() {
      
   }

   
   [JsonIgnore]
   public String NUAssociatedDataPathID {
      get {
         return _associatedDataPathID;
      }
      set {
         this._associatedDataPathID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedNSGatewayID {
      get {
         return _associatedNSGatewayID;
      }
      set {
         this._associatedNSGatewayID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedNSGatewayName {
      get {
         return _associatedNSGatewayName;
      }
      set {
         this._associatedNSGatewayName = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedSystemID {
      get {
         return _associatedSystemID;
      }
      set {
         this._associatedSystemID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedTestSuiteRunID {
      get {
         return _associatedTestSuiteRunID;
      }
      set {
         this._associatedTestSuiteRunID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedUplinkConnectionID {
      get {
         return _associatedUplinkConnectionID;
      }
      set {
         this._associatedUplinkConnectionID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedUplinkInterface {
      get {
         return _associatedUplinkInterface;
      }
      set {
         this._associatedUplinkInterface = value;
      }
   }

   
   [JsonIgnore]
   public bool NUCreateOnly {
      get {
         return _createOnly;
      }
      set {
         this._createOnly = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDuration {
      get {
         return _duration;
      }
      set {
         this._duration = value;
      }
   }

   
   [JsonIgnore]
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
      }
   }

   
   [JsonIgnore]
   public bool NURunBandwidthTest {
      get {
         return _runBandwidthTest;
      }
      set {
         this._runBandwidthTest = value;
      }
   }

   
   [JsonIgnore]
   public bool NURunConnectivityTest {
      get {
         return _runConnectivityTest;
      }
      set {
         this._runConnectivityTest = value;
      }
   }

   
   [JsonIgnore]
   public bool NURunMTUDiscoveryTest {
      get {
         return _runMTUDiscoveryTest;
      }
      set {
         this._runMTUDiscoveryTest = value;
      }
   }

   
   [JsonIgnore]
   public long? NUStartDateTime {
      get {
         return _startDateTime;
      }
      set {
         this._startDateTime = value;
      }
   }

   
   [JsonIgnore]
   public long? NUStopDateTime {
      get {
         return _stopDateTime;
      }
      set {
         this._stopDateTime = value;
      }
   }

   
   [JsonIgnore]
   public ETestResult? NUTestResult {
      get {
         return _testResult;
      }
      set {
         this._testResult = value;
      }
   }

   
   [JsonIgnore]
   public String NUUnderlayTestServer {
      get {
         return _underlayTestServer;
      }
      set {
         this._underlayTestServer = value;
      }
   }

   
   [JsonIgnore]
   public EUnderlayTestType? NUUnderlayTestType {
      get {
         return _underlayTestType;
      }
      set {
         this._underlayTestType = value;
      }
   }

   

   

   public String toString() {
      return "UnderlayTest [" + "associatedDataPathID=" + _associatedDataPathID + ", associatedNSGatewayID=" + _associatedNSGatewayID + ", associatedNSGatewayName=" + _associatedNSGatewayName + ", associatedSystemID=" + _associatedSystemID + ", associatedTestSuiteRunID=" + _associatedTestSuiteRunID + ", associatedUplinkConnectionID=" + _associatedUplinkConnectionID + ", associatedUplinkInterface=" + _associatedUplinkInterface + ", createOnly=" + _createOnly + ", duration=" + _duration + ", name=" + _name + ", runBandwidthTest=" + _runBandwidthTest + ", runConnectivityTest=" + _runConnectivityTest + ", runMTUDiscoveryTest=" + _runMTUDiscoveryTest + ", startDateTime=" + _startDateTime + ", stopDateTime=" + _stopDateTime + ", testResult=" + _testResult + ", underlayTestServer=" + _underlayTestServer + ", underlayTestType=" + _underlayTestType + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "underlaytests";
   }

   public static String getRestName()
   {
	return "underlaytest";
   }
}
}