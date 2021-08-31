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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class ListChildrenStacksResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private ListChildrenStacks_Data data;

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

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public ListChildrenStacks_Data Data
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

		public class ListChildrenStacks_Data
		{

			private int? pageSize;

			private int? totalSize;

			private int? currentPage;

			private List<ListChildrenStacks_Stack> result;

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

			public int? TotalSize
			{
				get
				{
					return totalSize;
				}
				set	
				{
					totalSize = value;
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

			public List<ListChildrenStacks_Stack> Result
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

			public class ListChildrenStacks_Stack
			{

				private long? id;

				private string name;

				private string comment;

				private bool? preferred;

				private bool? latest;

				private List<string> buildTypes;

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

				public string Comment
				{
					get
					{
						return comment;
					}
					set	
					{
						comment = value;
					}
				}

				public bool? Preferred
				{
					get
					{
						return preferred;
					}
					set	
					{
						preferred = value;
					}
				}

				public bool? Latest
				{
					get
					{
						return latest;
					}
					set	
					{
						latest = value;
					}
				}

				public List<string> BuildTypes
				{
					get
					{
						return buildTypes;
					}
					set	
					{
						buildTypes = value;
					}
				}
			}
		}
	}
}
