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

public class IngressAuditACLTemplate: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EPolicyState {DRAFT,LIVE };
   public enum EPriorityType {TOP_AUDIT };

   
   [JsonProperty("active")]
   protected bool _active;
   
   [JsonProperty("allowAddressSpoof")]
   protected bool _allowAddressSpoof;
   
   [JsonProperty("associatedLiveEntityID")]
   protected String _associatedLiveEntityID;
   
   [JsonProperty("associatedVirtualFirewallPolicyID")]
   protected String _associatedVirtualFirewallPolicyID;
   
   [JsonProperty("autoGeneratePriority")]
   protected bool _autoGeneratePriority;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("defaultAllowIP")]
   protected bool _defaultAllowIP;
   
   [JsonProperty("defaultAllowNonIP")]
   protected bool _defaultAllowNonIP;
   
   [JsonProperty("description")]
   protected String _description;
   
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
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("owner")]
   protected String _owner;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("policyState")]
   protected EPolicyState? _policyState;
   
   [JsonProperty("priority")]
   protected long? _priority;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("priorityType")]
   protected EPriorityType? _priorityType;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private IngressAuditACLEntryTemplatesFetcher _ingressAuditACLEntryTemplates;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public IngressAuditACLTemplate() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _ingressAuditACLEntryTemplates = new IngressAuditACLEntryTemplatesFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public bool NUActive {
      get {
         return _active;
      }
      set {
         this._active = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAllowAddressSpoof {
      get {
         return _allowAddressSpoof;
      }
      set {
         this._allowAddressSpoof = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedLiveEntityID {
      get {
         return _associatedLiveEntityID;
      }
      set {
         this._associatedLiveEntityID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedVirtualFirewallPolicyID {
      get {
         return _associatedVirtualFirewallPolicyID;
      }
      set {
         this._associatedVirtualFirewallPolicyID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAutoGeneratePriority {
      get {
         return _autoGeneratePriority;
      }
      set {
         this._autoGeneratePriority = value;
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
   public bool NUDefaultAllowIP {
      get {
         return _defaultAllowIP;
      }
      set {
         this._defaultAllowIP = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDefaultAllowNonIP {
      get {
         return _defaultAllowNonIP;
      }
      set {
         this._defaultAllowNonIP = value;
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
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
   public EPolicyState? NUPolicyState {
      get {
         return _policyState;
      }
      set {
         this._policyState = value;
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
   public EPriorityType? NUPriorityType {
      get {
         return _priorityType;
      }
      set {
         this._priorityType = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public IngressAuditACLEntryTemplatesFetcher getIngressAuditACLEntryTemplates() {
      return _ingressAuditACLEntryTemplates;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   

   public String toString() {
      return "IngressAuditACLTemplate [" + "active=" + _active + ", allowAddressSpoof=" + _allowAddressSpoof + ", associatedLiveEntityID=" + _associatedLiveEntityID + ", associatedVirtualFirewallPolicyID=" + _associatedVirtualFirewallPolicyID + ", autoGeneratePriority=" + _autoGeneratePriority + ", creationDate=" + _creationDate + ", defaultAllowIP=" + _defaultAllowIP + ", defaultAllowNonIP=" + _defaultAllowNonIP + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", name=" + _name + ", owner=" + _owner + ", policyState=" + _policyState + ", priority=" + _priority + ", priorityType=" + _priorityType + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ingressauditacltemplates";
   }

   public static String getRestName()
   {
	return "ingressauditacltemplate";
   }
}
}