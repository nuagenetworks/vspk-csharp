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

public class IngressProfile: RestObject {

   private const long serialVersionUID = 1L;

   

   
   [JsonProperty("associatedIPFilterProfileID")]
   protected String _associatedIPFilterProfileID;
   
   [JsonProperty("associatedIPFilterProfileName")]
   protected String _associatedIPFilterProfileName;
   
   [JsonProperty("associatedIPv6FilterProfileID")]
   protected String _associatedIPv6FilterProfileID;
   
   [JsonProperty("associatedIPv6FilterProfileName")]
   protected String _associatedIPv6FilterProfileName;
   
   [JsonProperty("associatedMACFilterProfileID")]
   protected String _associatedMACFilterProfileID;
   
   [JsonProperty("associatedMACFilterProfileName")]
   protected String _associatedMACFilterProfileName;
   
   [JsonProperty("associatedSAPIngressQoSProfileID")]
   protected String _associatedSAPIngressQoSProfileID;
   
   [JsonProperty("associatedSAPIngressQoSProfileName")]
   protected String _associatedSAPIngressQoSProfileName;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("name")]
   protected String _name;
   

   
   [JsonIgnore]
   private VPortsFetcher _vPorts;
   
   public IngressProfile() {
      
      _vPorts = new VPortsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAssociatedIPFilterProfileID {
      get {
         return _associatedIPFilterProfileID;
      }
      set {
         this._associatedIPFilterProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIPFilterProfileName {
      get {
         return _associatedIPFilterProfileName;
      }
      set {
         this._associatedIPFilterProfileName = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIPv6FilterProfileID {
      get {
         return _associatedIPv6FilterProfileID;
      }
      set {
         this._associatedIPv6FilterProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIPv6FilterProfileName {
      get {
         return _associatedIPv6FilterProfileName;
      }
      set {
         this._associatedIPv6FilterProfileName = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedMACFilterProfileID {
      get {
         return _associatedMACFilterProfileID;
      }
      set {
         this._associatedMACFilterProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedMACFilterProfileName {
      get {
         return _associatedMACFilterProfileName;
      }
      set {
         this._associatedMACFilterProfileName = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedSAPIngressQoSProfileID {
      get {
         return _associatedSAPIngressQoSProfileID;
      }
      set {
         this._associatedSAPIngressQoSProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedSAPIngressQoSProfileName {
      get {
         return _associatedSAPIngressQoSProfileName;
      }
      set {
         this._associatedSAPIngressQoSProfileName = value;
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
      }
   }

   

   
   public VPortsFetcher getVPorts() {
      return _vPorts;
   }
   

   public String toString() {
      return "IngressProfile [" + "associatedIPFilterProfileID=" + _associatedIPFilterProfileID + ", associatedIPFilterProfileName=" + _associatedIPFilterProfileName + ", associatedIPv6FilterProfileID=" + _associatedIPv6FilterProfileID + ", associatedIPv6FilterProfileName=" + _associatedIPv6FilterProfileName + ", associatedMACFilterProfileID=" + _associatedMACFilterProfileID + ", associatedMACFilterProfileName=" + _associatedMACFilterProfileName + ", associatedSAPIngressQoSProfileID=" + _associatedSAPIngressQoSProfileID + ", associatedSAPIngressQoSProfileName=" + _associatedSAPIngressQoSProfileName + ", description=" + _description + ", name=" + _name + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ingressprofiles";
   }

   public static String getRestName()
   {
	return "ingressprofile";
   }
}
}