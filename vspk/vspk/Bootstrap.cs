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

public class Bootstrap: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EZFBMatchAttribute {HOSTNAME,IP_ADDRESS,MAC_ADDRESS,NONE,NSGATEWAY_ID,SERIAL_NUMBER,UUID };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EStatus {ACTIVE,CERTIFICATE_SIGNED,INACTIVE,NOTIFICATION_APP_REQ_ACK,NOTIFICATION_APP_REQ_SENT };

   
   [JsonProperty("ZFBInfo")]
   protected String _ZFBInfo;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("ZFBMatchAttribute")]
   protected EZFBMatchAttribute? _ZFBMatchAttribute;
   
   [JsonProperty("ZFBMatchValue")]
   protected String _ZFBMatchValue;
   
   [JsonProperty("associatedEntityType")]
   protected String _associatedEntityType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("installerID")]
   protected String _installerID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("status")]
   protected EStatus? _status;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public Bootstrap() {
      _status = EStatus.INACTIVE;
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUZFBInfo {
      get {
         return _ZFBInfo;
      }
      set {
         this._ZFBInfo = value;
      }
   }

   
   [JsonIgnore]
   public EZFBMatchAttribute? NUZFBMatchAttribute {
      get {
         return _ZFBMatchAttribute;
      }
      set {
         this._ZFBMatchAttribute = value;
      }
   }

   
   [JsonIgnore]
   public String NUZFBMatchValue {
      get {
         return _ZFBMatchValue;
      }
      set {
         this._ZFBMatchValue = value;
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
   public String NUInstallerID {
      get {
         return _installerID;
      }
      set {
         this._installerID = value;
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
   public EStatus? NUStatus {
      get {
         return _status;
      }
      set {
         this._status = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "Bootstrap [" + "ZFBInfo=" + _ZFBInfo + ", ZFBMatchAttribute=" + _ZFBMatchAttribute + ", ZFBMatchValue=" + _ZFBMatchValue + ", associatedEntityType=" + _associatedEntityType + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", installerID=" + _installerID + ", lastUpdatedBy=" + _lastUpdatedBy + ", status=" + _status + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "bootstraps";
   }

   public static String getRestName()
   {
	return "bootstrap";
   }
}
}