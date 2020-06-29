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
using Aliyun.Acs.Cloudauth.Transform;
using Aliyun.Acs.Cloudauth.Transform.V20180916;

namespace Aliyun.Acs.Cloudauth.Model.V20180916
{
    public class GetVerifyTokenRequest : RpcAcsRequest<GetVerifyTokenResponse>
    {
        public GetVerifyTokenRequest()
            : base("Cloudauth", "2018-09-16", "GetVerifyToken", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string binding;

		private string verifyConfigs;

		private string userData;

		private string biz;

		private string ticketId;

		public string Binding
		{
			get
			{
				return binding;
			}
			set	
			{
				binding = value;
				DictionaryUtil.Add(BodyParameters, "Binding", value);
			}
		}

		public string VerifyConfigs
		{
			get
			{
				return verifyConfigs;
			}
			set	
			{
				verifyConfigs = value;
				DictionaryUtil.Add(QueryParameters, "VerifyConfigs", value);
			}
		}

		public string UserData
		{
			get
			{
				return userData;
			}
			set	
			{
				userData = value;
				DictionaryUtil.Add(QueryParameters, "UserData", value);
			}
		}

		public string Biz
		{
			get
			{
				return biz;
			}
			set	
			{
				biz = value;
				DictionaryUtil.Add(QueryParameters, "Biz", value);
			}
		}

		public string TicketId
		{
			get
			{
				return ticketId;
			}
			set	
			{
				ticketId = value;
				DictionaryUtil.Add(QueryParameters, "TicketId", value);
			}
		}

        public override GetVerifyTokenResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetVerifyTokenResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
