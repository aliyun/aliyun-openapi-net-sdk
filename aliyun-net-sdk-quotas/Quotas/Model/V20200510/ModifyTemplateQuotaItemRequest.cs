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
    public class ModifyTemplateQuotaItemRequest : RpcAcsRequest<ModifyTemplateQuotaItemResponse>
    {
        public ModifyTemplateQuotaItemRequest()
            : base("quotas", "2020-05-10", "ModifyTemplateQuotaItem", "quotas", "openAPI")
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

		private float? desireValue;

		private string effectiveTime;

		private string id;

		private string quotaCategory;

		private string expireTime;

		private string envLanguage;

		private long? noticeType;

		private List<string> dimensionss = new List<string>(){ };

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

		public float? DesireValue
		{
			get
			{
				return desireValue;
			}
			set	
			{
				desireValue = value;
				DictionaryUtil.Add(BodyParameters, "DesireValue", value.ToString());
			}
		}

		public string EffectiveTime
		{
			get
			{
				return effectiveTime;
			}
			set	
			{
				effectiveTime = value;
				DictionaryUtil.Add(BodyParameters, "EffectiveTime", value);
			}
		}

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(BodyParameters, "Id", value);
			}
		}

		public string QuotaCategory
		{
			get
			{
				return quotaCategory;
			}
			set	
			{
				quotaCategory = value;
				DictionaryUtil.Add(QueryParameters, "QuotaCategory", value);
			}
		}

		public string ExpireTime
		{
			get
			{
				return expireTime;
			}
			set	
			{
				expireTime = value;
				DictionaryUtil.Add(BodyParameters, "ExpireTime", value);
			}
		}

		public string EnvLanguage
		{
			get
			{
				return envLanguage;
			}
			set	
			{
				envLanguage = value;
				DictionaryUtil.Add(BodyParameters, "EnvLanguage", value);
			}
		}

		public long? NoticeType
		{
			get
			{
				return noticeType;
			}
			set	
			{
				noticeType = value;
				DictionaryUtil.Add(BodyParameters, "NoticeType", value.ToString());
			}
		}

		public List<string> Dimensionss
		{
			get
			{
				return dimensionss;
			}

			set
			{
				dimensionss = value;
				if(dimensionss != null)
				{
					for (int depth1 = 0; depth1 < dimensionss.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"Dimensions." + (depth1 + 1), dimensionss[depth1]);
						DictionaryUtil.Add(BodyParameters,"Dimensions." + (depth1 + 1), dimensionss[depth1]);
					}
				}
			}
		}

		public class Dimensions
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

        public override ModifyTemplateQuotaItemResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyTemplateQuotaItemResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
