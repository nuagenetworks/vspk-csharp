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

public class BRConnection: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAdvertisementCriteria {BFD,LINK_BASED,OPENFLOW };
   public enum EMode {Static };

   
   [JsonProperty("DNSAddress")]
   protected String _DNSAddress;
   
   [JsonProperty("address")]
   protected String _address;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("advertisementCriteria")]
   protected EAdvertisementCriteria? _advertisementCriteria;
   
   [JsonProperty("gateway")]
   protected String _gateway;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("mode")]
   protected EMode? _mode;
   
   [JsonProperty("netmask")]
   protected String _netmask;
   
   [JsonProperty("uplinkID")]
   protected long? _uplinkID;
   

   
   [JsonIgnore]
   private BFDSessionsFetcher _bFDSessions;
   
   public BRConnection() {
      
      _bFDSessions = new BFDSessionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUDNSAddress {
      get {
         return _DNSAddress;
      }
      set {
         this._DNSAddress = value;
      }
   }

   
   [JsonIgnore]
   public String NUAddress {
      get {
         return _address;
      }
      set {
         this._address = value;
      }
   }

   
   [JsonIgnore]
   public EAdvertisementCriteria? NUAdvertisementCriteria {
      get {
         return _advertisementCriteria;
      }
      set {
         this._advertisementCriteria = value;
      }
   }

   
   [JsonIgnore]
   public String NUGateway {
      get {
         return _gateway;
      }
      set {
         this._gateway = value;
      }
   }

   
   [JsonIgnore]
   public EMode? NUMode {
      get {
         return _mode;
      }
      set {
         this._mode = value;
      }
   }

   
   [JsonIgnore]
   public String NUNetmask {
      get {
         return _netmask;
      }
      set {
         this._netmask = value;
      }
   }

   
   [JsonIgnore]
   public long? NUUplinkID {
      get {
         return _uplinkID;
      }
      set {
         this._uplinkID = value;
      }
   }

   

   
   public BFDSessionsFetcher getBFDSessions() {
      return _bFDSessions;
   }
   

   public String toString() {
      return "BRConnection [" + "DNSAddress=" + _DNSAddress + ", address=" + _address + ", advertisementCriteria=" + _advertisementCriteria + ", gateway=" + _gateway + ", mode=" + _mode + ", netmask=" + _netmask + ", uplinkID=" + _uplinkID + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "brconnections";
   }

   public static String getRestName()
   {
	return "brconnection";
   }
}
}