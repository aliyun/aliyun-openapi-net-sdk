/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Slb.Transform;
using Aliyun.Acs.Slb.Transform.V20140515;

namespace Aliyun.Acs.Slb.Model.V20140515
{
    public class SetLoadBalancerHTTPSListenerAttributeRequest : RpcAcsRequest<SetLoadBalancerHTTPSListenerAttributeResponse>
    {
        public SetLoadBalancerHTTPSListenerAttributeRequest()
            : base("Slb", "2014-05-15", "SetLoadBalancerHTTPSListenerAttribute", "slb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Slb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Slb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? healthCheckTimeout;

		private string xForwardedFor;

		private string healthCheckURI;

		private string aclStatus;

		private string aclType;

		private string healthCheck;

		private string vServerGroupId;

		private string aclId;

		private string cookie;

		private string healthCheckDomain;

		private int? requestTimeout;

		private long? ownerId;

		private string cACertificateId;

		private string loadBalancerId;

		private string xForwardedFor_SLBIP;

		private int? healthCheckInterval;

		private string xForwardedFor_SLBID;

		private string description;

		private int? unhealthyThreshold;

		private int? healthyThreshold;

		private string scheduler;

		private string enableHttp2;

		private int? cookieTimeout;

		private string stickySessionType;

		private int? listenerPort;

		private string resourceOwnerAccount;

		private int? bandwidth;

		private string stickySession;

		private string ownerAccount;

		private string gzip;

		private string tLSCipherPolicy;

		private string serverCertificateId;

		private int? idleTimeout;

		private string xForwardedFor_proto;

		private int? healthCheckConnectPort;

		private string healthCheckHttpCode;

		private string vServerGroup;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public int? HealthCheckTimeout
		{
			get
			{
				return healthCheckTimeout;
			}
			set	
			{
				healthCheckTimeout = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckTimeout", value.ToString());
			}
		}

		public string XForwardedFor
		{
			get
			{
				return xForwardedFor;
			}
			set	
			{
				xForwardedFor = value;
				DictionaryUtil.Add(QueryParameters, "XForwardedFor", value);
			}
		}

		public string HealthCheckURI
		{
			get
			{
				return healthCheckURI;
			}
			set	
			{
				healthCheckURI = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckURI", value);
			}
		}

		public string AclStatus
		{
			get
			{
				return aclStatus;
			}
			set	
			{
				aclStatus = value;
				DictionaryUtil.Add(QueryParameters, "AclStatus", value);
			}
		}

		public string AclType
		{
			get
			{
				return aclType;
			}
			set	
			{
				aclType = value;
				DictionaryUtil.Add(QueryParameters, "AclType", value);
			}
		}

		public string HealthCheck
		{
			get
			{
				return healthCheck;
			}
			set	
			{
				healthCheck = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheck", value);
			}
		}

		public string VServerGroupId
		{
			get
			{
				return vServerGroupId;
			}
			set	
			{
				vServerGroupId = value;
				DictionaryUtil.Add(QueryParameters, "VServerGroupId", value);
			}
		}

		public string AclId
		{
			get
			{
				return aclId;
			}
			set	
			{
				aclId = value;
				DictionaryUtil.Add(QueryParameters, "AclId", value);
			}
		}

		public string Cookie
		{
			get
			{
				return cookie;
			}
			set	
			{
				cookie = value;
				DictionaryUtil.Add(QueryParameters, "Cookie", value);
			}
		}

		public string HealthCheckDomain
		{
			get
			{
				return healthCheckDomain;
			}
			set	
			{
				healthCheckDomain = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckDomain", value);
			}
		}

		public int? RequestTimeout
		{
			get
			{
				return requestTimeout;
			}
			set	
			{
				requestTimeout = value;
				DictionaryUtil.Add(QueryParameters, "RequestTimeout", value.ToString());
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string CACertificateId
		{
			get
			{
				return cACertificateId;
			}
			set	
			{
				cACertificateId = value;
				DictionaryUtil.Add(QueryParameters, "CACertificateId", value);
			}
		}

		public string LoadBalancerId
		{
			get
			{
				return loadBalancerId;
			}
			set	
			{
				loadBalancerId = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerId", value);
			}
		}

		public string XForwardedFor_SLBIP
		{
			get
			{
				return xForwardedFor_SLBIP;
			}
			set	
			{
				xForwardedFor_SLBIP = value;
				DictionaryUtil.Add(QueryParameters, "XForwardedFor_SLBIP", value);
			}
		}

		public int? HealthCheckInterval
		{
			get
			{
				return healthCheckInterval;
			}
			set	
			{
				healthCheckInterval = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckInterval", value.ToString());
			}
		}

		public string XForwardedFor_SLBID
		{
			get
			{
				return xForwardedFor_SLBID;
			}
			set	
			{
				xForwardedFor_SLBID = value;
				DictionaryUtil.Add(QueryParameters, "XForwardedFor_SLBID", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public int? UnhealthyThreshold
		{
			get
			{
				return unhealthyThreshold;
			}
			set	
			{
				unhealthyThreshold = value;
				DictionaryUtil.Add(QueryParameters, "UnhealthyThreshold", value.ToString());
			}
		}

		public int? HealthyThreshold
		{
			get
			{
				return healthyThreshold;
			}
			set	
			{
				healthyThreshold = value;
				DictionaryUtil.Add(QueryParameters, "HealthyThreshold", value.ToString());
			}
		}

		public string Scheduler
		{
			get
			{
				return scheduler;
			}
			set	
			{
				scheduler = value;
				DictionaryUtil.Add(QueryParameters, "Scheduler", value);
			}
		}

		public string EnableHttp2
		{
			get
			{
				return enableHttp2;
			}
			set	
			{
				enableHttp2 = value;
				DictionaryUtil.Add(QueryParameters, "EnableHttp2", value);
			}
		}

		public int? CookieTimeout
		{
			get
			{
				return cookieTimeout;
			}
			set	
			{
				cookieTimeout = value;
				DictionaryUtil.Add(QueryParameters, "CookieTimeout", value.ToString());
			}
		}

		public string StickySessionType
		{
			get
			{
				return stickySessionType;
			}
			set	
			{
				stickySessionType = value;
				DictionaryUtil.Add(QueryParameters, "StickySessionType", value);
			}
		}

		public int? ListenerPort
		{
			get
			{
				return listenerPort;
			}
			set	
			{
				listenerPort = value;
				DictionaryUtil.Add(QueryParameters, "ListenerPort", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public int? Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
				DictionaryUtil.Add(QueryParameters, "Bandwidth", value.ToString());
			}
		}

		public string StickySession
		{
			get
			{
				return stickySession;
			}
			set	
			{
				stickySession = value;
				DictionaryUtil.Add(QueryParameters, "StickySession", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string Gzip
		{
			get
			{
				return gzip;
			}
			set	
			{
				gzip = value;
				DictionaryUtil.Add(QueryParameters, "Gzip", value);
			}
		}

		public string TLSCipherPolicy
		{
			get
			{
				return tLSCipherPolicy;
			}
			set	
			{
				tLSCipherPolicy = value;
				DictionaryUtil.Add(QueryParameters, "TLSCipherPolicy", value);
			}
		}

		public string ServerCertificateId
		{
			get
			{
				return serverCertificateId;
			}
			set	
			{
				serverCertificateId = value;
				DictionaryUtil.Add(QueryParameters, "ServerCertificateId", value);
			}
		}

		public int? IdleTimeout
		{
			get
			{
				return idleTimeout;
			}
			set	
			{
				idleTimeout = value;
				DictionaryUtil.Add(QueryParameters, "IdleTimeout", value.ToString());
			}
		}

		public string XForwardedFor_proto
		{
			get
			{
				return xForwardedFor_proto;
			}
			set	
			{
				xForwardedFor_proto = value;
				DictionaryUtil.Add(QueryParameters, "XForwardedFor_proto", value);
			}
		}

		public int? HealthCheckConnectPort
		{
			get
			{
				return healthCheckConnectPort;
			}
			set	
			{
				healthCheckConnectPort = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckConnectPort", value.ToString());
			}
		}

		public string HealthCheckHttpCode
		{
			get
			{
				return healthCheckHttpCode;
			}
			set	
			{
				healthCheckHttpCode = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckHttpCode", value);
			}
		}

		public string VServerGroup
		{
			get
			{
				return vServerGroup;
			}
			set	
			{
				vServerGroup = value;
				DictionaryUtil.Add(QueryParameters, "VServerGroup", value);
			}
		}

        public override SetLoadBalancerHTTPSListenerAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetLoadBalancerHTTPSListenerAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
