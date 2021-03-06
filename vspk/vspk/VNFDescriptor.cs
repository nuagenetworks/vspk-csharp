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

public class VNFDescriptor: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EType {FIREWALL,THREAT_PREVENTION,WAN_OPT };

   
   [JsonProperty("CPUCount")]
   protected long? _CPUCount;
   
   [JsonProperty("associatedVNFThresholdPolicyID")]
   protected String _associatedVNFThresholdPolicyID;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("memoryMB")]
   protected long? _memoryMB;
   
   [JsonProperty("metadataID")]
   protected String _metadataID;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("storageGB")]
   protected long? _storageGB;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("type")]
   protected EType? _type;
   
   [JsonProperty("vendor")]
   protected String _vendor;
   
   [JsonProperty("visible")]
   protected bool _visible;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private VNFInterfaceDescriptorsFetcher _vNFInterfaceDescriptors;
   
   public VNFDescriptor() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _vNFInterfaceDescriptors = new VNFInterfaceDescriptorsFetcher(this);
      
   }

   
   [JsonIgnore]
   public long? NUCPUCount {
      get {
         return _CPUCount;
      }
      set {
         this._CPUCount = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedVNFThresholdPolicyID {
      get {
         return _associatedVNFThresholdPolicyID;
      }
      set {
         this._associatedVNFThresholdPolicyID = value;
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
   public long? NUMemoryMB {
      get {
         return _memoryMB;
      }
      set {
         this._memoryMB = value;
      }
   }

   
   [JsonIgnore]
   public String NUMetadataID {
      get {
         return _metadataID;
      }
      set {
         this._metadataID = value;
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
   public long? NUStorageGB {
      get {
         return _storageGB;
      }
      set {
         this._storageGB = value;
      }
   }

   
   [JsonIgnore]
   public EType? NUType {
      get {
         return _type;
      }
      set {
         this._type = value;
      }
   }

   
   [JsonIgnore]
   public String NUVendor {
      get {
         return _vendor;
      }
      set {
         this._vendor = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVisible {
      get {
         return _visible;
      }
      set {
         this._visible = value;
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
   
   public VNFInterfaceDescriptorsFetcher getVNFInterfaceDescriptors() {
      return _vNFInterfaceDescriptors;
   }
   

   public String toString() {
      return "VNFDescriptor [" + "CPUCount=" + _CPUCount + ", associatedVNFThresholdPolicyID=" + _associatedVNFThresholdPolicyID + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", memoryMB=" + _memoryMB + ", metadataID=" + _metadataID + ", name=" + _name + ", storageGB=" + _storageGB + ", type=" + _type + ", vendor=" + _vendor + ", visible=" + _visible + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "vnfdescriptors";
   }

   public static String getRestName()
   {
	return "vnfdescriptor";
   }
}
}