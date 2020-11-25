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
    public class ModifyDedicatedHostAttributeRequest : RpcAcsRequest<ModifyDedicatedHostAttributeResponse>
    {
        public ModifyDedicatedHostAttributeRequest()
            : base("Ecs", "2014-05-26", "ModifyDedicatedHostAttribute", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string description;

		private float? cpuOverCommitRatio;

		private string actionOnMaintenance;

		private string dedicatedHostClusterId;

		private string dedicatedHostName;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string dedicatedHostId;

		private long? ownerId;

		private int? networkAttributesSlbUdpTimeout;

		private string autoPlacement;

		private int? networkAttributesUdpTimeout;

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

		public float? CpuOverCommitRatio
		{
			get
			{
				return cpuOverCommitRatio;
			}
			set	
			{
				cpuOverCommitRatio = value;
				DictionaryUtil.Add(QueryParameters, "CpuOverCommitRatio", value.ToString());
			}
		}

		public string ActionOnMaintenance
		{
			get
			{
				return actionOnMaintenance;
			}
			set	
			{
				actionOnMaintenance = value;
				DictionaryUtil.Add(QueryParameters, "ActionOnMaintenance", value);
			}
		}

		public string DedicatedHostClusterId
		{
			get
			{
				return dedicatedHostClusterId;
			}
			set	
			{
				dedicatedHostClusterId = value;
				DictionaryUtil.Add(QueryParameters, "DedicatedHostClusterId", value);
			}
		}

		public string DedicatedHostName
		{
			get
			{
				return dedicatedHostName;
			}
			set	
			{
				dedicatedHostName = value;
				DictionaryUtil.Add(QueryParameters, "DedicatedHostName", value);
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

		public string DedicatedHostId
		{
			get
			{
				return dedicatedHostId;
			}
			set	
			{
				dedicatedHostId = value;
				DictionaryUtil.Add(QueryParameters, "DedicatedHostId", value);
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

		public int? NetworkAttributesSlbUdpTimeout
		{
			get
			{
				return networkAttributesSlbUdpTimeout;
			}
			set	
			{
				networkAttributesSlbUdpTimeout = value;
				DictionaryUtil.Add(QueryParameters, "NetworkAttributes.SlbUdpTimeout", value.ToString());
			}
		}

		public string AutoPlacement
		{
			get
			{
				return autoPlacement;
			}
			set	
			{
				autoPlacement = value;
				DictionaryUtil.Add(QueryParameters, "AutoPlacement", value);
			}
		}

		public int? NetworkAttributesUdpTimeout
		{
			get
			{
				return networkAttributesUdpTimeout;
			}
			set	
			{
				networkAttributesUdpTimeout = value;
				DictionaryUtil.Add(QueryParameters, "NetworkAttributes.UdpTimeout", value.ToString());
			}
		}

        public override ModifyDedicatedHostAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDedicatedHostAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
