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
    public class CreateUnionTaskRequest : RpcAcsRequest<CreateUnionTaskResponse>
    {
        public CreateUnionTaskRequest()
            : base("UniMkt", "2018-12-12", "CreateUnionTask", "uniMkt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string taskType;

		private string taskBizType;

		private string clientToken;

		private long? brandUserId;

		private long? contentId;

		private string channel;

		private string endTime;

		private string brandUserNick;

		private string startTime;

		private long? proxyUserId;

		private string taskRuleType;

		private long? quota;

		private int? industryLabelBagId;

		private string name;

		private long? quotaDay;

		private string channelId;

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

		public long? ContentId
		{
			get
			{
				return contentId;
			}
			set	
			{
				contentId = value;
				DictionaryUtil.Add(QueryParameters, "ContentId", value.ToString());
			}
		}

		public string Channel
		{
			get
			{
				return channel;
			}
			set	
			{
				channel = value;
				DictionaryUtil.Add(QueryParameters, "Channel", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string BrandUserNick
		{
			get
			{
				return brandUserNick;
			}
			set	
			{
				brandUserNick = value;
				DictionaryUtil.Add(QueryParameters, "BrandUserNick", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
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

		public long? Quota
		{
			get
			{
				return quota;
			}
			set	
			{
				quota = value;
				DictionaryUtil.Add(QueryParameters, "Quota", value.ToString());
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

		public long? QuotaDay
		{
			get
			{
				return quotaDay;
			}
			set	
			{
				quotaDay = value;
				DictionaryUtil.Add(QueryParameters, "QuotaDay", value.ToString());
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateUnionTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateUnionTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
