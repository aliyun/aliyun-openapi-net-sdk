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
using Aliyun.Acs.dms_enterprise.Transform;
using Aliyun.Acs.dms_enterprise.Transform.V20181101;

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
    public class ListLogicTablesRequest : RpcAcsRequest<ListLogicTablesResponse>
    {
        public ListLogicTablesRequest()
            : base("dms-enterprise", "2018-11-01", "ListLogicTables", "dms-enterprise", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string searchName;

		private bool? returnGuid;

		private long? tid;

		private int? pageNumber;

		private int? pageSize;

		private string databaseId;

		[JsonProperty(PropertyName = "SearchName")]
		public string SearchName
		{
			get
			{
				return searchName;
			}
			set	
			{
				searchName = value;
				DictionaryUtil.Add(QueryParameters, "SearchName", value);
			}
		}

		[JsonProperty(PropertyName = "ReturnGuid")]
		public bool? ReturnGuid
		{
			get
			{
				return returnGuid;
			}
			set	
			{
				returnGuid = value;
				DictionaryUtil.Add(QueryParameters, "ReturnGuid", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Tid")]
		public long? Tid
		{
			get
			{
				return tid;
			}
			set	
			{
				tid = value;
				DictionaryUtil.Add(QueryParameters, "Tid", value.ToString());
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

		[JsonProperty(PropertyName = "DatabaseId")]
		public string DatabaseId
		{
			get
			{
				return databaseId;
			}
			set	
			{
				databaseId = value;
				DictionaryUtil.Add(QueryParameters, "DatabaseId", value);
			}
		}

        public override ListLogicTablesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListLogicTablesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
