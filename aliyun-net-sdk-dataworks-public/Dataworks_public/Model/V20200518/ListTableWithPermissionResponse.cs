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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListTableWithPermissionResponse : AcsResponse
	{

		private string requestId;

		private ListTableWithPermission_Tables tables;

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

		public ListTableWithPermission_Tables Tables
		{
			get
			{
				return tables;
			}
			set	
			{
				tables = value;
			}
		}

		public class ListTableWithPermission_Tables
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListTableWithPermission_TableListItem> tableList;

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
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

			public List<ListTableWithPermission_TableListItem> TableList
			{
				get
				{
					return tableList;
				}
				set	
				{
					tableList = value;
				}
			}

			public class ListTableWithPermission_TableListItem
			{

				private string projectGuid;

				private string guid;

				private string name;

				private string nameCn;

				private string comment;

				private string owner;

				private List<string> action;

				public string ProjectGuid
				{
					get
					{
						return projectGuid;
					}
					set	
					{
						projectGuid = value;
					}
				}

				public string Guid
				{
					get
					{
						return guid;
					}
					set	
					{
						guid = value;
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

				public string NameCn
				{
					get
					{
						return nameCn;
					}
					set	
					{
						nameCn = value;
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

				public string Owner
				{
					get
					{
						return owner;
					}
					set	
					{
						owner = value;
					}
				}

				public List<string> Action
				{
					get
					{
						return action;
					}
					set	
					{
						action = value;
					}
				}
			}
		}
	}
}
