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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.avatar;
using Aliyun.Acs.avatar.Transform;
using Aliyun.Acs.avatar.Transform.V20220130;

namespace Aliyun.Acs.avatar.Model.V20220130
{
    public class SendVamlRequest : RpcAcsRequest<SendVamlResponse>
    {
        public SendVamlRequest()
            : base("avatar", "2022-01-30", "SendVaml")
        {
			Method = MethodType.POST;
        }

		private long? tenantId;

		private string sessionId;

		private string vaml;

		[JsonProperty(PropertyName = "TenantId")]
		public long? TenantId
		{
			get
			{
				return tenantId;
			}
			set	
			{
				tenantId = value;
				DictionaryUtil.Add(QueryParameters, "TenantId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "SessionId")]
		public string SessionId
		{
			get
			{
				return sessionId;
			}
			set	
			{
				sessionId = value;
				DictionaryUtil.Add(QueryParameters, "SessionId", value);
			}
		}

		[JsonProperty(PropertyName = "Vaml")]
		public string Vaml
		{
			get
			{
				return vaml;
			}
			set	
			{
				vaml = value;
				DictionaryUtil.Add(QueryParameters, "Vaml", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SendVamlResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SendVamlResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
