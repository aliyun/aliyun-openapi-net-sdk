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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ess.Transform;
using Aliyun.Acs.Ess.Transform.V20140828;

namespace Aliyun.Acs.Ess.Model.V20140828
{
    public class DescribeScalingInstancesRequest : RpcAcsRequest<DescribeScalingInstancesResponse>
    {
        public DescribeScalingInstancesRequest()
            : base("Ess", "2014-08-28", "DescribeScalingInstances", "ess", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string creationType;

		private string instanceId1;

		private string instanceId3;

		private string instanceId2;

		private string instanceId5;

		private string instanceId4;

		private string instanceId7;

		private string instanceId6;

		private string instanceId9;

		private string instanceId8;

		private long? ownerId;

		private string scalingConfigurationId;

		private string healthStatus;

		private string instanceId10;

		private string instanceId12;

		private string instanceId11;

		private string scalingGroupId;

		private string lifecycleState;

		private int? pageNumber;

		private int? pageSize;

		private string instanceId20;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string instanceId18;

		private string instanceId17;

		private string instanceId19;

		private string instanceId14;

		private string instanceId13;

		private string instanceId16;

		private string instanceId15;

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

		public string CreationType
		{
			get
			{
				return creationType;
			}
			set	
			{
				creationType = value;
				DictionaryUtil.Add(QueryParameters, "CreationType", value);
			}
		}

		public string InstanceId1
		{
			get
			{
				return instanceId1;
			}
			set	
			{
				instanceId1 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.1", value);
			}
		}

		public string InstanceId3
		{
			get
			{
				return instanceId3;
			}
			set	
			{
				instanceId3 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.3", value);
			}
		}

		public string InstanceId2
		{
			get
			{
				return instanceId2;
			}
			set	
			{
				instanceId2 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.2", value);
			}
		}

		public string InstanceId5
		{
			get
			{
				return instanceId5;
			}
			set	
			{
				instanceId5 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.5", value);
			}
		}

		public string InstanceId4
		{
			get
			{
				return instanceId4;
			}
			set	
			{
				instanceId4 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.4", value);
			}
		}

		public string InstanceId7
		{
			get
			{
				return instanceId7;
			}
			set	
			{
				instanceId7 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.7", value);
			}
		}

		public string InstanceId6
		{
			get
			{
				return instanceId6;
			}
			set	
			{
				instanceId6 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.6", value);
			}
		}

		public string InstanceId9
		{
			get
			{
				return instanceId9;
			}
			set	
			{
				instanceId9 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.9", value);
			}
		}

		public string InstanceId8
		{
			get
			{
				return instanceId8;
			}
			set	
			{
				instanceId8 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.8", value);
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

		public string ScalingConfigurationId
		{
			get
			{
				return scalingConfigurationId;
			}
			set	
			{
				scalingConfigurationId = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationId", value);
			}
		}

		public string HealthStatus
		{
			get
			{
				return healthStatus;
			}
			set	
			{
				healthStatus = value;
				DictionaryUtil.Add(QueryParameters, "HealthStatus", value);
			}
		}

		public string InstanceId10
		{
			get
			{
				return instanceId10;
			}
			set	
			{
				instanceId10 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.10", value);
			}
		}

		public string InstanceId12
		{
			get
			{
				return instanceId12;
			}
			set	
			{
				instanceId12 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.12", value);
			}
		}

		public string InstanceId11
		{
			get
			{
				return instanceId11;
			}
			set	
			{
				instanceId11 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.11", value);
			}
		}

		public string ScalingGroupId
		{
			get
			{
				return scalingGroupId;
			}
			set	
			{
				scalingGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId", value);
			}
		}

		public string LifecycleState
		{
			get
			{
				return lifecycleState;
			}
			set	
			{
				lifecycleState = value;
				DictionaryUtil.Add(QueryParameters, "LifecycleState", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string InstanceId20
		{
			get
			{
				return instanceId20;
			}
			set	
			{
				instanceId20 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.20", value);
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

		public string InstanceId18
		{
			get
			{
				return instanceId18;
			}
			set	
			{
				instanceId18 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.18", value);
			}
		}

		public string InstanceId17
		{
			get
			{
				return instanceId17;
			}
			set	
			{
				instanceId17 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.17", value);
			}
		}

		public string InstanceId19
		{
			get
			{
				return instanceId19;
			}
			set	
			{
				instanceId19 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.19", value);
			}
		}

		public string InstanceId14
		{
			get
			{
				return instanceId14;
			}
			set	
			{
				instanceId14 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.14", value);
			}
		}

		public string InstanceId13
		{
			get
			{
				return instanceId13;
			}
			set	
			{
				instanceId13 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.13", value);
			}
		}

		public string InstanceId16
		{
			get
			{
				return instanceId16;
			}
			set	
			{
				instanceId16 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.16", value);
			}
		}

		public string InstanceId15
		{
			get
			{
				return instanceId15;
			}
			set	
			{
				instanceId15 = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId.15", value);
			}
		}

        public override DescribeScalingInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeScalingInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
