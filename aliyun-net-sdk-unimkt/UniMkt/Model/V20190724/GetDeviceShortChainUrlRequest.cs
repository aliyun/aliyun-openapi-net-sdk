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
using Aliyun.Acs.UniMkt.Transform;
using Aliyun.Acs.UniMkt.Transform.V20190724;

namespace Aliyun.Acs.UniMkt.Model.V20190724
{
    public class GetDeviceShortChainUrlRequest : RpcAcsRequest<GetDeviceShortChainUrlResponse>
    {
        public GetDeviceShortChainUrlRequest()
            : base("UniMkt", "2019-07-24", "GetDeviceShortChainUrl", "1.0.0", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private bool? longterm;

		private string url;

		public bool? Longterm
		{
			get
			{
				return longterm;
			}
			set	
			{
				longterm = value;
				DictionaryUtil.Add(BodyParameters, "Longterm", value.ToString());
			}
		}

		public string Url
		{
			get
			{
				return url;
			}
			set	
			{
				url = value;
				DictionaryUtil.Add(BodyParameters, "Url", value);
			}
		}

        public override GetDeviceShortChainUrlResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetDeviceShortChainUrlResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
