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

using net.nuagenetworks.vspk.v5_0.fetchers;

namespace net.nuagenetworks.vspk.v5_0
{

public class EnterpriseProfile: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAllowedForwardingClasses {A,B,C,D,E,F,G,H,NONE };
   public enum EEncryptionManagementMode {DISABLED,MANAGED };
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("BGPEnabled")]
   protected bool _BGPEnabled;
   
   [JsonProperty("DHCPLeaseInterval")]
   protected long? _DHCPLeaseInterval;
   
   [JsonProperty("VNFManagementEnabled")]
   protected bool _VNFManagementEnabled;
   
   [JsonProperty("allowAdvancedQOSConfiguration")]
   protected bool _allowAdvancedQOSConfiguration;
   
   [JsonProperty("allowGatewayManagement")]
   protected bool _allowGatewayManagement;
   
   [JsonProperty("allowTrustedForwardingClass")]
   protected bool _allowTrustedForwardingClass;
   
   [JsonProperty("allowedForwardingClasses")]
   protected System.Collections.Generic.List<EAllowedForwardingClasses> _allowedForwardingClasses;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("enableApplicationPerformanceManagement")]
   protected bool _enableApplicationPerformanceManagement;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("encryptionManagementMode")]
   protected EEncryptionManagementMode? _encryptionManagementMode;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("floatingIPsQuota")]
   protected long? _floatingIPsQuota;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("receiveMultiCastListID")]
   protected String _receiveMultiCastListID;
   
   [JsonProperty("sendMultiCastListID")]
   protected String _sendMultiCastListID;
   

   
   [JsonIgnore]
   private EnterprisesFetcher _enterprises;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private MultiCastListsFetcher _multiCastLists;
   
   public EnterpriseProfile() {
      _floatingIPsQuota = 100L;
      _DHCPLeaseInterval = 24L;
      
      _enterprises = new EnterprisesFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _multiCastLists = new MultiCastListsFetcher(this);
      
   }

   
   [JsonIgnore]
   public bool NUBGPEnabled {
      get {
         return _BGPEnabled;
      }
      set {
         this._BGPEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDHCPLeaseInterval {
      get {
         return _DHCPLeaseInterval;
      }
      set {
         this._DHCPLeaseInterval = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVNFManagementEnabled {
      get {
         return _VNFManagementEnabled;
      }
      set {
         this._VNFManagementEnabled = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAllowAdvancedQOSConfiguration {
      get {
         return _allowAdvancedQOSConfiguration;
      }
      set {
         this._allowAdvancedQOSConfiguration = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAllowGatewayManagement {
      get {
         return _allowGatewayManagement;
      }
      set {
         this._allowGatewayManagement = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAllowTrustedForwardingClass {
      get {
         return _allowTrustedForwardingClass;
      }
      set {
         this._allowTrustedForwardingClass = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<EAllowedForwardingClasses> NUAllowedForwardingClasses {
      get {
         return _allowedForwardingClasses;
      }
      set {
         this._allowedForwardingClasses = value;
      }
   }

   
   [JsonIgnore]
   public String NUDescription {
      get {
         return _description;
      }
      set {
         this._description = value;
      }
   }

   
   [JsonIgnore]
   public bool NUEnableApplicationPerformanceManagement {
      get {
         return _enableApplicationPerformanceManagement;
      }
      set {
         this._enableApplicationPerformanceManagement = value;
      }
   }

   
   [JsonIgnore]
   public EEncryptionManagementMode? NUEncryptionManagementMode {
      get {
         return _encryptionManagementMode;
      }
      set {
         this._encryptionManagementMode = value;
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
   public long? NUFloatingIPsQuota {
      get {
         return _floatingIPsQuota;
      }
      set {
         this._floatingIPsQuota = value;
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
      }
   }

   
   [JsonIgnore]
   public String NUReceiveMultiCastListID {
      get {
         return _receiveMultiCastListID;
      }
      set {
         this._receiveMultiCastListID = value;
      }
   }

   
   [JsonIgnore]
   public String NUSendMultiCastListID {
      get {
         return _sendMultiCastListID;
      }
      set {
         this._sendMultiCastListID = value;
      }
   }

   

   
   public EnterprisesFetcher getEnterprises() {
      return _enterprises;
   }
   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public MultiCastListsFetcher getMultiCastLists() {
      return _multiCastLists;
   }
   

   public String toString() {
      return "EnterpriseProfile [" + "BGPEnabled=" + _BGPEnabled + ", DHCPLeaseInterval=" + _DHCPLeaseInterval + ", VNFManagementEnabled=" + _VNFManagementEnabled + ", allowAdvancedQOSConfiguration=" + _allowAdvancedQOSConfiguration + ", allowGatewayManagement=" + _allowGatewayManagement + ", allowTrustedForwardingClass=" + _allowTrustedForwardingClass + ", allowedForwardingClasses=" + _allowedForwardingClasses + ", description=" + _description + ", enableApplicationPerformanceManagement=" + _enableApplicationPerformanceManagement + ", encryptionManagementMode=" + _encryptionManagementMode + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", floatingIPsQuota=" + _floatingIPsQuota + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", receiveMultiCastListID=" + _receiveMultiCastListID + ", sendMultiCastListID=" + _sendMultiCastListID + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "enterpriseprofiles";
   }

   public static String getRestName()
   {
	return "enterpriseprofile";
   }
}
}