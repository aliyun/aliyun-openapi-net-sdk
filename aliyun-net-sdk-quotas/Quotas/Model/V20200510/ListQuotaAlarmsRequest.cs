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
    public class ListQuotaAlarmsRequest : RpcAcsRequest<ListQuotaAlarmsResponse>
    {
        public ListQuotaAlarmsRequest()
            : base("quotas", "2020-05-10", "ListQuotaAlarms", "quotas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.quotas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.quotas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string productCode;

		private string quotaActionCode;

		private string nextToken;

		private List<QuotaDimensions> quotaDimensionss = new List<QuotaDimensions>(){ };

		private int? maxResults;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(BodyParameters, "NextToken", value);
			}
		}

		public List<QuotaDimensions> QuotaDimensionss
		{
			get
			{
				return quotaDimensionss;
			}

			set
			{
				quotaDimensionss = value;
				for (int i = 0; i < quotaDimensionss.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"QuotaDimensions." + (i + 1) + ".Key", quotaDimensionss[i].Key);
					DictionaryUtil.Add(BodyParameters,"QuotaDimensions." + (i + 1) + ".Value", quotaDimensionss[i].Value);
				}
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(BodyParameters, "MaxResults", value.ToString());
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

			public string Value
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

        public override ListQuotaAlarmsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListQuotaAlarmsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
