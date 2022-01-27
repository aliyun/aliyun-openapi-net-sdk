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

namespace Aliyun.Acs.CDRS.Model.V20201101
{
	public class ListPersonTrackResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private long? pageNumber;

		private long? pageSize;

		private long? totalCount;

		private List<ListPersonTrack_Datas> data;

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

		public List<ListPersonTrack_Datas> Data
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

		public class ListPersonTrack_Datas
		{

			private string personId;

			private string corpId;

			private string dataSourceId;

			private string dataSourceName;

			private string picUrlPath;

			private string targetPicUrlPath;

			private string rightBottomY;

			private string rightBottomX;

			private string leftTopY;

			private string leftTopX;

			private string shotTime;

			private string order;

			private string longitude;

			private string latitude;

			private string sourceUrl;

			private string targetUrl;

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

			public string DataSourceName
			{
				get
				{
					return dataSourceName;
				}
				set	
				{
					dataSourceName = value;
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

			public string Order
			{
				get
				{
					return order;
				}
				set	
				{
					order = value;
				}
			}

			public string Longitude
			{
				get
				{
					return longitude;
				}
				set	
				{
					longitude = value;
				}
			}

			public string Latitude
			{
				get
				{
					return latitude;
				}
				set	
				{
					latitude = value;
				}
			}

			public string SourceUrl
			{
				get
				{
					return sourceUrl;
				}
				set	
				{
					sourceUrl = value;
				}
			}

			public string TargetUrl
			{
				get
				{
					return targetUrl;
				}
				set	
				{
					targetUrl = value;
				}
			}
		}
	}
}
