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

public class L7applicationsignature: RestObject {

   private const long serialVersionUID = 1L;

   

   
   [JsonProperty("category")]
   protected String _category;
   
   [JsonProperty("deprecated")]
   protected bool _deprecated;
   
   [JsonProperty("deprecatedVersion")]
   protected String _deprecatedVersion;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("dictionaryVersion")]
   protected long? _dictionaryVersion;
   
   [JsonProperty("guidstring")]
   protected String _guidstring;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("pluginName")]
   protected String _pluginName;
   
   [JsonProperty("productivity")]
   protected long? _productivity;
   
   [JsonProperty("readonly")]
   protected bool _readonly;
   
   [JsonProperty("reference")]
   protected String _reference;
   
   [JsonProperty("risk")]
   protected long? _risk;
   
   [JsonProperty("signatureIndex")]
   protected long? _signatureIndex;
   
   [JsonProperty("softwareFlags")]
   protected String _softwareFlags;
   

   
   [JsonIgnore]
   private ApplicationsFetcher _applications;
   
   public L7applicationsignature() {
      
      _applications = new ApplicationsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUCategory {
      get {
         return _category;
      }
      set {
         this._category = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDeprecated {
      get {
         return _deprecated;
      }
      set {
         this._deprecated = value;
      }
   }

   
   [JsonIgnore]
   public String NUDeprecatedVersion {
      get {
         return _deprecatedVersion;
      }
      set {
         this._deprecatedVersion = value;
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
   public long? NUDictionaryVersion {
      get {
         return _dictionaryVersion;
      }
      set {
         this._dictionaryVersion = value;
      }
   }

   
   [JsonIgnore]
   public String NUGuidstring {
      get {
         return _guidstring;
      }
      set {
         this._guidstring = value;
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
   public String NUPluginName {
      get {
         return _pluginName;
      }
      set {
         this._pluginName = value;
      }
   }

   
   [JsonIgnore]
   public long? NUProductivity {
      get {
         return _productivity;
      }
      set {
         this._productivity = value;
      }
   }

   
   [JsonIgnore]
   public bool NUReadonly {
      get {
         return _readonly;
      }
      set {
         this._readonly = value;
      }
   }

   
   [JsonIgnore]
   public String NUReference {
      get {
         return _reference;
      }
      set {
         this._reference = value;
      }
   }

   
   [JsonIgnore]
   public long? NURisk {
      get {
         return _risk;
      }
      set {
         this._risk = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSignatureIndex {
      get {
         return _signatureIndex;
      }
      set {
         this._signatureIndex = value;
      }
   }

   
   [JsonIgnore]
   public String NUSoftwareFlags {
      get {
         return _softwareFlags;
      }
      set {
         this._softwareFlags = value;
      }
   }

   

   
   public ApplicationsFetcher getApplications() {
      return _applications;
   }
   

   public String toString() {
      return "L7applicationsignature [" + "category=" + _category + ", deprecated=" + _deprecated + ", deprecatedVersion=" + _deprecatedVersion + ", description=" + _description + ", dictionaryVersion=" + _dictionaryVersion + ", guidstring=" + _guidstring + ", name=" + _name + ", pluginName=" + _pluginName + ", productivity=" + _productivity + ", readonly=" + _readonly + ", reference=" + _reference + ", risk=" + _risk + ", signatureIndex=" + _signatureIndex + ", softwareFlags=" + _softwareFlags + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "l7applicationsignatures";
   }

   public static String getRestName()
   {
	return "l7applicationsignature";
   }
}
}