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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ModifyAutoProvisioningGroupRequest : RpcAcsRequest<ModifyAutoProvisioningGroupResponse>
    {
        public ModifyAutoProvisioningGroupRequest()
            : base("Ecs", "2014-05-26", "ModifyAutoProvisioningGroup", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private bool? terminateInstancesWithExpiration;

		private string defaultTargetCapacityType;

		private string excessCapacityTerminationPolicy;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string autoProvisioningGroupId;

		private string payAsYouGoTargetCapacity;

		private string totalTargetCapacity;

		private string spotTargetCapacity;

		private float? maxSpotPrice;

		private string autoProvisioningGroupName;

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

		public bool? TerminateInstancesWithExpiration
		{
			get
			{
				return terminateInstancesWithExpiration;
			}
			set	
			{
				terminateInstancesWithExpiration = value;
				DictionaryUtil.Add(QueryParameters, "TerminateInstancesWithExpiration", value.ToString());
			}
		}

		public string DefaultTargetCapacityType
		{
			get
			{
				return defaultTargetCapacityType;
			}
			set	
			{
				defaultTargetCapacityType = value;
				DictionaryUtil.Add(QueryParameters, "DefaultTargetCapacityType", value);
			}
		}

		public string ExcessCapacityTerminationPolicy
		{
			get
			{
				return excessCapacityTerminationPolicy;
			}
			set	
			{
				excessCapacityTerminationPolicy = value;
				DictionaryUtil.Add(QueryParameters, "ExcessCapacityTerminationPolicy", value);
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

		public string AutoProvisioningGroupId
		{
			get
			{
				return autoProvisioningGroupId;
			}
			set	
			{
				autoProvisioningGroupId = value;
				DictionaryUtil.Add(QueryParameters, "AutoProvisioningGroupId", value);
			}
		}

		public string PayAsYouGoTargetCapacity
		{
			get
			{
				return payAsYouGoTargetCapacity;
			}
			set	
			{
				payAsYouGoTargetCapacity = value;
				DictionaryUtil.Add(QueryParameters, "PayAsYouGoTargetCapacity", value);
			}
		}

		public string TotalTargetCapacity
		{
			get
			{
				return totalTargetCapacity;
			}
			set	
			{
				totalTargetCapacity = value;
				DictionaryUtil.Add(QueryParameters, "TotalTargetCapacity", value);
			}
		}

		public string SpotTargetCapacity
		{
			get
			{
				return spotTargetCapacity;
			}
			set	
			{
				spotTargetCapacity = value;
				DictionaryUtil.Add(QueryParameters, "SpotTargetCapacity", value);
			}
		}

		public float? MaxSpotPrice
		{
			get
			{
				return maxSpotPrice;
			}
			set	
			{
				maxSpotPrice = value;
				DictionaryUtil.Add(QueryParameters, "MaxSpotPrice", value.ToString());
			}
		}

		public string AutoProvisioningGroupName
		{
			get
			{
				return autoProvisioningGroupName;
			}
			set	
			{
				autoProvisioningGroupName = value;
				DictionaryUtil.Add(QueryParameters, "AutoProvisioningGroupName", value);
			}
		}

        public override ModifyAutoProvisioningGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyAutoProvisioningGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
