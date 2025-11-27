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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.WebsiteBuild.Model.V20250429
{
	public class SearchImageResponse : AcsResponse
	{

		private string requestId;

		private string errorMsg;

		private string success;

		private string errorCode;

		private SearchImage_ImageResponse imageResponse;

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

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
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

		public SearchImage_ImageResponse ImageResponse
		{
			get
			{
				return imageResponse;
			}
			set	
			{
				imageResponse = value;
			}
		}

		public class SearchImage_ImageResponse
		{

			private int? maxResults;

			private string nextToken;

			private List<SearchImage_Image> imageList;

			public int? MaxResults
			{
				get
				{
					return maxResults;
				}
				set	
				{
					maxResults = value;
				}
			}

			public string NextToken
			{
				get
				{
					return nextToken;
				}
				set	
				{
					nextToken = value;
				}
			}

			public List<SearchImage_Image> ImageList
			{
				get
				{
					return imageList;
				}
				set	
				{
					imageList = value;
				}
			}

			public class SearchImage_Image
			{

				private string imageUuid;

				private string ossKey;

				private string url;

				private int? width;

				private int? height;

				private string imageRatio;

				private string imageCategory;

				private string tagsFromImage;

				private string descriptiveTones;

				private string quantitativePalette;

				public string ImageUuid
				{
					get
					{
						return imageUuid;
					}
					set	
					{
						imageUuid = value;
					}
				}

				public string OssKey
				{
					get
					{
						return ossKey;
					}
					set	
					{
						ossKey = value;
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

				public string ImageRatio
				{
					get
					{
						return imageRatio;
					}
					set	
					{
						imageRatio = value;
					}
				}

				public string ImageCategory
				{
					get
					{
						return imageCategory;
					}
					set	
					{
						imageCategory = value;
					}
				}

				public string TagsFromImage
				{
					get
					{
						return tagsFromImage;
					}
					set	
					{
						tagsFromImage = value;
					}
				}

				public string DescriptiveTones
				{
					get
					{
						return descriptiveTones;
					}
					set	
					{
						descriptiveTones = value;
					}
				}

				public string QuantitativePalette
				{
					get
					{
						return quantitativePalette;
					}
					set	
					{
						quantitativePalette = value;
					}
				}
			}
		}
	}
}
