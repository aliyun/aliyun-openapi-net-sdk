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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Slb.Transform.V20140515;

namespace Aliyun.Acs.Slb.Model.V20140515
{
    public class CreateLoadBalancerHttpsListenerRequest : RpcAcsRequest<CreateLoadBalancerHttpsListenerResponse>
    {
        public CreateLoadBalancerHttpsListenerRequest()
            : base("Slb", "2014-05-15", "CreateLoadBalancerHTTPSListener")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _loadBalancerId;

		private int? _bandwidth;

		private int? _listenerPort;

		private int? _backendServerPort;

		private string _xForwardedFor;

		private string _scheduler;

		private string _stickySession;

		private string _stickySessionType;

		private int? _cookieTimeout;

		private string _cookie;

		private string _healthCheck;

		private string _healthCheckDomain;

		private string _healthCheckUri;

		private int? _healthyThreshold;

		private int? _unhealthyThreshold;

		private int? _healthCheckTimeout;

		private int? _healthCheckConnectPort;

		private int? _healthCheckInterval;

		private string _healthCheckHttpCode;

		private string _serverCertificateId;

		private int? _maxConnection;

		private string _ownerAccount;

		private string _accessKeyID;

		private string _vServerGroupId;

		private string _cACertificateId;

		private string _tags;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string LoadBalancerId
		{
			get
			{
				return _loadBalancerId;
			}
			set	
			{
				_loadBalancerId = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerId", value);
			}
		}

		public int? Bandwidth
		{
			get
			{
				return _bandwidth;
			}
			set	
			{
				_bandwidth = value;
				DictionaryUtil.Add(QueryParameters, "Bandwidth", value.ToString());
			}
		}

		public int? ListenerPort
		{
			get
			{
				return _listenerPort;
			}
			set	
			{
				_listenerPort = value;
				DictionaryUtil.Add(QueryParameters, "ListenerPort", value.ToString());
			}
		}

		public int? BackendServerPort
		{
			get
			{
				return _backendServerPort;
			}
			set	
			{
				_backendServerPort = value;
				DictionaryUtil.Add(QueryParameters, "BackendServerPort", value.ToString());
			}
		}

		public string XForwardedFor
		{
			get
			{
				return _xForwardedFor;
			}
			set	
			{
				_xForwardedFor = value;
				DictionaryUtil.Add(QueryParameters, "XForwardedFor", value);
			}
		}

		public string Scheduler
		{
			get
			{
				return _scheduler;
			}
			set	
			{
				_scheduler = value;
				DictionaryUtil.Add(QueryParameters, "Scheduler", value);
			}
		}

		public string StickySession
		{
			get
			{
				return _stickySession;
			}
			set	
			{
				_stickySession = value;
				DictionaryUtil.Add(QueryParameters, "StickySession", value);
			}
		}

		public string StickySessionType
		{
			get
			{
				return _stickySessionType;
			}
			set	
			{
				_stickySessionType = value;
				DictionaryUtil.Add(QueryParameters, "StickySessionType", value);
			}
		}

		public int? CookieTimeout
		{
			get
			{
				return _cookieTimeout;
			}
			set	
			{
				_cookieTimeout = value;
				DictionaryUtil.Add(QueryParameters, "CookieTimeout", value.ToString());
			}
		}

		public string Cookie
		{
			get
			{
				return _cookie;
			}
			set	
			{
				_cookie = value;
				DictionaryUtil.Add(QueryParameters, "Cookie", value);
			}
		}

		public string HealthCheck
		{
			get
			{
				return _healthCheck;
			}
			set	
			{
				_healthCheck = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheck", value);
			}
		}

		public string HealthCheckDomain
		{
			get
			{
				return _healthCheckDomain;
			}
			set	
			{
				_healthCheckDomain = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckDomain", value);
			}
		}

		public string HealthCheckUri
		{
			get
			{
				return _healthCheckUri;
			}
			set	
			{
				_healthCheckUri = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckURI", value);
			}
		}

		public int? HealthyThreshold
		{
			get
			{
				return _healthyThreshold;
			}
			set	
			{
				_healthyThreshold = value;
				DictionaryUtil.Add(QueryParameters, "HealthyThreshold", value.ToString());
			}
		}

		public int? UnhealthyThreshold
		{
			get
			{
				return _unhealthyThreshold;
			}
			set	
			{
				_unhealthyThreshold = value;
				DictionaryUtil.Add(QueryParameters, "UnhealthyThreshold", value.ToString());
			}
		}

		public int? HealthCheckTimeout
		{
			get
			{
				return _healthCheckTimeout;
			}
			set	
			{
				_healthCheckTimeout = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckTimeout", value.ToString());
			}
		}

		public int? HealthCheckConnectPort
		{
			get
			{
				return _healthCheckConnectPort;
			}
			set	
			{
				_healthCheckConnectPort = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckConnectPort", value.ToString());
			}
		}

		public int? HealthCheckInterval
		{
			get
			{
				return _healthCheckInterval;
			}
			set	
			{
				_healthCheckInterval = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckInterval", value.ToString());
			}
		}

		public string HealthCheckHttpCode
		{
			get
			{
				return _healthCheckHttpCode;
			}
			set	
			{
				_healthCheckHttpCode = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckHttpCode", value);
			}
		}

		public string ServerCertificateId
		{
			get
			{
				return _serverCertificateId;
			}
			set	
			{
				_serverCertificateId = value;
				DictionaryUtil.Add(QueryParameters, "ServerCertificateId", value);
			}
		}

		public int? MaxConnection
		{
			get
			{
				return _maxConnection;
			}
			set	
			{
				_maxConnection = value;
				DictionaryUtil.Add(QueryParameters, "MaxConnection", value.ToString());
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string AccessKeyID
		{
			get
			{
				return _accessKeyID;
			}
			set	
			{
				_accessKeyID = value;
				DictionaryUtil.Add(QueryParameters, "access_key_id", value);
			}
		}

		public string VServerGroupId
		{
			get
			{
				return _vServerGroupId;
			}
			set	
			{
				_vServerGroupId = value;
				DictionaryUtil.Add(QueryParameters, "VServerGroupId", value);
			}
		}

		public string CaCertificateId
		{
			get
			{
				return _cACertificateId;
			}
			set	
			{
				_cACertificateId = value;
				DictionaryUtil.Add(QueryParameters, "CACertificateId", value);
			}
		}

		public string Tags
		{
			get
			{
				return _tags;
			}
			set	
			{
				_tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
			}
		}

        public override CreateLoadBalancerHttpsListenerResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateLoadBalancerHttpsListenerResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}