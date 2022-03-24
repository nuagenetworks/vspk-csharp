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

public class Scheduledtestsuiterun: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EOperationStatus {RUNNING,STARTED,UNKNOWN };

   
   [JsonProperty("NSGatewayName")]
   protected String _NSGatewayName;
   
   [JsonProperty("VPortName")]
   protected String _VPortName;
   
   [JsonProperty("associatedScheduledTestSuiteID")]
   protected String _associatedScheduledTestSuiteID;
   
   [JsonProperty("associatedScheduledTestSuiteName")]
   protected String _associatedScheduledTestSuiteName;
   
   [JsonProperty("datapathID")]
   protected String _datapathID;
   
   [JsonProperty("destination")]
   protected String _destination;
   
   [JsonProperty("domainName")]
   protected String _domainName;
   
   [JsonProperty("macAddress")]
   protected String _macAddress;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("operationStatus")]
   protected EOperationStatus? _operationStatus;
   
   [JsonProperty("secondaryDatapathID")]
   protected String _secondaryDatapathID;
   
   [JsonProperty("secondaryNSGatewayName")]
   protected String _secondaryNSGatewayName;
   
   [JsonProperty("secondarySystemID")]
   protected String _secondarySystemID;
   
   [JsonProperty("sourceIP")]
   protected String _sourceIP;
   
   [JsonProperty("subnetName")]
   protected String _subnetName;
   
   [JsonProperty("systemID")]
   protected String _systemID;
   
   [JsonProperty("vlanID")]
   protected long? _vlanID;
   
   [JsonProperty("vportPortName")]
   protected String _vportPortName;
   
   [JsonProperty("vportVlanID")]
   protected long? _vportVlanID;
   
   [JsonProperty("zoneName")]
   protected String _zoneName;
   

   
   [JsonIgnore]
   private TestRunsFetcher _testRuns;
   
   public Scheduledtestsuiterun() {
      
      _testRuns = new TestRunsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUNSGatewayName {
      get {
         return _NSGatewayName;
      }
      set {
         this._NSGatewayName = value;
      }
   }

   
   [JsonIgnore]
   public String NUVPortName {
      get {
         return _VPortName;
      }
      set {
         this._VPortName = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedScheduledTestSuiteID {
      get {
         return _associatedScheduledTestSuiteID;
      }
      set {
         this._associatedScheduledTestSuiteID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedScheduledTestSuiteName {
      get {
         return _associatedScheduledTestSuiteName;
      }
      set {
         this._associatedScheduledTestSuiteName = value;
      }
   }

   
   [JsonIgnore]
   public String NUDatapathID {
      get {
         return _datapathID;
      }
      set {
         this._datapathID = value;
      }
   }

   
   [JsonIgnore]
   public String NUDestination {
      get {
         return _destination;
      }
      set {
         this._destination = value;
      }
   }

   
   [JsonIgnore]
   public String NUDomainName {
      get {
         return _domainName;
      }
      set {
         this._domainName = value;
      }
   }

   
   [JsonIgnore]
   public String NUMacAddress {
      get {
         return _macAddress;
      }
      set {
         this._macAddress = value;
      }
   }

   
   [JsonIgnore]
   public EOperationStatus? NUOperationStatus {
      get {
         return _operationStatus;
      }
      set {
         this._operationStatus = value;
      }
   }

   
   [JsonIgnore]
   public String NUSecondaryDatapathID {
      get {
         return _secondaryDatapathID;
      }
      set {
         this._secondaryDatapathID = value;
      }
   }

   
   [JsonIgnore]
   public String NUSecondaryNSGatewayName {
      get {
         return _secondaryNSGatewayName;
      }
      set {
         this._secondaryNSGatewayName = value;
      }
   }

   
   [JsonIgnore]
   public String NUSecondarySystemID {
      get {
         return _secondarySystemID;
      }
      set {
         this._secondarySystemID = value;
      }
   }

   
   [JsonIgnore]
   public String NUSourceIP {
      get {
         return _sourceIP;
      }
      set {
         this._sourceIP = value;
      }
   }

   
   [JsonIgnore]
   public String NUSubnetName {
      get {
         return _subnetName;
      }
      set {
         this._subnetName = value;
      }
   }

   
   [JsonIgnore]
   public String NUSystemID {
      get {
         return _systemID;
      }
      set {
         this._systemID = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVlanID {
      get {
         return _vlanID;
      }
      set {
         this._vlanID = value;
      }
   }

   
   [JsonIgnore]
   public String NUVportPortName {
      get {
         return _vportPortName;
      }
      set {
         this._vportPortName = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVportVlanID {
      get {
         return _vportVlanID;
      }
      set {
         this._vportVlanID = value;
      }
   }

   
   [JsonIgnore]
   public String NUZoneName {
      get {
         return _zoneName;
      }
      set {
         this._zoneName = value;
      }
   }

   

   
   public TestRunsFetcher getTestRuns() {
      return _testRuns;
   }
   

   public String toString() {
      return "Scheduledtestsuiterun [" + "NSGatewayName=" + _NSGatewayName + ", VPortName=" + _VPortName + ", associatedScheduledTestSuiteID=" + _associatedScheduledTestSuiteID + ", associatedScheduledTestSuiteName=" + _associatedScheduledTestSuiteName + ", datapathID=" + _datapathID + ", destination=" + _destination + ", domainName=" + _domainName + ", macAddress=" + _macAddress + ", operationStatus=" + _operationStatus + ", secondaryDatapathID=" + _secondaryDatapathID + ", secondaryNSGatewayName=" + _secondaryNSGatewayName + ", secondarySystemID=" + _secondarySystemID + ", sourceIP=" + _sourceIP + ", subnetName=" + _subnetName + ", systemID=" + _systemID + ", vlanID=" + _vlanID + ", vportPortName=" + _vportPortName + ", vportVlanID=" + _vportVlanID + ", zoneName=" + _zoneName + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "scheduledtestsuiteruns";
   }

   public static String getRestName()
   {
	return "scheduledtestsuiterun";
   }
}
}