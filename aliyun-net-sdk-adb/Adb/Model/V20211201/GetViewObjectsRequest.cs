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
using Aliyun.Acs.adb.Transform;
using Aliyun.Acs.adb.Transform.V20211201;

namespace Aliyun.Acs.adb.Model.V20211201
{
    public class GetViewObjectsRequest : RpcAcsRequest<GetViewObjectsResponse>
    {
        public GetViewObjectsRequest()
            : base("adb", "2021-12-01", "GetViewObjects", "ads", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? pageNumber;

		private long? pageSize;

		private string filterViewName;

		private string filterViewType;

		private string schemaName;

		private string dBClusterId;

		private string orderBy;

		private string filterOwner;

		public long? PageNumber
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

		public string FilterViewName
		{
			get
			{
				return filterViewName;
			}
			set	
			{
				filterViewName = value;
				DictionaryUtil.Add(QueryParameters, "FilterViewName", value);
			}
		}

		public string FilterViewType
		{
			get
			{
				return filterViewType;
			}
			set	
			{
				filterViewType = value;
				DictionaryUtil.Add(QueryParameters, "FilterViewType", value);
			}
		}

		public string SchemaName
		{
			get
			{
				return schemaName;
			}
			set	
			{
				schemaName = value;
				DictionaryUtil.Add(QueryParameters, "SchemaName", value);
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

		public string OrderBy
		{
			get
			{
				return orderBy;
			}
			set	
			{
				orderBy = value;
				DictionaryUtil.Add(QueryParameters, "OrderBy", value);
			}
		}

		public string FilterOwner
		{
			get
			{
				return filterOwner;
			}
			set	
			{
				filterOwner = value;
				DictionaryUtil.Add(QueryParameters, "FilterOwner", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetViewObjectsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetViewObjectsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
