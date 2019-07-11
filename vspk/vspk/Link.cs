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

public class Link: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAcceptanceCriteria {ALL,SUBNETS_ONLY };
   public enum EAssociatedDestinationType {DOMAIN };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EType {BIDIR,BORDER_ROUTER,HUB_AND_SPOKE,OVERLAY_ADDRESS_TRANSLATION,SERVICE_CHAINING };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("acceptanceCriteria")]
   protected EAcceptanceCriteria? _acceptanceCriteria;
   
   [JsonProperty("associatedDestinationID")]
   protected String _associatedDestinationID;
   
   [JsonProperty("associatedDestinationName")]
   protected String _associatedDestinationName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("associatedDestinationType")]
   protected EAssociatedDestinationType? _associatedDestinationType;
   
   [JsonProperty("associatedSourceID")]
   protected String _associatedSourceID;
   
   [JsonProperty("associatedSourceName")]
   protected String _associatedSourceName;
   
   [JsonProperty("associatedSourceType")]
   protected String _associatedSourceType;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("readOnly")]
   protected bool _readOnly;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("type")]
   protected EType? _type;
   

   
   [JsonIgnore]
   private CSNATPoolsFetcher _cSNATPools;
   
   [JsonIgnore]
   private DemarcationServicesFetcher _demarcationServices;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private NextHopsFetcher _nextHops;
   
   [JsonIgnore]
   private OverlayAddressPoolsFetcher _overlayAddressPools;
   
   [JsonIgnore]
   private PolicyStatementsFetcher _policyStatements;
   
   [JsonIgnore]
   private PSNATPoolsFetcher _pSNATPools;
   
   public Link() {
      
      _cSNATPools = new CSNATPoolsFetcher(this);
      
      _demarcationServices = new DemarcationServicesFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _nextHops = new NextHopsFetcher(this);
      
      _overlayAddressPools = new OverlayAddressPoolsFetcher(this);
      
      _policyStatements = new PolicyStatementsFetcher(this);
      
      _pSNATPools = new PSNATPoolsFetcher(this);
      
   }

   
   [JsonIgnore]
   public EAcceptanceCriteria? NUAcceptanceCriteria {
      get {
         return _acceptanceCriteria;
      }
      set {
         this._acceptanceCriteria = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedDestinationID {
      get {
         return _associatedDestinationID;
      }
      set {
         this._associatedDestinationID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedDestinationName {
      get {
         return _associatedDestinationName;
      }
      set {
         this._associatedDestinationName = value;
      }
   }

   
   [JsonIgnore]
   public EAssociatedDestinationType? NUAssociatedDestinationType {
      get {
         return _associatedDestinationType;
      }
      set {
         this._associatedDestinationType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedSourceID {
      get {
         return _associatedSourceID;
      }
      set {
         this._associatedSourceID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedSourceName {
      get {
         return _associatedSourceName;
      }
      set {
         this._associatedSourceName = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedSourceType {
      get {
         return _associatedSourceType;
      }
      set {
         this._associatedSourceType = value;
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
   public bool NUReadOnly {
      get {
         return _readOnly;
      }
      set {
         this._readOnly = value;
      }
   }

   
   [JsonIgnore]
   public EType? NUType {
      get {
         return _type;
      }
      set {
         this._type = value;
      }
   }

   

   
   public CSNATPoolsFetcher getCSNATPools() {
      return _cSNATPools;
   }
   
   public DemarcationServicesFetcher getDemarcationServices() {
      return _demarcationServices;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public NextHopsFetcher getNextHops() {
      return _nextHops;
   }
   
   public OverlayAddressPoolsFetcher getOverlayAddressPools() {
      return _overlayAddressPools;
   }
   
   public PolicyStatementsFetcher getPolicyStatements() {
      return _policyStatements;
   }
   
   public PSNATPoolsFetcher getPSNATPools() {
      return _pSNATPools;
   }
   

   public String toString() {
      return "Link [" + "acceptanceCriteria=" + _acceptanceCriteria + ", associatedDestinationID=" + _associatedDestinationID + ", associatedDestinationName=" + _associatedDestinationName + ", associatedDestinationType=" + _associatedDestinationType + ", associatedSourceID=" + _associatedSourceID + ", associatedSourceName=" + _associatedSourceName + ", associatedSourceType=" + _associatedSourceType + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", readOnly=" + _readOnly + ", type=" + _type + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "links";
   }

   public static String getRestName()
   {
	return "link";
   }
}
}