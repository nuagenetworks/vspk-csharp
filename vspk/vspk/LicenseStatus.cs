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

public class LicenseStatus: RestObject {

   private const long serialVersionUID = 1L;

   

   
   [JsonProperty("accumulateLicensesEnabled")]
   protected bool _accumulateLicensesEnabled;
   
   [JsonProperty("totalLicensedAVRSGsCount")]
   protected long? _totalLicensedAVRSGsCount;
   
   [JsonProperty("totalLicensedAVRSsCount")]
   protected long? _totalLicensedAVRSsCount;
   
   [JsonProperty("totalLicensedGatewaysCount")]
   protected long? _totalLicensedGatewaysCount;
   
   [JsonProperty("totalLicensedNICsCount")]
   protected long? _totalLicensedNICsCount;
   
   [JsonProperty("totalLicensedNSGsCount")]
   protected long? _totalLicensedNSGsCount;
   
   [JsonProperty("totalLicensedUsedAVRSGsCount")]
   protected long? _totalLicensedUsedAVRSGsCount;
   
   [JsonProperty("totalLicensedUsedAVRSsCount")]
   protected long? _totalLicensedUsedAVRSsCount;
   
   [JsonProperty("totalLicensedUsedNICsCount")]
   protected long? _totalLicensedUsedNICsCount;
   
   [JsonProperty("totalLicensedUsedNSGsCount")]
   protected long? _totalLicensedUsedNSGsCount;
   
   [JsonProperty("totalLicensedUsedVDFGsCount")]
   protected long? _totalLicensedUsedVDFGsCount;
   
   [JsonProperty("totalLicensedUsedVDFsCount")]
   protected long? _totalLicensedUsedVDFsCount;
   
   [JsonProperty("totalLicensedUsedVMsCount")]
   protected long? _totalLicensedUsedVMsCount;
   
   [JsonProperty("totalLicensedUsedVRSGsCount")]
   protected long? _totalLicensedUsedVRSGsCount;
   
   [JsonProperty("totalLicensedUsedVRSsCount")]
   protected long? _totalLicensedUsedVRSsCount;
   
   [JsonProperty("totalLicensedVDFGsCount")]
   protected long? _totalLicensedVDFGsCount;
   
   [JsonProperty("totalLicensedVDFsCount")]
   protected long? _totalLicensedVDFsCount;
   
   [JsonProperty("totalLicensedVMsCount")]
   protected long? _totalLicensedVMsCount;
   
   [JsonProperty("totalLicensedVRSGsCount")]
   protected long? _totalLicensedVRSGsCount;
   
   [JsonProperty("totalLicensedVRSsCount")]
   protected long? _totalLicensedVRSsCount;
   
