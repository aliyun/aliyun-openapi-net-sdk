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
    public class DescribeScalingActivitiesRequest : RpcAcsRequest<DescribeScalingActivitiesResponse>
    {
        public DescribeScalingActivitiesRequest()
            : base("Ess", "2014-08-28", "DescribeScalingActivities", "ess", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string scalingActivityId9;

		private long? resourceOwnerId;

		private string scalingActivityId5;

		private string scalingActivityId6;

		private string scalingGroupId;

		private string scalingActivityId7;

		private string scalingActivityId8;

		private string scalingActivityId1;

		private string scalingActivityId2;

		private string scalingActivityId3;

		private string scalingActivityId4;

		private int? pageNumber;

		private string statusCode;

		private int? pageSize;

		private string scalingActivityId11;

		private string scalingActivityId10;

		private string scalingActivityId13;

		private string scalingActivityId12;

		private string scalingActivityId15;

		private string scalingActivityId14;

		private string scalingActivityId17;

		private string scalingActivityId16;

		private string scalingActivityId19;

		private string resourceOwnerAccount;

		private string scalingActivityId18;

		private string ownerAccount;

		private long? ownerId;

		private string scalingActivityId20;

		public string ScalingActivityId9
		{
			get
			{
				return scalingActivityId9;
			}
			set	
			{
				scalingActivityId9 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.9", value);
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

		public string ScalingActivityId5
		{
			get
			{
				return scalingActivityId5;
			}
			set	
			{
				scalingActivityId5 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.5", value);
			}
		}

		public string ScalingActivityId6
		{
			get
			{
				return scalingActivityId6;
			}
			set	
			{
				scalingActivityId6 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.6", value);
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

		public string ScalingActivityId7
		{
			get
			{
				return scalingActivityId7;
			}
			set	
			{
				scalingActivityId7 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.7", value);
			}
		}

		public string ScalingActivityId8
		{
			get
			{
				return scalingActivityId8;
			}
			set	
			{
				scalingActivityId8 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.8", value);
			}
		}

		public string ScalingActivityId1
		{
			get
			{
				return scalingActivityId1;
			}
			set	
			{
				scalingActivityId1 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.1", value);
			}
		}

		public string ScalingActivityId2
		{
			get
			{
				return scalingActivityId2;
			}
			set	
			{
				scalingActivityId2 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.2", value);
			}
		}

		public string ScalingActivityId3
		{
			get
			{
				return scalingActivityId3;
			}
			set	
			{
				scalingActivityId3 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.3", value);
			}
		}

		public string ScalingActivityId4
		{
			get
			{
				return scalingActivityId4;
			}
			set	
			{
				scalingActivityId4 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.4", value);
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

		public string StatusCode
		{
			get
			{
				return statusCode;
			}
			set	
			{
				statusCode = value;
				DictionaryUtil.Add(QueryParameters, "StatusCode", value);
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

		public string ScalingActivityId11
		{
			get
			{
				return scalingActivityId11;
			}
			set	
			{
				scalingActivityId11 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.11", value);
			}
		}

		public string ScalingActivityId10
		{
			get
			{
				return scalingActivityId10;
			}
			set	
			{
				scalingActivityId10 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.10", value);
			}
		}

		public string ScalingActivityId13
		{
			get
			{
				return scalingActivityId13;
			}
			set	
			{
				scalingActivityId13 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.13", value);
			}
		}

		public string ScalingActivityId12
		{
			get
			{
				return scalingActivityId12;
			}
			set	
			{
				scalingActivityId12 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.12", value);
			}
		}

		public string ScalingActivityId15
		{
			get
			{
				return scalingActivityId15;
			}
			set	
			{
				scalingActivityId15 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.15", value);
			}
		}

		public string ScalingActivityId14
		{
			get
			{
				return scalingActivityId14;
			}
			set	
			{
				scalingActivityId14 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.14", value);
			}
		}

		public string ScalingActivityId17
		{
			get
			{
				return scalingActivityId17;
			}
			set	
			{
				scalingActivityId17 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.17", value);
			}
		}

		public string ScalingActivityId16
		{
			get
			{
				return scalingActivityId16;
			}
			set	
			{
				scalingActivityId16 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.16", value);
			}
		}

		public string ScalingActivityId19
		{
			get
			{
				return scalingActivityId19;
			}
			set	
			{
				scalingActivityId19 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.19", value);
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

		public string ScalingActivityId18
		{
			get
			{
				return scalingActivityId18;
			}
			set	
			{
				scalingActivityId18 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.18", value);
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

		public string ScalingActivityId20
		{
			get
			{
				return scalingActivityId20;
			}
			set	
			{
				scalingActivityId20 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActivityId.20", value);
			}
		}

        public override DescribeScalingActivitiesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeScalingActivitiesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
