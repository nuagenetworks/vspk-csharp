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

public class VirtualUplink: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAuxMode {COLD,HOT,NONE };
   public enum EFecEnabled {ACTIVE,DISABLED,PASSIVE };
   public enum ERole {NONE,PRIMARY,SECONDARY,TERTIARY,UNKNOWN };

   
   [JsonProperty("associatedEgressQoSPolicyID")]
   protected String _associatedEgressQoSPolicyID;
   
   [JsonProperty("associatedIngressOverlayQoSPolicerID")]
   protected String _associatedIngressOverlayQoSPolicerID;
   
   [JsonProperty("associatedIngressQoSPolicyID")]
   protected String _associatedIngressQoSPolicyID;
   
   [JsonProperty("associatedIngressUnderlayQoSPolicerID")]
   protected String _associatedIngressUnderlayQoSPolicerID;
   
   [JsonProperty("associatedUplinkConnectionID")]
   protected String _associatedUplinkConnectionID;
   
   [JsonProperty("associatedVSCProfileID")]
   protected String _associatedVSCProfileID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("auxMode")]
   protected EAuxMode? _auxMode;
   
   [JsonProperty("enableNATProbes")]
   protected bool _enableNATProbes;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("fecEnabled")]
   protected EFecEnabled? _fecEnabled;
   
   [JsonProperty("peerEndpoint")]
   protected String _peerEndpoint;
   
   [JsonProperty("peerGatewayID")]
   protected String _peerGatewayID;
   
   [JsonProperty("peerGatewayName")]
   protected String _peerGatewayName;
   
   [JsonProperty("peerGatewaySystemID")]
   protected String _peerGatewaySystemID;
   
   [JsonProperty("peerPortID")]
   protected String _peerPortID;
   
   [JsonProperty("peerUplinkID")]
   protected long? _peerUplinkID;
   
   [JsonProperty("peerVLANID")]
   protected String _peerVLANID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("role")]
   protected ERole? _role;
   
   [JsonProperty("roleOrder")]
   protected long? _roleOrder;
   
   [JsonProperty("shuntEndpoint")]
   protected String _shuntEndpoint;
   
   [JsonProperty("shuntPortID")]
   protected String _shuntPortID;
   
   [JsonProperty("shuntVLANID")]
   protected String _shuntVLANID;
   
   [JsonProperty("trafficThroughUBROnly")]
   protected bool _trafficThroughUBROnly;
   
   [JsonProperty("underlayID")]
   protected long? _underlayID;
   
   [JsonProperty("underlayNAT")]
   protected bool _underlayNAT;
   
   [JsonProperty("underlayName")]
   protected String _underlayName;
   
   [JsonProperty("underlayRouting")]
   protected bool _underlayRouting;
   
   [JsonProperty("virtualUplinkDatapathID")]
   protected String _virtualUplinkDatapathID;
   

   
   [JsonIgnore]
   private IKEGatewayConnectionsFetcher _iKEGatewayConnections;
   
   public VirtualUplink() {
      
      _iKEGatewayConnections = new IKEGatewayConnectionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAssociatedEgressQoSPolicyID {
      get {
         return _associatedEgressQoSPolicyID;
      }
      set {
         this._associatedEgressQoSPolicyID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIngressOverlayQoSPolicerID {
      get {
         return _associatedIngressOverlayQoSPolicerID;
      }
      set {
         this._associatedIngressOverlayQoSPolicerID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIngressQoSPolicyID {
      get {
         return _associatedIngressQoSPolicyID;
      }
      set {
         this._associatedIngressQoSPolicyID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIngressUnderlayQoSPolicerID {
      get {
         return _associatedIngressUnderlayQoSPolicerID;
      }
      set {
         this._associatedIngressUnderlayQoSPolicerID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedUplinkConnectionID {
      get {
         return _associatedUplinkConnectionID;
      }
      set {
         this._associatedUplinkConnectionID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedVSCProfileID {
      get {
         return _associatedVSCProfileID;
      }
      set {
         this._associatedVSCProfileID = value;
      }
   }

   
   [JsonIgnore]
   public EAuxMode? NUAuxMode {
      get {
         return _auxMode;
      }
      set {
         this._auxMode = value;
      }
   }

   
   [JsonIgnore]
   public bool NUEnableNATProbes {
      get {
         return _enableNATProbes;
      }
      set {
         this._enableNATProbes = value;
      }
   }

   
   [JsonIgnore]
   public EFecEnabled? NUFecEnabled {
      get {
         return _fecEnabled;
      }
      set {
         this._fecEnabled = value;
      }
   }

   
   [JsonIgnore]
   public String NUPeerEndpoint {
      get {
         return _peerEndpoint;
      }
      set {
         this._peerEndpoint = value;
      }
   }

   
   [JsonIgnore]
   public String NUPeerGatewayID {
      get {
         return _peerGatewayID;
      }
      set {
         this._peerGatewayID = value;
      }
   }

   
   [JsonIgnore]
   public String NUPeerGatewayName {
      get {
         return _peerGatewayName;
      }
      set {
         this._peerGatewayName = value;
      }
   }

   
   [JsonIgnore]
   public String NUPeerGatewaySystemID {
      get {
         return _peerGatewaySystemID;
      }
      set {
         this._peerGatewaySystemID = value;
      }
   }

   
   [JsonIgnore]
   public String NUPeerPortID {
      get {
         return _peerPortID;
      }
      set {
         this._peerPortID = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPeerUplinkID {
      get {
         return _peerUplinkID;
      }
      set {
         this._peerUplinkID = value;
      }
   }

   
   [JsonIgnore]
   public String NUPeerVLANID {
      get {
         return _peerVLANID;
      }
      set {
         this._peerVLANID = value;
      }
   }

   
   [JsonIgnore]
   public ERole? NURole {
      get {
         return _role;
      }
      set {
         this._role = value;
      }
   }

   
   [JsonIgnore]
   public long? NURoleOrder {
      get {
         return _roleOrder;
      }
      set {
         this._roleOrder = value;
      }
   }

   
   [JsonIgnore]
   public String NUShuntEndpoint {
      get {
         return _shuntEndpoint;
      }
      set {
         this._shuntEndpoint = value;
      }
   }

   
   [JsonIgnore]
   public String NUShuntPortID {
      get {
         return _shuntPortID;
      }
      set {
         this._shuntPortID = value;
      }
   }

   
   [JsonIgnore]
   public String NUShuntVLANID {
      get {
         return _shuntVLANID;
      }
      set {
         this._shuntVLANID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUTrafficThroughUBROnly {
      get {
         return _trafficThroughUBROnly;
      }
      set {
         this._trafficThroughUBROnly = value;
      }
   }

   
   [JsonIgnore]
   public long? NUUnderlayID {
      get {
         return _underlayID;
      }
      set {
         this._underlayID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUUnderlayNAT {
      get {
         return _underlayNAT;
      }
      set {
         this._underlayNAT = value;
      }
   }

   
   [JsonIgnore]
   public String NUUnderlayName {
      get {
         return _underlayName;
      }
      set {
         this._underlayName = value;
      }
   }

   
   [JsonIgnore]
   public bool NUUnderlayRouting {
      get {
         return _underlayRouting;
      }
      set {
         this._underlayRouting = value;
      }
   }

   
   [JsonIgnore]
   public String NUVirtualUplinkDatapathID {
      get {
         return _virtualUplinkDatapathID;
      }
      set {
         this._virtualUplinkDatapathID = value;
      }
   }

   

   
   public IKEGatewayConnectionsFetcher getIKEGatewayConnections() {
      return _iKEGatewayConnections;
   }
   

   public String toString() {
      return "VirtualUplink [" + "associatedEgressQoSPolicyID=" + _associatedEgressQoSPolicyID + ", associatedIngressOverlayQoSPolicerID=" + _associatedIngressOverlayQoSPolicerID + ", associatedIngressQoSPolicyID=" + _associatedIngressQoSPolicyID + ", associatedIngressUnderlayQoSPolicerID=" + _associatedIngressUnderlayQoSPolicerID + ", associatedUplinkConnectionID=" + _associatedUplinkConnectionID + ", associatedVSCProfileID=" + _associatedVSCProfileID + ", auxMode=" + _auxMode + ", enableNATProbes=" + _enableNATProbes + ", fecEnabled=" + _fecEnabled + ", peerEndpoint=" + _peerEndpoint + ", peerGatewayID=" + _peerGatewayID + ", peerGatewayName=" + _peerGatewayName + ", peerGatewaySystemID=" + _peerGatewaySystemID + ", peerPortID=" + _peerPortID + ", peerUplinkID=" + _peerUplinkID + ", peerVLANID=" + _peerVLANID + ", role=" + _role + ", roleOrder=" + _roleOrder + ", shuntEndpoint=" + _shuntEndpoint + ", shuntPortID=" + _shuntPortID + ", shuntVLANID=" + _shuntVLANID + ", trafficThroughUBROnly=" + _trafficThroughUBROnly + ", underlayID=" + _underlayID + ", underlayNAT=" + _underlayNAT + ", underlayName=" + _underlayName + ", underlayRouting=" + _underlayRouting + ", virtualUplinkDatapathID=" + _virtualUplinkDatapathID + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "virtualuplinks";
   }

   public static String getRestName()
   {
	return "virtualuplink";
   }
}
}