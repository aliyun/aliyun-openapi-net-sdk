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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20151101
{
	public class OpsDescribeImagesResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNo;

		private int? pageSize;

		private List<Image> images;

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

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
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

		public List<Image> Images
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

		public class Image{

			private long? id;

			private string bid;

			private long? aliUid;

			private string imageId;

			private int? imageSize;

			private string imageName;

			private string osType;

			private string platform;

			private string osName;

			private string osBit;

			private string osMemo;

			private string osKind;

			private string remark;

			private string version;

			private string createdTime;

			private string modifiedTime;

			private string status;

			private string snapshotId;

			private string productCode;

			private string regionNo;

			private string displayName;

			private string imageCategory;

			private long? srcImageId;

			private bool? supportIoOptimizedInstance;

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

			public string Bid
			{
				get
				{
					return bid;
				}
				set	
				{
					bid = value;
				}
			}

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
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

			public int? ImageSize
			{
				get
				{
					return imageSize;
				}
				set	
				{
					imageSize = value;
				}
			}

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

			public string OsType
			{
				get
				{
					return osType;
				}
				set	
				{
					osType = value;
				}
			}

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

			public string OsName
			{
				get
				{
					return osName;
				}
				set	
				{
					osName = value;
				}
			}

			public string OsBit
			{
				get
				{
					return osBit;
				}
				set	
				{
					osBit = value;
				}
			}

			public string OsMemo
			{
				get
				{
					return osMemo;
				}
				set	
				{
					osMemo = value;
				}
			}

			public string OsKind
			{
				get
				{
					return osKind;
				}
				set	
				{
					osKind = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
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

			public string SnapshotId
			{
				get
				{
					return snapshotId;
				}
				set	
				{
					snapshotId = value;
				}
			}

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public string RegionNo
			{
				get
				{
					return regionNo;
				}
				set	
				{
					regionNo = value;
				}
			}

			public string DisplayName
			{
				get
				{
					return displayName;
				}
				set	
				{
					displayName = value;
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

			public long? SrcImageId
			{
				get
				{
					return srcImageId;
				}
				set	
				{
					srcImageId = value;
				}
			}

			public bool? SupportIoOptimizedInstance
			{
				get
				{
					return supportIoOptimizedInstance;
				}
				set	
				{
					supportIoOptimizedInstance = value;
				}
			}
		}
	}
}