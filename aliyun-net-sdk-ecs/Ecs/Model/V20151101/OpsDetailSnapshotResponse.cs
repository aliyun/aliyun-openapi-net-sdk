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
	public class OpsDetailSnapshotResponse : AcsResponse
	{

		private string snapshotName;

		private string snapshotId;

		private string createdTime;

		private string progress;

		private string imageId;

		private string snapshotType;

		private int? snapshotSize;

		private string regionNo;

		private string description;

		private string sourceDiskId;

		private string sourceDiskType;

		private int? sourceDiskSize;

		public string SnapshotName
		{
			get
			{
				return snapshotName;
			}
			set	
			{
				snapshotName = value;
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

		public string SnapshotType
		{
			get
			{
				return snapshotType;
			}
			set	
			{
				snapshotType = value;
			}
		}

		public int? SnapshotSize
		{
			get
			{
				return snapshotSize;
			}
			set	
			{
				snapshotSize = value;
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

		public string SourceDiskId
		{
			get
			{
				return sourceDiskId;
			}
			set	
			{
				sourceDiskId = value;
			}
		}

		public string SourceDiskType
		{
			get
			{
				return sourceDiskType;
			}
			set	
			{
				sourceDiskType = value;
			}
		}

		public int? SourceDiskSize
		{
			get
			{
				return sourceDiskSize;
			}
			set	
			{
				sourceDiskSize = value;
			}
		}
	}
}