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
    public class ModifyHttpHeaderConfigRequest : RpcAcsRequest<ModifyHttpHeaderConfigResponse>
    {
        public ModifyHttpHeaderConfigRequest()
            : base("Cdn", "2014-11-11", "ModifyHttpHeaderConfig")
        {
        }

		private long? _ownerId;

		private string _securityToken;

		private string _domainName;

		private string _headerKey;

		private string _headerValue;

		private string _configID;

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

		public string HeaderKey
		{
			get
			{
				return _headerKey;
			}
			set	
			{
				_headerKey = value;
				DictionaryUtil.Add(QueryParameters, "HeaderKey", value);
			}
		}

		public string HeaderValue
		{
			get
			{
				return _headerValue;
			}
			set	
			{
				_headerValue = value;
				DictionaryUtil.Add(QueryParameters, "HeaderValue", value);
			}
		}

		public string ConfigID
		{
			get
			{
				return _configID;
			}
			set	
			{
				_configID = value;
				DictionaryUtil.Add(QueryParameters, "ConfigID", value);
			}
		}

        public override ModifyHttpHeaderConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyHttpHeaderConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}