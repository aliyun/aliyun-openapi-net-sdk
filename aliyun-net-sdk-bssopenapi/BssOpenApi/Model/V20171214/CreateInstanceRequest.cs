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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;
using System.Collections.Generic;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class CreateInstanceRequest : RpcAcsRequest<CreateInstanceResponse>
    {
        public CreateInstanceRequest()
            : base("BssOpenApi", "2017-12-14", "CreateInstance")
        {
        }

		private string productCode;

		private int? period;

		private string subscriptionType;

		private int? renewPeriod;

		private string renewalStatus;

		private List<Parameter> parameters;

		private long? ownerId;

		private string productType;

		public string ProductCode
		{
			get
			{
				return productCode;
			}
			set	
			{
				productCode = value;
				DictionaryUtil.Add(QueryParameters, "ProductCode", value);
			}
		}

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public string SubscriptionType
		{
			get
			{
				return subscriptionType;
			}
			set	
			{
				subscriptionType = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionType", value);
			}
		}

		public int? RenewPeriod
		{
			get
			{
				return renewPeriod;
			}
			set	
			{
				renewPeriod = value;
				DictionaryUtil.Add(QueryParameters, "RenewPeriod", value.ToString());
			}
		}

		public string RenewalStatus
		{
			get
			{
				return renewalStatus;
			}
			set	
			{
				renewalStatus = value;
				DictionaryUtil.Add(QueryParameters, "RenewalStatus", value);
			}
		}

		public List<Parameter> Parameters
		{
			get
			{
				return parameters;
			}

			set
			{
				parameters = value;
				for (int i = 0; i < parameters.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Parameter." + (i + 1) + ".Code", parameters[i].Code);
					DictionaryUtil.Add(QueryParameters,"Parameter." + (i + 1) + ".Value", parameters[i].Value);
				}
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

		public string ProductType
		{
			get
			{
				return productType;
			}
			set	
			{
				productType = value;
				DictionaryUtil.Add(QueryParameters, "ProductType", value);
			}
		}

		public class Parameter
		{

			private string code;

			private string value_;

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
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

        public override CreateInstanceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}