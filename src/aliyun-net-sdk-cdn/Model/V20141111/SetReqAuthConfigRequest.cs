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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cdn.Transform.V20141111;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class SetReqAuthConfigRequest : RpcAcsRequest<SetReqAuthConfigResponse>
    {
        public SetReqAuthConfigRequest()
            : base("Cdn", "2014-11-11", "SetReqAuthConfig")
        {
        }

		private long? _ownerId;

		private string _securityToken;

		private string _domainName;

		private string _authType;

		private string _key1;

		private string _key2;

		private string _timeOut;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string SecurityToken
		{
			get
			{
				return _securityToken;
			}
			set	
			{
				_securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string DomainName
		{
			get
			{
				return _domainName;
			}
			set	
			{
				_domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string AuthType
		{
			get
			{
				return _authType;
			}
			set	
			{
				_authType = value;
				DictionaryUtil.Add(QueryParameters, "AuthType", value);
			}
		}

		public string Key1
		{
			get
			{
				return _key1;
			}
			set	
			{
				_key1 = value;
				DictionaryUtil.Add(QueryParameters, "Key1", value);
			}
		}

		public string Key2
		{
			get
			{
				return _key2;
			}
			set	
			{
				_key2 = value;
				DictionaryUtil.Add(QueryParameters, "Key2", value);
			}
		}

		public string TimeOut
		{
			get
			{
				return _timeOut;
			}
			set	
			{
				_timeOut = value;
				DictionaryUtil.Add(QueryParameters, "TimeOut", value);
			}
		}

        public override SetReqAuthConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetReqAuthConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}