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
using Aliyun.Acs.OssSddp;
using Aliyun.Acs.OssSddp.Transform;
using Aliyun.Acs.OssSddp.Transform.V20240222;

namespace Aliyun.Acs.OssSddp.Model.V20240222
{
    public class GetSddpVersionRequest : RpcAcsRequest<GetSddpVersionResponse>
    {
        public GetSddpVersionRequest()
            : base("OssSddp", "2024-02-22", "GetSddpVersion")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string clientToken;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetSddpVersionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetSddpVersionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
