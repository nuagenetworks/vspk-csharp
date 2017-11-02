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

public class IKECertificate: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("PEMEncoded")]
   protected String _PEMEncoded;
   
   [JsonProperty("associatedEnterpriseID")]
   protected String _associatedEnterpriseID;
   
   [JsonProperty("description")]
   protected String _description;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("issuerDN")]
   protected String _issuerDN;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("notAfter")]
   protected long? _notAfter;
   
   [JsonProperty("notBefore")]
   protected long? _notBefore;
   
   [JsonProperty("serialNumber")]
   protected long? _serialNumber;
   
   [JsonProperty("subjectDN")]
   protected String _subjectDN;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public IKECertificate() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUPEMEncoded {
      get {
         return _PEMEncoded;
      }
      set {
         this._PEMEncoded = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedEnterpriseID {
      get {
         return _associatedEnterpriseID;
      }
      set {
         this._associatedEnterpriseID = value;
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
   public String NUIssuerDN {
      get {
         return _issuerDN;
      }
      set {
         this._issuerDN = value;
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
   public long? NUNotAfter {
      get {
         return _notAfter;
      }
      set {
         this._notAfter = value;
      }
   }

   
   [JsonIgnore]
   public long? NUNotBefore {
      get {
         return _notBefore;
      }
      set {
         this._notBefore = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSerialNumber {
      get {
         return _serialNumber;
      }
      set {
         this._serialNumber = value;
      }
   }

   
   [JsonIgnore]
   public String NUSubjectDN {
      get {
         return _subjectDN;
      }
      set {
         this._subjectDN = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "IKECertificate [" + "PEMEncoded=" + _PEMEncoded + ", associatedEnterpriseID=" + _associatedEnterpriseID + ", description=" + _description + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", issuerDN=" + _issuerDN + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", notAfter=" + _notAfter + ", notBefore=" + _notBefore + ", serialNumber=" + _serialNumber + ", subjectDN=" + _subjectDN + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ikecertificates";
   }

   public static String getRestName()
   {
	return "ikecertificate";
   }
}
}