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
	public class SearchAggregateObjectResponse : AcsResponse
	{

		private string code;

		private string message;

		private int? total;

		private long? pageSize;

		private string requestId;

		private bool? success;

		private SearchAggregateObject_Data data;

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

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
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

		public bool? Success
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

		public SearchAggregateObject_Data Data
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

		public class SearchAggregateObject_Data
		{

			private List<SearchAggregateObject_BodyListItem> bodyList;

			private List<SearchAggregateObject_FaceListItem> faceList;

			private List<SearchAggregateObject_MotorListItem> motorList;

			private List<SearchAggregateObject_NonMotorListItem> nonMotorList;

			public List<SearchAggregateObject_BodyListItem> BodyList
			{
				get
				{
					return bodyList;
				}
				set	
				{
					bodyList = value;
				}
			}

			public List<SearchAggregateObject_FaceListItem> FaceList
			{
				get
				{
					return faceList;
				}
				set	
				{
					faceList = value;
				}
			}

			public List<SearchAggregateObject_MotorListItem> MotorList
			{
				get
				{
					return motorList;
				}
				set	
				{
					motorList = value;
				}
			}

			public List<SearchAggregateObject_NonMotorListItem> NonMotorList
			{
				get
				{
					return nonMotorList;
				}
				set	
				{
					nonMotorList = value;
				}
			}

			public class SearchAggregateObject_BodyListItem
			{

				private string deviceID;

				private string objectType;

				private int? leftTopX;

				private int? leftTopY;

				private int? rightBottomX;

				private int? rightBottomY;

				private float? score;

				private string shotTime;

				private string sourceImageUrl;

				private string targetImageUrl;

				private string deviceName;

				private float? deviceLatitude;

				private float? deviceLongitude;

				private string personId;

				public string DeviceID
				{
					get
					{
						return deviceID;
					}
					set	
					{
						deviceID = value;
					}
				}

				public string ObjectType
				{
					get
					{
						return objectType;
					}
					set	
					{
						objectType = value;
					}
				}

				public int? LeftTopX
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

				public int? LeftTopY
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

				public int? RightBottomX
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

				public int? RightBottomY
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

				public float? Score
				{
					get
					{
						return score;
					}
					set	
					{
						score = value;
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

				public string SourceImageUrl
				{
					get
					{
						return sourceImageUrl;
					}
					set	
					{
						sourceImageUrl = value;
					}
				}

				public string TargetImageUrl
				{
					get
					{
						return targetImageUrl;
					}
					set	
					{
						targetImageUrl = value;
					}
				}

				public string DeviceName
				{
					get
					{
						return deviceName;
					}
					set	
					{
						deviceName = value;
					}
				}

				public float? DeviceLatitude
				{
					get
					{
						return deviceLatitude;
					}
					set	
					{
						deviceLatitude = value;
					}
				}

				public float? DeviceLongitude
				{
					get
					{
						return deviceLongitude;
					}
					set	
					{
						deviceLongitude = value;
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
			}

			public class SearchAggregateObject_FaceListItem
			{

				private string deviceID;

				private string objectType;

				private int? leftTopX;

				private int? leftTopY;

				private int? rightBottomX;

				private int? rightBottomY;

				private float? score;

				private string shotTime;

				private string sourceImageUrl;

				private string targetImageUrl;

				private string deviceName;

				private float? deviceLatitude;

				private float? deviceLongitude;

				private string personId;

				public string DeviceID
				{
					get
					{
						return deviceID;
					}
					set	
					{
						deviceID = value;
					}
				}

				public string ObjectType
				{
					get
					{
						return objectType;
					}
					set	
					{
						objectType = value;
					}
				}

				public int? LeftTopX
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

				public int? LeftTopY
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

				public int? RightBottomX
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

				public int? RightBottomY
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

				public float? Score
				{
					get
					{
						return score;
					}
					set	
					{
						score = value;
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

				public string SourceImageUrl
				{
					get
					{
						return sourceImageUrl;
					}
					set	
					{
						sourceImageUrl = value;
					}
				}

				public string TargetImageUrl
				{
					get
					{
						return targetImageUrl;
					}
					set	
					{
						targetImageUrl = value;
					}
				}

				public string DeviceName
				{
					get
					{
						return deviceName;
					}
					set	
					{
						deviceName = value;
					}
				}

				public float? DeviceLatitude
				{
					get
					{
						return deviceLatitude;
					}
					set	
					{
						deviceLatitude = value;
					}
				}

				public float? DeviceLongitude
				{
					get
					{
						return deviceLongitude;
					}
					set	
					{
						deviceLongitude = value;
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
			}

			public class SearchAggregateObject_MotorListItem
			{

				private string deviceID;

				private string objectType;

				private int? leftTopX;

				private int? leftTopY;

				private int? rightBottomX;

				private int? rightBottomY;

				private float? score;

				private string shotTime;

				private string sourceImageUrl;

				private string targetImageUrl;

				private string deviceName;

				private float? deviceLatitude;

				private float? deviceLongitude;

				private string personId;

				public string DeviceID
				{
					get
					{
						return deviceID;
					}
					set	
					{
						deviceID = value;
					}
				}

				public string ObjectType
				{
					get
					{
						return objectType;
					}
					set	
					{
						objectType = value;
					}
				}

				public int? LeftTopX
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

				public int? LeftTopY
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

				public int? RightBottomX
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

				public int? RightBottomY
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

				public float? Score
				{
					get
					{
						return score;
					}
					set	
					{
						score = value;
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

				public string SourceImageUrl
				{
					get
					{
						return sourceImageUrl;
					}
					set	
					{
						sourceImageUrl = value;
					}
				}

				public string TargetImageUrl
				{
					get
					{
						return targetImageUrl;
					}
					set	
					{
						targetImageUrl = value;
					}
				}

				public string DeviceName
				{
					get
					{
						return deviceName;
					}
					set	
					{
						deviceName = value;
					}
				}

				public float? DeviceLatitude
				{
					get
					{
						return deviceLatitude;
					}
					set	
					{
						deviceLatitude = value;
					}
				}

				public float? DeviceLongitude
				{
					get
					{
						return deviceLongitude;
					}
					set	
					{
						deviceLongitude = value;
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
			}

			public class SearchAggregateObject_NonMotorListItem
			{

				private string deviceID;

				private string objectType;

				private int? leftTopX;

				private int? leftTopY;

				private int? rightBottomX;

				private int? rightBottomY;

				private float? score;

				private string shotTime;

				private string sourceImageUrl;

				private string targetImageUrl;

				private string deviceName;

				private float? deviceLatitude;

				private float? deviceLongitude;

				private string personId;

				public string DeviceID
				{
					get
					{
						return deviceID;
					}
					set	
					{
						deviceID = value;
					}
				}

				public string ObjectType
				{
					get
					{
						return objectType;
					}
					set	
					{
						objectType = value;
					}
				}

				public int? LeftTopX
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

				public int? LeftTopY
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

				public int? RightBottomX
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

				public int? RightBottomY
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

				public float? Score
				{
					get
					{
						return score;
					}
					set	
					{
						score = value;
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

				public string SourceImageUrl
				{
					get
					{
						return sourceImageUrl;
					}
					set	
					{
						sourceImageUrl = value;
					}
				}

				public string TargetImageUrl
				{
					get
					{
						return targetImageUrl;
					}
					set	
					{
						targetImageUrl = value;
					}
				}

				public string DeviceName
				{
					get
					{
						return deviceName;
					}
					set	
					{
						deviceName = value;
					}
				}

				public float? DeviceLatitude
				{
					get
					{
						return deviceLatitude;
					}
					set	
					{
						deviceLatitude = value;
					}
				}

				public float? DeviceLongitude
				{
					get
					{
						return deviceLongitude;
					}
					set	
					{
						deviceLongitude = value;
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
			}
		}
	}
}
