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
	public class GetProjectResponse : AcsResponse
	{

		private int? httpStatusCode;

		private bool? success;

		private string requestId;

		private GetProject_Data data;

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

		public GetProject_Data Data
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

		public class GetProject_Data
		{

			private string gmtModified;

			private int? maxFlowNode;

			private string defaultDiResourceGroupIdentifier;

			private int? destination;

			private int? isAllowDownload;

			private string prodStorageQuota;

			private int? schedulerRetryInterval;

			private string residentArea;

			private int? tablePrivacyMode;

			private string projectOwnerBaseId;

			private bool? useProxyOdpsAccount;

			private bool? disableDevelopment;

			private int? projectMode;

			private string gmtCreate;

			private string devStorageQuota;

			private int? isDefault;

			private int? protectedMode;

			private bool? baseProject;

			private long? tenantId;

			private string projectDescription;

			private string appkey;

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

			public int? MaxFlowNode
			{
				get
				{
					return maxFlowNode;
				}
				set	
				{
					maxFlowNode = value;
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

			public int? Destination
			{
				get
				{
					return destination;
				}
				set	
				{
					destination = value;
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

			public string ProdStorageQuota
			{
				get
				{
					return prodStorageQuota;
				}
				set	
				{
					prodStorageQuota = value;
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

			public int? TablePrivacyMode
			{
				get
				{
					return tablePrivacyMode;
				}
				set	
				{
					tablePrivacyMode = value;
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

			public bool? UseProxyOdpsAccount
			{
				get
				{
					return useProxyOdpsAccount;
				}
				set	
				{
					useProxyOdpsAccount = value;
				}
			}

			public bool? DisableDevelopment
			{
				get
				{
					return disableDevelopment;
				}
				set	
				{
					disableDevelopment = value;
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

			public string DevStorageQuota
			{
				get
				{
					return devStorageQuota;
				}
				set	
				{
					devStorageQuota = value;
				}
			}

			public int? IsDefault
			{
				get
				{
					return isDefault;
				}
				set	
				{
					isDefault = value;
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

			public bool? BaseProject
			{
				get
				{
					return baseProject;
				}
				set	
				{
					baseProject = value;
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

			public string Appkey
			{
				get
				{
					return appkey;
				}
				set	
				{
					appkey = value;
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
