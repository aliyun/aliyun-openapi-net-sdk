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
    public class SetCcConfigRequest : RpcAcsRequest<SetCcConfigResponse>
    {
        public SetCcConfigRequest()
            : base("Cdn", "2014-11-11", "SetCcConfig")
        {
        }

		private long? _ownerId;

		private string _securityToken;

		private string _domainName;

		private string _enable;

		private string _allowIps;

		private string _blockIps;

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

		public string Enable
		{
			get
			{
				return _enable;
			}
			set	
			{
				_enable = value;
				DictionaryUtil.Add(QueryParameters, "Enable", value);
			}
		}

		public string AllowIps
		{
			get
			{
				return _allowIps;
			}
			set	
			{
				_allowIps = value;
				DictionaryUtil.Add(QueryParameters, "AllowIps", value);
			}
		}

		public string BlockIps
		{
			get
			{
				return _blockIps;
			}
			set	
			{
				_blockIps = value;
				DictionaryUtil.Add(QueryParameters, "BlockIps", value);
			}
		}

        public override SetCcConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetCcConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}