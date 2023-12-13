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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class ListAllProdsResponse : AcsResponse
	{

		private string requestId;

		private ListAllProds_Data data;

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

		public ListAllProds_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListAllProds_Data
		{

			private int? totalCount;

			private int? pageSize;

			private int? currentPage;

			private List<ListAllProds_ProdListItem> prodList;

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

			public List<ListAllProds_ProdListItem> ProdList
			{
				get
				{
					return prodList;
				}
				set	
				{
					prodList = value;
				}
			}

			public class ListAllProds_ProdListItem
			{

				private string prodCode;

				private int? totalLogCount;

				private int? importedLogCount;

				private string modifyTime;

				private string cloudCode;

				public string ProdCode
				{
					get
					{
						return prodCode;
					}
					set	
					{
						prodCode = value;
					}
				}

				public int? TotalLogCount
				{
					get
					{
						return totalLogCount;
					}
					set	
					{
						totalLogCount = value;
					}
				}

				public int? ImportedLogCount
				{
					get
					{
						return importedLogCount;
					}
					set	
					{
						importedLogCount = value;
					}
				}

				public string ModifyTime
				{
					get
					{
						return modifyTime;
					}
					set	
					{
						modifyTime = value;
					}
				}

				public string CloudCode
				{
					get
					{
						return cloudCode;
					}
					set	
					{
						cloudCode = value;
					}
				}
			}
		}
	}
}
