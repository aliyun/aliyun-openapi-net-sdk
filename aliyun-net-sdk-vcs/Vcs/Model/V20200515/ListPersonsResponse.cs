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

namespace Aliyun.Acs.Vcs.Model.V20200515
{
	public class ListPersonsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private ListPersons_Data data;

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

		public ListPersons_Data Data
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

		public class ListPersons_Data
		{

			private string pageNo;

			private string pageSize;

			private string totalCount;

			private string totalPage;

			private List<ListPersons_RecordsItem> records;

			public string PageNo
			{
				get
				{
					return pageNo;
				}
				set	
				{
					pageNo = value;
				}
			}

			public string PageSize
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

			public string TotalCount
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

			public string TotalPage
			{
				get
				{
					return totalPage;
				}
				set	
				{
					totalPage = value;
				}
			}

			public List<ListPersons_RecordsItem> Records
			{
				get
				{
					return records;
				}
				set	
				{
					records = value;
				}
			}

			public class ListPersons_RecordsItem
			{

				private string firstAppearTime;

				private string personId;

				private string picUrl;

				private List<ListPersons_TagListItem> tagList;

				public string FirstAppearTime
				{
					get
					{
						return firstAppearTime;
					}
					set	
					{
						firstAppearTime = value;
					}
				}

				public string PersonId
				{
					get
					{
						return personId;
					}
					set	
					{
						personId = value;
					}
				}

				public string PicUrl
				{
					get
					{
						return picUrl;
					}
					set	
					{
						picUrl = value;
					}
				}

				public List<ListPersons_TagListItem> TagList
				{
					get
					{
						return tagList;
					}
					set	
					{
						tagList = value;
					}
				}

				public class ListPersons_TagListItem
				{

					private string tagCode;

					private string tagName;

					private string tagValue;

					private string tagValueId;

					public string TagCode
					{
						get
						{
							return tagCode;
						}
						set	
						{
							tagCode = value;
						}
					}

					public string TagName
					{
						get
						{
							return tagName;
						}
						set	
						{
							tagName = value;
						}
					}

					public string TagValue
					{
						get
						{
							return tagValue;
						}
						set	
						{
							tagValue = value;
						}
					}

					public string TagValueId
					{
						get
						{
							return tagValueId;
						}
						set	
						{
							tagValueId = value;
						}
					}
				}
			}
		}
	}
}
