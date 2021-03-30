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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeViewContentResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeViewContent_ViewContent> viewContentList;

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

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
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

		public List<DescribeViewContent_ViewContent> ViewContentList
		{
			get
			{
				return viewContentList;
			}
			set	
			{
				viewContentList = value;
			}
		}

		public class DescribeViewContent_ViewContent
		{

			private string taskId;

			private string dataId;

			private string bizType;

			private string content;

			private string url;

			private string newUrl;

			private string thumbnail;

			private string requestTime;

			private string scanFinishedTime;

			private string suggestion;

			private long? id;

			private string scanResult;

			private List<DescribeViewContent_Result> results;

			private List<DescribeViewContent_FrameResult> frameResults;

			private List<DescribeViewContent_FaceResult> faceResults;

			public string TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
				}
			}

			public string DataId
			{
				get
				{
					return dataId;
				}
				set	
				{
					dataId = value;
				}
			}

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public string NewUrl
			{
				get
				{
					return newUrl;
				}
				set	
				{
					newUrl = value;
				}
			}

			public string Thumbnail
			{
				get
				{
					return thumbnail;
				}
				set	
				{
					thumbnail = value;
				}
			}

			public string RequestTime
			{
				get
				{
					return requestTime;
				}
				set	
				{
					requestTime = value;
				}
			}

			public string ScanFinishedTime
			{
				get
				{
					return scanFinishedTime;
				}
				set	
				{
					scanFinishedTime = value;
				}
			}

			public string Suggestion
			{
				get
				{
					return suggestion;
				}
				set	
				{
					suggestion = value;
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

			public string ScanResult
			{
				get
				{
					return scanResult;
				}
				set	
				{
					scanResult = value;
				}
			}

			public List<DescribeViewContent_Result> Results
			{
				get
				{
					return results;
				}
				set	
				{
					results = value;
				}
			}

			public List<DescribeViewContent_FrameResult> FrameResults
			{
				get
				{
					return frameResults;
				}
				set	
				{
					frameResults = value;
				}
			}

			public List<DescribeViewContent_FaceResult> FaceResults
			{
				get
				{
					return faceResults;
				}
				set	
				{
					faceResults = value;
				}
			}

			public class DescribeViewContent_Result
			{

				private string suggestion;

				private string label;

				private string scene;

				public string Suggestion
				{
					get
					{
						return suggestion;
					}
					set	
					{
						suggestion = value;
					}
				}

				public string Label
				{
					get
					{
						return label;
					}
					set	
					{
						label = value;
					}
				}

				public string Scene
				{
					get
					{
						return scene;
					}
					set	
					{
						scene = value;
					}
				}
			}

			public class DescribeViewContent_FrameResult
			{

				private string url;

				private int? offset;

				private string label;

				public string Url
				{
					get
					{
						return url;
					}
					set	
					{
						url = value;
					}
				}

				public int? Offset
				{
					get
					{
						return offset;
					}
					set	
					{
						offset = value;
					}
				}

				public string Label
				{
					get
					{
						return label;
					}
					set	
					{
						label = value;
					}
				}
			}

			public class DescribeViewContent_FaceResult
			{

				private bool? bualified;

				private DescribeViewContent_Location location;

				private DescribeViewContent_Gender gender;

				private DescribeViewContent_Glasses glasses;

				private DescribeViewContent_Age age;

				private DescribeViewContent_Smile smile;

				private DescribeViewContent_Quality quality;

				private DescribeViewContent_Respirator respirator;

				private DescribeViewContent_Hat hat;

				private DescribeViewContent_Mustache mustache;

				private DescribeViewContent_Bang bang;

				private DescribeViewContent_Hairstyle hairstyle;

				private DescribeViewContent_Image image;

				public bool? Bualified
				{
					get
					{
						return bualified;
					}
					set	
					{
						bualified = value;
					}
				}

				public DescribeViewContent_Location Location
				{
					get
					{
						return location;
					}
					set	
					{
						location = value;
					}
				}

				public DescribeViewContent_Gender Gender
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

				public DescribeViewContent_Glasses Glasses
				{
					get
					{
						return glasses;
					}
					set	
					{
						glasses = value;
					}
				}

				public DescribeViewContent_Age Age
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

				public DescribeViewContent_Smile Smile
				{
					get
					{
						return smile;
					}
					set	
					{
						smile = value;
					}
				}

				public DescribeViewContent_Quality Quality
				{
					get
					{
						return quality;
					}
					set	
					{
						quality = value;
					}
				}

				public DescribeViewContent_Respirator Respirator
				{
					get
					{
						return respirator;
					}
					set	
					{
						respirator = value;
					}
				}

				public DescribeViewContent_Hat Hat
				{
					get
					{
						return hat;
					}
					set	
					{
						hat = value;
					}
				}

				public DescribeViewContent_Mustache Mustache
				{
					get
					{
						return mustache;
					}
					set	
					{
						mustache = value;
					}
				}

				public DescribeViewContent_Bang Bang
				{
					get
					{
						return bang;
					}
					set	
					{
						bang = value;
					}
				}

				public DescribeViewContent_Hairstyle Hairstyle
				{
					get
					{
						return hairstyle;
					}
					set	
					{
						hairstyle = value;
					}
				}

				public DescribeViewContent_Image Image
				{
					get
					{
						return image;
					}
					set	
					{
						image = value;
					}
				}

				public class DescribeViewContent_Location
				{

					private int? x;

					private int? y;

					private int? w;

					private int? h;

					public int? X
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

					public int? Y
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

					public int? W
					{
						get
						{
							return w;
						}
						set	
						{
							w = value;
						}
					}

					public int? H
					{
						get
						{
							return h;
						}
						set	
						{
							h = value;
						}
					}
				}

				public class DescribeViewContent_Gender
				{

					private float? rate;

					private string _value;

					public float? Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}

				public class DescribeViewContent_Glasses
				{

					private float? rate;

					private string _value;

					public float? Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}

				public class DescribeViewContent_Age
				{

					private float? rate;

					private int? _value;

					public float? Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

					public int? _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}

				public class DescribeViewContent_Smile
				{

					private float? rate;

					private float? _value;

					public float? Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

					public float? _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}

				public class DescribeViewContent_Quality
				{

					private float? blur;

					private float? pitch;

					private float? yaw;

					private float? roll;

					public float? Blur
					{
						get
						{
							return blur;
						}
						set	
						{
							blur = value;
						}
					}

					public float? Pitch
					{
						get
						{
							return pitch;
						}
						set	
						{
							pitch = value;
						}
					}

					public float? Yaw
					{
						get
						{
							return yaw;
						}
						set	
						{
							yaw = value;
						}
					}

					public float? Roll
					{
						get
						{
							return roll;
						}
						set	
						{
							roll = value;
						}
					}
				}

				public class DescribeViewContent_Respirator
				{

					private float? rate;

					private string _value;

					public float? Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}

				public class DescribeViewContent_Hat
				{

					private float? rate;

					private string _value;

					public float? Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}

				public class DescribeViewContent_Mustache
				{

					private float? rate;

					private string _value;

					public float? Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}

				public class DescribeViewContent_Bang
				{

					private float? rate;

					private string _value;

					public float? Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}

				public class DescribeViewContent_Hairstyle
				{

					private float? rate;

					private string _value;

					public float? Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}

				public class DescribeViewContent_Image
				{

					private int? width;

					private int? height;

					public int? Width
					{
						get
						{
							return width;
						}
						set	
						{
							width = value;
						}
					}

					public int? Height
					{
						get
						{
							return height;
						}
						set	
						{
							height = value;
						}
					}
				}
			}
		}
	}
}
