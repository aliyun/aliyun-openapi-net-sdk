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
using Aliyun.Acs.dcdn.Transform;
using Aliyun.Acs.dcdn.Transform.V20180115;
using System.Collections.Generic;

namespace Aliyun.Acs.dcdn.Model.V20180115
{
    public class BatchSetDcdnDomainConfigsRequest : RpcAcsRequest<BatchSetDcdnDomainConfigsResponse>
    {
        public BatchSetDcdnDomainConfigsRequest()
            : base("dcdn", "2018-01-15", "BatchSetDcdnDomainConfigs")
        {
        }

		private string functions;

		private string securityToken;

		private string domainNames;

		private string ownerAccount;

		private string action;

		private long? ownerId;

		public string Functions
		{
			get
			{
				return functions;
			}
			set	
			{
				functions = value;
				DictionaryUtil.Add(QueryParameters, "Functions", value);
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

		public string DomainNames
		{
			get
			{
				return domainNames;
			}
			set	
			{
				domainNames = value;
				DictionaryUtil.Add(QueryParameters, "DomainNames", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
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

        public override BatchSetDcdnDomainConfigsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return BatchSetDcdnDomainConfigsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}