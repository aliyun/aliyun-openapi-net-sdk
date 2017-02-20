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
	public class DescribeDisksResponse : AcsResponse
	{
	    public int? TotalCount { get; set; }

	    public int? PageNumber { get; set; }

	    public int? PageSize { get; set; }

	    public List<Disk> Disks { get; set; }

	    public class Disk{
	        public string DiskId { get; set; }

	        public string RegionId { get; set; }

	        public string ZoneId { get; set; }

	        public string DiskName { get; set; }

	        public string Description { get; set; }

	        public TypeEnum? Type { get; set; }

	        public CategoryEnum? Category { get; set; }

	        public int? Size { get; set; }

	        public string ImageId { get; set; }

	        public string SourceSnapshotId { get; set; }

	        public string AutoSnapshotPolicyId { get; set; }

	        public string ProductCode { get; set; }

	        public bool? Portable { get; set; }

	        public string Status { get; set; }

	        public string InstanceId { get; set; }

	        public string Device { get; set; }

	        public bool? DeleteWithInstance { get; set; }

	        public bool? DeleteAutoSnapshot { get; set; }

	        public bool? EnableAutoSnapshot { get; set; }

	        public bool? EnableAutomatedSnapshotPolicy { get; set; }

	        public string CreationTime { get; set; }

	        public string AttachedTime { get; set; }

	        public string DetachedTime { get; set; }

	        public string DiskChargeType { get; set; }

	        public string ExpiredTime { get; set; }

	        public List<OperationLock> OperationLocks { get; set; }

	        public List<Tag> Tags { get; set; }

	        public enum TypeEnum {
			
					System,
					Data,
			}

			public enum CategoryEnum {
			
					EphemeralSsd,
					Ephemeral,
					Cloud,
			}

			public class OperationLock{
			    public string LockReason { get; set; }
			}

			public class Tag{
			    public string TagKey { get; set; }

			    public string TagValue { get; set; }
			}
		}
	}
}