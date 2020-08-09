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
	public class ListEventAlgorithmResultsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private string extendValue;

		private ListEventAlgorithmResults_Data data;

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

		public string ExtendValue
		{
			get
			{
				return extendValue;
			}
			set	
			{
				extendValue = value;
			}
		}

		public ListEventAlgorithmResults_Data Data
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

		public class ListEventAlgorithmResults_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private int? totalPage;

			private List<ListEventAlgorithmResults_RecordsItem> records;

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

			public int? TotalPage
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

			public List<ListEventAlgorithmResults_RecordsItem> Records
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

			public class ListEventAlgorithmResults_RecordsItem
			{

				private string capStyle;

				private string corpId;

				private string dataSourceId;

				private string eventType;

				private string faceCount;

				private string picUrlPath;

				private string shotTime;

				private string targetPicUrlPath;

				private string recordId;

				private string extendValue;

				private string extendValueTwo;

				private string extendValueThree;

				public string CapStyle
				{
					get
					{
						return capStyle;
					}
					set	
					{
						capStyle = value;
					}
				}

				public string CorpId
				{
					get
					{
						return corpId;
					}
					set	
					{
						corpId = value;
					}
				}

				public string DataSourceId
				{
					get
					{
						return dataSourceId;
					}
					set	
					{
						dataSourceId = value;
					}
				}

				public string EventType
				{
					get
					{
						return eventType;
					}
					set	
					{
						eventType = value;
					}
				}

				public string FaceCount
				{
					get
					{
						return faceCount;
					}
					set	
					{
						faceCount = value;
					}
				}

				public string PicUrlPath
				{
					get
					{
						return picUrlPath;
					}
					set	
					{
						picUrlPath = value;
					}
				}

				public string ShotTime
				{
					get
					{
						return shotTime;
					}
					set	
					{
						shotTime = value;
					}
				}

				public string TargetPicUrlPath
				{
					get
					{
						return targetPicUrlPath;
					}
					set	
					{
						targetPicUrlPath = value;
					}
				}

				public string RecordId
				{
					get
					{
						return recordId;
					}
					set	
					{
						recordId = value;
					}
				}

				public string ExtendValue
				{
					get
					{
						return extendValue;
					}
					set	
					{
						extendValue = value;
					}
				}

				public string ExtendValueTwo
				{
					get
					{
						return extendValueTwo;
					}
					set	
					{
						extendValueTwo = value;
					}
				}

				public string ExtendValueThree
				{
					get
					{
						return extendValueThree;
					}
					set	
					{
						extendValueThree = value;
					}
				}
			}
		}
	}
}
