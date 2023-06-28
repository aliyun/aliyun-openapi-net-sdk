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

namespace Aliyun.Acs.SWAS_OPEN.Model.V20200601
{
	public class ListImagesResponse : AcsResponse
	{

		private string requestId;

		private List<ListImages_Image> images;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Images")]
		public List<ListImages_Image> Images
		{
			get
			{
				return images;
			}
			set	
			{
				images = value;
			}
		}

		public class ListImages_Image
		{

			private string imageType;

			private string description;

			private string imageName;

			private string imageId;

			private string platform;

			[JsonProperty(PropertyName = "ImageType")]
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

			[JsonProperty(PropertyName = "Description")]
			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			[JsonProperty(PropertyName = "ImageName")]
			public string ImageName
			{
				get
				{
					return imageName;
				}
				set	
				{
					imageName = value;
				}
			}

			[JsonProperty(PropertyName = "ImageId")]
			public string ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
				}
			}

			[JsonProperty(PropertyName = "Platform")]
			public string Platform
			{
				get
				{
					return platform;
				}
				set	
				{
					platform = value;
				}
			}
		}
	}
}
