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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class ListCheckInstanceResultResponse : AcsResponse
	{

		private string nextToken;

		private int? maxResults;

		private int? totalCount;

		private string requestId;

		private string checks;

		private List<ListCheckInstanceResult_BasicDataItem> basicData;

		private List<ListCheckInstanceResult_ColumnsItem> columns;

		private ListCheckInstanceResult_PageInfo pageInfo;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string Checks
		{
			get
			{
				return checks;
			}
			set	
			{
				checks = value;
			}
		}

		public List<ListCheckInstanceResult_BasicDataItem> BasicData
		{
			get
			{
				return basicData;
			}
			set	
			{
				basicData = value;
			}
		}

		public List<ListCheckInstanceResult_ColumnsItem> Columns
		{
			get
			{
				return columns;
			}
			set	
			{
				columns = value;
			}
		}

		public ListCheckInstanceResult_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class ListCheckInstanceResult_BasicDataItem
		{

			private long? id;

			private string status;

			private string regionId;

			private string instanceId;

			private string instanceName;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
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
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}
		}

		public class ListCheckInstanceResult_ColumnsItem
		{

			private string type;

			private string key;

			private string showName;

			private bool? search;

			private string searchKey;

			private List<ListCheckInstanceResult_GridsItem> grids;

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string ShowName
			{
				get
				{
					return showName;
				}
				set	
				{
					showName = value;
				}
			}

			public bool? Search
			{
				get
				{
					return search;
				}
				set	
				{
					search = value;
				}
			}

			public string SearchKey
			{
				get
				{
					return searchKey;
				}
				set	
				{
					searchKey = value;
				}
			}

			public List<ListCheckInstanceResult_GridsItem> Grids
			{
				get
				{
					return grids;
				}
				set	
				{
					grids = value;
				}
			}

			public class ListCheckInstanceResult_GridsItem
			{

				private string type;

				private string key;

				private string showName;

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string ShowName
				{
					get
					{
						return showName;
					}
					set	
					{
						showName = value;
					}
				}
			}
		}

		public class ListCheckInstanceResult_PageInfo
		{

			private int? currentPage;

			private int? pageSize;

			private string nextToken;

			private int? maxResults;

			private int? totalCount;

			private string count;

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
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
				}
			}

			public string NextToken
			{
				get
				{
					return nextToken;
				}
				set	
				{
					nextToken = value;
				}
			}

			public int? MaxResults
			{
				get
				{
					return maxResults;
				}
				set	
				{
					maxResults = value;
				}
			}

			public int? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public string Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}
		}
	}
}
