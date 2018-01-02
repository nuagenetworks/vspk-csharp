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

public class NSGInfo: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum ETPMStatus {DISABLED,ENABLED_NOT_OPERATIONAL,ENABLED_OPERATIONAL,UNKNOWN };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EFamily {ANY,NSG_AMI,NSG_C,NSG_DOCKER,NSG_E,NSG_E200,NSG_E300,NSG_V,NSG_X,NSG_X200 };

   
   [JsonProperty("BIOSReleaseDate")]
   protected String _BIOSReleaseDate;
   
   [JsonProperty("BIOSVersion")]
   protected String _BIOSVersion;
   
   [JsonProperty("CPUType")]
   protected String _CPUType;
   
   [JsonProperty("MACAddress")]
   protected String _MACAddress;
   
   [JsonProperty("NSGVersion")]
   protected String _NSGVersion;
   
   [JsonProperty("SKU")]
   protected String _SKU;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("TPMStatus")]
   protected ETPMStatus? _TPMStatus;
   
   [JsonProperty("UUID")]
   protected String _UUID;
   
   [JsonProperty("associatedNSGatewayID")]
   protected String _associatedNSGatewayID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("family")]
   protected EFamily? _family;
   
   [JsonProperty("libraries")]
   protected String _libraries;
   
   [JsonProperty("productName")]
   protected String _productName;
   
   [JsonProperty("serialNumber")]
   protected String _serialNumber;
   

   
   public NSGInfo() {
      
   }

   
   [JsonIgnore]
   public String NUBIOSReleaseDate {
      get {
         return _BIOSReleaseDate;
      }
      set {
         this._BIOSReleaseDate = value;
      }
   }

   
   [JsonIgnore]
   public String NUBIOSVersion {
      get {
         return _BIOSVersion;
      }
      set {
         this._BIOSVersion = value;
      }
   }

   
   [JsonIgnore]
   public String NUCPUType {
      get {
         return _CPUType;
      }
      set {
         this._CPUType = value;
      }
   }

   
   [JsonIgnore]
   public String NUMACAddress {
      get {
         return _MACAddress;
      }
      set {
         this._MACAddress = value;
      }
   }

   
   [JsonIgnore]
   public String NUNSGVersion {
      get {
         return _NSGVersion;
      }
      set {
         this._NSGVersion = value;
      }
   }

   
   [JsonIgnore]
   public String NUSKU {
      get {
         return _SKU;
      }
      set {
         this._SKU = value;
      }
   }

   
   [JsonIgnore]
   public ETPMStatus? NUTPMStatus {
      get {
         return _TPMStatus;
      }
      set {
         this._TPMStatus = value;
      }
   }

   
   [JsonIgnore]
   public String NUUUID {
      get {
         return _UUID;
      }
      set {
         this._UUID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedNSGatewayID {
      get {
         return _associatedNSGatewayID;
      }
      set {
         this._associatedNSGatewayID = value;
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
   public EFamily? NUFamily {
      get {
         return _family;
      }
      set {
         this._family = value;
      }
   }

   
   [JsonIgnore]
   public String NULibraries {
      get {
         return _libraries;
      }
      set {
         this._libraries = value;
      }
   }

   
   [JsonIgnore]
   public String NUProductName {
      get {
         return _productName;
      }
      set {
         this._productName = value;
      }
   }

   
   [JsonIgnore]
   public String NUSerialNumber {
      get {
         return _serialNumber;
      }
      set {
         this._serialNumber = value;
      }
   }

   

   

   public String toString() {
      return "NSGInfo [" + "BIOSReleaseDate=" + _BIOSReleaseDate + ", BIOSVersion=" + _BIOSVersion + ", CPUType=" + _CPUType + ", MACAddress=" + _MACAddress + ", NSGVersion=" + _NSGVersion + ", SKU=" + _SKU + ", TPMStatus=" + _TPMStatus + ", UUID=" + _UUID + ", associatedNSGatewayID=" + _associatedNSGatewayID + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", family=" + _family + ", libraries=" + _libraries + ", productName=" + _productName + ", serialNumber=" + _serialNumber + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "nsginfos";
   }

   public static String getRestName()
   {
	return "nsginfo";
   }
}
}