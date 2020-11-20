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
    public class DescribeScalingRulesRequest : RpcAcsRequest<DescribeScalingRulesResponse>
    {
        public DescribeScalingRulesRequest()
            : base("Ess", "2014-08-28", "DescribeScalingRules", "ess", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string scalingRuleId10;

		private long? ownerId;

		private string scalingRuleAri1;

		private string scalingRuleAri2;

		private string scalingRuleAri3;

		private string scalingRuleAri4;

		private string scalingRuleAri5;

		private string scalingRuleAri6;

		private string scalingRuleAri7;

		private string scalingRuleAri8;

		private bool? showAlarmRules;

		private string scalingRuleName1;

		private string scalingRuleName2;

		private string scalingRuleName3;

		private string scalingRuleName4;

		private string scalingRuleName5;

		private string scalingGroupId;

		private string scalingRuleName6;

		private string scalingRuleName7;

		private string scalingRuleName8;

		private string scalingRuleAri9;

		private string scalingRuleName9;

		private int? pageNumber;

		private int? pageSize;

		private string scalingRuleType;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string scalingRuleName10;

		private string scalingRuleId8;

		private string scalingRuleId9;

		private string scalingRuleAri10;

		private string scalingRuleId4;

		private string scalingRuleId5;

		private string scalingRuleId6;

		private string scalingRuleId7;

		private string scalingRuleId1;

		private string scalingRuleId2;

		private string scalingRuleId3;

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

		public string ScalingRuleId10
		{
			get
			{
				return scalingRuleId10;
			}
			set	
			{
				scalingRuleId10 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleId.10", value);
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

		public string ScalingRuleAri1
		{
			get
			{
				return scalingRuleAri1;
			}
			set	
			{
				scalingRuleAri1 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleAri.1", value);
			}
		}

		public string ScalingRuleAri2
		{
			get
			{
				return scalingRuleAri2;
			}
			set	
			{
				scalingRuleAri2 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleAri.2", value);
			}
		}

		public string ScalingRuleAri3
		{
			get
			{
				return scalingRuleAri3;
			}
			set	
			{
				scalingRuleAri3 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleAri.3", value);
			}
		}

		public string ScalingRuleAri4
		{
			get
			{
				return scalingRuleAri4;
			}
			set	
			{
				scalingRuleAri4 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleAri.4", value);
			}
		}

		public string ScalingRuleAri5
		{
			get
			{
				return scalingRuleAri5;
			}
			set	
			{
				scalingRuleAri5 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleAri.5", value);
			}
		}

		public string ScalingRuleAri6
		{
			get
			{
				return scalingRuleAri6;
			}
			set	
			{
				scalingRuleAri6 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleAri.6", value);
			}
		}

		public string ScalingRuleAri7
		{
			get
			{
				return scalingRuleAri7;
			}
			set	
			{
				scalingRuleAri7 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleAri.7", value);
			}
		}

		public string ScalingRuleAri8
		{
			get
			{
				return scalingRuleAri8;
			}
			set	
			{
				scalingRuleAri8 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleAri.8", value);
			}
		}

		public bool? ShowAlarmRules
		{
			get
			{
				return showAlarmRules;
			}
			set	
			{
				showAlarmRules = value;
				DictionaryUtil.Add(QueryParameters, "ShowAlarmRules", value.ToString());
			}
		}

		public string ScalingRuleName1
		{
			get
			{
				return scalingRuleName1;
			}
			set	
			{
				scalingRuleName1 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleName.1", value);
			}
		}

		public string ScalingRuleName2
		{
			get
			{
				return scalingRuleName2;
			}
			set	
			{
				scalingRuleName2 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleName.2", value);
			}
		}

		public string ScalingRuleName3
		{
			get
			{
				return scalingRuleName3;
			}
			set	
			{
				scalingRuleName3 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleName.3", value);
			}
		}

		public string ScalingRuleName4
		{
			get
			{
				return scalingRuleName4;
			}
			set	
			{
				scalingRuleName4 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleName.4", value);
			}
		}

		public string ScalingRuleName5
		{
			get
			{
				return scalingRuleName5;
			}
			set	
			{
				scalingRuleName5 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleName.5", value);
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

		public string ScalingRuleName6
		{
			get
			{
				return scalingRuleName6;
			}
			set	
			{
				scalingRuleName6 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleName.6", value);
			}
		}

		public string ScalingRuleName7
		{
			get
			{
				return scalingRuleName7;
			}
			set	
			{
				scalingRuleName7 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleName.7", value);
			}
		}

		public string ScalingRuleName8
		{
			get
			{
				return scalingRuleName8;
			}
			set	
			{
				scalingRuleName8 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleName.8", value);
			}
		}

		public string ScalingRuleAri9
		{
			get
			{
				return scalingRuleAri9;
			}
			set	
			{
				scalingRuleAri9 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleAri.9", value);
			}
		}

		public string ScalingRuleName9
		{
			get
			{
				return scalingRuleName9;
			}
			set	
			{
				scalingRuleName9 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleName.9", value);
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

		public string ScalingRuleType
		{
			get
			{
				return scalingRuleType;
			}
			set	
			{
				scalingRuleType = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleType", value);
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

		public string ScalingRuleName10
		{
			get
			{
				return scalingRuleName10;
			}
			set	
			{
				scalingRuleName10 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleName.10", value);
			}
		}

		public string ScalingRuleId8
		{
			get
			{
				return scalingRuleId8;
			}
			set	
			{
				scalingRuleId8 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleId.8", value);
			}
		}

		public string ScalingRuleId9
		{
			get
			{
				return scalingRuleId9;
			}
			set	
			{
				scalingRuleId9 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleId.9", value);
			}
		}

		public string ScalingRuleAri10
		{
			get
			{
				return scalingRuleAri10;
			}
			set	
			{
				scalingRuleAri10 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleAri.10", value);
			}
		}

		public string ScalingRuleId4
		{
			get
			{
				return scalingRuleId4;
			}
			set	
			{
				scalingRuleId4 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleId.4", value);
			}
		}

		public string ScalingRuleId5
		{
			get
			{
				return scalingRuleId5;
			}
			set	
			{
				scalingRuleId5 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleId.5", value);
			}
		}

		public string ScalingRuleId6
		{
			get
			{
				return scalingRuleId6;
			}
			set	
			{
				scalingRuleId6 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleId.6", value);
			}
		}

		public string ScalingRuleId7
		{
			get
			{
				return scalingRuleId7;
			}
			set	
			{
				scalingRuleId7 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleId.7", value);
			}
		}

		public string ScalingRuleId1
		{
			get
			{
				return scalingRuleId1;
			}
			set	
			{
				scalingRuleId1 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleId.1", value);
			}
		}

		public string ScalingRuleId2
		{
			get
			{
				return scalingRuleId2;
			}
			set	
			{
				scalingRuleId2 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleId.2", value);
			}
		}

		public string ScalingRuleId3
		{
			get
			{
				return scalingRuleId3;
			}
			set	
			{
				scalingRuleId3 = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleId.3", value);
			}
		}

        public override DescribeScalingRulesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeScalingRulesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
