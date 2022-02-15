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
using Aliyun.Acs.Copyright;
using Aliyun.Acs.Copyright.Transform;
using Aliyun.Acs.Copyright.Transform.V20190123;

namespace Aliyun.Acs.Copyright.Model.V20190123
{
    public class GetAlipayUrlRequest : RpcAcsRequest<GetAlipayUrlResponse>
    {
        public GetAlipayUrlRequest()
            : base("Copyright", "2019-01-23", "GetAlipayUrl")
        {
        }

		private long? orderId;

		private string type;

		private string bizType;

		private string returnUrl;

		public long? OrderId
		{
			get
			{
				return orderId;
			}
			set	
			{
				orderId = value;
				DictionaryUtil.Add(QueryParameters, "OrderId", value.ToString());
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
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
				DictionaryUtil.Add(QueryParameters, "BizType", value);
			}
		}

		public string ReturnUrl
		{
			get
			{
				return returnUrl;
			}
			set	
			{
				returnUrl = value;
				DictionaryUtil.Add(QueryParameters, "ReturnUrl", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetAlipayUrlResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetAlipayUrlResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
