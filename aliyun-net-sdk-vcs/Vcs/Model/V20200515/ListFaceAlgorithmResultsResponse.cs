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
	public class ListFaceAlgorithmResultsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private ListFaceAlgorithmResults_Data data;

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

		public ListFaceAlgorithmResults_Data Data
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

		public class ListFaceAlgorithmResults_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private int? totalPage;

			private List<ListFaceAlgorithmResults_RecordsItem> records;

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

			public List<ListFaceAlgorithmResults_RecordsItem> Records
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

			public class ListFaceAlgorithmResults_RecordsItem
			{

				private string faceId;

				private string corpId;

				private string dataSourceId;

				private string shotTime;

				private string genderCode;

				private string minAge;

				private string maxAge;

				private string capStyle;

				private string hairStyle;

				private float? leftTopX;

				private float? leftTopY;

				private float? rightBottomX;

				private float? rightBottomY;

				private string picUrlPath;

				private string targetPicUrlPath;

				private string sourceId;

				public string FaceId
				{
					get
					{
						return faceId;
					}
					set	
					{
						faceId = value;
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

				public string GenderCode
				{
					get
					{
						return genderCode;
					}
					set	
					{
						genderCode = value;
					}
				}

				public string MinAge
				{
					get
					{
						return minAge;
					}
					set	
					{
						minAge = value;
					}
				}

				public string MaxAge
				{
					get
					{
						return maxAge;
					}
					set	
					{
						maxAge = value;
					}
				}

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

				public string HairStyle
				{
					get
					{
						return hairStyle;
					}
					set	
					{
						hairStyle = value;
					}
				}

				public float? LeftTopX
				{
					get
					{
						return leftTopX;
					}
					set	
					{
						leftTopX = value;
					}
				}

				public float? LeftTopY
				{
					get
					{
						return leftTopY;
					}
					set	
					{
						leftTopY = value;
					}
				}

				public float? RightBottomX
				{
					get
					{
						return rightBottomX;
					}
					set	
					{
						rightBottomX = value;
					}
				}

				public float? RightBottomY
				{
					get
					{
						return rightBottomY;
					}
					set	
					{
						rightBottomY = value;
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

				public string SourceId
				{
					get
					{
						return sourceId;
					}
					set	
					{
						sourceId = value;
					}
				}
			}
		}
	}
}
