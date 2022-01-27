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

namespace Aliyun.Acs.reid_cloud.Model.V20201029
{
	public class PullActionDataResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string message;

		private string code;

		private string dynamicCode;

		private int? partitionIndex;

		private string requestId;

		private bool? success;

		private long? nextMessageId;

		private string dynamicMessage;

		private List<PullActionData_Action> actions;

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

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
			}
		}

		public int? PartitionIndex
		{
			get
			{
				return partitionIndex;
			}
			set	
			{
				partitionIndex = value;
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

		public long? NextMessageId
		{
			get
			{
				return nextMessageId;
			}
			set	
			{
				nextMessageId = value;
			}
		}

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
			}
		}

		public List<PullActionData_Action> Actions
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

		public class PullActionData_Action
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

			private int? bodyPointNumber;

			private string imageUrl;

			private long? locationId;

			private int? stayPeriod;

			private int? facePointNumber;

			private float? score;

			private string specialType;

			private string imageObjectKey;

			private PullActionData_ObjectPositionInImage objectPositionInImage;

			private PullActionData_PointInMap pointInMap;

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

			public PullActionData_ObjectPositionInImage ObjectPositionInImage
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

			public PullActionData_PointInMap PointInMap
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

			public class PullActionData_ObjectPositionInImage
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

			public class PullActionData_PointInMap
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
