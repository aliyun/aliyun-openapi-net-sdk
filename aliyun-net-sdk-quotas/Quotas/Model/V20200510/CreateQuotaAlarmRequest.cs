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
using Aliyun.Acs.quotas.Transform;
using Aliyun.Acs.quotas.Transform.V20200510;

namespace Aliyun.Acs.quotas.Model.V20200510
{
    public class CreateQuotaAlarmRequest : RpcAcsRequest<CreateQuotaAlarmResponse>
    {
        public CreateQuotaAlarmRequest()
            : base("quotas", "2020-05-10", "CreateQuotaAlarm", "quotas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.quotas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.quotas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string productCode;

		private string webHook;

		private float? threshold;

		private string quotaActionCode;

		private string thresholdType;

		private List<string> quotaDimensionss = new List<string>(){ };

		private float? thresholdPercent;

		private string alarmName;

		public string ProductCode
		{
			get
			{
				return productCode;
			}
			set	
			{
				productCode = value;
				DictionaryUtil.Add(BodyParameters, "ProductCode", value);
			}
		}

		public string WebHook
		{
			get
			{
				return webHook;
			}
			set	
			{
				webHook = value;
				DictionaryUtil.Add(BodyParameters, "WebHook", value);
			}
		}

		public float? Threshold
		{
			get
			{
				return threshold;
			}
			set	
			{
				threshold = value;
				DictionaryUtil.Add(BodyParameters, "Threshold", value.ToString());
			}
		}

		public string QuotaActionCode
		{
			get
			{
				return quotaActionCode;
			}
			set	
			{
				quotaActionCode = value;
				DictionaryUtil.Add(BodyParameters, "QuotaActionCode", value);
			}
		}

		public string ThresholdType
		{
			get
			{
				return thresholdType;
			}
			set	
			{
				thresholdType = value;
				DictionaryUtil.Add(BodyParameters, "ThresholdType", value);
			}
		}

		public List<string> QuotaDimensionss
		{
			get
			{
				return quotaDimensionss;
			}

			set
			{
				quotaDimensionss = value;
				if(quotaDimensionss != null)
				{
					for (int depth1 = 0; depth1 < quotaDimensionss.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"QuotaDimensions." + (depth1 + 1), quotaDimensionss[depth1]);
						DictionaryUtil.Add(BodyParameters,"QuotaDimensions." + (depth1 + 1), quotaDimensionss[depth1]);
					}
				}
			}
		}

		public float? ThresholdPercent
		{
			get
			{
				return thresholdPercent;
			}
			set	
			{
				thresholdPercent = value;
				DictionaryUtil.Add(BodyParameters, "ThresholdPercent", value.ToString());
			}
		}

		public string AlarmName
		{
			get
			{
				return alarmName;
			}
			set	
			{
				alarmName = value;
				DictionaryUtil.Add(BodyParameters, "AlarmName", value);
			}
		}

		public class QuotaDimensions
		{

			private string key;

			private string value_;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string Value_
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateQuotaAlarmResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateQuotaAlarmResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
