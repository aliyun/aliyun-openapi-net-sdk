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
    public class SetLoadBalancerUdpListenerAttributeRequest : RpcAcsRequest<SetLoadBalancerUdpListenerAttributeResponse>
    {
        public SetLoadBalancerUdpListenerAttributeRequest()
            : base("Slb", "2014-05-15", "SetLoadBalancerUDPListenerAttribute")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _loadBalancerId;

		private int? _listenerPort;

		private int? _bandwidth;

		private string _scheduler;

		private int? _persistenceTimeout;

		private int? _healthyThreshold;

		private int? _unhealthyThreshold;

		private int? _healthCheckConnectTimeout;

		private int? _healthCheckConnectPort;

		private int? _healthCheckInterval;

		private string _healthCheckReq;

		private string _healthCheckExp;

		private int? _maxConnection;

		private string _ownerAccount;

		private string _accessKeyID;

		private string _tags;

		private string _vServerGroup;

		private string _vServerGroupId;

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

		public int? PersistenceTimeout
		{
			get
			{
				return _persistenceTimeout;
			}
			set	
			{
				_persistenceTimeout = value;
				DictionaryUtil.Add(QueryParameters, "PersistenceTimeout", value.ToString());
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

		public int? HealthCheckConnectTimeout
		{
			get
			{
				return _healthCheckConnectTimeout;
			}
			set	
			{
				_healthCheckConnectTimeout = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckConnectTimeout", value.ToString());
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

		public string HealthCheckReq
		{
			get
			{
				return _healthCheckReq;
			}
			set	
			{
				_healthCheckReq = value;
				DictionaryUtil.Add(QueryParameters, "healthCheckReq", value);
			}
		}

		public string HealthCheckExp
		{
			get
			{
				return _healthCheckExp;
			}
			set	
			{
				_healthCheckExp = value;
				DictionaryUtil.Add(QueryParameters, "healthCheckExp", value);
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

		public string VServerGroup
		{
			get
			{
				return _vServerGroup;
			}
			set	
			{
				_vServerGroup = value;
				DictionaryUtil.Add(QueryParameters, "VServerGroup", value);
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

        public override SetLoadBalancerUdpListenerAttributeResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetLoadBalancerUdpListenerAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}