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

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class ListContactFlowsResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private ListContactFlows_Data data;

		public string Code
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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public ListContactFlows_Data Data
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

		public class ListContactFlows_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListContactFlows_ContactFlow> list;

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

			public List<ListContactFlows_ContactFlow> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListContactFlows_ContactFlow
			{

				private string contactFlowId;

				private string createdTime;

				private string definition;

				private string description;

				private string draftId;

				private string editor;

				private string instanceId;

				private string name;

				private bool? published;

				private string type;

				private string updatedTime;

				private List<string> numberList;

				public string ContactFlowId
				{
					get
					{
						return contactFlowId;
					}
					set	
					{
						contactFlowId = value;
					}
				}

				public string CreatedTime
				{
					get
					{
						return createdTime;
					}
					set	
					{
						createdTime = value;
					}
				}

				public string Definition
				{
					get
					{
						return definition;
					}
					set	
					{
						definition = value;
					}
				}

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

				public string DraftId
				{
					get
					{
						return draftId;
					}
					set	
					{
						draftId = value;
					}
				}

				public string Editor
				{
					get
					{
						return editor;
					}
					set	
					{
						editor = value;
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

				public bool? Published
				{
					get
					{
						return published;
					}
					set	
					{
						published = value;
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

				public string UpdatedTime
				{
					get
					{
						return updatedTime;
					}
					set	
					{
						updatedTime = value;
					}
				}

				public List<string> NumberList
				{
					get
					{
						return numberList;
					}
					set	
					{
						numberList = value;
					}
				}
			}
		}
	}
}
