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

using net.nuagenetworks.vspk.v6.fetchers;

namespace net.nuagenetworks.vspk.v6
{

public class QOS: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EServiceClass {A,B,C,D,E,F,G,H,NONE };

   
   [JsonProperty("BUMCommittedBurstSize")]
   protected String _BUMCommittedBurstSize;
   
   [JsonProperty("BUMCommittedInformationRate")]
   protected String _BUMCommittedInformationRate;
   
   [JsonProperty("BUMPeakBurstSize")]
   protected String _BUMPeakBurstSize;
   
   [JsonProperty("BUMPeakInformationRate")]
   protected String _BUMPeakInformationRate;
   
   [JsonProperty("BUMRateLimitingActive")]
   protected bool _BUMRateLimitingActive;
   
   [JsonProperty("EgressFIPCommittedBurstSize")]
   protected String _EgressFIPCommittedBurstSize;
   
   [JsonProperty("EgressFIPCommittedInformationRate")]
   protected String _EgressFIPCommittedInformationRate;
   
   [JsonProperty("EgressFIPPeakBurstSize")]
   protected String _EgressFIPPeakBurstSize;
   
   [JsonProperty("EgressFIPPeakInformationRate")]
   protected String _EgressFIPPeakInformationRate;
   
   [JsonProperty("FIPCommittedBurstSize")]
   protected String _FIPCommittedBurstSize;
   
   [JsonProperty("FIPCommittedInformationRate")]
   protected String _FIPCommittedInformationRate;
   
   [JsonProperty("FIPPeakBurstSize")]
   protected String _FIPPeakBurstSize;
   
   [JsonProperty("FIPPeakInformationRate")]
   protected String _FIPPeakInformationRate;
   
   [JsonProperty("FIPRateLimitingActive")]
   protected bool _FIPRateLimitingActive;
   
   [JsonProperty("active")]
   protected bool _active;
   
   [JsonProperty("assocQosId")]
   protected String _assocQosId;
   
   [JsonProperty("associatedDSCPForwardingClassTableID")]
   protected String _associatedDSCPForwardingClassTableID;
   
   [JsonProperty("associatedDSCPForwardingClassTableName")]
   protected String _associatedDSCPForwardingClassTableName;
   
   [JsonProperty("burst")]
   protected String _burst;
   
   [JsonProperty("committedBurstSize")]
   protected String _committedBurstSize;
   