   [JsonProperty("totalUsedGatewaysCount")]
   protected long? _totalUsedGatewaysCount;
   

   
   public LicenseStatus() {
      
   }

   
   [JsonIgnore]
   public bool NUAccumulateLicensesEnabled {
      get {
         return _accumulateLicensesEnabled;
      }
      set {
         this._accumulateLicensesEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedAVRSGsCount {
      get {
         return _totalLicensedAVRSGsCount;
      }
      set {
         this._totalLicensedAVRSGsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedAVRSsCount {
      get {
         return _totalLicensedAVRSsCount;
      }
      set {
         this._totalLicensedAVRSsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedGatewaysCount {
      get {
         return _totalLicensedGatewaysCount;
      }
      set {
         this._totalLicensedGatewaysCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedNICsCount {
      get {
         return _totalLicensedNICsCount;
      }
      set {
         this._totalLicensedNICsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedNSGsCount {
      get {
         return _totalLicensedNSGsCount;
      }
      set {
         this._totalLicensedNSGsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedUsedAVRSGsCount {
      get {
         return _totalLicensedUsedAVRSGsCount;
      }
      set {
         this._totalLicensedUsedAVRSGsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedUsedAVRSsCount {
      get {
         return _totalLicensedUsedAVRSsCount;
      }
      set {
         this._totalLicensedUsedAVRSsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedUsedNICsCount {
      get {
         return _totalLicensedUsedNICsCount;
      }
      set {
         this._totalLicensedUsedNICsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedUsedNSGsCount {
      get {
         return _totalLicensedUsedNSGsCount;
      }
      set {
         this._totalLicensedUsedNSGsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedUsedVDFGsCount {
      get {
         return _totalLicensedUsedVDFGsCount;
      }
      set {
         this._totalLicensedUsedVDFGsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedUsedVDFsCount {
      get {
         return _totalLicensedUsedVDFsCount;
      }
      set {
         this._totalLicensedUsedVDFsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedUsedVMsCount {
      get {
         return _totalLicensedUsedVMsCount;
      }
      set {
         this._totalLicensedUsedVMsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedUsedVRSGsCount {
      get {
         return _totalLicensedUsedVRSGsCount;
      }
      set {
         this._totalLicensedUsedVRSGsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedUsedVRSsCount {
      get {
         return _totalLicensedUsedVRSsCount;
      }
      set {
         this._totalLicensedUsedVRSsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedVDFGsCount {
      get {
         return _totalLicensedVDFGsCount;
      }
      set {
         this._totalLicensedVDFGsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedVDFsCount {
      get {
         return _totalLicensedVDFsCount;
      }
      set {
         this._totalLicensedVDFsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedVMsCount {
      get {
         return _totalLicensedVMsCount;
      }
      set {
         this._totalLicensedVMsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedVRSGsCount {
      get {
         return _totalLicensedVRSGsCount;
      }
      set {
         this._totalLicensedVRSGsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalLicensedVRSsCount {
      get {
         return _totalLicensedVRSsCount;
      }
      set {
         this._totalLicensedVRSsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTotalUsedGatewaysCount {
      get {
         return _totalUsedGatewaysCount;
      }
      set {
         this._totalUsedGatewaysCount = value;
      }
   }

   

   

   public String toString() {
      return "LicenseStatus [" + "accumulateLicensesEnabled=" + _accumulateLicensesEnabled + ", totalLicensedAVRSGsCount=" + _totalLicensedAVRSGsCount + ", totalLicensedAVRSsCount=" + _totalLicensedAVRSsCount + ", totalLicensedGatewaysCount=" + _totalLicensedGatewaysCount + ", totalLicensedNICsCount=" + _totalLicensedNICsCount + ", totalLicensedNSGsCount=" + _totalLicensedNSGsCount + ", totalLicensedUsedAVRSGsCount=" + _totalLicensedUsedAVRSGsCount + ", totalLicensedUsedAVRSsCount=" + _totalLicensedUsedAVRSsCount + ", totalLicensedUsedNICsCount=" + _totalLicensedUsedNICsCount + ", totalLicensedUsedNSGsCount=" + _totalLicensedUsedNSGsCount + ", totalLicensedUsedVDFGsCount=" + _totalLicensedUsedVDFGsCount + ", totalLicensedUsedVDFsCount=" + _totalLicensedUsedVDFsCount + ", totalLicensedUsedVMsCount=" + _totalLicensedUsedVMsCount + ", totalLicensedUsedVRSGsCount=" + _totalLicensedUsedVRSGsCount + ", totalLicensedUsedVRSsCount=" + _totalLicensedUsedVRSsCount + ", totalLicensedVDFGsCount=" + _totalLicensedVDFGsCount + ", totalLicensedVDFsCount=" + _totalLicensedVDFsCount + ", totalLicensedVMsCount=" + _totalLicensedVMsCount + ", totalLicensedVRSGsCount=" + _totalLicensedVRSGsCount + ", totalLicensedVRSsCount=" + _totalLicensedVRSsCount + ", totalUsedGatewaysCount=" + _totalUsedGatewaysCount + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "licensestatus";
   }

   public static String getRestName()
   {
	return "licensestatus";
   }
}
}