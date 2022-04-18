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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeDataLimitsResponse : AcsResponse
	{

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeDataLimits_DataLimit> items;

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

			private bool? supportEvent;

			private string errorMessage;

			private int? checkStatus;

			private string localName;

			private string tenantName;

			private string agentId;

			private long? nextStartTime;

			private string connector;

			private int? port;

			private string checkStatusName;

			private int? agentState;

			private int? samplingSize;

			private string parentId;

			private int? datamaskStatus;

			private int? processTotalCount;

			private long? resourceType;

			private string errorCode;

			private int? ocrStatus;

			private int? logStoreDay;

			private int? eventStatus;

			private bool? supportScan;

			private long? lastFinishedTime;

			private string userName;

			private int? auditStatus;

			private bool? supportOcr;

			private bool? supportAgentInstall;

			private string engineType;

			private string instanceId;

			private int? totalCount;

			private string instanceDescription;

			private string dbVersion;

			private string regionId;

			private long? gmtCreate;

			private bool? supportAudit;

			private int? autoScan;

			private string resourceTypeCode;

			private bool? supportDatamask;

			private int? processStatus;

			private long? id;

			private int? enable;

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
		}
	}
}
