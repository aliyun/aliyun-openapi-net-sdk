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
using Aliyun.Acs.Cbn.Transform;
using Aliyun.Acs.Cbn.Transform.V20170912;

namespace Aliyun.Acs.Cbn.Model.V20170912
{
    public class AddTrafficMatchRuleToTrafficMarkingPolicyRequest : RpcAcsRequest<AddTrafficMatchRuleToTrafficMarkingPolicyResponse>
    {
        public AddTrafficMatchRuleToTrafficMarkingPolicyRequest()
            : base("Cbn", "2017-09-12", "AddTrafficMatchRuleToTrafficMarkingPolicy", "cbn", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string trafficMarkingPolicyId;

		private bool? dryRun;

		private List<TrafficMatchRules> trafficMatchRuless = new List<TrafficMatchRules>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

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

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string TrafficMarkingPolicyId
		{
			get
			{
				return trafficMarkingPolicyId;
			}
			set	
			{
				trafficMarkingPolicyId = value;
				DictionaryUtil.Add(QueryParameters, "TrafficMarkingPolicyId", value);
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
			}
		}

		public List<TrafficMatchRules> TrafficMatchRuless
		{
			get
			{
				return trafficMatchRuless;
			}

			set
			{
				trafficMatchRuless = value;
				if(trafficMatchRuless != null)
				{
					for (int depth1 = 0; depth1 < trafficMatchRuless.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"TrafficMatchRules." + (depth1 + 1), trafficMatchRuless[depth1]);
						DictionaryUtil.Add(QueryParameters,"TrafficMatchRules." + (depth1 + 1), trafficMatchRuless[depth1]);
						DictionaryUtil.Add(QueryParameters,"TrafficMatchRules." + (depth1 + 1), trafficMatchRuless[depth1]);
						DictionaryUtil.Add(QueryParameters,"TrafficMatchRules." + (depth1 + 1), trafficMatchRuless[depth1]);
						DictionaryUtil.Add(QueryParameters,"TrafficMatchRules." + (depth1 + 1), trafficMatchRuless[depth1]);
						DictionaryUtil.Add(QueryParameters,"TrafficMatchRules." + (depth1 + 1), trafficMatchRuless[depth1]);
					}
				}
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

		public class TrafficMatchRules
		{

			private List<string> dstPortRanges = new List<string>(){ };

			private int? matchDscp;

			private string protocol;

			private string trafficMatchRuleDescription;

			private List<string> srcPortRanges = new List<string>(){ };

			private string dstCidr;

			private string trafficMatchRuleName;

			private string srcCidr;

			public List<string> DstPortRanges
			{
				get
				{
					return dstPortRanges;
				}
				set	
				{
					dstPortRanges = value;
				}
			}

			public int? MatchDscp
			{
				get
				{
					return matchDscp;
				}
				set	
				{
					matchDscp = value;
				}
			}

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public string TrafficMatchRuleDescription
			{
				get
				{
					return trafficMatchRuleDescription;
				}
				set	
				{
					trafficMatchRuleDescription = value;
				}
			}

			public List<string> SrcPortRanges
			{
				get
				{
					return srcPortRanges;
				}
				set	
				{
					srcPortRanges = value;
				}
			}

			public string DstCidr
			{
				get
				{
					return dstCidr;
				}
				set	
				{
					dstCidr = value;
				}
			}

			public string TrafficMatchRuleName
			{
				get
				{
					return trafficMatchRuleName;
				}
				set	
				{
					trafficMatchRuleName = value;
				}
			}

			public string SrcCidr
			{
				get
				{
					return srcCidr;
				}
				set	
				{
					srcCidr = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddTrafficMatchRuleToTrafficMarkingPolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddTrafficMatchRuleToTrafficMarkingPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
