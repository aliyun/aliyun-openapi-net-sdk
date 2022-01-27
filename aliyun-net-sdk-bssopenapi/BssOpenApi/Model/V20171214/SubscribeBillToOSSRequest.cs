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
    public class SubscribeBillToOSSRequest : RpcAcsRequest<SubscribeBillToOSSResponse>
    {
        public SubscribeBillToOSSRequest()
            : base("BssOpenApi", "2017-12-14", "SubscribeBillToOSS")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? bucketOwnerId;

		private string subscribeType;

		private string subscribeBucket;

		private string beginBillingCycle;

		private string multAccountRelSubscribe;

		public long? BucketOwnerId
		{
			get
			{
				return bucketOwnerId;
			}
			set	
			{
				bucketOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "BucketOwnerId", value.ToString());
			}
		}

		public string SubscribeType
		{
			get
			{
				return subscribeType;
			}
			set	
			{
				subscribeType = value;
				DictionaryUtil.Add(QueryParameters, "SubscribeType", value);
			}
		}

		public string SubscribeBucket
		{
			get
			{
				return subscribeBucket;
			}
			set	
			{
				subscribeBucket = value;
				DictionaryUtil.Add(QueryParameters, "SubscribeBucket", value);
			}
		}

		public string BeginBillingCycle
		{
			get
			{
				return beginBillingCycle;
			}
			set	
			{
				beginBillingCycle = value;
				DictionaryUtil.Add(QueryParameters, "BeginBillingCycle", value);
			}
		}

		public string MultAccountRelSubscribe
		{
			get
			{
				return multAccountRelSubscribe;
			}
			set	
			{
				multAccountRelSubscribe = value;
				DictionaryUtil.Add(QueryParameters, "MultAccountRelSubscribe", value);
			}
		}

        public override SubscribeBillToOSSResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubscribeBillToOSSResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
