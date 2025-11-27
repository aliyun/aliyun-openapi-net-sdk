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

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
	public class CopyPlaybookResponse : AcsResponse
	{

		private string requestId;

		private CopyPlaybook_Data data;

		private CopyPlaybook_Page page;

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

		public CopyPlaybook_Data Data
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

		public CopyPlaybook_Page Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
			}
		}

		public class CopyPlaybook_Data
		{

			private string displayName;

			private string playbookUuid;

			private string ownType;

			private int? active;

			private long? lastRuntime;

			private int? permission;

			private long? gmtCreate;

			private long? gmtModified;

			private int? historyMd5;

			private int? succNum;

			private int? failNum;

			private double? failRate;

			private string inputParams;

			private string outputParams;

			private string description;

			private string logicReleaseTaskflowMd5;

			private int? playbookStatus;

			private string tenantId;

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

			public string PlaybookUuid
			{
				get
				{
					return playbookUuid;
				}
				set	
				{
					playbookUuid = value;
				}
			}

			public string OwnType
			{
				get
				{
					return ownType;
				}
				set	
				{
					ownType = value;
				}
			}

			public int? Active
			{
				get
				{
					return active;
				}
				set	
				{
					active = value;
				}
			}

			public long? LastRuntime
			{
				get
				{
					return lastRuntime;
				}
				set	
				{
					lastRuntime = value;
				}
			}

			public int? Permission
			{
				get
				{
					return permission;
				}
				set	
				{
					permission = value;
				}
			}

			public long? GmtCreate
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

			public long? GmtModified
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

			public int? HistoryMd5
			{
				get
				{
					return historyMd5;
				}
				set	
				{
					historyMd5 = value;
				}
			}

			public int? SuccNum
			{
				get
				{
					return succNum;
				}
				set	
				{
					succNum = value;
				}
			}

			public int? FailNum
			{
				get
				{
					return failNum;
				}
				set	
				{
					failNum = value;
				}
			}

			public double? FailRate
			{
				get
				{
					return failRate;
				}
				set	
				{
					failRate = value;
				}
			}

			public string InputParams
			{
				get
				{
					return inputParams;
				}
				set	
				{
					inputParams = value;
				}
			}

			public string OutputParams
			{
				get
				{
					return outputParams;
				}
				set	
				{
					outputParams = value;
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

			public string LogicReleaseTaskflowMd5
			{
				get
				{
					return logicReleaseTaskflowMd5;
				}
				set	
				{
					logicReleaseTaskflowMd5 = value;
				}
			}

			public int? PlaybookStatus
			{
				get
				{
					return playbookStatus;
				}
				set	
				{
					playbookStatus = value;
				}
			}

			public string TenantId
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
		}

		public class CopyPlaybook_Page
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

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
		}
	}
}
