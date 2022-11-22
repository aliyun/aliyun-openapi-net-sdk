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
    public class CreateCenInterRegionTrafficQosPolicyRequest : RpcAcsRequest<CreateCenInterRegionTrafficQosPolicyResponse>
    {
        public CreateCenInterRegionTrafficQosPolicyRequest()
            : base("Cbn", "2017-09-12", "CreateCenInterRegionTrafficQosPolicy", "cbn", "openAPI")
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

		private List<TrafficQosQueues> trafficQosQueuess = new List<TrafficQosQueues>(){ };

		private string trafficQosPolicyName;

		private bool? dryRun;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string trafficQosPolicyDescription;

		private long? ownerId;

		private string transitRouterId;

		private string transitRouterAttachmentId;

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

		public List<TrafficQosQueues> TrafficQosQueuess
		{
			get
			{
				return trafficQosQueuess;
			}

			set
			{
				trafficQosQueuess = value;
				if(trafficQosQueuess != null)
				{
					for (int depth1 = 0; depth1 < trafficQosQueuess.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"TrafficQosQueues." + (depth1 + 1), trafficQosQueuess[depth1]);
						DictionaryUtil.Add(QueryParameters,"TrafficQosQueues." + (depth1 + 1), trafficQosQueuess[depth1]);
						DictionaryUtil.Add(QueryParameters,"TrafficQosQueues." + (depth1 + 1), trafficQosQueuess[depth1]);
					}
				}
			}
		}

		public string TrafficQosPolicyName
		{
			get
			{
				return trafficQosPolicyName;
			}
			set	
			{
				trafficQosPolicyName = value;
				DictionaryUtil.Add(QueryParameters, "TrafficQosPolicyName", value);
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

		public string TrafficQosPolicyDescription
		{
			get
			{
				return trafficQosPolicyDescription;
			}
			set	
			{
				trafficQosPolicyDescription = value;
				DictionaryUtil.Add(QueryParameters, "TrafficQosPolicyDescription", value);
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

		public string TransitRouterId
		{
			get
			{
				return transitRouterId;
			}
			set	
			{
				transitRouterId = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterId", value);
			}
		}

		public string TransitRouterAttachmentId
		{
			get
			{
				return transitRouterAttachmentId;
			}
			set	
			{
				transitRouterAttachmentId = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterAttachmentId", value);
			}
		}

		public class TrafficQosQueues
		{

			private List<string> dscpss = new List<string>(){ };

			private string qosQueueName;

			private string remainBandwidthPercent;

			private string qosQueueDescription;

			public List<string> Dscpss
			{
				get
				{
					return dscpss;
				}
				set	
				{
					dscpss = value;
				}
			}

			public string QosQueueName
			{
				get
				{
					return qosQueueName;
				}
				set	
				{
					qosQueueName = value;
				}
			}

			public string RemainBandwidthPercent
			{
				get
				{
					return remainBandwidthPercent;
				}
				set	
				{
					remainBandwidthPercent = value;
				}
			}

			public string QosQueueDescription
			{
				get
				{
					return qosQueueDescription;
				}
				set	
				{
					qosQueueDescription = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateCenInterRegionTrafficQosPolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateCenInterRegionTrafficQosPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
