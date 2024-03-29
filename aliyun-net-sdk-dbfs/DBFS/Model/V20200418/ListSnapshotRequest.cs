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
using Aliyun.Acs.DBFS.Transform;
using Aliyun.Acs.DBFS.Transform.V20200418;

namespace Aliyun.Acs.DBFS.Model.V20200418
{
    public class ListSnapshotRequest : RpcAcsRequest<ListSnapshotResponse>
    {
        public ListSnapshotRequest()
            : base("DBFS", "2020-04-18", "ListSnapshot", "dbfs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.DBFS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.DBFS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sortType;

		private string snapshotIds;

		private string filterValue;

		private string snapshotName;

		private int? pageNumber;

		private string filterKey;

		private string sortKey;

		private int? pageSize;

		private string fsId;

		private string snapshotType;

		private string status;

		[JsonProperty(PropertyName = "SortType")]
		public string SortType
		{
			get
			{
				return sortType;
			}
			set	
			{
				sortType = value;
				DictionaryUtil.Add(QueryParameters, "SortType", value);
			}
		}

		[JsonProperty(PropertyName = "SnapshotIds")]
		public string SnapshotIds
		{
			get
			{
				return snapshotIds;
			}
			set	
			{
				snapshotIds = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotIds", value);
			}
		}

		[JsonProperty(PropertyName = "FilterValue")]
		public string FilterValue
		{
			get
			{
				return filterValue;
			}
			set	
			{
				filterValue = value;
				DictionaryUtil.Add(QueryParameters, "FilterValue", value);
			}
		}

		[JsonProperty(PropertyName = "SnapshotName")]
		public string SnapshotName
		{
			get
			{
				return snapshotName;
			}
			set	
			{
				snapshotName = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotName", value);
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

		[JsonProperty(PropertyName = "FilterKey")]
		public string FilterKey
		{
			get
			{
				return filterKey;
			}
			set	
			{
				filterKey = value;
				DictionaryUtil.Add(QueryParameters, "FilterKey", value);
			}
		}

		[JsonProperty(PropertyName = "SortKey")]
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

		[JsonProperty(PropertyName = "FsId")]
		public string FsId
		{
			get
			{
				return fsId;
			}
			set	
			{
				fsId = value;
				DictionaryUtil.Add(QueryParameters, "FsId", value);
			}
		}

		[JsonProperty(PropertyName = "SnapshotType")]
		public string SnapshotType
		{
			get
			{
				return snapshotType;
			}
			set	
			{
				snapshotType = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotType", value);
			}
		}

		[JsonProperty(PropertyName = "Status")]
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

        public override ListSnapshotResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListSnapshotResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
