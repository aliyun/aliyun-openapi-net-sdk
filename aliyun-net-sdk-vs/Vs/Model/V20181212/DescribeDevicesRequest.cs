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
    public class DescribeDevicesRequest : RpcAcsRequest<DescribeDevicesResponse>
    {
        public DescribeDevicesRequest()
            : base("vs", "2018-12-12", "DescribeDevices")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sortDirection;

		private bool? includeDirectory;

		private string gbId;

		private string type;

		private long? pageNum;

		private string parentId;

		private bool? includeStats;

		private string vendor;

		private long? pageSize;

		private string directoryId;

		private string id;

		private string groupId;

		private long? ownerId;

		private string name;

		private string sortBy;

		private string status;

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

		public bool? IncludeDirectory
		{
			get
			{
				return includeDirectory;
			}
			set	
			{
				includeDirectory = value;
				DictionaryUtil.Add(QueryParameters, "IncludeDirectory", value.ToString());
			}
		}

		public string GbId
		{
			get
			{
				return gbId;
			}
			set	
			{
				gbId = value;
				DictionaryUtil.Add(QueryParameters, "GbId", value);
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

		public string ParentId
		{
			get
			{
				return parentId;
			}
			set	
			{
				parentId = value;
				DictionaryUtil.Add(QueryParameters, "ParentId", value);
			}
		}

		public bool? IncludeStats
		{
			get
			{
				return includeStats;
			}
			set	
			{
				includeStats = value;
				DictionaryUtil.Add(QueryParameters, "IncludeStats", value.ToString());
			}
		}

		public string Vendor
		{
			get
			{
				return vendor;
			}
			set	
			{
				vendor = value;
				DictionaryUtil.Add(QueryParameters, "Vendor", value);
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

		public string DirectoryId
		{
			get
			{
				return directoryId;
			}
			set	
			{
				directoryId = value;
				DictionaryUtil.Add(QueryParameters, "DirectoryId", value);
			}
		}

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
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

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
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

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeDevicesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDevicesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
