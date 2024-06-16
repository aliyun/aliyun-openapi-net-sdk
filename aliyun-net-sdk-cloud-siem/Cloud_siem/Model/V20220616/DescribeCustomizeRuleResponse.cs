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
	public class DescribeCustomizeRuleResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private DescribeCustomizeRule_Data data;

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

		public DescribeCustomizeRule_Data Data
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

		public class DescribeCustomizeRule_Data
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

			private int? eventTransferSwitch;

			private string eventTransferType;

			private string eventTransferExt;

			private int? status;

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
		}
	}
}
