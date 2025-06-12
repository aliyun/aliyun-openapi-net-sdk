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
    public class TransferVersionRequest : RpcAcsRequest<TransferVersionResponse>
    {
        public TransferVersionRequest()
            : base("clickhouse", "2019-11-11", "TransferVersion", "service", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.clickhouse.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.clickhouse.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
			Method = MethodType.PUT;
        }

		private long? resourceOwnerId;

		private int? pageNumber;

		private string sourceAccount;

		private string targetAccount;

		private string sourceClusterName;

		private int? pageSize;

		private string sourcePassword;

		private string disableWriteWindows;

		private string resourceOwnerAccount;

		private string dBClusterId;

		private string targetPassword;

		private string ownerAccount;

		private long? ownerId;

		private string targetDbClusterId;

		private string sourceShards;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string SourceAccount
		{
			get
			{
				return sourceAccount;
			}
			set	
			{
				sourceAccount = value;
				DictionaryUtil.Add(QueryParameters, "SourceAccount", value);
			}
		}

		public string TargetAccount
		{
			get
			{
				return targetAccount;
			}
			set	
			{
				targetAccount = value;
				DictionaryUtil.Add(QueryParameters, "TargetAccount", value);
			}
		}

		public string SourceClusterName
		{
			get
			{
				return sourceClusterName;
			}
			set	
			{
				sourceClusterName = value;
				DictionaryUtil.Add(QueryParameters, "SourceClusterName", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string SourcePassword
		{
			get
			{
				return sourcePassword;
			}
			set	
			{
				sourcePassword = value;
				DictionaryUtil.Add(QueryParameters, "SourcePassword", value);
			}
		}

		public string DisableWriteWindows
		{
			get
			{
				return disableWriteWindows;
			}
			set	
			{
				disableWriteWindows = value;
				DictionaryUtil.Add(QueryParameters, "DisableWriteWindows", value);
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

		public string TargetPassword
		{
			get
			{
				return targetPassword;
			}
			set	
			{
				targetPassword = value;
				DictionaryUtil.Add(QueryParameters, "TargetPassword", value);
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

		public string TargetDbClusterId
		{
			get
			{
				return targetDbClusterId;
			}
			set	
			{
				targetDbClusterId = value;
				DictionaryUtil.Add(QueryParameters, "TargetDbClusterId", value);
			}
		}

		public string SourceShards
		{
			get
			{
				return sourceShards;
			}
			set	
			{
				sourceShards = value;
				DictionaryUtil.Add(QueryParameters, "SourceShards", value);
			}
		}

        public override TransferVersionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return TransferVersionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
