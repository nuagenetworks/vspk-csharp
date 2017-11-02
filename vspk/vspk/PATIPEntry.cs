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

public class PATIPEntry: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EIPType {IPV4,IPV6 };
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("IPAddress")]
   protected String _IPAddress;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("IPType")]
   protected EIPType? _IPType;
   
   [JsonProperty("PATCentralized")]
   protected bool _PATCentralized;
   
   [JsonProperty("associatedDomainID")]
   protected String _associatedDomainID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("hypervisorID")]
   protected String _hypervisorID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   

   
   public PATIPEntry() {
      
   }

   
   [JsonIgnore]
   public String NUIPAddress {
      get {
         return _IPAddress;
      }
      set {
         this._IPAddress = value;
      }
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
   public bool NUPATCentralized {
      get {
         return _PATCentralized;
      }
      set {
         this._PATCentralized = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedDomainID {
      get {
         return _associatedDomainID;
      }
      set {
         this._associatedDomainID = value;
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
   public String NUHypervisorID {
      get {
         return _hypervisorID;
      }
      set {
         this._hypervisorID = value;
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

   

   

   public String toString() {
      return "PATIPEntry [" + "IPAddress=" + _IPAddress + ", IPType=" + _IPType + ", PATCentralized=" + _PATCentralized + ", associatedDomainID=" + _associatedDomainID + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", hypervisorID=" + _hypervisorID + ", lastUpdatedBy=" + _lastUpdatedBy + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "patipentries";
   }

   public static String getRestName()
   {
	return "patipentry";
   }
}
}