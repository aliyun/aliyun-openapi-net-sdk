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
using Aliyun.Acs.OpenSearch.Transform;
using Aliyun.Acs.OpenSearch.Transform.V20171225;

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
    public class ListStatisticLogsRequest : RoaAcsRequest<ListStatisticLogsResponse>
    {
        public ListStatisticLogsRequest()
            : base("OpenSearch", "2017-12-25", "ListStatisticLogs", "opensearch", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OpenSearch.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OpenSearch.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/v4/openapi/app-groups/[appGroupIdentity]/statistic-logs/[moduleName]";
			Method = MethodType.GET;
        }

		private string columns;

		private string query;

		private int? pageSize;

		private string moduleName;

		private bool? distinct;

		private string sortBy;

		private int? startTime;

		private int? stopTime;

		private string appGroupIdentity;

		private int? pageNumber;

		public string Columns
		{
			get
			{
				return columns;
			}
			set	
			{
				columns = value;
				DictionaryUtil.Add(QueryParameters, "columns", value);
			}
		}

		public string Query
		{
			get
			{
				return query;
			}
			set	
			{
				query = value;
				DictionaryUtil.Add(QueryParameters, "query", value);
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
				DictionaryUtil.Add(QueryParameters, "pageSize", value.ToString());
			}
		}

		public string ModuleName
		{
			get
			{
				return moduleName;
			}
			set	
			{
				moduleName = value;
				DictionaryUtil.Add(PathParameters, "moduleName", value);
			}
		}

		public bool? Distinct
		{
			get
			{
				return distinct;
			}
			set	
			{
				distinct = value;
				DictionaryUtil.Add(QueryParameters, "distinct", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "sortBy", value);
			}
		}

		public int? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "startTime", value.ToString());
			}
		}

		public int? StopTime
		{
			get
			{
				return stopTime;
			}
			set	
			{
				stopTime = value;
				DictionaryUtil.Add(QueryParameters, "stopTime", value.ToString());
			}
		}

		public string AppGroupIdentity
		{
			get
			{
				return appGroupIdentity;
			}
			set	
			{
				appGroupIdentity = value;
				DictionaryUtil.Add(PathParameters, "appGroupIdentity", value);
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
				DictionaryUtil.Add(QueryParameters, "pageNumber", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListStatisticLogsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListStatisticLogsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
