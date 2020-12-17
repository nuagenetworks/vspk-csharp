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

public class GNMISession: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EGatewayVendor {CISCO,NOKIA };
   public enum EStatus {CONNECTED,DISCONNECTED };
   public enum ESubscriptionState {COMPLETED,FAILED,INIT,IN_PROGRESS };

   
   [JsonProperty("associatedGatewayID")]
   protected String _associatedGatewayID;
   
   [JsonProperty("associatedGatewayName")]
   protected String _associatedGatewayName;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("gatewayModel")]
   protected String _gatewayModel;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("gatewayVendor")]
   protected EGatewayVendor? _gatewayVendor;
   
   [JsonProperty("gatewayVersion")]
   protected String _gatewayVersion;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("owner")]
   protected String _owner;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("status")]
   protected EStatus? _status;
   
   [JsonProperty("subscriptionError")]
   protected String _subscriptionError;
   
   [JsonProperty("subscriptionFailureReason")]
   protected String _subscriptionFailureReason;
   
   [JsonProperty("subscriptionFailureRetryCount")]
   protected long? _subscriptionFailureRetryCount;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("subscriptionState")]
   protected ESubscriptionState? _subscriptionState;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public GNMISession() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAssociatedGatewayID {
      get {
         return _associatedGatewayID;
      }
      set {
         this._associatedGatewayID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedGatewayName {
      get {
         return _associatedGatewayName;
      }
      set {
         this._associatedGatewayName = value;
      }
   }

   
   [JsonIgnore]
   public String NUCreationDate {
      get {
         return _creationDate;
      }
      set {
         this._creationDate = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<Metadata> NUEmbeddedMetadata {
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
   public String NUGatewayModel {
      get {
         return _gatewayModel;
      }
      set {
         this._gatewayModel = value;
      }
   }

   
   [JsonIgnore]
   public EGatewayVendor? NUGatewayVendor {
      get {
         return _gatewayVendor;
      }
      set {
         this._gatewayVendor = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayVersion {
      get {
         return _gatewayVersion;
      }
      set {
         this._gatewayVersion = value;
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
   public String NULastUpdatedDate {
      get {
         return _lastUpdatedDate;
      }
      set {
         this._lastUpdatedDate = value;
      }
   }

   
   [JsonIgnore]
   public String NUOwner {
      get {
         return _owner;
      }
      set {
         this._owner = value;
      }
   }

   
   [JsonIgnore]
   public EStatus? NUStatus {
      get {
         return _status;
      }
      set {
         this._status = value;
      }
   }

   
   [JsonIgnore]
   public String NUSubscriptionError {
      get {
         return _subscriptionError;
      }
      set {
         this._subscriptionError = value;
      }
   }

   
   [JsonIgnore]
   public String NUSubscriptionFailureReason {
      get {
         return _subscriptionFailureReason;
      }
      set {
         this._subscriptionFailureReason = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSubscriptionFailureRetryCount {
      get {
         return _subscriptionFailureRetryCount;
      }
      set {
         this._subscriptionFailureRetryCount = value;
      }
   }

   
   [JsonIgnore]
   public ESubscriptionState? NUSubscriptionState {
      get {
         return _subscriptionState;
      }
      set {
         this._subscriptionState = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "GNMISession [" + "associatedGatewayID=" + _associatedGatewayID + ", associatedGatewayName=" + _associatedGatewayName + ", creationDate=" + _creationDate + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", gatewayModel=" + _gatewayModel + ", gatewayVendor=" + _gatewayVendor + ", gatewayVersion=" + _gatewayVersion + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", owner=" + _owner + ", status=" + _status + ", subscriptionError=" + _subscriptionError + ", subscriptionFailureReason=" + _subscriptionFailureReason + ", subscriptionFailureRetryCount=" + _subscriptionFailureRetryCount + ", subscriptionState=" + _subscriptionState + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "gnmisessions";
   }

   public static String getRestName()
   {
	return "gnmisession";
   }
}
}