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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeImagesResponse : AcsResponse
	{
	    public string RegionId { get; set; }

	    public int? TotalCount { get; set; }

	    public int? PageNumber { get; set; }

	    public int? PageSize { get; set; }

	    public List<Image> Images { get; set; }

	    public class Image{
	        public string Progress { get; set; }

	        public string ImageId { get; set; }

	        public string ImageName { get; set; }

	        public string ImageVersion { get; set; }

	        public string Description { get; set; }

	        public int? Size { get; set; }

	        public string ImageOwnerAlias { get; set; }

	        public bool? IsSupportIoOptimized { get; set; }

	        public string OsName { get; set; }

	        public ArchitectureEnum? Architecture { get; set; }

	        public string Status { get; set; }

	        public string ProductCode { get; set; }

	        public bool? IsSubscribed { get; set; }

	        public string CreationTime { get; set; }

	        public string IsSelfShared { get; set; }

	        public string OsType { get; set; }

	        public string Platform { get; set; }

	        public string Usage { get; set; }

	        public bool? IsCopied { get; set; }

	        public List<DiskDeviceMapping> DiskDeviceMappings { get; set; }

	        public List<Tag> Tags { get; set; }

	        public enum ArchitectureEnum {
			
					X8664,
					I386,
			}

			public class DiskDeviceMapping{
			    public string SnapshotId { get; set; }

			    public string Size { get; set; }

			    public string Device { get; set; }

			    public string Format { get; set; }

			    public string ImportOssBucket { get; set; }

			    public string ImportOssObject { get; set; }
			}

			public class Tag{
			    public string TagKey { get; set; }

			    public string TagValue { get; set; }
			}
		}
	}
}