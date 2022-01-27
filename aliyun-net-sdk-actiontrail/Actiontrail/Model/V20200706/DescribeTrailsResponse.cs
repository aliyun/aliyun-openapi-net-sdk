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

namespace Aliyun.Acs.Actiontrail.Model.V20200706
{
	public class DescribeTrailsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeTrails_Trail> trailList;

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

		public List<DescribeTrails_Trail> TrailList
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

		public class DescribeTrails_Trail
		{

			private string status;

			private string homeRegion;

			private string startLoggingTime;

			private string createTime;

			private string stopLoggingTime;

			private string organizationId;

			private string slsWriteRoleArn;

			private string ossBucketLocation;

			private string trailRegion;

			private string name;

			private bool? isOrganizationTrail;

			private string slsProjectArn;

			private string eventRW;

			private string ossKeyPrefix;

			private string updateTime;

			private string region;

			private string ossBucketName;

			private string ossWriteRoleArn;

			private long? isShadowTrail;

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

			public string StartLoggingTime
			{
				get
				{
					return startLoggingTime;
				}
				set	
				{
					startLoggingTime = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string StopLoggingTime
			{
				get
				{
					return stopLoggingTime;
				}
				set	
				{
					stopLoggingTime = value;
				}
			}

			public string OrganizationId
			{
				get
				{
					return organizationId;
				}
				set	
				{
					organizationId = value;
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

			public string OssBucketLocation
			{
				get
				{
					return ossBucketLocation;
				}
				set	
				{
					ossBucketLocation = value;
				}
			}

			public string TrailRegion
			{
				get
				{
					return trailRegion;
				}
				set	
				{
					trailRegion = value;
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

			public bool? IsOrganizationTrail
			{
				get
				{
					return isOrganizationTrail;
				}
				set	
				{
					isOrganizationTrail = value;
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

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
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

			public string OssWriteRoleArn
			{
				get
				{
					return ossWriteRoleArn;
				}
				set	
				{
					ossWriteRoleArn = value;
				}
			}

			public long? IsShadowTrail
			{
				get
				{
					return isShadowTrail;
				}
				set	
				{
					isShadowTrail = value;
				}
			}
		}
	}
}
