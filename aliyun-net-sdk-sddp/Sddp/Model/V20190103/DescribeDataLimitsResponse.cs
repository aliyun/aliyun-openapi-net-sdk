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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeDataLimitsResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeDataLimits_DataLimit> items;

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

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
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

		public List<DescribeDataLimits_DataLimit> Items
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

		public class DescribeDataLimits_DataLimit
		{

			private string regionId;

			private string localName;

			private string parentId;

			private long? id;

			private string userName;

			private long? gmtCreate;

			private string connector;

			private int? checkStatus;

			private string checkStatusName;

			private long? resourceType;

			private string resourceTypeCode;

			private int? auditStatus;

			private int? logStoreDay;

			private int? enable;

			private int? autoScan;

			private string engineType;

			private int? processStatus;

			private int? processTotalCount;

			private int? totalCount;

			private long? lastFinishedTime;

			private string errorCode;

			private string errorMessage;

			private int? port;

			private string dbVersion;

			private bool? supportDatamask;

			private bool? supportScan;

			private bool? supportAudit;

			private int? datamaskStatus;

			private int? samplingSize;

			private long? nextStartTime;

			private bool? supportOcr;

			private int? ocrStatus;

			private string agentId;

			private int? agentState;

			private bool? supportAgentInstall;

			private int? eventStatus;

			private bool? supportEvent;

			private string instanceId;

			private string instanceDescription;

			private string tenantName;

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

			public string LocalName
			{
				get
				{
					return localName;
				}
				set	
				{
					localName = value;
				}
			}

			public string ParentId
			{
				get
				{
					return parentId;
				}
				set	
				{
					parentId = value;
				}
			}

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
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

			public string Connector
			{
				get
				{
					return connector;
				}
				set	
				{
					connector = value;
				}
			}

			public int? CheckStatus
			{
				get
				{
					return checkStatus;
				}
				set	
				{
					checkStatus = value;
				}
			}

			public string CheckStatusName
			{
				get
				{
					return checkStatusName;
				}
				set	
				{
					checkStatusName = value;
				}
			}

			public long? ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

			public string ResourceTypeCode
			{
				get
				{
					return resourceTypeCode;
				}
				set	
				{
					resourceTypeCode = value;
				}
			}

			public int? AuditStatus
			{
				get
				{
					return auditStatus;
				}
				set	
				{
					auditStatus = value;
				}
			}

			public int? LogStoreDay
			{
				get
				{
					return logStoreDay;
				}
				set	
				{
					logStoreDay = value;
				}
			}

			public int? Enable
			{
				get
				{
					return enable;
				}
				set	
				{
					enable = value;
				}
			}

			public int? AutoScan
			{
				get
				{
					return autoScan;
				}
				set	
				{
					autoScan = value;
				}
			}

			public string EngineType
			{
				get
				{
					return engineType;
				}
				set	
				{
					engineType = value;
				}
			}

			public int? ProcessStatus
			{
				get
				{
					return processStatus;
				}
				set	
				{
					processStatus = value;
				}
			}

			public int? ProcessTotalCount
			{
				get
				{
					return processTotalCount;
				}
				set	
				{
					processTotalCount = value;
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

			public long? LastFinishedTime
			{
				get
				{
					return lastFinishedTime;
				}
				set	
				{
					lastFinishedTime = value;
				}
			}

			public string ErrorCode
			{
				get
				{
					return errorCode;
				}
				set	
				{
					errorCode = value;
				}
			}

			public string ErrorMessage
			{
				get
				{
					return errorMessage;
				}
				set	
				{
					errorMessage = value;
				}
			}

			public int? Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public string DbVersion
			{
				get
				{
					return dbVersion;
				}
				set	
				{
					dbVersion = value;
				}
			}

			public bool? SupportDatamask
			{
				get
				{
					return supportDatamask;
				}
				set	
				{
					supportDatamask = value;
				}
			}

			public bool? SupportScan
			{
				get
				{
					return supportScan;
				}
				set	
				{
					supportScan = value;
				}
			}

			public bool? SupportAudit
			{
				get
				{
					return supportAudit;
				}
				set	
				{
					supportAudit = value;
				}
			}

			public int? DatamaskStatus
			{
				get
				{
					return datamaskStatus;
				}
				set	
				{
					datamaskStatus = value;
				}
			}

			public int? SamplingSize
			{
				get
				{
					return samplingSize;
				}
				set	
				{
					samplingSize = value;
				}
			}

			public long? NextStartTime
			{
				get
				{
					return nextStartTime;
				}
				set	
				{
					nextStartTime = value;
				}
			}

			public bool? SupportOcr
			{
				get
				{
					return supportOcr;
				}
				set	
				{
					supportOcr = value;
				}
			}

			public int? OcrStatus
			{
				get
				{
					return ocrStatus;
				}
				set	
				{
					ocrStatus = value;
				}
			}

			public string AgentId
			{
				get
				{
					return agentId;
				}
				set	
				{
					agentId = value;
				}
			}

			public int? AgentState
			{
				get
				{
					return agentState;
				}
				set	
				{
					agentState = value;
				}
			}

			public bool? SupportAgentInstall
			{
				get
				{
					return supportAgentInstall;
				}
				set	
				{
					supportAgentInstall = value;
				}
			}

			public int? EventStatus
			{
				get
				{
					return eventStatus;
				}
				set	
				{
					eventStatus = value;
				}
			}

			public bool? SupportEvent
			{
				get
				{
					return supportEvent;
				}
				set	
				{
					supportEvent = value;
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

			public string InstanceDescription
			{
				get
				{
					return instanceDescription;
				}
				set	
				{
					instanceDescription = value;
				}
			}

			public string TenantName
			{
				get
				{
					return tenantName;
				}
				set	
				{
					tenantName = value;
				}
			}
		}
	}
}
