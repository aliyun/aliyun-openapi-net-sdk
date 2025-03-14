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
	public class DescribePlaybookResponse : AcsResponse
	{

		private string requestId;

		private DescribePlaybook_Playbook playbook;

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

		public DescribePlaybook_Playbook Playbook
		{
			get
			{
				return playbook;
			}
			set	
			{
				playbook = value;
			}
		}

		public class DescribePlaybook_Playbook
		{

			private string gmtCreate;

			private string gmtModified;

			private string playbookUuid;

			private string taskflow;

			private string taskflowType;

			private string taskconfig;

			private string tenantId;

			private string inputtype;

			private string ownType;

			private int? successExeNum;

			private int? failExeNum;

			private long? lastExeTime;

			private string triggerInfo;

			private string operateType;

			private string displayName;

			private int? riskLevel;

			private string type;

			private string inputParams;

			private string description;

			private string oss;

			private bool? active;

			private string compiledresult;

			private string onlineOss;

			private bool? onlineActive;

			private string onlineCompiledresult;

			private string executeMode;

			private string cron;

			private string onlineExecuteMode;

			private string onlineCron;

			private long? schedulerId;

			private long? onlineSchedulerId;

			private int? parentId;

			private string outputParams;

			private string taskflowMd5;

			private string onlineReleaseUuid;

			private string onlineReleaseTime;

			private string releaseUuid;

			private string releaseTime;

			private string onlineReleaseTaskflowMd5;

			private string releaseTaskflowMd5;

			private int? flag;

			private string rightLevel;

			private string taskFlowDesc;

			private string debugFlag;

			private int? playbookStatus;

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

			public string Taskflow
			{
				get
				{
					return taskflow;
				}
				set	
				{
					taskflow = value;
				}
			}

			public string TaskflowType
			{
				get
				{
					return taskflowType;
				}
				set	
				{
					taskflowType = value;
				}
			}

			public string Taskconfig
			{
				get
				{
					return taskconfig;
				}
				set	
				{
					taskconfig = value;
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

			public string Inputtype
			{
				get
				{
					return inputtype;
				}
				set	
				{
					inputtype = value;
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

			public int? SuccessExeNum
			{
				get
				{
					return successExeNum;
				}
				set	
				{
					successExeNum = value;
				}
			}

			public int? FailExeNum
			{
				get
				{
					return failExeNum;
				}
				set	
				{
					failExeNum = value;
				}
			}

			public long? LastExeTime
			{
				get
				{
					return lastExeTime;
				}
				set	
				{
					lastExeTime = value;
				}
			}

			public string TriggerInfo
			{
				get
				{
					return triggerInfo;
				}
				set	
				{
					triggerInfo = value;
				}
			}

			public string OperateType
			{
				get
				{
					return operateType;
				}
				set	
				{
					operateType = value;
				}
			}

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

			public int? RiskLevel
			{
				get
				{
					return riskLevel;
				}
				set	
				{
					riskLevel = value;
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

			public string Oss
			{
				get
				{
					return oss;
				}
				set	
				{
					oss = value;
				}
			}

			public bool? Active
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

			public string Compiledresult
			{
				get
				{
					return compiledresult;
				}
				set	
				{
					compiledresult = value;
				}
			}

			public string OnlineOss
			{
				get
				{
					return onlineOss;
				}
				set	
				{
					onlineOss = value;
				}
			}

			public bool? OnlineActive
			{
				get
				{
					return onlineActive;
				}
				set	
				{
					onlineActive = value;
				}
			}

			public string OnlineCompiledresult
			{
				get
				{
					return onlineCompiledresult;
				}
				set	
				{
					onlineCompiledresult = value;
				}
			}

			public string ExecuteMode
			{
				get
				{
					return executeMode;
				}
				set	
				{
					executeMode = value;
				}
			}

			public string Cron
			{
				get
				{
					return cron;
				}
				set	
				{
					cron = value;
				}
			}

			public string OnlineExecuteMode
			{
				get
				{
					return onlineExecuteMode;
				}
				set	
				{
					onlineExecuteMode = value;
				}
			}

			public string OnlineCron
			{
				get
				{
					return onlineCron;
				}
				set	
				{
					onlineCron = value;
				}
			}

			public long? SchedulerId
			{
				get
				{
					return schedulerId;
				}
				set	
				{
					schedulerId = value;
				}
			}

			public long? OnlineSchedulerId
			{
				get
				{
					return onlineSchedulerId;
				}
				set	
				{
					onlineSchedulerId = value;
				}
			}

			public int? ParentId
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

			public string TaskflowMd5
			{
				get
				{
					return taskflowMd5;
				}
				set	
				{
					taskflowMd5 = value;
				}
			}

			public string OnlineReleaseUuid
			{
				get
				{
					return onlineReleaseUuid;
				}
				set	
				{
					onlineReleaseUuid = value;
				}
			}

			public string OnlineReleaseTime
			{
				get
				{
					return onlineReleaseTime;
				}
				set	
				{
					onlineReleaseTime = value;
				}
			}

			public string ReleaseUuid
			{
				get
				{
					return releaseUuid;
				}
				set	
				{
					releaseUuid = value;
				}
			}

			public string ReleaseTime
			{
				get
				{
					return releaseTime;
				}
				set	
				{
					releaseTime = value;
				}
			}

			public string OnlineReleaseTaskflowMd5
			{
				get
				{
					return onlineReleaseTaskflowMd5;
				}
				set	
				{
					onlineReleaseTaskflowMd5 = value;
				}
			}

			public string ReleaseTaskflowMd5
			{
				get
				{
					return releaseTaskflowMd5;
				}
				set	
				{
					releaseTaskflowMd5 = value;
				}
			}

			public int? Flag
			{
				get
				{
					return flag;
				}
				set	
				{
					flag = value;
				}
			}

			public string RightLevel
			{
				get
				{
					return rightLevel;
				}
				set	
				{
					rightLevel = value;
				}
			}

			public string TaskFlowDesc
			{
				get
				{
					return taskFlowDesc;
				}
				set	
				{
					taskFlowDesc = value;
				}
			}

			public string DebugFlag
			{
				get
				{
					return debugFlag;
				}
				set	
				{
					debugFlag = value;
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
		}
	}
}
