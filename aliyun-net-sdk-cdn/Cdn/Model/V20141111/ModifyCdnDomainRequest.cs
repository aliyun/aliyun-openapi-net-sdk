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
    public class ModifyCdnDomainRequest : RpcAcsRequest<ModifyCdnDomainResponse>
    {
        public ModifyCdnDomainRequest()
            : base("Cdn", "2014-11-11", "ModifyCdnDomain")
        {
        }

		private string topLevelDomain;

		private int? sourcePort;

		private string resourceGroupId;

		private string priorities;

		private string sources;

		private string securityToken;

		private string domainName;

		private string action;

		private string sourceType;

		private long? ownerId;

		private string accessKeyId;

		public string TopLevelDomain
		{
			get
			{
				return topLevelDomain;
			}
			set	
			{
				topLevelDomain = value;
				DictionaryUtil.Add(QueryParameters, "TopLevelDomain", value);
			}
		}

		public int? SourcePort
		{
			get
			{
				return sourcePort;
			}
			set	
			{
				sourcePort = value;
				DictionaryUtil.Add(QueryParameters, "SourcePort", value.ToString());
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public string Priorities
		{
			get
			{
				return priorities;
			}
			set	
			{
				priorities = value;
				DictionaryUtil.Add(QueryParameters, "Priorities", value);
			}
		}

		public string Sources
		{
			get
			{
				return sources;
			}
			set	
			{
				sources = value;
				DictionaryUtil.Add(QueryParameters, "Sources", value);
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

		public string SourceType
		{
			get
			{
				return sourceType;
			}
			set	
			{
				sourceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceType", value);
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

        public override ModifyCdnDomainResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyCdnDomainResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}