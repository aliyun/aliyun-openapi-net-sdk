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
using Aliyun.Acs.xtrace;
using Aliyun.Acs.xtrace.Transform;
using Aliyun.Acs.xtrace.Transform.V20190808;

namespace Aliyun.Acs.xtrace.Model.V20190808
{
    public class GetTraceAnalysisRequest : RpcAcsRequest<GetTraceAnalysisResponse>
    {
        public GetTraceAnalysisRequest()
            : base("xtrace", "2019-08-08", "GetTraceAnalysis")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.xtrace.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.xtrace.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string query;

		private string api;

		private string proxyUserId;

		public string Query
		{
			get
			{
				return query;
			}
			set	
			{
				query = value;
				DictionaryUtil.Add(QueryParameters, "Query", value);
			}
		}

		public string Api
		{
			get
			{
				return api;
			}
			set	
			{
				api = value;
				DictionaryUtil.Add(QueryParameters, "Api", value);
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
				DictionaryUtil.Add(QueryParameters, "ProxyUserId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetTraceAnalysisResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetTraceAnalysisResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
