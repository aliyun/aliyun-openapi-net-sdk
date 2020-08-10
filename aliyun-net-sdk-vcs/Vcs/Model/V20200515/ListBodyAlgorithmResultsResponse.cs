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
	public class ListBodyAlgorithmResultsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private ListBodyAlgorithmResults_Data data;

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

		public ListBodyAlgorithmResults_Data Data
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

		public class ListBodyAlgorithmResults_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private int? totalPage;

			private List<ListBodyAlgorithmResults_RecordsItem> records;

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

			public List<ListBodyAlgorithmResults_RecordsItem> Records
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

			public class ListBodyAlgorithmResults_RecordsItem
			{

				private string capStyle;

				private string corpId;

				private string dataSourceId;

				private string personId;

				private string genderCode;

				private string hairStyle;

				private float? leftTopX;

				private float? leftTopY;

				private string maxAge;

				private string minAge;

				private string picUrlPath;

				private float? rightBottomX;

				private float? rightBottomY;

				private string shotTime;

				private string targetPicUrlPath;

				private string coatLength;

				private string coatStyle;

				private string trousersLength;

				private string trousersStyle;

				private string coatColor;

				private string trousersColor;

				private string sourceId;

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

				public string CoatLength
				{
					get
					{
						return coatLength;
					}
					set	
					{
						coatLength = value;
					}
				}

				public string CoatStyle
				{
					get
					{
						return coatStyle;
					}
					set	
					{
						coatStyle = value;
					}
				}

				public string TrousersLength
				{
					get
					{
						return trousersLength;
					}
					set	
					{
						trousersLength = value;
					}
				}

				public string TrousersStyle
				{
					get
					{
						return trousersStyle;
					}
					set	
					{
						trousersStyle = value;
					}
				}

				public string CoatColor
				{
					get
					{
						return coatColor;
					}
					set	
					{
						coatColor = value;
					}
				}

				public string TrousersColor
				{
					get
					{
						return trousersColor;
					}
					set	
					{
						trousersColor = value;
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
