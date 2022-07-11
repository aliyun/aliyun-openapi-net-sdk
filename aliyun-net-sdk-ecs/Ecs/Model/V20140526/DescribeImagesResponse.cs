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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeImagesResponse : AcsResponse
	{

		private int? pageSize;

		private int? pageNumber;

		private string requestId;

		private int? totalCount;

		private string regionId;

		private List<DescribeImages_Image> images;

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

		public List<DescribeImages_Image> Images
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

		public class DescribeImages_Image
		{

			private string creationTime;

			private string status;

			private string imageFamily;

			private string progress;

			private bool? isCopied;

			private bool? isSupportIoOptimized;

			private string imageOwnerAlias;

			private bool? isSupportCloudinit;

			private string imageVersion;

			private string usage;

			private string isSelfShared;

			private string description;

			private int? size;

			private string resourceGroupId;

			private string platform;

			private string oSNameEn;

			private string imageName;

			private string oSName;

			private string imageId;

			private string oSType;

			private bool? isSubscribed;

			private string productCode;

			private string architecture;

			private bool? isPublic;

			private long? imageOwnerId;

			private bool? loginAsNonRootSupported;

			private string supplierName;

			private List<DescribeImages_DiskDeviceMapping> diskDeviceMappings;

			private List<DescribeImages_Tag> tags;

			private DescribeImages_DetectionOptions detectionOptions;

			private DescribeImages_Features features;

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

			public string ImageFamily
			{
				get
				{
					return imageFamily;
				}
				set	
				{
					imageFamily = value;
				}
			}

			public string Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}

			public bool? IsCopied
			{
				get
				{
					return isCopied;
				}
				set	
				{
					isCopied = value;
				}
			}

			public bool? IsSupportIoOptimized
			{
				get
				{
					return isSupportIoOptimized;
				}
				set	
				{
					isSupportIoOptimized = value;
				}
			}

			public string ImageOwnerAlias
			{
				get
				{
					return imageOwnerAlias;
				}
				set	
				{
					imageOwnerAlias = value;
				}
			}

			public bool? IsSupportCloudinit
			{
				get
				{
					return isSupportCloudinit;
				}
				set	
				{
					isSupportCloudinit = value;
				}
			}

			public string ImageVersion
			{
				get
				{
					return imageVersion;
				}
				set	
				{
					imageVersion = value;
				}
			}

			public string Usage
			{
				get
				{
					return usage;
				}
				set	
				{
					usage = value;
				}
			}

			public string IsSelfShared
			{
				get
				{
					return isSelfShared;
				}
				set	
				{
					isSelfShared = value;
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

			public int? Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
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

			public string OSNameEn
			{
				get
				{
					return oSNameEn;
				}
				set	
				{
					oSNameEn = value;
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

			public string OSName
			{
				get
				{
					return oSName;
				}
				set	
				{
					oSName = value;
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

			public string OSType
			{
				get
				{
					return oSType;
				}
				set	
				{
					oSType = value;
				}
			}

			public bool? IsSubscribed
			{
				get
				{
					return isSubscribed;
				}
				set	
				{
					isSubscribed = value;
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

			public string Architecture
			{
				get
				{
					return architecture;
				}
				set	
				{
					architecture = value;
				}
			}

			public bool? IsPublic
			{
				get
				{
					return isPublic;
				}
				set	
				{
					isPublic = value;
				}
			}

			public long? ImageOwnerId
			{
				get
				{
					return imageOwnerId;
				}
				set	
				{
					imageOwnerId = value;
				}
			}

			public bool? LoginAsNonRootSupported
			{
				get
				{
					return loginAsNonRootSupported;
				}
				set	
				{
					loginAsNonRootSupported = value;
				}
			}

			public string SupplierName
			{
				get
				{
					return supplierName;
				}
				set	
				{
					supplierName = value;
				}
			}

			public List<DescribeImages_DiskDeviceMapping> DiskDeviceMappings
			{
				get
				{
					return diskDeviceMappings;
				}
				set	
				{
					diskDeviceMappings = value;
				}
			}

			public List<DescribeImages_Tag> Tags
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

			public DescribeImages_DetectionOptions DetectionOptions
			{
				get
				{
					return detectionOptions;
				}
				set	
				{
					detectionOptions = value;
				}
			}

			public DescribeImages_Features Features
			{
				get
				{
					return features;
				}
				set	
				{
					features = value;
				}
			}

			public class DescribeImages_DiskDeviceMapping
			{

				private string type;

				private string importOSSBucket;

				private string progress;

				private string snapshotId;

				private string importOSSObject;

				private string device;

				private string size;

				private int? remainTime;

				private string format;

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string ImportOSSBucket
				{
					get
					{
						return importOSSBucket;
					}
					set	
					{
						importOSSBucket = value;
					}
				}

				public string Progress
				{
					get
					{
						return progress;
					}
					set	
					{
						progress = value;
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

				public string ImportOSSObject
				{
					get
					{
						return importOSSObject;
					}
					set	
					{
						importOSSObject = value;
					}
				}

				public string Device
				{
					get
					{
						return device;
					}
					set	
					{
						device = value;
					}
				}

				public string Size
				{
					get
					{
						return size;
					}
					set	
					{
						size = value;
					}
				}

				public int? RemainTime
				{
					get
					{
						return remainTime;
					}
					set	
					{
						remainTime = value;
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
			}

			public class DescribeImages_Tag
			{

				private string tagValue;

				private string tagKey;

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}
			}

			public class DescribeImages_DetectionOptions
			{

				private string status;

				private List<DescribeImages_Item> items;

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

				public List<DescribeImages_Item> Items
				{
					get
					{
						return items;
					}
					set	
					{
						items = value;
					}
				}

				public class DescribeImages_Item
				{

					private string name;

					private string _value;

					private string riskLevel;

					private string riskCode;

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

					public string RiskLevel
					{
						get
						{
							return riskLevel;
						}
						set	
						{
							riskLevel = value;
						}
					}

					public string RiskCode
					{
						get
						{
							return riskCode;
						}
						set	
						{
							riskCode = value;
						}
					}
				}
			}

			public class DescribeImages_Features
			{

				private string nvmeSupport;

				public string NvmeSupport
				{
					get
					{
						return nvmeSupport;
					}
					set	
					{
						nvmeSupport = value;
					}
				}
			}
		}
	}
}
