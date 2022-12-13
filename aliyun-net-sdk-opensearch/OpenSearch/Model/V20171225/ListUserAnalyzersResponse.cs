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

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
	public class ListUserAnalyzersResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private List<ListUserAnalyzers_ResultItem> result;

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

		public List<ListUserAnalyzers_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListUserAnalyzers_ResultItem
		{

			private int? created;

			private bool? available;

			private string name;

			private int? updated;

			private string id;

			private string business;

			private List<ListUserAnalyzers_DictsItem> dicts;

			public int? Created
			{
				get
				{
					return created;
				}
				set	
				{
					created = value;
				}
			}

			public bool? Available
			{
				get
				{
					return available;
				}
				set	
				{
					available = value;
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
				}
			}

			public int? Updated
			{
				get
				{
					return updated;
				}
				set	
				{
					updated = value;
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
				}
			}

			public string Business
			{
				get
				{
					return business;
				}
				set	
				{
					business = value;
				}
			}

			public List<ListUserAnalyzers_DictsItem> Dicts
			{
				get
				{
					return dicts;
				}
				set	
				{
					dicts = value;
				}
			}

			public class ListUserAnalyzers_DictsItem
			{

				private int? created;

				private int? entriesCount;

				private string type;

				private int? entriesLimit;

				private bool? available;

				private int? updated;

				private string id;

				public int? Created
				{
					get
					{
						return created;
					}
					set	
					{
						created = value;
					}
				}

				public int? EntriesCount
				{
					get
					{
						return entriesCount;
					}
					set	
					{
						entriesCount = value;
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
					}
				}

				public int? EntriesLimit
				{
					get
					{
						return entriesLimit;
					}
					set	
					{
						entriesLimit = value;
					}
				}

				public bool? Available
				{
					get
					{
						return available;
					}
					set	
					{
						available = value;
					}
				}

				public int? Updated
				{
					get
					{
						return updated;
					}
					set	
					{
						updated = value;
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
					}
				}
			}
		}
	}
}
