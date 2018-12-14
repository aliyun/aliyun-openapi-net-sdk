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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class DescribeTemplatesListRequest : RpcAcsRequest<DescribeTemplatesListResponse>
    {
        public DescribeTemplatesListRequest()
            : base("Rds", "2014-08-15", "DescribeTemplatesList", "rds", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private int? minAvgConsume;

		private string ownerAccount;

		private int? maxRecordsPerPage;

		private string endTime;

		private string startTime;

		private long? ownerId;

		private string accessKeyId;

		private int? maxAvgConsume;

		private string sortKey;

		private int? minAvgScanRows;

		private string sqType;

		private string securityToken;

		private string sortMethod;

		private int? pageNumbers;

		private string action;

		private string pagingId;

		private string dBInstanceId;

		private int? maxAvgScanRows;

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

		public int? MinAvgConsume
		{
			get
			{
				return minAvgConsume;
			}
			set	
			{
				minAvgConsume = value;
				DictionaryUtil.Add(QueryParameters, "MinAvgConsume", value.ToString());
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

		public int? MaxRecordsPerPage
		{
			get
			{
				return maxRecordsPerPage;
			}
			set	
			{
				maxRecordsPerPage = value;
				DictionaryUtil.Add(QueryParameters, "MaxRecordsPerPage", value.ToString());
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
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

		public int? MaxAvgConsume
		{
			get
			{
				return maxAvgConsume;
			}
			set	
			{
				maxAvgConsume = value;
				DictionaryUtil.Add(QueryParameters, "MaxAvgConsume", value.ToString());
			}
		}

		public string SortKey
		{
			get
			{
				return sortKey;
			}
			set	
			{
				sortKey = value;
				DictionaryUtil.Add(QueryParameters, "SortKey", value);
			}
		}

		public int? MinAvgScanRows
		{
			get
			{
				return minAvgScanRows;
			}
			set	
			{
				minAvgScanRows = value;
				DictionaryUtil.Add(QueryParameters, "MinAvgScanRows", value.ToString());
			}
		}

		public string SqType
		{
			get
			{
				return sqType;
			}
			set	
			{
				sqType = value;
				DictionaryUtil.Add(QueryParameters, "SqType", value);
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

		public string SortMethod
		{
			get
			{
				return sortMethod;
			}
			set	
			{
				sortMethod = value;
				DictionaryUtil.Add(QueryParameters, "SortMethod", value);
			}
		}

		public int? PageNumbers
		{
			get
			{
				return pageNumbers;
			}
			set	
			{
				pageNumbers = value;
				DictionaryUtil.Add(QueryParameters, "PageNumbers", value.ToString());
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

		public string PagingId
		{
			get
			{
				return pagingId;
			}
			set	
			{
				pagingId = value;
				DictionaryUtil.Add(QueryParameters, "PagingId", value);
			}
		}

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		public int? MaxAvgScanRows
		{
			get
			{
				return maxAvgScanRows;
			}
			set	
			{
				maxAvgScanRows = value;
				DictionaryUtil.Add(QueryParameters, "MaxAvgScanRows", value.ToString());
			}
		}

        public override DescribeTemplatesListResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeTemplatesListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}