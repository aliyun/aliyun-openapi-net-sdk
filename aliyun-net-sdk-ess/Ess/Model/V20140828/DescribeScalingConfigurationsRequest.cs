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
    public class DescribeScalingConfigurationsRequest : RpcAcsRequest<DescribeScalingConfigurationsResponse>
    {
        public DescribeScalingConfigurationsRequest()
            : base("Ess", "2014-08-28", "DescribeScalingConfigurations", "ess", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string scalingConfigurationId6;

		private string scalingConfigurationId7;

		private long? resourceOwnerId;

		private string scalingConfigurationId4;

		private string scalingConfigurationId5;

		private string scalingGroupId;

		private string scalingConfigurationId8;

		private string scalingConfigurationId9;

		private string scalingConfigurationId10;

		private int? pageNumber;

		private string scalingConfigurationName2;

		private string scalingConfigurationName3;

		private string scalingConfigurationName1;

		private int? pageSize;

		private string scalingConfigurationId2;

		private string scalingConfigurationId3;

		private string scalingConfigurationId1;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string scalingConfigurationName6;

		private string scalingConfigurationName7;

		private string scalingConfigurationName4;

		private string scalingConfigurationName5;

		private long? ownerId;

		private string scalingConfigurationName8;

		private string scalingConfigurationName9;

		private string scalingConfigurationName10;

		public string ScalingConfigurationId6
		{
			get
			{
				return scalingConfigurationId6;
			}
			set	
			{
				scalingConfigurationId6 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationId.6", value);
			}
		}

		public string ScalingConfigurationId7
		{
			get
			{
				return scalingConfigurationId7;
			}
			set	
			{
				scalingConfigurationId7 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationId.7", value);
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

		public string ScalingConfigurationId4
		{
			get
			{
				return scalingConfigurationId4;
			}
			set	
			{
				scalingConfigurationId4 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationId.4", value);
			}
		}

		public string ScalingConfigurationId5
		{
			get
			{
				return scalingConfigurationId5;
			}
			set	
			{
				scalingConfigurationId5 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationId.5", value);
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

		public string ScalingConfigurationId8
		{
			get
			{
				return scalingConfigurationId8;
			}
			set	
			{
				scalingConfigurationId8 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationId.8", value);
			}
		}

		public string ScalingConfigurationId9
		{
			get
			{
				return scalingConfigurationId9;
			}
			set	
			{
				scalingConfigurationId9 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationId.9", value);
			}
		}

		public string ScalingConfigurationId10
		{
			get
			{
				return scalingConfigurationId10;
			}
			set	
			{
				scalingConfigurationId10 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationId.10", value);
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

		public string ScalingConfigurationName2
		{
			get
			{
				return scalingConfigurationName2;
			}
			set	
			{
				scalingConfigurationName2 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationName.2", value);
			}
		}

		public string ScalingConfigurationName3
		{
			get
			{
				return scalingConfigurationName3;
			}
			set	
			{
				scalingConfigurationName3 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationName.3", value);
			}
		}

		public string ScalingConfigurationName1
		{
			get
			{
				return scalingConfigurationName1;
			}
			set	
			{
				scalingConfigurationName1 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationName.1", value);
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

		public string ScalingConfigurationId2
		{
			get
			{
				return scalingConfigurationId2;
			}
			set	
			{
				scalingConfigurationId2 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationId.2", value);
			}
		}

		public string ScalingConfigurationId3
		{
			get
			{
				return scalingConfigurationId3;
			}
			set	
			{
				scalingConfigurationId3 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationId.3", value);
			}
		}

		public string ScalingConfigurationId1
		{
			get
			{
				return scalingConfigurationId1;
			}
			set	
			{
				scalingConfigurationId1 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationId.1", value);
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

		public string ScalingConfigurationName6
		{
			get
			{
				return scalingConfigurationName6;
			}
			set	
			{
				scalingConfigurationName6 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationName.6", value);
			}
		}

		public string ScalingConfigurationName7
		{
			get
			{
				return scalingConfigurationName7;
			}
			set	
			{
				scalingConfigurationName7 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationName.7", value);
			}
		}

		public string ScalingConfigurationName4
		{
			get
			{
				return scalingConfigurationName4;
			}
			set	
			{
				scalingConfigurationName4 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationName.4", value);
			}
		}

		public string ScalingConfigurationName5
		{
			get
			{
				return scalingConfigurationName5;
			}
			set	
			{
				scalingConfigurationName5 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationName.5", value);
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

		public string ScalingConfigurationName8
		{
			get
			{
				return scalingConfigurationName8;
			}
			set	
			{
				scalingConfigurationName8 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationName.8", value);
			}
		}

		public string ScalingConfigurationName9
		{
			get
			{
				return scalingConfigurationName9;
			}
			set	
			{
				scalingConfigurationName9 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationName.9", value);
			}
		}

		public string ScalingConfigurationName10
		{
			get
			{
				return scalingConfigurationName10;
			}
			set	
			{
				scalingConfigurationName10 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingConfigurationName.10", value);
			}
		}

        public override DescribeScalingConfigurationsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeScalingConfigurationsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
