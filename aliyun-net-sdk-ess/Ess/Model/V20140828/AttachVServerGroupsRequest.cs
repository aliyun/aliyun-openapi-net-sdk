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
using Aliyun.Acs.Ess.Transform;
using Aliyun.Acs.Ess.Transform.V20140828;
using System.Collections.Generic;

namespace Aliyun.Acs.Ess.Model.V20140828
{
    public class AttachVServerGroupsRequest : RpcAcsRequest<AttachVServerGroupsResponse>
    {
        public AttachVServerGroupsRequest()
            : base("Ess", "2014-08-28", "AttachVServerGroups", "ess", "openAPI")
        {
        }

		private string resourceOwnerAccount;

		private string regionId;

		private string scalingGroupId;

		private string action;

		private bool? forceAttach;

		private long? ownerId;

		private List<VServerGroup> vServerGroups;

		private string accessKeyId;

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

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public bool? ForceAttach
		{
			get
			{
				return forceAttach;
			}
			set	
			{
				forceAttach = value;
				DictionaryUtil.Add(QueryParameters, "ForceAttach", value.ToString());
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

		public List<VServerGroup> VServerGroups
		{
			get
			{
				return vServerGroups;
			}

			set
			{
				vServerGroups = value;
				for (int i = 0; i < vServerGroups.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"VServerGroup." + (i + 1) + ".LoadBalancerId", vServerGroups[i].LoadBalancerId);
					for (int j = 0; j < vServerGroups[i].VServerGroupAttributes.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"VServerGroup." + (i + 1) + ".VServerGroupAttribute." +(j + 1), vServerGroups[i].VServerGroupAttributes[j]);
					}
				}
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public class VServerGroup
		{

			private string loadBalancerId;

			private List<VServerGroupAttribute> vServerGroupAttributes;

			public string LoadBalancerId
			{
				get
				{
					return loadBalancerId;
				}
				set	
				{
					loadBalancerId = value;
				}
			}

			public List<VServerGroupAttribute> VServerGroupAttributes
			{
				get
				{
					return vServerGroupAttributes;
				}
				set	
				{
					vServerGroupAttributes = value;
				}
			}

			public class VServerGroupAttribute
			{

				private string vServerGroupId;

				private int? port;

				private int? weight;

				public string VServerGroupId
				{
					get
					{
						return vServerGroupId;
					}
					set	
					{
						vServerGroupId = value;
					}
				}

				public int? Port
				{
					get
					{
						return port;
					}
					set	
					{
						port = value;
					}
				}

				public int? Weight
				{
					get
					{
						return weight;
					}
					set	
					{
						weight = value;
					}
				}
			}
		}

        public override AttachVServerGroupsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AttachVServerGroupsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}