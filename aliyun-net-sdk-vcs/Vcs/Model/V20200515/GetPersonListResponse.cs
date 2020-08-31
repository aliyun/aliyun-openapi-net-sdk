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
	public class GetPersonListResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private GetPersonList_Data data;

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

		public GetPersonList_Data Data
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

		public class GetPersonList_Data
		{

			private long? pageNumber;

			private long? pageSize;

			private long? totalCount;

			private List<GetPersonList_RecordsItem> records;

			public long? PageNumber
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

			public long? PageSize
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

			public long? TotalCount
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

			public List<GetPersonList_RecordsItem> Records
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

			public class GetPersonList_RecordsItem
			{

				private string faceUrl;

				private long? firstShotTime;

				private string personId;

				private string searchMatchingRate;

				private long? lastShotTime;

				private List<GetPersonList_TagList> propertyTagList;

				public string FaceUrl
				{
					get
					{
						return faceUrl;
					}
					set	
					{
						faceUrl = value;
					}
				}

				public long? FirstShotTime
				{
					get
					{
						return firstShotTime;
					}
					set	
					{
						firstShotTime = value;
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

				public string SearchMatchingRate
				{
					get
					{
						return searchMatchingRate;
					}
					set	
					{
						searchMatchingRate = value;
					}
				}

				public long? LastShotTime
				{
					get
					{
						return lastShotTime;
					}
					set	
					{
						lastShotTime = value;
					}
				}

				public List<GetPersonList_TagList> PropertyTagList
				{
					get
					{
						return propertyTagList;
					}
					set	
					{
						propertyTagList = value;
					}
				}

				public class GetPersonList_TagList
				{

					private string code;

					private string tagCodeName;

					private string tagName;

					private string _value;

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

					public string TagCodeName
					{
						get
						{
							return tagCodeName;
						}
						set	
						{
							tagCodeName = value;
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

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}
			}
		}
	}
}
