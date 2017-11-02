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

public class VRSRedeploymentpolicy: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("ALUbr0StatusRedeploymentEnabled")]
   protected bool _ALUbr0StatusRedeploymentEnabled;
   
   [JsonProperty("CPUUtilizationRedeploymentEnabled")]
   protected bool _CPUUtilizationRedeploymentEnabled;
   
   [JsonProperty("CPUUtilizationThreshold")]
   protected float _CPUUtilizationThreshold;
   
   [JsonProperty("VRSCorrectiveActionDelay")]
   protected long? _VRSCorrectiveActionDelay;
   
   [JsonProperty("VRSProcessRedeploymentEnabled")]
   protected bool _VRSProcessRedeploymentEnabled;
   
   [JsonProperty("VRSVSCStatusRedeploymentEnabled")]
   protected bool _VRSVSCStatusRedeploymentEnabled;
   
   [JsonProperty("deploymentCountThreshold")]
   protected long? _deploymentCountThreshold;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("jesxmonProcessRedeploymentEnabled")]
   protected bool _jesxmonProcessRedeploymentEnabled;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("logDiskUtilizationRedeploymentEnabled")]
   protected bool _logDiskUtilizationRedeploymentEnabled;
   
   [JsonProperty("logDiskUtilizationThreshold")]
   protected float _logDiskUtilizationThreshold;
   
   [JsonProperty("memoryUtilizationRedeploymentEnabled")]
   protected bool _memoryUtilizationRedeploymentEnabled;
   
   [JsonProperty("memoryUtilizationThreshold")]
   protected float _memoryUtilizationThreshold;
   
   [JsonProperty("redeploymentDelay")]
   protected long? _redeploymentDelay;
   
   [JsonProperty("rootDiskUtilizationRedeploymentEnabled")]
   protected bool _rootDiskUtilizationRedeploymentEnabled;
   
   [JsonProperty("rootDiskUtilizationThreshold")]
   protected float _rootDiskUtilizationThreshold;
   

   
   public VRSRedeploymentpolicy() {
      
   }

   
   [JsonIgnore]
   public bool NUALUbr0StatusRedeploymentEnabled {
      get {
         return _ALUbr0StatusRedeploymentEnabled;
      }
      set {
         this._ALUbr0StatusRedeploymentEnabled = value;
      }
   }

   
   [JsonIgnore]
   public bool NUCPUUtilizationRedeploymentEnabled {
      get {
         return _CPUUtilizationRedeploymentEnabled;
      }
      set {
         this._CPUUtilizationRedeploymentEnabled = value;
      }
   }

   
   [JsonIgnore]
   public float NUCPUUtilizationThreshold {
      get {
         return _CPUUtilizationThreshold;
      }
      set {
         this._CPUUtilizationThreshold = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVRSCorrectiveActionDelay {
      get {
         return _VRSCorrectiveActionDelay;
      }
      set {
         this._VRSCorrectiveActionDelay = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVRSProcessRedeploymentEnabled {
      get {
         return _VRSProcessRedeploymentEnabled;
      }
      set {
         this._VRSProcessRedeploymentEnabled = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVRSVSCStatusRedeploymentEnabled {
      get {
         return _VRSVSCStatusRedeploymentEnabled;
      }
      set {
         this._VRSVSCStatusRedeploymentEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDeploymentCountThreshold {
      get {
         return _deploymentCountThreshold;
      }
      set {
         this._deploymentCountThreshold = value;
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
   public bool NUJesxmonProcessRedeploymentEnabled {
      get {
         return _jesxmonProcessRedeploymentEnabled;
      }
      set {
         this._jesxmonProcessRedeploymentEnabled = value;
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
   public bool NULogDiskUtilizationRedeploymentEnabled {
      get {
         return _logDiskUtilizationRedeploymentEnabled;
      }
      set {
         this._logDiskUtilizationRedeploymentEnabled = value;
      }
   }

   
   [JsonIgnore]
   public float NULogDiskUtilizationThreshold {
      get {
         return _logDiskUtilizationThreshold;
      }
      set {
         this._logDiskUtilizationThreshold = value;
      }
   }

   
   [JsonIgnore]
   public bool NUMemoryUtilizationRedeploymentEnabled {
      get {
         return _memoryUtilizationRedeploymentEnabled;
      }
      set {
         this._memoryUtilizationRedeploymentEnabled = value;
      }
   }

   
   [JsonIgnore]
   public float NUMemoryUtilizationThreshold {
      get {
         return _memoryUtilizationThreshold;
      }
      set {
         this._memoryUtilizationThreshold = value;
      }
   }

   
   [JsonIgnore]
   public long? NURedeploymentDelay {
      get {
         return _redeploymentDelay;
      }
      set {
         this._redeploymentDelay = value;
      }
   }

   
   [JsonIgnore]
   public bool NURootDiskUtilizationRedeploymentEnabled {
      get {
         return _rootDiskUtilizationRedeploymentEnabled;
      }
      set {
         this._rootDiskUtilizationRedeploymentEnabled = value;
      }
   }

   
   [JsonIgnore]
   public float NURootDiskUtilizationThreshold {
      get {
         return _rootDiskUtilizationThreshold;
      }
      set {
         this._rootDiskUtilizationThreshold = value;
      }
   }

   

   

   public String toString() {
      return "VRSRedeploymentpolicy [" + "ALUbr0StatusRedeploymentEnabled=" + _ALUbr0StatusRedeploymentEnabled + ", CPUUtilizationRedeploymentEnabled=" + _CPUUtilizationRedeploymentEnabled + ", CPUUtilizationThreshold=" + _CPUUtilizationThreshold + ", VRSCorrectiveActionDelay=" + _VRSCorrectiveActionDelay + ", VRSProcessRedeploymentEnabled=" + _VRSProcessRedeploymentEnabled + ", VRSVSCStatusRedeploymentEnabled=" + _VRSVSCStatusRedeploymentEnabled + ", deploymentCountThreshold=" + _deploymentCountThreshold + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", jesxmonProcessRedeploymentEnabled=" + _jesxmonProcessRedeploymentEnabled + ", lastUpdatedBy=" + _lastUpdatedBy + ", logDiskUtilizationRedeploymentEnabled=" + _logDiskUtilizationRedeploymentEnabled + ", logDiskUtilizationThreshold=" + _logDiskUtilizationThreshold + ", memoryUtilizationRedeploymentEnabled=" + _memoryUtilizationRedeploymentEnabled + ", memoryUtilizationThreshold=" + _memoryUtilizationThreshold + ", redeploymentDelay=" + _redeploymentDelay + ", rootDiskUtilizationRedeploymentEnabled=" + _rootDiskUtilizationRedeploymentEnabled + ", rootDiskUtilizationThreshold=" + _rootDiskUtilizationThreshold + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "vrsredeploymentpolicies";
   }

   public static String getRestName()
   {
	return "vrsredeploymentpolicy";
   }
}
}