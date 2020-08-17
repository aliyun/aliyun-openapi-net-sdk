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
	public class ListEventAlgorithmDetailsResponse : AcsResponse
	{

		private string code;

		private string message;

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private string success;

		private int? totalCount;

		private List<ListEventAlgorithmDetails_Datas> data;

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

		public string Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public List<ListEventAlgorithmDetails_Datas> Data
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

		public class ListEventAlgorithmDetails_Datas
		{

			private string corpId;

			private string dataSourceId;

			private string eventType;

			private string eventValue;

			private string extendValue;

			private string extraExtendValue;

			private string faceCount;

			private string leftTopX;

			private string leftTopY;

			private string picUrlPath;

			private string pointX;

			private string pointY;

			private string recordId;

			private string rightBottomX;

			private string rightBottomY;

			private string shotTime;

			private string sourceId;

			private string targetPicUrlPath;

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

			public string EventValue
			{
				get
				{
					return eventValue;
				}
				set	
				{
					eventValue = value;
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

			public string ExtraExtendValue
			{
				get
				{
					return extraExtendValue;
				}
				set	
				{
					extraExtendValue = value;
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

			public string LeftTopX
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

			public string LeftTopY
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

			public string PointX
			{
				get
				{
					return pointX;
				}
				set	
				{
					pointX = value;
				}
			}

			public string PointY
			{
				get
				{
					return pointY;
				}
				set	
				{
					pointY = value;
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

			public string RightBottomX
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

			public string RightBottomY
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
		}
	}
}
