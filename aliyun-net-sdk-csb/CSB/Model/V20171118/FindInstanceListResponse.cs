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

namespace Aliyun.Acs.CSB.Model.V20171118
{
	public class FindInstanceListResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private FindInstanceList_Data data;

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

		public FindInstanceList_Data Data
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

		public class FindInstanceList_Data
		{

			private int? currentPage;

			private int? pageNumber;

			private List<FindInstanceList_Item> itemList;

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

			public List<FindInstanceList_Item> ItemList
			{
				get
				{
					return itemList;
				}
				set	
				{
					itemList = value;
				}
			}

			public class FindInstanceList_Item
			{

				private string description;

				private string frontStatus;

				private long? gmtCreate;

				private long? gmtModified;

				private long? id;

				private int? instanceCategory;

				private string name;

				private int? statusCode;

				private bool? visible;

				private string vpcName;

				public string Description
				{
					get
					{
						return description;
					}
					set	
					{
						description = value;
					}
				}

				public string FrontStatus
				{
					get
					{
						return frontStatus;
					}
					set	
					{
						frontStatus = value;
					}
				}

				public long? GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public long? GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

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

				public int? InstanceCategory
				{
					get
					{
						return instanceCategory;
					}
					set	
					{
						instanceCategory = value;
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

				public int? StatusCode
				{
					get
					{
						return statusCode;
					}
					set	
					{
						statusCode = value;
					}
				}

				public bool? Visible
				{
					get
					{
						return visible;
					}
					set	
					{
						visible = value;
					}
				}

				public string VpcName
				{
					get
					{
						return vpcName;
					}
					set	
					{
						vpcName = value;
					}
				}
			}
		}
	}
}
