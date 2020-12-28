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
using Aliyun.Acs.BssOpenApi;
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class ChangeResellerConsumeAmountRequest : RpcAcsRequest<ChangeResellerConsumeAmountResponse>
    {
        public ChangeResellerConsumeAmountRequest()
            : base("BssOpenApi", "2017-12-14", "ChangeResellerConsumeAmount")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string amount;

		private string outBizId;

		private string source;

		private long? ownerId;

		private string businessType;

		private string adjustType;

		private string extendMap;

		private string currency;

		public string Amount
		{
			get
			{
				return amount;
			}
			set	
			{
				amount = value;
				DictionaryUtil.Add(QueryParameters, "Amount", value);
			}
		}

		public string OutBizId
		{
			get
			{
				return outBizId;
			}
			set	
			{
				outBizId = value;
				DictionaryUtil.Add(QueryParameters, "OutBizId", value);
			}
		}

		public string Source
		{
			get
			{
				return source;
			}
			set	
			{
				source = value;
				DictionaryUtil.Add(QueryParameters, "Source", value);
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

		public string BusinessType
		{
			get
			{
				return businessType;
			}
			set	
			{
				businessType = value;
				DictionaryUtil.Add(QueryParameters, "BusinessType", value);
			}
		}

		public string AdjustType
		{
			get
			{
				return adjustType;
			}
			set	
			{
				adjustType = value;
				DictionaryUtil.Add(QueryParameters, "AdjustType", value);
			}
		}

		public string ExtendMap
		{
			get
			{
				return extendMap;
			}
			set	
			{
				extendMap = value;
				DictionaryUtil.Add(QueryParameters, "ExtendMap", value);
			}
		}

		public string Currency
		{
			get
			{
				return currency;
			}
			set	
			{
				currency = value;
				DictionaryUtil.Add(QueryParameters, "Currency", value);
			}
		}

        public override ChangeResellerConsumeAmountResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ChangeResellerConsumeAmountResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
