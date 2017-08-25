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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20141111;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class SetReqAuthConfigRequest : RpcAcsRequest<SetReqAuthConfigResponse>
    {
        public SetReqAuthConfigRequest()
            : base("Cdn", "2014-11-11", "SetReqAuthConfig")
        {
        }

		private string key1;

		private string key2;

		private string securityToken;

		private string domainName;

		private string action;

		private long? ownerId;

		private string timeOut;

		private string accessKeyId;

		private string authType;

		public string Key1
		{
			get
			{
				return key1;
			}
			set	
			{
				key1 = value;
				DictionaryUtil.Add(QueryParameters, "Key1", value);
			}
		}

		public string Key2
		{
			get
			{
				return key2;
			}
			set	
			{
				key2 = value;
				DictionaryUtil.Add(QueryParameters, "Key2", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string TimeOut
		{
			get
			{
				return timeOut;
			}
			set	
			{
				timeOut = value;
				DictionaryUtil.Add(QueryParameters, "TimeOut", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string AuthType
		{
			get
			{
				return authType;
			}
			set	
			{
				authType = value;
				DictionaryUtil.Add(QueryParameters, "AuthType", value);
			}
		}

        public override SetReqAuthConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetReqAuthConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}