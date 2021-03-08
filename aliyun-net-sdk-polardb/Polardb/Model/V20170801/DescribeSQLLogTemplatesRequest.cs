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
    public class DescribeSQLLogTemplatesRequest : RpcAcsRequest<DescribeSQLLogTemplatesResponse>
    {
        public DescribeSQLLogTemplatesRequest()
            : base("polardb", "2017-08-01", "DescribeSQLLogTemplates", "polardb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string startTime;

		private string jobId;

		private string sortKey;

		private float? minAvgScanRows;

		private string securityToken;

		private int? pageNumbers;

		private string pagingId;

		private string dBInstanceId;

		private float? maxAvgScanRows;

		private string sqlType;

		private string resourceOwnerAccount;

		private float? minAvgConsume;

		private string ownerAccount;

		private int? maxRecordsPerPage;

		private string endTime;

		private long? ownerId;

		private float? maxAvgConsume;

		private string childDBInstanceIDs;

		private string sortMethod;

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

		public string JobId
		{
			get
			{
				return jobId;
			}
			set	
			{
				jobId = value;
				DictionaryUtil.Add(QueryParameters, "JobId", value);
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

		public float? MinAvgScanRows
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

		public float? MaxAvgScanRows
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

		public string SqlType
		{
			get
			{
				return sqlType;
			}
			set	
			{
				sqlType = value;
				DictionaryUtil.Add(QueryParameters, "SqlType", value);
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

		public float? MinAvgConsume
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

		public float? MaxAvgConsume
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

		public string ChildDBInstanceIDs
		{
			get
			{
				return childDBInstanceIDs;
			}
			set	
			{
				childDBInstanceIDs = value;
				DictionaryUtil.Add(QueryParameters, "ChildDBInstanceIDs", value);
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

        public override DescribeSQLLogTemplatesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeSQLLogTemplatesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
