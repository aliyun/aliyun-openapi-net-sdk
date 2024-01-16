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
using Aliyun.Acs.AiMiaoBi;
using Aliyun.Acs.AiMiaoBi.Transform;
using Aliyun.Acs.AiMiaoBi.Transform.V20230801;

namespace Aliyun.Acs.AiMiaoBi.Model.V20230801
{
    public class CreateTokenRequest : RpcAcsRequest<CreateTokenResponse>
    {
        public CreateTokenRequest()
            : base("AiMiaoBi", "2023-08-01", "CreateToken")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string agentKey;

		public string AgentKey
		{
			get
			{
				return agentKey;
			}
			set	
			{
				agentKey = value;
				DictionaryUtil.Add(QueryParameters, "AgentKey", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateTokenResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTokenResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
