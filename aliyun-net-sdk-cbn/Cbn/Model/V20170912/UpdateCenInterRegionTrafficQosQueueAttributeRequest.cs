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
using Aliyun.Acs.Cbn;
using Aliyun.Acs.Cbn.Transform;
using Aliyun.Acs.Cbn.Transform.V20170912;

namespace Aliyun.Acs.Cbn.Model.V20170912
{
    public class UpdateCenInterRegionTrafficQosQueueAttributeRequest : RpcAcsRequest<UpdateCenInterRegionTrafficQosQueueAttributeResponse>
    {
        public UpdateCenInterRegionTrafficQosQueueAttributeRequest()
            : base("Cbn", "2017-09-12", "UpdateCenInterRegionTrafficQosQueueAttribute")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> dscpss = new List<string>(){ };

		private long? resourceOwnerId;

		private string clientToken;

		private string qosQueueName;

		private string remainBandwidthPercent;

		private bool? dryRun;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string qosQueueId;

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

		public string QosQueueName
		{
			get
			{
				return qosQueueName;
			}
			set	
			{
				qosQueueName = value;
				DictionaryUtil.Add(QueryParameters, "QosQueueName", value);
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
				DictionaryUtil.Add(QueryParameters, "RemainBandwidthPercent", value);
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

		public string QosQueueId
		{
			get
			{
				return qosQueueId;
			}
			set	
			{
				qosQueueId = value;
				DictionaryUtil.Add(QueryParameters, "QosQueueId", value);
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
				DictionaryUtil.Add(QueryParameters, "QosQueueDescription", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateCenInterRegionTrafficQosQueueAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateCenInterRegionTrafficQosQueueAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
