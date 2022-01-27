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
	public class DescribeSnapshotGroupsResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private List<DescribeSnapshotGroups_SnapshotGroup> snapshotGroups;

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

		public List<DescribeSnapshotGroups_SnapshotGroup> SnapshotGroups
		{
			get
			{
				return snapshotGroups;
			}
			set	
			{
				snapshotGroups = value;
			}
		}

		public class DescribeSnapshotGroups_SnapshotGroup
		{

			private string status;

			private string creationTime;

			private string description;

			private string progressStatus;

			private string snapshotGroupId;

			private string instanceId;

			private string name;

			private string resourceGroupId;

			private List<DescribeSnapshotGroups_Tag> tags;

			private List<DescribeSnapshotGroups_Snapshot> snapshots;

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

			public string ProgressStatus
			{
				get
				{
					return progressStatus;
				}
				set	
				{
					progressStatus = value;
				}
			}

			public string SnapshotGroupId
			{
				get
				{
					return snapshotGroupId;
				}
				set	
				{
					snapshotGroupId = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

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

			public List<DescribeSnapshotGroups_Tag> Tags
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

			public List<DescribeSnapshotGroups_Snapshot> Snapshots
			{
				get
				{
					return snapshots;
				}
				set	
				{
					snapshots = value;
				}
			}

			public class DescribeSnapshotGroups_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
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

			public class DescribeSnapshotGroups_Snapshot
			{

				private string sourceDiskId;

				private string progress;

				private int? instantAccessRetentionDays;

				private string snapshotId;

				private bool? instantAccess;

				private string sourceDiskType;

				private List<DescribeSnapshotGroups_Tag2> tags1;

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

				public int? InstantAccessRetentionDays
				{
					get
					{
						return instantAccessRetentionDays;
					}
					set	
					{
						instantAccessRetentionDays = value;
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

				public bool? InstantAccess
				{
					get
					{
						return instantAccess;
					}
					set	
					{
						instantAccess = value;
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

				public List<DescribeSnapshotGroups_Tag2> Tags1
				{
					get
					{
						return tags1;
					}
					set	
					{
						tags1 = value;
					}
				}

				public class DescribeSnapshotGroups_Tag2
				{

					private string key;

					private string _value;

					public string Key
					{
						get
						{
							return key;
						}
						set	
						{
							key = value;
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
			}
		}
	}
}
