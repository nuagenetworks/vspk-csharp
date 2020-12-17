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

public class VMIPReservation: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EIPType {DUALSTACK,IPV4,IPV6 };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EState {ASSIGNED,ASSIGNED_DELETE_PENDING,UNASSIGNED };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("IPType")]
   protected EIPType? _IPType;
   
   [JsonProperty("IPV4Address")]
   protected String _IPV4Address;
   
   [JsonProperty("IPV6Address")]
   protected String _IPV6Address;
   
   [JsonProperty("IPV6AllocationPools")]
   protected System.Collections.Generic.List<AllocationPool> _IPV6AllocationPools;
   
   [JsonProperty("allocationPools")]
   protected System.Collections.Generic.List<AllocationPool> _allocationPools;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
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
   
   [JsonProperty("owner")]
   protected String _owner;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("state")]
   protected EState? _state;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public VMIPReservation() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public EIPType? NUIPType {
      get {
         return _IPType;
      }
      set {
         this._IPType = value;
      }
   }

   
   [JsonIgnore]
   public String NUIPV4Address {
      get {
         return _IPV4Address;
      }
      set {
         this._IPV4Address = value;
      }
   }

   
   [JsonIgnore]
   public String NUIPV6Address {
      get {
         return _IPV6Address;
      }
      set {
         this._IPV6Address = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<AllocationPool> NUIPV6AllocationPools {
      get {
         return _IPV6AllocationPools;
      }
      set {
         this._IPV6AllocationPools = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<AllocationPool> NUAllocationPools {
      get {
         return _allocationPools;
      }
      set {
         this._allocationPools = value;
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
   public EState? NUState {
      get {
         return _state;
      }
      set {
         this._state = value;
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
      return "VMIPReservation [" + "IPType=" + _IPType + ", IPV4Address=" + _IPV4Address + ", IPV6Address=" + _IPV6Address + ", IPV6AllocationPools=" + _IPV6AllocationPools + ", allocationPools=" + _allocationPools + ", creationDate=" + _creationDate + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", owner=" + _owner + ", state=" + _state + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "vmipreservations";
   }

   public static String getRestName()
   {
	return "vmipreservation";
   }
}
}