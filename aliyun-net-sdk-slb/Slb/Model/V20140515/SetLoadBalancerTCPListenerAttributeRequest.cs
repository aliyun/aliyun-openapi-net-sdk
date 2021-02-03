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
    public class SetLoadBalancerTCPListenerAttributeRequest : RpcAcsRequest<SetLoadBalancerTCPListenerAttributeResponse>
    {
        public SetLoadBalancerTCPListenerAttributeRequest()
            : base("Slb", "2014-05-15", "SetLoadBalancerTCPListenerAttribute", "slb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Slb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Slb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string healthCheckURI;

		private string aclStatus;

		private string aclType;

		private string masterSlaveServerGroup;

		private int? establishedTimeout;

		private int? persistenceTimeout;

		private string vServerGroupId;

		private string aclId;

		private string healthCheckDomain;

		private string synProxy;

		private long? ownerId;

		private string loadBalancerId;

		private string masterSlaveServerGroupId;

		private int? healthCheckInterval;

		private string connectionDrain;

		private int? healthCheckConnectTimeout;

		private string description;

		private int? unhealthyThreshold;

		private int? healthyThreshold;

		private string scheduler;

		private int? listenerPort;

		private string healthCheckType;

		private string resourceOwnerAccount;

		private int? bandwidth;

		private string ownerAccount;

		private int? connectionDrainTimeout;

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

		public string MasterSlaveServerGroup
		{
			get
			{
				return masterSlaveServerGroup;
			}
			set	
			{
				masterSlaveServerGroup = value;
				DictionaryUtil.Add(QueryParameters, "MasterSlaveServerGroup", value);
			}
		}

		public int? EstablishedTimeout
		{
			get
			{
				return establishedTimeout;
			}
			set	
			{
				establishedTimeout = value;
				DictionaryUtil.Add(QueryParameters, "EstablishedTimeout", value.ToString());
			}
		}

		public int? PersistenceTimeout
		{
			get
			{
				return persistenceTimeout;
			}
			set	
			{
				persistenceTimeout = value;
				DictionaryUtil.Add(QueryParameters, "PersistenceTimeout", value.ToString());
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

		public string SynProxy
		{
			get
			{
				return synProxy;
			}
			set	
			{
				synProxy = value;
				DictionaryUtil.Add(QueryParameters, "SynProxy", value);
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

		public string MasterSlaveServerGroupId
		{
			get
			{
				return masterSlaveServerGroupId;
			}
			set	
			{
				masterSlaveServerGroupId = value;
				DictionaryUtil.Add(QueryParameters, "MasterSlaveServerGroupId", value);
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

		public string ConnectionDrain
		{
			get
			{
				return connectionDrain;
			}
			set	
			{
				connectionDrain = value;
				DictionaryUtil.Add(QueryParameters, "ConnectionDrain", value);
			}
		}

		public int? HealthCheckConnectTimeout
		{
			get
			{
				return healthCheckConnectTimeout;
			}
			set	
			{
				healthCheckConnectTimeout = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckConnectTimeout", value.ToString());
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

		public string HealthCheckType
		{
			get
			{
				return healthCheckType;
			}
			set	
			{
				healthCheckType = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckType", value);
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

		public int? ConnectionDrainTimeout
		{
			get
			{
				return connectionDrainTimeout;
			}
			set	
			{
				connectionDrainTimeout = value;
				DictionaryUtil.Add(QueryParameters, "ConnectionDrainTimeout", value.ToString());
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

        public override SetLoadBalancerTCPListenerAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetLoadBalancerTCPListenerAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
