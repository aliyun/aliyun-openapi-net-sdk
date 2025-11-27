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
using Aliyun.Acs.clickhouse.Transform;
using Aliyun.Acs.clickhouse.Transform.V20191111;

namespace Aliyun.Acs.clickhouse.Model.V20191111
{
    public class ModifyAccountAuthorityRequest : RpcAcsRequest<ModifyAccountAuthorityResponse>
    {
        public ModifyAccountAuthorityRequest()
            : base("clickhouse", "2019-11-11", "ModifyAccountAuthority", "service", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.clickhouse.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.clickhouse.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string totalDictionaries;

		private string accountName;

		private string dmlAuthority;

		private string resourceOwnerAccount;

		private string dBClusterId;

		private string ownerAccount;

		private string allowDatabases;

		private string allowDictionaries;

		private long? ownerId;

		private bool? ddlAuthority;

		private string totalDatabases;

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

		public string TotalDictionaries
		{
			get
			{
				return totalDictionaries;
			}
			set	
			{
				totalDictionaries = value;
				DictionaryUtil.Add(QueryParameters, "TotalDictionaries", value);
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

		public string DmlAuthority
		{
			get
			{
				return dmlAuthority;
			}
			set	
			{
				dmlAuthority = value;
				DictionaryUtil.Add(QueryParameters, "DmlAuthority", value);
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

		public string AllowDatabases
		{
			get
			{
				return allowDatabases;
			}
			set	
			{
				allowDatabases = value;
				DictionaryUtil.Add(QueryParameters, "AllowDatabases", value);
			}
		}

		public string AllowDictionaries
		{
			get
			{
				return allowDictionaries;
			}
			set	
			{
				allowDictionaries = value;
				DictionaryUtil.Add(QueryParameters, "AllowDictionaries", value);
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

		public bool? DdlAuthority
		{
			get
			{
				return ddlAuthority;
			}
			set	
			{
				ddlAuthority = value;
				DictionaryUtil.Add(QueryParameters, "DdlAuthority", value.ToString());
			}
		}

		public string TotalDatabases
		{
			get
			{
				return totalDatabases;
			}
			set	
			{
				totalDatabases = value;
				DictionaryUtil.Add(QueryParameters, "TotalDatabases", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyAccountAuthorityResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyAccountAuthorityResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
