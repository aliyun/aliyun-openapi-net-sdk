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
	public class ListRootStacksResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private int? code;

		private ListRootStacks_Data data;

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

		public ListRootStacks_Data Data
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

		public class ListRootStacks_Data
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalSize;

			private List<ListRootStacks_RootStack> result;

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

			public List<ListRootStacks_RootStack> Result
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

			public class ListRootStacks_RootStack
			{

				private List<ListRootStacks_ChildStack> children;

				private ListRootStacks_Root root;

				public List<ListRootStacks_ChildStack> Children
				{
					get
					{
						return children;
					}
					set	
					{
						children = value;
					}
				}

				public ListRootStacks_Root Root
				{
					get
					{
						return root;
					}
					set	
					{
						root = value;
					}
				}

				public class ListRootStacks_ChildStack
				{

					private long? id;

					private string name;

					private string icon;

					private string comment;

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

					public string Icon
					{
						get
						{
							return icon;
						}
						set	
						{
							icon = value;
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
				}

				public class ListRootStacks_Root
				{

					private long? id;

					private string name;

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
				}
			}
		}
	}
}
