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

namespace Aliyun.Acs.reid.Model.V20190928
{
	public class ListActionDataResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private long? cursorTime;

		private string errorCode;

		private string errorMessage;

		private int? pageNumber;

		private long? totalCount;

		private int? pageSize;

		private List<ListActionData_Action> actions;

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

		public long? CursorTime
		{
			get
			{
				return cursorTime;
			}
			set	
			{
				cursorTime = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public List<ListActionData_Action> Actions
		{
			get
			{
				return actions;
			}
			set	
			{
				actions = value;
			}
		}

		public class ListActionData_Action
		{

			private long? storeId;

			private long? gmtCreate;

			private long? leaveTimestamp;

			private string locationLayerType;

			private bool? stayValid;

			private string gender;

			private long? ukId;

			private long? arriveTimestamp;

			private long? gmtModified;

			private string imageType;

			private long? inStay;

			private int? status;

			private int? age;

			private long? id;

			private string imageUrl;

			private long? locationId;

			private int? stayPeriod;

			private float? score;

			private string specialType;

			private string imageObjectKey;

			private int? facePointNumber;

			private int? bodyPointNumber;

			private ListActionData_ObjectPositionInImage objectPositionInImage;

			private ListActionData_PointInMap pointInMap;

			public long? StoreId
			{
				get
				{
					return storeId;
				}
				set	
				{
					storeId = value;
				}
			}

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? LeaveTimestamp
			{
				get
				{
					return leaveTimestamp;
				}
				set	
				{
					leaveTimestamp = value;
				}
			}

			public string LocationLayerType
			{
				get
				{
					return locationLayerType;
				}
				set	
				{
					locationLayerType = value;
				}
			}

			public bool? StayValid
			{
				get
				{
					return stayValid;
				}
				set	
				{
					stayValid = value;
				}
			}

			public string Gender
			{
				get
				{
					return gender;
				}
				set	
				{
					gender = value;
				}
			}

			public long? UkId
			{
				get
				{
					return ukId;
				}
				set	
				{
					ukId = value;
				}
			}

			public long? ArriveTimestamp
			{
				get
				{
					return arriveTimestamp;
				}
				set	
				{
					arriveTimestamp = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string ImageType
			{
				get
				{
					return imageType;
				}
				set	
				{
					imageType = value;
				}
			}

			public long? InStay
			{
				get
				{
					return inStay;
				}
				set	
				{
					inStay = value;
				}
			}

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public int? Age
			{
				get
				{
					return age;
				}
				set	
				{
					age = value;
				}
			}

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string ImageUrl
			{
				get
				{
					return imageUrl;
				}
				set	
				{
					imageUrl = value;
				}
			}

			public long? LocationId
			{
				get
				{
					return locationId;
				}
				set	
				{
					locationId = value;
				}
			}

			public int? StayPeriod
			{
				get
				{
					return stayPeriod;
				}
				set	
				{
					stayPeriod = value;
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

			public string SpecialType
			{
				get
				{
					return specialType;
				}
				set	
				{
					specialType = value;
				}
			}

			public string ImageObjectKey
			{
				get
				{
					return imageObjectKey;
				}
				set	
				{
					imageObjectKey = value;
				}
			}

			public int? FacePointNumber
			{
				get
				{
					return facePointNumber;
				}
				set	
				{
					facePointNumber = value;
				}
			}

			public int? BodyPointNumber
			{
				get
				{
					return bodyPointNumber;
				}
				set	
				{
					bodyPointNumber = value;
				}
			}

			public ListActionData_ObjectPositionInImage ObjectPositionInImage
			{
				get
				{
					return objectPositionInImage;
				}
				set	
				{
					objectPositionInImage = value;
				}
			}

			public ListActionData_PointInMap PointInMap
			{
				get
				{
					return pointInMap;
				}
				set	
				{
					pointInMap = value;
				}
			}

			public class ListActionData_ObjectPositionInImage
			{

				private float? bottom;

				private float? left;

				private float? top;

				private float? right;

				public float? Bottom
				{
					get
					{
						return bottom;
					}
					set	
					{
						bottom = value;
					}
				}

				public float? Left
				{
					get
					{
						return left;
					}
					set	
					{
						left = value;
					}
				}

				public float? Top
				{
					get
					{
						return top;
					}
					set	
					{
						top = value;
					}
				}

				public float? Right
				{
					get
					{
						return right;
					}
					set	
					{
						right = value;
					}
				}
			}

			public class ListActionData_PointInMap
			{

				private float? x;

				private float? y;

				public float? X
				{
					get
					{
						return x;
					}
					set	
					{
						x = value;
					}
				}

				public float? Y
				{
					get
					{
						return y;
					}
					set	
					{
						y = value;
					}
				}
			}
		}
	}
}
