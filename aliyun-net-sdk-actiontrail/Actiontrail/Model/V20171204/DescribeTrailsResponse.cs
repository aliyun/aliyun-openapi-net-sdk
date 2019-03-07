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

namespace Aliyun.Acs.Actiontrail.Model.V20171204
{
	public class DescribeTrailsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeTrails_TrailListItem> trailList;

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

		public List<DescribeTrails_TrailListItem> TrailList
		{
			get
			{
				return trailList;
			}
			set	
			{
				trailList = value;
			}
		}

		public class DescribeTrails_TrailListItem
		{

			private string name;

			private string homeRegion;

			private string roleName;

			private string status;

			private string includeGlobalServiceEvent;

			private string ossBucketName;

			private string ossKeyPrefix;

			private string region;

			private string eventRW;

			private string type;

			private string slsWriteRoleArn;

			private string slsProjectArn;

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

			public string HomeRegion
			{
				get
				{
					return homeRegion;
				}
				set	
				{
					homeRegion = value;
				}
			}

			public string RoleName
			{
				get
				{
					return roleName;
				}
				set	
				{
					roleName = value;
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

			public string IncludeGlobalServiceEvent
			{
				get
				{
					return includeGlobalServiceEvent;
				}
				set	
				{
					includeGlobalServiceEvent = value;
				}
			}

			public string OssBucketName
			{
				get
				{
					return ossBucketName;
				}
				set	
				{
					ossBucketName = value;
				}
			}

			public string OssKeyPrefix
			{
				get
				{
					return ossKeyPrefix;
				}
				set	
				{
					ossKeyPrefix = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string EventRW
			{
				get
				{
					return eventRW;
				}
				set	
				{
					eventRW = value;
				}
			}

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

			public string SlsWriteRoleArn
			{
				get
				{
					return slsWriteRoleArn;
				}
				set	
				{
					slsWriteRoleArn = value;
				}
			}

			public string SlsProjectArn
			{
				get
				{
					return slsProjectArn;
				}
				set	
				{
					slsProjectArn = value;
				}
			}
		}
	}
}