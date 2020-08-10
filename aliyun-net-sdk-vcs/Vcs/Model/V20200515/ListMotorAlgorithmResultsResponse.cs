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
	public class ListMotorAlgorithmResultsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private ListMotorAlgorithmResults_Data data;

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

		public ListMotorAlgorithmResults_Data Data
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

		public class ListMotorAlgorithmResults_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private int? totalPage;

			private List<ListMotorAlgorithmResults_RecordsItem> records;

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

			public List<ListMotorAlgorithmResults_RecordsItem> Records
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

			public class ListMotorAlgorithmResults_RecordsItem
			{

				private string corpId;

				private string dataSourceId;

				private float? leftTopX;

				private float? leftTopY;

				private string motorId;

				private string picUrlPath;

				private string plateNumber;

				private float? rightBottomX;

				private float? rightBottomY;

				private string shotTime;

				private string targetPicUrlPath;

				private string motorStyle;

				private string motorModel;

				private string motorColor;

				private string motorClass;

				private string motorBrand;

				private string plateColor;

				private string plateClass;

				private string safetyBelt;

				private string calling;

				private string sourceId;

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

				public string MotorId
				{
					get
					{
						return motorId;
					}
					set	
					{
						motorId = value;
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

				public string PlateNumber
				{
					get
					{
						return plateNumber;
					}
					set	
					{
						plateNumber = value;
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

				public string MotorStyle
				{
					get
					{
						return motorStyle;
					}
					set	
					{
						motorStyle = value;
					}
				}

				public string MotorModel
				{
					get
					{
						return motorModel;
					}
					set	
					{
						motorModel = value;
					}
				}

				public string MotorColor
				{
					get
					{
						return motorColor;
					}
					set	
					{
						motorColor = value;
					}
				}

				public string MotorClass
				{
					get
					{
						return motorClass;
					}
					set	
					{
						motorClass = value;
					}
				}

				public string MotorBrand
				{
					get
					{
						return motorBrand;
					}
					set	
					{
						motorBrand = value;
					}
				}

				public string PlateColor
				{
					get
					{
						return plateColor;
					}
					set	
					{
						plateColor = value;
					}
				}

				public string PlateClass
				{
					get
					{
						return plateClass;
					}
					set	
					{
						plateClass = value;
					}
				}

				public string SafetyBelt
				{
					get
					{
						return safetyBelt;
					}
					set	
					{
						safetyBelt = value;
					}
				}

				public string Calling
				{
					get
					{
						return calling;
					}
					set	
					{
						calling = value;
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
