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
    public class QueryRedeemRequest : RpcAcsRequest<QueryRedeemResponse>
    {
        public QueryRedeemRequest()
            : base("BssOpenApi", "2017-12-14", "QueryRedeem")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
        }

		private string expiryTimeEnd;

		private string expiryTimeStart;

		private int? pageNum;

		private bool? effectiveOrNot;

		private int? pageSize;

		public string ExpiryTimeEnd
		{
			get
			{
				return expiryTimeEnd;
			}
			set	
			{
				expiryTimeEnd = value;
				DictionaryUtil.Add(QueryParameters, "ExpiryTimeEnd", value);
			}
		}

		public string ExpiryTimeStart
		{
			get
			{
				return expiryTimeStart;
			}
			set	
			{
				expiryTimeStart = value;
				DictionaryUtil.Add(QueryParameters, "ExpiryTimeStart", value);
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public bool? EffectiveOrNot
		{
			get
			{
				return effectiveOrNot;
			}
			set	
			{
				effectiveOrNot = value;
				DictionaryUtil.Add(QueryParameters, "EffectiveOrNot", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

        public override QueryRedeemResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryRedeemResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
