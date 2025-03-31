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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class ListCloudSiemCustomizeRulesResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private ListCloudSiemCustomizeRules_Data data;

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

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public ListCloudSiemCustomizeRules_Data Data
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

		public class ListCloudSiemCustomizeRules_Data
		{

			private List<ListCloudSiemCustomizeRules_ResponseDataItem> responseData;

			private ListCloudSiemCustomizeRules_PageInfo pageInfo;

			public List<ListCloudSiemCustomizeRules_ResponseDataItem> ResponseData
			{
				get
				{
					return responseData;
				}
				set	
				{
					responseData = value;
				}
			}

			public ListCloudSiemCustomizeRules_PageInfo PageInfo
			{
				get
				{
					return pageInfo;
				}
				set	
				{
					pageInfo = value;
				}
			}

			public class ListCloudSiemCustomizeRules_ResponseDataItem
			{

				private long? id;

				private string gmtCreate;

				private string gmtModified;

				private long? aliuid;

				private string ruleName;

				private string ruleDesc;

				private string ruleType;

				private string threatLevel;

				private string alertType;

				private string alertTypeMds;

				private string logType;

				private string logTypeMds;

				private string logSource;

				private string logSourceMds;

				private string ruleCondition;

				private string ruleGroup;

				private string ruleThreshold;

				private string queryCycle;

				private string attCk;

				private int? eventTransferSwitch;

				private string eventTransferType;

				private string eventTransferExt;

				private int? status;

				private int? dataType;

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

				public long? Aliuid
				{
					get
					{
						return aliuid;
					}
					set	
					{
						aliuid = value;
					}
				}

				public string RuleName
				{
					get
					{
						return ruleName;
					}
					set	
					{
						ruleName = value;
					}
				}

				public string RuleDesc
				{
					get
					{
						return ruleDesc;
					}
					set	
					{
						ruleDesc = value;
					}
				}

				public string RuleType
				{
					get
					{
						return ruleType;
					}
					set	
					{
						ruleType = value;
					}
				}

				public string ThreatLevel
				{
					get
					{
						return threatLevel;
					}
					set	
					{
						threatLevel = value;
					}
				}

				public string AlertType
				{
					get
					{
						return alertType;
					}
					set	
					{
						alertType = value;
					}
				}

				public string AlertTypeMds
				{
					get
					{
						return alertTypeMds;
					}
					set	
					{
						alertTypeMds = value;
					}
				}

				public string LogType
				{
					get
					{
						return logType;
					}
					set	
					{
						logType = value;
					}
				}

				public string LogTypeMds
				{
					get
					{
						return logTypeMds;
					}
					set	
					{
						logTypeMds = value;
					}
				}

				public string LogSource
				{
					get
					{
						return logSource;
					}
					set	
					{
						logSource = value;
					}
				}

				public string LogSourceMds
				{
					get
					{
						return logSourceMds;
					}
					set	
					{
						logSourceMds = value;
					}
				}

				public string RuleCondition
				{
					get
					{
						return ruleCondition;
					}
					set	
					{
						ruleCondition = value;
					}
				}

				public string RuleGroup
				{
					get
					{
						return ruleGroup;
					}
					set	
					{
						ruleGroup = value;
					}
				}

				public string RuleThreshold
				{
					get
					{
						return ruleThreshold;
					}
					set	
					{
						ruleThreshold = value;
					}
				}

				public string QueryCycle
				{
					get
					{
						return queryCycle;
					}
					set	
					{
						queryCycle = value;
					}
				}

				public string AttCk
				{
					get
					{
						return attCk;
					}
					set	
					{
						attCk = value;
					}
				}

				public int? EventTransferSwitch
				{
					get
					{
						return eventTransferSwitch;
					}
					set	
					{
						eventTransferSwitch = value;
					}
				}

				public string EventTransferType
				{
					get
					{
						return eventTransferType;
					}
					set	
					{
						eventTransferType = value;
					}
				}

				public string EventTransferExt
				{
					get
					{
						return eventTransferExt;
					}
					set	
					{
						eventTransferExt = value;
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

				public int? DataType
				{
					get
					{
						return dataType;
					}
					set	
					{
						dataType = value;
					}
				}
			}

			public class ListCloudSiemCustomizeRules_PageInfo
			{

				private int? currentPage;

				private int? pageSize;

				private long? totalCount;

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

				public long? TotalCount
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
			}
		}
	}
}
