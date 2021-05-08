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
using Aliyun.Acs.UniMkt.Transform;
using Aliyun.Acs.UniMkt.Transform.V20181212;

namespace Aliyun.Acs.UniMkt.Model.V20181212
{
    public class SyncUnionOrderRequest : RpcAcsRequest<SyncUnionOrderResponse>
    {
        public SyncUnionOrderRequest()
            : base("UniMkt", "2018-12-12", "SyncUnionOrder", "uniMkt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string taskType;

		private long? realCostAmount;

		private string taskBizType;

		private string sex;

		private long? brandUserId;

		private string brandName;

		private long? proxyUserId;

		private string deviceId;

		private string holderId;

		private string bizSerialNumber;

		private string taskRuleType;

		private int? industryLabelBagId;

		private long? applyPrice;

		private string extendInfo;

		private string channelId;

		private int? age;

		private long? taskId;

		private string status;

		public string TaskType
		{
			get
			{
				return taskType;
			}
			set	
			{
				taskType = value;
				DictionaryUtil.Add(QueryParameters, "TaskType", value);
			}
		}

		public long? RealCostAmount
		{
			get
			{
				return realCostAmount;
			}
			set	
			{
				realCostAmount = value;
				DictionaryUtil.Add(QueryParameters, "RealCostAmount", value.ToString());
			}
		}

		public string TaskBizType
		{
			get
			{
				return taskBizType;
			}
			set	
			{
				taskBizType = value;
				DictionaryUtil.Add(QueryParameters, "TaskBizType", value);
			}
		}

		public string Sex
		{
			get
			{
				return sex;
			}
			set	
			{
				sex = value;
				DictionaryUtil.Add(QueryParameters, "Sex", value);
			}
		}

		public long? BrandUserId
		{
			get
			{
				return brandUserId;
			}
			set	
			{
				brandUserId = value;
				DictionaryUtil.Add(QueryParameters, "BrandUserId", value.ToString());
			}
		}

		public string BrandName
		{
			get
			{
				return brandName;
			}
			set	
			{
				brandName = value;
				DictionaryUtil.Add(QueryParameters, "BrandName", value);
			}
		}

		public long? ProxyUserId
		{
			get
			{
				return proxyUserId;
			}
			set	
			{
				proxyUserId = value;
				DictionaryUtil.Add(QueryParameters, "ProxyUserId", value.ToString());
			}
		}

		public string DeviceId
		{
			get
			{
				return deviceId;
			}
			set	
			{
				deviceId = value;
				DictionaryUtil.Add(QueryParameters, "DeviceId", value);
			}
		}

		public string HolderId
		{
			get
			{
				return holderId;
			}
			set	
			{
				holderId = value;
				DictionaryUtil.Add(QueryParameters, "HolderId", value);
			}
		}

		public string BizSerialNumber
		{
			get
			{
				return bizSerialNumber;
			}
			set	
			{
				bizSerialNumber = value;
				DictionaryUtil.Add(QueryParameters, "BizSerialNumber", value);
			}
		}

		public string TaskRuleType
		{
			get
			{
				return taskRuleType;
			}
			set	
			{
				taskRuleType = value;
				DictionaryUtil.Add(QueryParameters, "TaskRuleType", value);
			}
		}

		public int? IndustryLabelBagId
		{
			get
			{
				return industryLabelBagId;
			}
			set	
			{
				industryLabelBagId = value;
				DictionaryUtil.Add(QueryParameters, "IndustryLabelBagId", value.ToString());
			}
		}

		public long? ApplyPrice
		{
			get
			{
				return applyPrice;
			}
			set	
			{
				applyPrice = value;
				DictionaryUtil.Add(QueryParameters, "ApplyPrice", value.ToString());
			}
		}

		public string ExtendInfo
		{
			get
			{
				return extendInfo;
			}
			set	
			{
				extendInfo = value;
				DictionaryUtil.Add(QueryParameters, "ExtendInfo", value);
			}
		}

		public string ChannelId
		{
			get
			{
				return channelId;
			}
			set	
			{
				channelId = value;
				DictionaryUtil.Add(QueryParameters, "ChannelId", value);
			}
		}

		public int? Age
		{
			get
			{
				return age;
			}
			set	
			{
				age = value;
				DictionaryUtil.Add(QueryParameters, "Age", value.ToString());
			}
		}

		public long? TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(QueryParameters, "TaskId", value.ToString());
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

        public override SyncUnionOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SyncUnionOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
