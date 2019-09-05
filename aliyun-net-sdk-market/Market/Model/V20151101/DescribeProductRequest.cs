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
using Aliyun.Acs.Market.Transform;
using Aliyun.Acs.Market.Transform.V20151101;

namespace Aliyun.Acs.Market.Model.V20151101
{
    public class DescribeProductRequest : RpcAcsRequest<DescribeProductResponse>
    {
        public DescribeProductRequest()
            : base("Market", "2015-11-01", "DescribeProduct", "yunmarket", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string code;

		private bool? queryDraft;

		private string aliUid;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
				DictionaryUtil.Add(QueryParameters, "Code", value);
			}
		}

		public bool? QueryDraft
		{
			get
			{
				return queryDraft;
			}
			set	
			{
				queryDraft = value;
				DictionaryUtil.Add(QueryParameters, "QueryDraft", value.ToString());
			}
		}

		public string AliUid
		{
			get
			{
				return aliUid;
			}
			set	
			{
				aliUid = value;
				DictionaryUtil.Add(QueryParameters, "AliUid", value);
			}
		}

        public override DescribeProductResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeProductResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
