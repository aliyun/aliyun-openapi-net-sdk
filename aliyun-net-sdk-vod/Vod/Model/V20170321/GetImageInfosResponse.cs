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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetImageInfosResponse : AcsResponse
	{

		private string requestId;

		private List<GetImageInfos_Image> imageInfo;

		private List<string> nonExistImageIds;

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

		public List<GetImageInfos_Image> ImageInfo
		{
			get
			{
				return imageInfo;
			}
			set	
			{
				imageInfo = value;
			}
		}

		public List<string> NonExistImageIds
		{
			get
			{
				return nonExistImageIds;
			}
			set	
			{
				nonExistImageIds = value;
			}
		}

		public class GetImageInfos_Image
		{

			private string creationTime;

			private string storageLocation;

			private string status;

			private long? cateId;

			private string tags;

			private string regionId;

			private string imageType;

			private string cateName;

			private string description;

			private string appId;

			private string uRL;

			private string title;

			private string imageId;

			private string auditStatus;

			private GetImageInfos_Mezzanine mezzanine;

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

			public string StorageLocation
			{
				get
				{
					return storageLocation;
				}
				set	
				{
					storageLocation = value;
				}
			}

			public string Status
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

			public long? CateId
			{
				get
				{
					return cateId;
				}
				set	
				{
					cateId = value;
				}
			}

			public string Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
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

			public string CateName
			{
				get
				{
					return cateName;
				}
				set	
				{
					cateName = value;
				}
			}

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

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public string URL
			{
				get
				{
					return uRL;
				}
				set	
				{
					uRL = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

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

			public string AuditStatus
			{
				get
				{
					return auditStatus;
				}
				set	
				{
					auditStatus = value;
				}
			}

			public GetImageInfos_Mezzanine Mezzanine
			{
				get
				{
					return mezzanine;
				}
				set	
				{
					mezzanine = value;
				}
			}

			public class GetImageInfos_Mezzanine
			{

				private string fileURL;

				private string originalFileName;

				private int? width;

				private int? height;

				private string fileSize;

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

				public string OriginalFileName
				{
					get
					{
						return originalFileName;
					}
					set	
					{
						originalFileName = value;
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
			}
		}
	}
}
