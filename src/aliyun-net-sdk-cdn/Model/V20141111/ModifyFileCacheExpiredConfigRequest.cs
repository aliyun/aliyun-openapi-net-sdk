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
    public class ModifyFileCacheExpiredConfigRequest : RpcAcsRequest<ModifyFileCacheExpiredConfigResponse>
    {
        public ModifyFileCacheExpiredConfigRequest()
            : base("Cdn", "2014-11-11", "ModifyFileCacheExpiredConfig")
        {
        }

		private long? _ownerId;

		private string _securityToken;

		private string _domainName;

		private string _configID;

		private string _cacheContent;

		private string _tTl;

		private string _weight;

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

		public string CacheContent
		{
			get
			{
				return _cacheContent;
			}
			set	
			{
				_cacheContent = value;
				DictionaryUtil.Add(QueryParameters, "CacheContent", value);
			}
		}

		public string TTL
		{
			get
			{
				return _tTl;
			}
			set	
			{
				_tTl = value;
				DictionaryUtil.Add(QueryParameters, "TTL", value);
			}
		}

		public string Weight
		{
			get
			{
				return _weight;
			}
			set	
			{
				_weight = value;
				DictionaryUtil.Add(QueryParameters, "Weight", value);
			}
		}

        public override ModifyFileCacheExpiredConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyFileCacheExpiredConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}