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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class UpdateTrafficMirrorFilterRuleAttributeRequest : RpcAcsRequest<UpdateTrafficMirrorFilterRuleAttributeResponse>
    {
        public UpdateTrafficMirrorFilterRuleAttributeRequest()
            : base("Vpc", "2016-04-28", "UpdateTrafficMirrorFilterRuleAttribute", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sourcePortRange;

		private long? resourceOwnerId;

		private string destinationPortRange;

		private string clientToken;

		private string ruleAction;

		private string protocol;

		private string sourceCidrBlock;

		private bool? dryRun;

		private string resourceOwnerAccount;

		private string destinationCidrBlock;

		private string ownerAccount;

		private int? priority;

		private long? ownerId;

		private string trafficMirrorFilterRuleId;

		public string SourcePortRange
		{
			get
			{
				return sourcePortRange;
			}
			set	
			{
				sourcePortRange = value;
				DictionaryUtil.Add(QueryParameters, "SourcePortRange", value);
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

		public string DestinationPortRange
		{
			get
			{
				return destinationPortRange;
			}
			set	
			{
				destinationPortRange = value;
				DictionaryUtil.Add(QueryParameters, "DestinationPortRange", value);
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

		public string RuleAction
		{
			get
			{
				return ruleAction;
			}
			set	
			{
				ruleAction = value;
				DictionaryUtil.Add(QueryParameters, "RuleAction", value);
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
				DictionaryUtil.Add(QueryParameters, "Protocol", value);
			}
		}

		public string SourceCidrBlock
		{
			get
			{
				return sourceCidrBlock;
			}
			set	
			{
				sourceCidrBlock = value;
				DictionaryUtil.Add(QueryParameters, "SourceCidrBlock", value);
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

		public string DestinationCidrBlock
		{
			get
			{
				return destinationCidrBlock;
			}
			set	
			{
				destinationCidrBlock = value;
				DictionaryUtil.Add(QueryParameters, "DestinationCidrBlock", value);
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

		public int? Priority
		{
			get
			{
				return priority;
			}
			set	
			{
				priority = value;
				DictionaryUtil.Add(QueryParameters, "Priority", value.ToString());
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

		public string TrafficMirrorFilterRuleId
		{
			get
			{
				return trafficMirrorFilterRuleId;
			}
			set	
			{
				trafficMirrorFilterRuleId = value;
				DictionaryUtil.Add(QueryParameters, "TrafficMirrorFilterRuleId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateTrafficMirrorFilterRuleAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateTrafficMirrorFilterRuleAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
