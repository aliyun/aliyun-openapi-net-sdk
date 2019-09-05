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

namespace Aliyun.Acs.cusanalytic_sc_online.Model.V20190524
{
	public class DescribeLocationsResponse : AcsResponse
	{

		private string storeId;

		private List<DescribeLocations_LocationMsgItem> locationMsgItems;

		public string StoreId
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

		public List<DescribeLocations_LocationMsgItem> LocationMsgItems
		{
			get
			{
				return locationMsgItems;
			}
			set	
			{
				locationMsgItems = value;
			}
		}

		public class DescribeLocations_LocationMsgItem
		{

			private string tag;

			private long? id;

			private string extId;

			private string locationType;

			private string name;

			private long? status;

			private string gmtCreate;

			private long? storeId;

			private string gmtModified;

			private long? parentLocationId;

			private string layerType;

			private List<DescribeLocations_RectRoi> rectRois;

			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
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

			public string ExtId
			{
				get
				{
					return extId;
				}
				set	
				{
					extId = value;
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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public long? Status
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

			public string GmtCreate
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

			public string GmtModified
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

			public List<DescribeLocations_RectRoi> RectRois
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

			public class DescribeLocations_RectRoi
			{

				private List<DescribeLocations_Point> points;

				private DescribeLocations_LeftTop leftTop;

				private DescribeLocations_RightBottom rightBottom;

				public List<DescribeLocations_Point> Points
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

				public DescribeLocations_LeftTop LeftTop
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

				public DescribeLocations_RightBottom RightBottom
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

				public class DescribeLocations_Point
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

				public class DescribeLocations_LeftTop
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

				public class DescribeLocations_RightBottom
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
