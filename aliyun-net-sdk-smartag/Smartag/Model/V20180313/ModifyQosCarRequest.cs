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
using Aliyun.Acs.Smartag.Transform;
using Aliyun.Acs.Smartag.Transform.V20180313;

namespace Aliyun.Acs.Smartag.Model.V20180313
{
    public class ModifyQosCarRequest : RpcAcsRequest<ModifyQosCarResponse>
    {
        public ModifyQosCarRequest()
            : base("Smartag", "2018-03-13", "ModifyQosCar", "smartag", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private int? minBandwidthAbs;

		private string description;

		private string percentSourceType;

		private string qosId;

		private int? maxBandwidthAbs;

		private string resourceOwnerAccount;

		private int? maxBandwidthPercent;

		private string ownerAccount;

		private long? ownerId;

		private string qosCarId;

		private int? priority;

		private int? minBandwidthPercent;

		private string limitType;

		private string name;

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

		public int? MinBandwidthAbs
		{
			get
			{
				return minBandwidthAbs;
			}
			set	
			{
				minBandwidthAbs = value;
				DictionaryUtil.Add(QueryParameters, "MinBandwidthAbs", value.ToString());
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

		public string PercentSourceType
		{
			get
			{
				return percentSourceType;
			}
			set	
			{
				percentSourceType = value;
				DictionaryUtil.Add(QueryParameters, "PercentSourceType", value);
			}
		}

		public string QosId
		{
			get
			{
				return qosId;
			}
			set	
			{
				qosId = value;
				DictionaryUtil.Add(QueryParameters, "QosId", value);
			}
		}

		public int? MaxBandwidthAbs
		{
			get
			{
				return maxBandwidthAbs;
			}
			set	
			{
				maxBandwidthAbs = value;
				DictionaryUtil.Add(QueryParameters, "MaxBandwidthAbs", value.ToString());
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

		public int? MaxBandwidthPercent
		{
			get
			{
				return maxBandwidthPercent;
			}
			set	
			{
				maxBandwidthPercent = value;
				DictionaryUtil.Add(QueryParameters, "MaxBandwidthPercent", value.ToString());
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

		public string QosCarId
		{
			get
			{
				return qosCarId;
			}
			set	
			{
				qosCarId = value;
				DictionaryUtil.Add(QueryParameters, "QosCarId", value);
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

		public int? MinBandwidthPercent
		{
			get
			{
				return minBandwidthPercent;
			}
			set	
			{
				minBandwidthPercent = value;
				DictionaryUtil.Add(QueryParameters, "MinBandwidthPercent", value.ToString());
			}
		}

		public string LimitType
		{
			get
			{
				return limitType;
			}
			set	
			{
				limitType = value;
				DictionaryUtil.Add(QueryParameters, "LimitType", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

        public override ModifyQosCarResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyQosCarResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
