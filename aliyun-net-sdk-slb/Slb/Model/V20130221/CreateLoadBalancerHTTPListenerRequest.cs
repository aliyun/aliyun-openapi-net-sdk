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
using Aliyun.Acs.Slb.Transform.V20130221;

namespace Aliyun.Acs.Slb.Model.V20130221
{
    public class CreateLoadBalancerHTTPListenerRequest : RpcAcsRequest<CreateLoadBalancerHTTPListenerResponse>
    {
        public CreateLoadBalancerHTTPListenerRequest()
            : base("Slb", "2013-02-21", "CreateLoadBalancerHTTPListener", "slb", "openAPI")
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

		private string hostId;

		private int? unhealthyThreshold;

		private int? healthyThreshold;

		private string scheduler;

		private string healthCheck;

		private int? cookieTimeout;

		private string stickySessionType;

		private int? listenerPort;

		private string cookie;

		private string stickySession;

		private int? bandwidth;

		private string ownerAccount;

		private string ownerId;

		private string uRI;

		private string listenerStatus;

		private string loadBalancerId;

		private int? backendServerPort;

		private string domain;

		private int? interval;

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

		public string HostId
		{
			get
			{
				return hostId;
			}
			set	
			{
				hostId = value;
				DictionaryUtil.Add(QueryParameters, "HostId", value);
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

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		public string URI
		{
			get
			{
				return uRI;
			}
			set	
			{
				uRI = value;
				DictionaryUtil.Add(QueryParameters, "URI", value);
			}
		}

		public string ListenerStatus
		{
			get
			{
				return listenerStatus;
			}
			set	
			{
				listenerStatus = value;
				DictionaryUtil.Add(QueryParameters, "ListenerStatus", value);
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

		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(QueryParameters, "Domain", value);
			}
		}

		public int? Interval
		{
			get
			{
				return interval;
			}
			set	
			{
				interval = value;
				DictionaryUtil.Add(QueryParameters, "Interval", value.ToString());
			}
		}

        public override CreateLoadBalancerHTTPListenerResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLoadBalancerHTTPListenerResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
