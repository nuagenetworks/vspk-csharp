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

public class Job: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum ECommand {APPLICATION_SIGNATURE_IMPORT,APPLY_POLICY_CHANGES,BATCH_CRUD_REQUEST,BEGIN_POLICY_CHANGES,CERTIFICATE_NSG_RENEW,CERTIFICATE_NSG_REVOKE,CLEAR_IPSEC_DATA,CLEAR_MAC_MOVE_ALARMS,DEPLOY,DISCARD_POLICY_CHANGES,EXPORT,FORCE_KEYSERVER_UPDATE,FORCE_KEYSERVER_UPDATE_ACK,FORCE_KEYSERVER_VSD_RESYNC,GATEWAY_AUDIT,GET_ZFB_INFO,IMPORT,KEYSERVER_NOTIFICATION_TEST,NETCONF_FORCE_DEPLOY,NETCONF_SYNC,NOTIFY_NSG_REGISTRATION,NOTIFY_NSG_REGISTRATION_ACK,NOTIFY_NSG_REGISTRATION_TEST,NSG_NOTIFICATION_TEST,NSG_REGISTRATION_INFO,REDEPLOY,REJECT_ZFB_REQUEST,RELOAD,RELOAD_GEO_REDUNDANT_INFO,RELOAD_NSG_CONFIG,RESTART,RETRIEVE_ACTIVE_NSGS,SAAS_APPLICATION_TYPE,START,STATUS,STOP,SYNC,UNDEPLOY,VCENTER_ADD_COMPUTERESOURCE_INSCOPE,VCENTER_DELETE_AGENCY,VCENTER_MARK_AGENT_VM_AVAILABLE,VCENTER_RECONNECT,VCENTER_RELOAD,VCENTER_REMOVE_COMPUTERESOURCE_INSCOPE,VCENTER_SCRIPT_UPGRADE_VRS,VCENTER_SYNC,VCENTER_UPGRADE_VRS };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EStatus {FAILED,RUNNING,SUCCESS };

   
   [JsonProperty("assocEntityType")]
   protected String _assocEntityType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("command")]
   protected ECommand? _command;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("parameters")]
   protected Object _parameters;
   
   [JsonProperty("progress")]
   protected float _progress;
   
   [JsonProperty("result")]
   protected Object _result;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("status")]
   protected EStatus? _status;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public Job() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAssocEntityType {
      get {
         return _assocEntityType;
      }
      set {
         this._assocEntityType = value;
      }
   }

   
   [JsonIgnore]
   public ECommand? NUCommand {
      get {
         return _command;
      }
      set {
         this._command = value;
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
   public Object NUParameters {
      get {
         return _parameters;
      }
      set {
         this._parameters = value;
      }
   }

   
   [JsonIgnore]
   public float NUProgress {
      get {
         return _progress;
      }
      set {
         this._progress = value;
      }
   }

   
   [JsonIgnore]
   public Object NUResult {
      get {
         return _result;
      }
      set {
         this._result = value;
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

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "Job [" + "assocEntityType=" + _assocEntityType + ", command=" + _command + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", parameters=" + _parameters + ", progress=" + _progress + ", result=" + _result + ", status=" + _status + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "jobs";
   }

   public static String getRestName()
   {
	return "job";
   }
}
}