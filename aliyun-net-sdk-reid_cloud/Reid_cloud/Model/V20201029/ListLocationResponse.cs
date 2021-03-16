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
	public class ListLocationResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string message;

		private string code;

		private string dynamicCode;

		private string requestId;

		private bool? success;

		private string dynamicMessage;

		private List<ListLocation_LocationInfoItem> locationInfoItems;

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

		public List<ListLocation_LocationInfoItem> LocationInfoItems
		{
			get
			{
				return locationInfoItems;
			}
			set	
			{
				locationInfoItems = value;
			}
		}

		public class ListLocation_LocationInfoItem
		{

			private string externalId;

			private string locationType;

			private int? status;

			private long? storeId;

			private long? gmtCreate;

			private long? parentLocationId;

			private long? gmtModified;

			private string locationName;

			private string layerType;

			private long? locationId;

			private List<ListLocation_RectRoi> rectRois;

			public string ExternalId
			{
				get
				{
					return externalId;
				}
				set	
				{
					externalId = value;
				}
			}

			public string LocationType
			{
				get
				{
					return locationType;
				}
				set	
				{
					locationType = value;
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

			public long? ParentLocationId
			{
				get
				{
					return parentLocationId;
				}
				set	
				{
					parentLocationId = value;
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

			public string LocationName
			{
				get
				{
					return locationName;
				}
				set	
				{
					locationName = value;
				}
			}

			public string LayerType
			{
				get
				{
					return layerType;
				}
				set	
				{
					layerType = value;
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

			public List<ListLocation_RectRoi> RectRois
			{
				get
				{
					return rectRois;
				}
				set	
				{
					rectRois = value;
				}
			}

			public class ListLocation_RectRoi
			{

				private List<ListLocation_Point> points;

				private ListLocation_RightBottom rightBottom;

				private ListLocation_LeftTop leftTop;

				public List<ListLocation_Point> Points
				{
					get
					{
						return points;
					}
					set	
					{
						points = value;
					}
				}

				public ListLocation_RightBottom RightBottom
				{
					get
					{
						return rightBottom;
					}
					set	
					{
						rightBottom = value;
					}
				}

				public ListLocation_LeftTop LeftTop
				{
					get
					{
						return leftTop;
					}
					set	
					{
						leftTop = value;
					}
				}

				public class ListLocation_Point
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

				public class ListLocation_RightBottom
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

				public class ListLocation_LeftTop
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
}
