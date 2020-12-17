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

public class TestSuiteRun: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EOperationStatus {COMPLETED,CONTAINER_IP_FAILURE,STARTED,UNKNOWN };

   
   [JsonProperty("NSGatewayName")]
   protected String _NSGatewayName;
   
   [JsonProperty("VPortName")]
   protected String _VPortName;
   
   [JsonProperty("associatedEntityType")]
   protected String _associatedEntityType;
   
   [JsonProperty("associatedTestSuiteID")]
   protected String _associatedTestSuiteID;
   
   [JsonProperty("associatedTestSuiteName")]
   protected String _associatedTestSuiteName;
   
   [JsonProperty("associatedUnderlayTestID")]
   protected String _associatedUnderlayTestID;
   
   [JsonProperty("birthCertificate")]
   protected bool _birthCertificate;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("datapathID")]
   protected String _datapathID;
   
   [JsonProperty("destination")]
   protected String _destination;
   
   [JsonProperty("domainName")]
   protected String _domainName;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("operationStatus")]
   protected EOperationStatus? _operationStatus;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("subnetName")]
   protected String _subnetName;
   
   [JsonProperty("systemID")]
   protected String _systemID;
   
   [JsonProperty("zoneName")]
   protected String _zoneName;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private TestRunsFetcher _testRuns;
   
   public TestSuiteRun() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
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
   public String NUAssociatedEntityType {
      get {
         return _associatedEntityType;
      }
      set {
         this._associatedEntityType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedTestSuiteID {
      get {
         return _associatedTestSuiteID;
      }
      set {
         this._associatedTestSuiteID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedTestSuiteName {
      get {
         return _associatedTestSuiteName;
      }
      set {
         this._associatedTestSuiteName = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedUnderlayTestID {
      get {
         return _associatedUnderlayTestID;
      }
      set {
         this._associatedUnderlayTestID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUBirthCertificate {
      get {
         return _birthCertificate;
      }
      set {
         this._birthCertificate = value;
      }
   }

   
   [JsonIgnore]
   public String NUCreationDate {
      get {
         return _creationDate;
      }
      set {
         this._creationDate = value;
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
   public System.Collections.Generic.List<Metadata> NUEmbeddedMetadata {
      get {
         return _embeddedMetadata;
      }
      set {
         this._embeddedMetadata = value;
      }
   }

   
   [JsonIgnore]
   public EEntityScope? NUEntityScope {
      get {
         return _entityScope;
      }
      set {
         this._entityScope = value;
      }
   }

   
   [JsonIgnore]
   public String NUExternalID {
      get {
         return _externalID;
      }
      set {
         this._externalID = value;
      }
   }

   
   [JsonIgnore]
   public String NULastUpdatedBy {
      get {
         return _lastUpdatedBy;
      }
      set {
         this._lastUpdatedBy = value;
      }
   }

   
   [JsonIgnore]
   public String NULastUpdatedDate {
      get {
         return _lastUpdatedDate;
      }
      set {
         this._lastUpdatedDate = value;
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
   public String NUOwner {
      get {
         return _owner;
      }
      set {
         this._owner = value;
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
   public String NUZoneName {
      get {
         return _zoneName;
      }
      set {
         this._zoneName = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public TestRunsFetcher getTestRuns() {
      return _testRuns;
   }
   

   public String toString() {
      return "TestSuiteRun [" + "NSGatewayName=" + _NSGatewayName + ", VPortName=" + _VPortName + ", associatedEntityType=" + _associatedEntityType + ", associatedTestSuiteID=" + _associatedTestSuiteID + ", associatedTestSuiteName=" + _associatedTestSuiteName + ", associatedUnderlayTestID=" + _associatedUnderlayTestID + ", birthCertificate=" + _birthCertificate + ", creationDate=" + _creationDate + ", datapathID=" + _datapathID + ", destination=" + _destination + ", domainName=" + _domainName + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", operationStatus=" + _operationStatus + ", owner=" + _owner + ", subnetName=" + _subnetName + ", systemID=" + _systemID + ", zoneName=" + _zoneName + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "testsuiteruns";
   }

   public static String getRestName()
   {
	return "testsuiterun";
   }
}
}