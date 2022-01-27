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
    public class GetTokenRequest : RpcAcsRequest<GetTokenResponse>
    {
        public GetTokenRequest()
            : base("xtrace", "2019-08-08", "GetToken")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.xtrace.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.xtrace.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string appType;

		private string proxyUserId;

		private bool? isForce;

		public string AppType
		{
			get
			{
				return appType;
			}
			set	
			{
				appType = value;
				DictionaryUtil.Add(QueryParameters, "AppType", value);
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

		public bool? IsForce
		{
			get
			{
				return isForce;
			}
			set	
			{
				isForce = value;
				DictionaryUtil.Add(QueryParameters, "IsForce", value.ToString());
			}
		}

        public override GetTokenResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetTokenResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
