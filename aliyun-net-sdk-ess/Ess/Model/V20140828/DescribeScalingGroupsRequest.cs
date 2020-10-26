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
    public class DescribeScalingGroupsRequest : RpcAcsRequest<DescribeScalingGroupsResponse>
    {
        public DescribeScalingGroupsRequest()
            : base("Ess", "2014-08-28", "DescribeScalingGroups", "ess", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string scalingGroupId10;

		private string scalingGroupId12;

		private string scalingGroupId13;

		private string scalingGroupId14;

		private string scalingGroupId15;

		private long? ownerId;

		private int? pageNumber;

		private int? pageSize;

		private string scalingGroupName20;

		private string scalingGroupName19;

		private string scalingGroupId20;

		private string scalingGroupName18;

		private string scalingGroupName17;

		private string scalingGroupName16;

		private string resourceOwnerAccount;

		private string scalingGroupName;

		private string ownerAccount;

		private string scalingGroupName1;

		private string scalingGroupName2;

		private string scalingGroupId2;

		private string scalingGroupId1;

		private string scalingGroupId6;

		private string scalingGroupId16;

		private string scalingGroupName7;

		private string scalingGroupName11;

		private string scalingGroupId5;

		private string scalingGroupId17;

		private string scalingGroupName8;

		private string scalingGroupName10;

		private string scalingGroupId4;

		private string scalingGroupId18;

		private string scalingGroupName9;

		private string scalingGroupId3;

		private string scalingGroupId19;

		private string scalingGroupName3;

		private string scalingGroupName15;

		private string scalingGroupId9;

		private string scalingGroupName4;

		private string scalingGroupName14;

		private string scalingGroupId8;

		private string scalingGroupName5;

		private string scalingGroupName13;

		private string scalingGroupId7;

		private string scalingGroupName6;

		private string scalingGroupName12;

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

		public string ScalingGroupId10
		{
			get
			{
				return scalingGroupId10;
			}
			set	
			{
				scalingGroupId10 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.10", value);
			}
		}

		public string ScalingGroupId12
		{
			get
			{
				return scalingGroupId12;
			}
			set	
			{
				scalingGroupId12 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.12", value);
			}
		}

		public string ScalingGroupId13
		{
			get
			{
				return scalingGroupId13;
			}
			set	
			{
				scalingGroupId13 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.13", value);
			}
		}

		public string ScalingGroupId14
		{
			get
			{
				return scalingGroupId14;
			}
			set	
			{
				scalingGroupId14 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.14", value);
			}
		}

		public string ScalingGroupId15
		{
			get
			{
				return scalingGroupId15;
			}
			set	
			{
				scalingGroupId15 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.15", value);
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

		public string ScalingGroupName20
		{
			get
			{
				return scalingGroupName20;
			}
			set	
			{
				scalingGroupName20 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.20", value);
			}
		}

		public string ScalingGroupName19
		{
			get
			{
				return scalingGroupName19;
			}
			set	
			{
				scalingGroupName19 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.19", value);
			}
		}

		public string ScalingGroupId20
		{
			get
			{
				return scalingGroupId20;
			}
			set	
			{
				scalingGroupId20 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.20", value);
			}
		}

		public string ScalingGroupName18
		{
			get
			{
				return scalingGroupName18;
			}
			set	
			{
				scalingGroupName18 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.18", value);
			}
		}

		public string ScalingGroupName17
		{
			get
			{
				return scalingGroupName17;
			}
			set	
			{
				scalingGroupName17 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.17", value);
			}
		}

		public string ScalingGroupName16
		{
			get
			{
				return scalingGroupName16;
			}
			set	
			{
				scalingGroupName16 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.16", value);
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

		public string ScalingGroupName
		{
			get
			{
				return scalingGroupName;
			}
			set	
			{
				scalingGroupName = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName", value);
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

		public string ScalingGroupName1
		{
			get
			{
				return scalingGroupName1;
			}
			set	
			{
				scalingGroupName1 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.1", value);
			}
		}

		public string ScalingGroupName2
		{
			get
			{
				return scalingGroupName2;
			}
			set	
			{
				scalingGroupName2 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.2", value);
			}
		}

		public string ScalingGroupId2
		{
			get
			{
				return scalingGroupId2;
			}
			set	
			{
				scalingGroupId2 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.2", value);
			}
		}

		public string ScalingGroupId1
		{
			get
			{
				return scalingGroupId1;
			}
			set	
			{
				scalingGroupId1 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.1", value);
			}
		}

		public string ScalingGroupId6
		{
			get
			{
				return scalingGroupId6;
			}
			set	
			{
				scalingGroupId6 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.6", value);
			}
		}

		public string ScalingGroupId16
		{
			get
			{
				return scalingGroupId16;
			}
			set	
			{
				scalingGroupId16 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.16", value);
			}
		}

		public string ScalingGroupName7
		{
			get
			{
				return scalingGroupName7;
			}
			set	
			{
				scalingGroupName7 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.7", value);
			}
		}

		public string ScalingGroupName11
		{
			get
			{
				return scalingGroupName11;
			}
			set	
			{
				scalingGroupName11 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.11", value);
			}
		}

		public string ScalingGroupId5
		{
			get
			{
				return scalingGroupId5;
			}
			set	
			{
				scalingGroupId5 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.5", value);
			}
		}

		public string ScalingGroupId17
		{
			get
			{
				return scalingGroupId17;
			}
			set	
			{
				scalingGroupId17 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.17", value);
			}
		}

		public string ScalingGroupName8
		{
			get
			{
				return scalingGroupName8;
			}
			set	
			{
				scalingGroupName8 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.8", value);
			}
		}

		public string ScalingGroupName10
		{
			get
			{
				return scalingGroupName10;
			}
			set	
			{
				scalingGroupName10 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.10", value);
			}
		}

		public string ScalingGroupId4
		{
			get
			{
				return scalingGroupId4;
			}
			set	
			{
				scalingGroupId4 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.4", value);
			}
		}

		public string ScalingGroupId18
		{
			get
			{
				return scalingGroupId18;
			}
			set	
			{
				scalingGroupId18 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.18", value);
			}
		}

		public string ScalingGroupName9
		{
			get
			{
				return scalingGroupName9;
			}
			set	
			{
				scalingGroupName9 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.9", value);
			}
		}

		public string ScalingGroupId3
		{
			get
			{
				return scalingGroupId3;
			}
			set	
			{
				scalingGroupId3 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.3", value);
			}
		}

		public string ScalingGroupId19
		{
			get
			{
				return scalingGroupId19;
			}
			set	
			{
				scalingGroupId19 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.19", value);
			}
		}

		public string ScalingGroupName3
		{
			get
			{
				return scalingGroupName3;
			}
			set	
			{
				scalingGroupName3 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.3", value);
			}
		}

		public string ScalingGroupName15
		{
			get
			{
				return scalingGroupName15;
			}
			set	
			{
				scalingGroupName15 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.15", value);
			}
		}

		public string ScalingGroupId9
		{
			get
			{
				return scalingGroupId9;
			}
			set	
			{
				scalingGroupId9 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.9", value);
			}
		}

		public string ScalingGroupName4
		{
			get
			{
				return scalingGroupName4;
			}
			set	
			{
				scalingGroupName4 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.4", value);
			}
		}

		public string ScalingGroupName14
		{
			get
			{
				return scalingGroupName14;
			}
			set	
			{
				scalingGroupName14 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.14", value);
			}
		}

		public string ScalingGroupId8
		{
			get
			{
				return scalingGroupId8;
			}
			set	
			{
				scalingGroupId8 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.8", value);
			}
		}

		public string ScalingGroupName5
		{
			get
			{
				return scalingGroupName5;
			}
			set	
			{
				scalingGroupName5 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.5", value);
			}
		}

		public string ScalingGroupName13
		{
			get
			{
				return scalingGroupName13;
			}
			set	
			{
				scalingGroupName13 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.13", value);
			}
		}

		public string ScalingGroupId7
		{
			get
			{
				return scalingGroupId7;
			}
			set	
			{
				scalingGroupId7 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId.7", value);
			}
		}

		public string ScalingGroupName6
		{
			get
			{
				return scalingGroupName6;
			}
			set	
			{
				scalingGroupName6 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.6", value);
			}
		}

		public string ScalingGroupName12
		{
			get
			{
				return scalingGroupName12;
			}
			set	
			{
				scalingGroupName12 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName.12", value);
			}
		}

        public override DescribeScalingGroupsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeScalingGroupsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
