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
using Aliyun.Acs.vs;
using Aliyun.Acs.vs.Transform;
using Aliyun.Acs.vs.Transform.V20181212;

namespace Aliyun.Acs.vs.Model.V20181212
{
    public class DescribeRecordsRequest : RpcAcsRequest<DescribeRecordsResponse>
    {
        public DescribeRecordsRequest()
            : base("vs", "2018-12-12", "DescribeRecords")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sortDirection;

		private string startTime;

		private string type;

		private long? pageNum;

		private bool? privateBucket;

		private long? pageSize;

		private string streamId;

		private string endTime;

		private long? ownerId;

		private string sortBy;

		public string SortDirection
		{
			get
			{
				return sortDirection;
			}
			set	
			{
				sortDirection = value;
				DictionaryUtil.Add(QueryParameters, "SortDirection", value);
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

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public long? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public bool? PrivateBucket
		{
			get
			{
				return privateBucket;
			}
			set	
			{
				privateBucket = value;
				DictionaryUtil.Add(QueryParameters, "PrivateBucket", value.ToString());
			}
		}

		public long? PageSize
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

		public string StreamId
		{
			get
			{
				return streamId;
			}
			set	
			{
				streamId = value;
				DictionaryUtil.Add(QueryParameters, "StreamId", value);
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

		public string SortBy
		{
			get
			{
				return sortBy;
			}
			set	
			{
				sortBy = value;
				DictionaryUtil.Add(QueryParameters, "SortBy", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeRecordsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeRecordsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
