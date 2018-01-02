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

public class VRSMetrics: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("ALUbr0Status")]
   protected bool _ALUbr0Status;
   
   [JsonProperty("CPUUtilization")]
   protected float _CPUUtilization;
   
   [JsonProperty("VRSProcess")]
   protected bool _VRSProcess;
   
   [JsonProperty("VRSVSCStatus")]
   protected bool _VRSVSCStatus;
   
   [JsonProperty("appliedMetricsPushInterval")]
   protected long? _appliedMetricsPushInterval;
   
   [JsonProperty("associatedVCenterHypervisorID")]
   protected String _associatedVCenterHypervisorID;
   
   [JsonProperty("currentVersion")]
   protected String _currentVersion;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("jesxmonProcess")]
   protected bool _jesxmonProcess;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("logDiskPartitionUtilization")]
   protected float _logDiskPartitionUtilization;
   
   [JsonProperty("memoryUtilization")]
   protected float _memoryUtilization;
   
   [JsonProperty("reDeploy")]
   protected bool _reDeploy;
   
   [JsonProperty("receivingMetrics")]
   protected bool _receivingMetrics;
   
   [JsonProperty("rootDiskPartitionUtilization")]
   protected float _rootDiskPartitionUtilization;
   

   
   public VRSMetrics() {
      
   }

   
   [JsonIgnore]
   public bool NUALUbr0Status {
      get {
         return _ALUbr0Status;
      }
      set {
         this._ALUbr0Status = value;
      }
   }

   
   [JsonIgnore]
   public float NUCPUUtilization {
      get {
         return _CPUUtilization;
      }
      set {
         this._CPUUtilization = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVRSProcess {
      get {
         return _VRSProcess;
      }
      set {
         this._VRSProcess = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVRSVSCStatus {
      get {
         return _VRSVSCStatus;
      }
      set {
         this._VRSVSCStatus = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAppliedMetricsPushInterval {
      get {
         return _appliedMetricsPushInterval;
      }
      set {
         this._appliedMetricsPushInterval = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedVCenterHypervisorID {
      get {
         return _associatedVCenterHypervisorID;
      }
      set {
         this._associatedVCenterHypervisorID = value;
      }
   }

   
   [JsonIgnore]
   public String NUCurrentVersion {
      get {
         return _currentVersion;
      }
      set {
         this._currentVersion = value;
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
   public bool NUJesxmonProcess {
      get {
         return _jesxmonProcess;
      }
      set {
         this._jesxmonProcess = value;
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
   public float NULogDiskPartitionUtilization {
      get {
         return _logDiskPartitionUtilization;
      }
      set {
         this._logDiskPartitionUtilization = value;
      }
   }

   
   [JsonIgnore]
   public float NUMemoryUtilization {
      get {
         return _memoryUtilization;
      }
      set {
         this._memoryUtilization = value;
      }
   }

   
   [JsonIgnore]
   public bool NUReDeploy {
      get {
         return _reDeploy;
      }
      set {
         this._reDeploy = value;
      }
   }

   
   [JsonIgnore]
   public bool NUReceivingMetrics {
      get {
         return _receivingMetrics;
      }
      set {
         this._receivingMetrics = value;
      }
   }

   
   [JsonIgnore]
   public float NURootDiskPartitionUtilization {
      get {
         return _rootDiskPartitionUtilization;
      }
      set {
         this._rootDiskPartitionUtilization = value;
      }
   }

   

   

   public String toString() {
      return "VRSMetrics [" + "ALUbr0Status=" + _ALUbr0Status + ", CPUUtilization=" + _CPUUtilization + ", VRSProcess=" + _VRSProcess + ", VRSVSCStatus=" + _VRSVSCStatus + ", appliedMetricsPushInterval=" + _appliedMetricsPushInterval + ", associatedVCenterHypervisorID=" + _associatedVCenterHypervisorID + ", currentVersion=" + _currentVersion + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", jesxmonProcess=" + _jesxmonProcess + ", lastUpdatedBy=" + _lastUpdatedBy + ", logDiskPartitionUtilization=" + _logDiskPartitionUtilization + ", memoryUtilization=" + _memoryUtilization + ", reDeploy=" + _reDeploy + ", receivingMetrics=" + _receivingMetrics + ", rootDiskPartitionUtilization=" + _rootDiskPartitionUtilization + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "vrsmetrics";
   }

   public static String getRestName()
   {
	return "vrsmetrics";
   }
}
}