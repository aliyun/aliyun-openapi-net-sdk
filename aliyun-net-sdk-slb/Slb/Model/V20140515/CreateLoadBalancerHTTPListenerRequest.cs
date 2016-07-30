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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Slb.Transform;
using Aliyun.Acs.Slb.Transform.V20140515;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Model.V20140515
{
    public class CreateLoadBalancerHTTPListenerRequest : RpcAcsRequest<CreateLoadBalancerHTTPListenerResponse>
    {
        public CreateLoadBalancerHTTPListenerRequest()
            : base("Slb", "2014-05-15", "CreateLoadBalancerHTTPListener")
        {
        }

		private long? ownerId;

		private string resourceOwnerAccount;

		private long? resourceOwnerId;

		private string loadBalancerId;

		private int? bandwidth;

		private int? listenerPort;

		private int? backendServerPort;

		private string xForwardedFor;

		private string scheduler;

		private string stickySession;

		private string stickySessionType;

		private int? cookieTimeout;

		private string cookie;

		private string healthCheck;

		private string healthCheckDomain;

		private string healthCheckURI;

		private int? healthyThreshold;

		private int? unhealthyThreshold;

		private int? healthCheckTimeout;

		private int? healthCheckConnectPort;

		private int? healthCheckInterval;

		private string healthCheckHttpCode;

		private int? maxConnection;

		private string ownerAccount;

		private string access_key_id;

		private string vServerGroupId;

		private string tags;

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

		public int? BackendServerPort
		{
			get
			{
				return backendServerPort;
			}
			set	
			{
				backendServerPort = value;
				DictionaryUtil.Add(QueryParameters, "BackendServerPort", value.ToString());
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

		public int? MaxConnection
		{
			get
			{
				return maxConnection;
			}
			set	
			{
				maxConnection = value;
				DictionaryUtil.Add(QueryParameters, "MaxConnection", value.ToString());
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

		public string Access_key_id
		{
			get
			{
				return access_key_id;
			}
			set	
			{
				access_key_id = value;
				DictionaryUtil.Add(QueryParameters, "access_key_id", value);
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

		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
			}
		}

        public override CreateLoadBalancerHTTPListenerResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateLoadBalancerHTTPListenerResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}