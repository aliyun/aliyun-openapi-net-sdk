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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class DescribeActiveOperationTasksRequest : RpcAcsRequest<DescribeActiveOperationTasksResponse>
    {
        public DescribeActiveOperationTasksRequest()
            : base("Rds", "2014-08-15", "DescribeActiveOperationTasks")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string productId;

		private string changeLevel;

		private int? pageNumber;

		private string insName;

		private string securityToken;

		private int? pageSize;

		private string taskType;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private int? allowCancel;

		private long? ownerId;

		private string dbType;

		private int? allowChange;

		private string region;

		private int? status;

		[JsonProperty(PropertyName = "ResourceOwnerId")]
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

		[JsonProperty(PropertyName = "ProductId")]
		public string ProductId
		{
			get
			{
				return productId;
			}
			set	
			{
				productId = value;
				DictionaryUtil.Add(QueryParameters, "ProductId", value);
			}
		}

		[JsonProperty(PropertyName = "ChangeLevel")]
		public string ChangeLevel
		{
			get
			{
				return changeLevel;
			}
			set	
			{
				changeLevel = value;
				DictionaryUtil.Add(QueryParameters, "ChangeLevel", value);
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "InsName")]
		public string InsName
		{
			get
			{
				return insName;
			}
			set	
			{
				insName = value;
				DictionaryUtil.Add(QueryParameters, "InsName", value);
			}
		}

		[JsonProperty(PropertyName = "SecurityToken")]
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

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "TaskType")]
		public string TaskType
		{
			get
			{
				return taskType;
			}
			set	
			{
				taskType = value;
				DictionaryUtil.Add(QueryParameters, "TaskType", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
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

		[JsonProperty(PropertyName = "OwnerAccount")]
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

		[JsonProperty(PropertyName = "AllowCancel")]
		public int? AllowCancel
		{
			get
			{
				return allowCancel;
			}
			set	
			{
				allowCancel = value;
				DictionaryUtil.Add(QueryParameters, "AllowCancel", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
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

		[JsonProperty(PropertyName = "DbType")]
		public string DbType
		{
			get
			{
				return dbType;
			}
			set	
			{
				dbType = value;
				DictionaryUtil.Add(QueryParameters, "DbType", value);
			}
		}

		[JsonProperty(PropertyName = "AllowChange")]
		public int? AllowChange
		{
			get
			{
				return allowChange;
			}
			set	
			{
				allowChange = value;
				DictionaryUtil.Add(QueryParameters, "AllowChange", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Region")]
		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		[JsonProperty(PropertyName = "Status")]
		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeActiveOperationTasksResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeActiveOperationTasksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
