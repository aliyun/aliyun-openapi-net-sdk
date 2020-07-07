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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetProjectDetailResponse : AcsResponse
	{

		private int? httpStatusCode;

		private bool? success;

		private string requestId;

		private GetProjectDetail_Data data;

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public GetProjectDetail_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetProjectDetail_Data
		{

			private string gmtModified;

			private string defaultDiResourceGroupIdentifier;

			private int? isAllowDownload;

			private int? schedulerRetryInterval;

			private string residentArea;

			private string projectOwnerBaseId;

			private int? projectMode;

			private string gmtCreate;

			private int? protectedMode;

			private long? tenantId;

			private string projectDescription;

			private int? schedulerMaxRetryTimes;

			private string projectName;

			private string projectIdentifier;

			private int? projectId;

			private int? status;

			private int? developmentType;

			private List<string> envTypes;

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string DefaultDiResourceGroupIdentifier
			{
				get
				{
					return defaultDiResourceGroupIdentifier;
				}
				set	
				{
					defaultDiResourceGroupIdentifier = value;
				}
			}

			public int? IsAllowDownload
			{
				get
				{
					return isAllowDownload;
				}
				set	
				{
					isAllowDownload = value;
				}
			}

			public int? SchedulerRetryInterval
			{
				get
				{
					return schedulerRetryInterval;
				}
				set	
				{
					schedulerRetryInterval = value;
				}
			}

			public string ResidentArea
			{
				get
				{
					return residentArea;
				}
				set	
				{
					residentArea = value;
				}
			}

			public string ProjectOwnerBaseId
			{
				get
				{
					return projectOwnerBaseId;
				}
				set	
				{
					projectOwnerBaseId = value;
				}
			}

			public int? ProjectMode
			{
				get
				{
					return projectMode;
				}
				set	
				{
					projectMode = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public int? ProtectedMode
			{
				get
				{
					return protectedMode;
				}
				set	
				{
					protectedMode = value;
				}
			}

			public long? TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public string ProjectDescription
			{
				get
				{
					return projectDescription;
				}
				set	
				{
					projectDescription = value;
				}
			}

			public int? SchedulerMaxRetryTimes
			{
				get
				{
					return schedulerMaxRetryTimes;
				}
				set	
				{
					schedulerMaxRetryTimes = value;
				}
			}

			public string ProjectName
			{
				get
				{
					return projectName;
				}
				set	
				{
					projectName = value;
				}
			}

			public string ProjectIdentifier
			{
				get
				{
					return projectIdentifier;
				}
				set	
				{
					projectIdentifier = value;
				}
			}

			public int? ProjectId
			{
				get
				{
					return projectId;
				}
				set	
				{
					projectId = value;
				}
			}

			public int? Status
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

			public int? DevelopmentType
			{
				get
				{
					return developmentType;
				}
				set	
				{
					developmentType = value;
				}
			}

			public List<string> EnvTypes
			{
				get
				{
					return envTypes;
				}
				set	
				{
					envTypes = value;
				}
			}
		}
	}
}
