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

public class ForwardingPathListEntry: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EFCOverride {A,B,C,D,E,F,G,H,NONE };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EForwardingAction {IKE,OVERLAY,UNDERLAY_PAT,UNDERLAY_ROUTE };
   public enum ERemoteUplinkPreference {DEFAULT,PRIMARY,PRIMARY_SECONDARY,SECONDARY,SECONDARY_PRIMARY };
   public enum EUplinkPreference {DEFAULT,PRIMARY,PRIMARY_SECONDARY,SECONDARY,SECONDARY_PRIMARY };

   
   [JsonProperty("DSCPRemarking")]
   protected String _DSCPRemarking;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("FCOverride")]
   protected EFCOverride? _FCOverride;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("forwardingAction")]
   protected EForwardingAction? _forwardingAction;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("priority")]
   protected long? _priority;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("remoteUplinkPreference")]
   protected ERemoteUplinkPreference? _remoteUplinkPreference;
   
   [JsonProperty("slaAware")]
   protected bool _slaAware;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("uplinkPreference")]
   protected EUplinkPreference? _uplinkPreference;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public ForwardingPathListEntry() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUDSCPRemarking {
      get {
         return _DSCPRemarking;
      }
      set {
         this._DSCPRemarking = value;
      }
   }

   
   [JsonIgnore]
   public EFCOverride? NUFCOverride {
      get {
         return _FCOverride;
      }
      set {
         this._FCOverride = value;
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
   public EForwardingAction? NUForwardingAction {
      get {
         return _forwardingAction;
      }
      set {
         this._forwardingAction = value;
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
   public String NUOwner {
      get {
         return _owner;
      }
      set {
         this._owner = value;
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
   public ERemoteUplinkPreference? NURemoteUplinkPreference {
      get {
         return _remoteUplinkPreference;
      }
      set {
         this._remoteUplinkPreference = value;
      }
   }

   
   [JsonIgnore]
   public bool NUSlaAware {
      get {
         return _slaAware;
      }
      set {
         this._slaAware = value;
      }
   }

   
   [JsonIgnore]
   public EUplinkPreference? NUUplinkPreference {
      get {
         return _uplinkPreference;
      }
      set {
         this._uplinkPreference = value;
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
   

   public String toString() {
      return "ForwardingPathListEntry [" + "DSCPRemarking=" + _DSCPRemarking + ", FCOverride=" + _FCOverride + ", creationDate=" + _creationDate + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", forwardingAction=" + _forwardingAction + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", owner=" + _owner + ", priority=" + _priority + ", remoteUplinkPreference=" + _remoteUplinkPreference + ", slaAware=" + _slaAware + ", uplinkPreference=" + _uplinkPreference + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "forwardingpathlistentries";
   }

   public static String getRestName()
   {
	return "forwardingpathlistentry";
   }
}
}