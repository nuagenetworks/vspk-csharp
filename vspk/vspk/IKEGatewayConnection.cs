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

public class IKEGatewayConnection: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum ENSGIdentifierType {ID_DER_ASN1_DN,ID_FQDN,ID_IPV4_ADDR,ID_KEY_ID,ID_RFC822_ADDR };
   public enum ENSGRole {INITIATOR,RESPONDER };
   public enum EAssociatedCloudType {AZURECLOUD };
   public enum EAssociatedIKEAuthenticationType {IKE_CERTIFICATE,IKE_PSK };
   public enum EConfigurationStatus {CANCELING,CANCELLED,CLOUD_CONFIGURATION_REMOVED,FAILED,IN_PROGRESS,NOT_APPLICABLE,PAUSING,SUCCESS,SYNCED_FROM_CLOUD,UNKNOWN,WAITING,WAITING_FOR_RESOURCES };
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("NSGIdentifier")]
   protected String _NSGIdentifier;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("NSGIdentifierType")]
   protected ENSGIdentifierType? _NSGIdentifierType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("NSGRole")]
   protected ENSGRole? _NSGRole;
   
   [JsonProperty("allowAnySubnet")]
   protected bool _allowAnySubnet;
   
   [JsonProperty("associatedCloudID")]
   protected String _associatedCloudID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("associatedCloudType")]
   protected EAssociatedCloudType? _associatedCloudType;
   
   [JsonProperty("associatedIKEAuthenticationID")]
   protected String _associatedIKEAuthenticationID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("associatedIKEAuthenticationType")]
   protected EAssociatedIKEAuthenticationType? _associatedIKEAuthenticationType;
   
   [JsonProperty("associatedIKEEncryptionProfileID")]
   protected String _associatedIKEEncryptionProfileID;
   
   [JsonProperty("associatedIKEGatewayProfileID")]
   protected String _associatedIKEGatewayProfileID;
   
   [JsonProperty("associatedVLANID")]
   protected String _associatedVLANID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("configurationStatus")]
   protected EConfigurationStatus? _configurationStatus;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("mark")]
   protected long? _mark;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("portVLANName")]
   protected String _portVLANName;
   
   [JsonProperty("priority")]
   protected long? _priority;
   
   [JsonProperty("sequence")]
   protected long? _sequence;
   
   [JsonProperty("unencryptedPSK")]
   protected String _unencryptedPSK;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private JobsFetcher _jobs;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PerformanceMonitorsFetcher _performanceMonitors;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private SubnetsFetcher _subnets;
   
   public IKEGatewayConnection() {
      
      _alarms = new AlarmsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _performanceMonitors = new PerformanceMonitorsFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _subnets = new SubnetsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUNSGIdentifier {
      get {
         return _NSGIdentifier;
      }
      set {
         this._NSGIdentifier = value;
      }
   }

   
   [JsonIgnore]
   public ENSGIdentifierType? NUNSGIdentifierType {
      get {
         return _NSGIdentifierType;
      }
      set {
         this._NSGIdentifierType = value;
      }
   }

   
   [JsonIgnore]
   public ENSGRole? NUNSGRole {
      get {
         return _NSGRole;
      }
      set {
         this._NSGRole = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAllowAnySubnet {
      get {
         return _allowAnySubnet;
      }
      set {
         this._allowAnySubnet = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedCloudID {
      get {
         return _associatedCloudID;
      }
      set {
         this._associatedCloudID = value;
      }
   }

   
   [JsonIgnore]
   public EAssociatedCloudType? NUAssociatedCloudType {
      get {
         return _associatedCloudType;
      }
      set {
         this._associatedCloudType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIKEAuthenticationID {
      get {
         return _associatedIKEAuthenticationID;
      }
      set {
         this._associatedIKEAuthenticationID = value;
      }
   }

   
   [JsonIgnore]
   public EAssociatedIKEAuthenticationType? NUAssociatedIKEAuthenticationType {
      get {
         return _associatedIKEAuthenticationType;
      }
      set {
         this._associatedIKEAuthenticationType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIKEEncryptionProfileID {
      get {
         return _associatedIKEEncryptionProfileID;
      }
      set {
         this._associatedIKEEncryptionProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIKEGatewayProfileID {
      get {
         return _associatedIKEGatewayProfileID;
      }
      set {
         this._associatedIKEGatewayProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedVLANID {
      get {
         return _associatedVLANID;
      }
      set {
         this._associatedVLANID = value;
      }
   }

   
   [JsonIgnore]
   public EConfigurationStatus? NUConfigurationStatus {
      get {
         return _configurationStatus;
      }
      set {
         this._configurationStatus = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUEmbeddedMetadata {
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
   public long? NUMark {
      get {
         return _mark;
      }
      set {
         this._mark = value;
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
   public String NUPortVLANName {
      get {
         return _portVLANName;
      }
      set {
         this._portVLANName = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPriority {
      get {
         return _priority;
      }
      set {
         this._priority = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSequence {
      get {
         return _sequence;
      }
      set {
         this._sequence = value;
      }
   }

   
   [JsonIgnore]
   public String NUUnencryptedPSK {
      get {
         return _unencryptedPSK;
      }
      set {
         this._unencryptedPSK = value;
      }
   }

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public JobsFetcher getJobs() {
      return _jobs;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PerformanceMonitorsFetcher getPerformanceMonitors() {
      return _performanceMonitors;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public SubnetsFetcher getSubnets() {
      return _subnets;
   }
   

   public String toString() {
      return "IKEGatewayConnection [" + "NSGIdentifier=" + _NSGIdentifier + ", NSGIdentifierType=" + _NSGIdentifierType + ", NSGRole=" + _NSGRole + ", allowAnySubnet=" + _allowAnySubnet + ", associatedCloudID=" + _associatedCloudID + ", associatedCloudType=" + _associatedCloudType + ", associatedIKEAuthenticationID=" + _associatedIKEAuthenticationID + ", associatedIKEAuthenticationType=" + _associatedIKEAuthenticationType + ", associatedIKEEncryptionProfileID=" + _associatedIKEEncryptionProfileID + ", associatedIKEGatewayProfileID=" + _associatedIKEGatewayProfileID + ", associatedVLANID=" + _associatedVLANID + ", configurationStatus=" + _configurationStatus + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", mark=" + _mark + ", name=" + _name + ", portVLANName=" + _portVLANName + ", priority=" + _priority + ", sequence=" + _sequence + ", unencryptedPSK=" + _unencryptedPSK + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ikegatewayconnections";
   }

   public static String getRestName()
   {
	return "ikegatewayconnection";
   }
}
}