   [JsonProperty("committedInformationRate")]
   protected String _committedInformationRate;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("peak")]
   protected String _peak;
   
   [JsonProperty("rateLimitingActive")]
   protected bool _rateLimitingActive;
   
   [JsonProperty("rewriteForwardingClass")]
   protected bool _rewriteForwardingClass;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("serviceClass")]
   protected EServiceClass? _serviceClass;
   
   [JsonProperty("trustedForwardingClass")]
   protected bool _trustedForwardingClass;
   

   
   [JsonIgnore]
   private ContainersFetcher _containers;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private VMsFetcher _vMs;
   
   public QOS() {
      
      _containers = new ContainersFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _vMs = new VMsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUBUMCommittedBurstSize {
      get {
         return _BUMCommittedBurstSize;
      }
      set {
         this._BUMCommittedBurstSize = value;
      }
   }

   
   [JsonIgnore]
   public String NUBUMCommittedInformationRate {
      get {
         return _BUMCommittedInformationRate;
      }
      set {
         this._BUMCommittedInformationRate = value;
      }
   }

   
   [JsonIgnore]
   public String NUBUMPeakBurstSize {
      get {
         return _BUMPeakBurstSize;
      }
      set {
         this._BUMPeakBurstSize = value;
      }
   }

   
   [JsonIgnore]
   public String NUBUMPeakInformationRate {
      get {
         return _BUMPeakInformationRate;
      }
      set {
         this._BUMPeakInformationRate = value;
      }
   }

   
   [JsonIgnore]
   public bool NUBUMRateLimitingActive {
      get {
         return _BUMRateLimitingActive;
      }
      set {
         this._BUMRateLimitingActive = value;
      }
   }

   
   [JsonIgnore]
   public String NUEgressFIPCommittedBurstSize {
      get {
         return _EgressFIPCommittedBurstSize;
      }
      set {
         this._EgressFIPCommittedBurstSize = value;
      }
   }

   
   [JsonIgnore]
   public String NUEgressFIPCommittedInformationRate {
      get {
         return _EgressFIPCommittedInformationRate;
      }
      set {
         this._EgressFIPCommittedInformationRate = value;
      }
   }

   
   [JsonIgnore]
   public String NUEgressFIPPeakBurstSize {
      get {
         return _EgressFIPPeakBurstSize;
      }
      set {
         this._EgressFIPPeakBurstSize = value;
      }
   }

   
   [JsonIgnore]
   public String NUEgressFIPPeakInformationRate {
      get {
         return _EgressFIPPeakInformationRate;
      }
      set {
         this._EgressFIPPeakInformationRate = value;
      }
   }

   
   [JsonIgnore]
   public String NUFIPCommittedBurstSize {
      get {
         return _FIPCommittedBurstSize;
      }
      set {
         this._FIPCommittedBurstSize = value;
      }
   }

   
   [JsonIgnore]
   public String NUFIPCommittedInformationRate {
      get {
         return _FIPCommittedInformationRate;
      }
      set {
         this._FIPCommittedInformationRate = value;
      }
   }

   
   [JsonIgnore]
   public String NUFIPPeakBurstSize {
      get {
         return _FIPPeakBurstSize;
      }
      set {
         this._FIPPeakBurstSize = value;
      }
   }

   
   [JsonIgnore]
   public String NUFIPPeakInformationRate {
      get {
         return _FIPPeakInformationRate;
      }
      set {
         this._FIPPeakInformationRate = value;
      }
   }

   
   [JsonIgnore]
   public bool NUFIPRateLimitingActive {
      get {
         return _FIPRateLimitingActive;
      }
      set {
         this._FIPRateLimitingActive = value;
      }
   }

   
   [JsonIgnore]
   public bool NUActive {
      get {
         return _active;
      }
      set {
         this._active = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssocQosId {
      get {
         return _assocQosId;
      }
      set {
         this._assocQosId = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedDSCPForwardingClassTableID {
      get {
         return _associatedDSCPForwardingClassTableID;
      }
      set {
         this._associatedDSCPForwardingClassTableID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedDSCPForwardingClassTableName {
      get {
         return _associatedDSCPForwardingClassTableName;
      }
      set {
         this._associatedDSCPForwardingClassTableName = value;
      }
   }

   
   [JsonIgnore]
   public String NUBurst {
      get {
         return _burst;
      }
      set {
         this._burst = value;
      }
   }

   
   [JsonIgnore]
   public String NUCommittedBurstSize {
      get {
         return _committedBurstSize;
      }
      set {
         this._committedBurstSize = value;
      }
   }

   
   [JsonIgnore]
   public String NUCommittedInformationRate {
      get {
         return _committedInformationRate;
      }
      set {
         this._committedInformationRate = value;
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
   public System.Collections.Generic.List<String> NUEmbeddedMetadata {
      get {
         return _embeddedMetadata;
      }
      set {
         this._embeddedMetadata = value;
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
   public String NUPeak {
      get {
         return _peak;
      }
      set {
         this._peak = value;
      }
   }

   
   [JsonIgnore]
   public bool NURateLimitingActive {
      get {
         return _rateLimitingActive;
      }
      set {
         this._rateLimitingActive = value;
      }
   }

   
   [JsonIgnore]
   public bool NURewriteForwardingClass {
      get {
         return _rewriteForwardingClass;
      }
      set {
         this._rewriteForwardingClass = value;
      }
   }

   
   [JsonIgnore]
   public EServiceClass? NUServiceClass {
      get {
         return _serviceClass;
      }
      set {
         this._serviceClass = value;
      }
   }

   
   [JsonIgnore]
   public bool NUTrustedForwardingClass {
      get {
         return _trustedForwardingClass;
      }
      set {
         this._trustedForwardingClass = value;
      }
   }

   

   
   public ContainersFetcher getContainers() {
      return _containers;
   }
   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public VMsFetcher getVMs() {
      return _vMs;
   }
   

   public String toString() {
      return "QOS [" + "BUMCommittedBurstSize=" + _BUMCommittedBurstSize + ", BUMCommittedInformationRate=" + _BUMCommittedInformationRate + ", BUMPeakBurstSize=" + _BUMPeakBurstSize + ", BUMPeakInformationRate=" + _BUMPeakInformationRate + ", BUMRateLimitingActive=" + _BUMRateLimitingActive + ", EgressFIPCommittedBurstSize=" + _EgressFIPCommittedBurstSize + ", EgressFIPCommittedInformationRate=" + _EgressFIPCommittedInformationRate + ", EgressFIPPeakBurstSize=" + _EgressFIPPeakBurstSize + ", EgressFIPPeakInformationRate=" + _EgressFIPPeakInformationRate + ", FIPCommittedBurstSize=" + _FIPCommittedBurstSize + ", FIPCommittedInformationRate=" + _FIPCommittedInformationRate + ", FIPPeakBurstSize=" + _FIPPeakBurstSize + ", FIPPeakInformationRate=" + _FIPPeakInformationRate + ", FIPRateLimitingActive=" + _FIPRateLimitingActive + ", active=" + _active + ", assocQosId=" + _assocQosId + ", associatedDSCPForwardingClassTableID=" + _associatedDSCPForwardingClassTableID + ", associatedDSCPForwardingClassTableName=" + _associatedDSCPForwardingClassTableName + ", burst=" + _burst + ", committedBurstSize=" + _committedBurstSize + ", committedInformationRate=" + _committedInformationRate + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", peak=" + _peak + ", rateLimitingActive=" + _rateLimitingActive + ", rewriteForwardingClass=" + _rewriteForwardingClass + ", serviceClass=" + _serviceClass + ", trustedForwardingClass=" + _trustedForwardingClass + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "qos";
   }

   public static String getRestName()
   {
	return "qos";
   }
}
}