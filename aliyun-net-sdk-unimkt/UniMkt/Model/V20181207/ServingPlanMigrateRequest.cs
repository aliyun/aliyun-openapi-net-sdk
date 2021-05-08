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
using Aliyun.Acs.UniMkt.Transform.V20181207;

namespace Aliyun.Acs.UniMkt.Model.V20181207
{
    public class ServingPlanMigrateRequest : RpcAcsRequest<ServingPlanMigrateResponse>
    {
        public ServingPlanMigrateRequest()
            : base("UniMkt", "2018-12-07", "ServingPlanMigrate", "uniMkt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string quotaPerDay;

		private string brandUserId;

		private string endTime;

		private string brandUserNick;

		private string startTime;

		private string proxyUserId;

		private string bizType;

		private string quota;

		private string name;

		private string proxyUserNick;

		private string payType;

		private string taskId;

		private string status;

		public string QuotaPerDay
		{
			get
			{
				return quotaPerDay;
			}
			set	
			{
				quotaPerDay = value;
				DictionaryUtil.Add(BodyParameters, "QuotaPerDay", value);
			}
		}

		public string BrandUserId
		{
			get
			{
				return brandUserId;
			}
			set	
			{
				brandUserId = value;
				DictionaryUtil.Add(BodyParameters, "BrandUserId", value);
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
				DictionaryUtil.Add(BodyParameters, "EndTime", value);
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
				DictionaryUtil.Add(BodyParameters, "BrandUserNick", value);
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
				DictionaryUtil.Add(BodyParameters, "StartTime", value);
			}
		}

		public string ProxyUserId
		{
			get
			{
				return proxyUserId;
			}
			set	
			{
				proxyUserId = value;
				DictionaryUtil.Add(BodyParameters, "ProxyUserId", value);
			}
		}

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(BodyParameters, "BizType", value);
			}
		}

		public string Quota
		{
			get
			{
				return quota;
			}
			set	
			{
				quota = value;
				DictionaryUtil.Add(BodyParameters, "Quota", value);
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
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public string ProxyUserNick
		{
			get
			{
				return proxyUserNick;
			}
			set	
			{
				proxyUserNick = value;
				DictionaryUtil.Add(BodyParameters, "ProxyUserNick", value);
			}
		}

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
				DictionaryUtil.Add(BodyParameters, "PayType", value);
			}
		}

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(BodyParameters, "TaskId", value);
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
				DictionaryUtil.Add(BodyParameters, "Status", value);
			}
		}

        public override ServingPlanMigrateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ServingPlanMigrateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
