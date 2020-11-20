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
using Aliyun.Acs.polardb.Transform;
using Aliyun.Acs.polardb.Transform.V20170801;

namespace Aliyun.Acs.polardb.Model.V20170801
{
    public class CreateDatabaseRequest : RpcAcsRequest<CreateDatabaseResponse>
    {
        public CreateDatabaseRequest()
            : base("polardb", "2017-08-01", "CreateDatabase", "polardb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string accountPrivilege;

		private string accountName;

		private string dBDescription;

		private string resourceOwnerAccount;

		private string dBClusterId;

		private string ownerAccount;

		private long? ownerId;

		private string collate;

		private string dBName;

		private string ctype;

		private string characterSetName;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string AccountPrivilege
		{
			get
			{
				return accountPrivilege;
			}
			set	
			{
				accountPrivilege = value;
				DictionaryUtil.Add(QueryParameters, "AccountPrivilege", value);
			}
		}

		public string AccountName
		{
			get
			{
				return accountName;
			}
			set	
			{
				accountName = value;
				DictionaryUtil.Add(QueryParameters, "AccountName", value);
			}
		}

		public string DBDescription
		{
			get
			{
				return dBDescription;
			}
			set	
			{
				dBDescription = value;
				DictionaryUtil.Add(QueryParameters, "DBDescription", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterId", value);
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

		public string Collate
		{
			get
			{
				return collate;
			}
			set	
			{
				collate = value;
				DictionaryUtil.Add(QueryParameters, "Collate", value);
			}
		}

		public string DBName
		{
			get
			{
				return dBName;
			}
			set	
			{
				dBName = value;
				DictionaryUtil.Add(QueryParameters, "DBName", value);
			}
		}

		public string Ctype
		{
			get
			{
				return ctype;
			}
			set	
			{
				ctype = value;
				DictionaryUtil.Add(QueryParameters, "Ctype", value);
			}
		}

		public string CharacterSetName
		{
			get
			{
				return characterSetName;
			}
			set	
			{
				characterSetName = value;
				DictionaryUtil.Add(QueryParameters, "CharacterSetName", value);
			}
		}

        public override CreateDatabaseResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDatabaseResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
