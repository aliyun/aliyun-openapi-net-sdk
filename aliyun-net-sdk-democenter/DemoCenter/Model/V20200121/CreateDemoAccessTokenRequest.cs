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
using Aliyun.Acs.DemoCenter;
using Aliyun.Acs.DemoCenter.Transform;
using Aliyun.Acs.DemoCenter.Transform.V20200121;

namespace Aliyun.Acs.DemoCenter.Model.V20200121
{
    public class CreateDemoAccessTokenRequest : RpcAcsRequest<CreateDemoAccessTokenResponse>
    {
        public CreateDemoAccessTokenRequest()
            : base("DemoCenter", "2020-01-21", "CreateDemoAccessToken")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
        }

		private int? edition;

		private long? demoId;

		public int? Edition
		{
			get
			{
				return edition;
			}
			set	
			{
				edition = value;
				DictionaryUtil.Add(BodyParameters, "Edition", value.ToString());
			}
		}

		public long? DemoId
		{
			get
			{
				return demoId;
			}
			set	
			{
				demoId = value;
				DictionaryUtil.Add(BodyParameters, "DemoId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateDemoAccessTokenResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDemoAccessTokenResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
