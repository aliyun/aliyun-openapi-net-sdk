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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class ListDynamicImageResponse : AcsResponse
	{

		private string requestId;

		private List<ListDynamicImage_DynamicImage> dynamicImageList;

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

		public List<ListDynamicImage_DynamicImage> DynamicImageList
		{
			get
			{
				return dynamicImageList;
			}
			set	
			{
				dynamicImageList = value;
			}
		}

		public class ListDynamicImage_DynamicImage
		{

			private string videoId;

			private string dynamicImageId;

			private string jobId;

			private string fileURL;

			private string width;

			private string height;

			private string duration;

			private string format;

			private string fileSize;

			private string fps;

			private string creationTime;

			public string VideoId
			{
				get
				{
					return videoId;
				}
				set	
				{
					videoId = value;
				}
			}

			public string DynamicImageId
			{
				get
				{
					return dynamicImageId;
				}
				set	
				{
					dynamicImageId = value;
				}
			}

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public string FileURL
			{
				get
				{
					return fileURL;
				}
				set	
				{
					fileURL = value;
				}
			}

			public string Width
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

			public string Height
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

			public string Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
				}
			}

			public string Format
			{
				get
				{
					return format;
				}
				set	
				{
					format = value;
				}
			}

			public string FileSize
			{
				get
				{
					return fileSize;
				}
				set	
				{
					fileSize = value;
				}
			}

			public string Fps
			{
				get
				{
					return fps;
				}
				set	
				{
					fps = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}
		}
	}
}
