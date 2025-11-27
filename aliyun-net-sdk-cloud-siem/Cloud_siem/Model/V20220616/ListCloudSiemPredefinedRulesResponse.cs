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
	public class ListCloudSiemPredefinedRulesResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private ListCloudSiemPredefinedRules_Data data;

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

		public ListCloudSiemPredefinedRules_Data Data
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

		public class ListCloudSiemPredefinedRules_Data
		{

			private List<ListCloudSiemPredefinedRules_ResponseDataItem> responseData;

			private ListCloudSiemPredefinedRules_PageInfo pageInfo;

			public List<ListCloudSiemPredefinedRules_ResponseDataItem> ResponseData
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

			public ListCloudSiemPredefinedRules_PageInfo PageInfo
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

			public class ListCloudSiemPredefinedRules_ResponseDataItem
			{

				private long? id;

				private string gmtCreate;

				private string gmtModified;

				private string ruleName;

				private string ruleNameCn;

				private string ruleNameEn;

				private string ruleNameMds;

				private string ruleDescMds;

				private string threatLevel;

				private string alertType;

				private string source;

				private string eventTransferType;

				private string attCk;

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

				public string RuleNameCn
				{
					get
					{
						return ruleNameCn;
					}
					set	
					{
						ruleNameCn = value;
					}
				}

				public string RuleNameEn
				{
					get
					{
						return ruleNameEn;
					}
					set	
					{
						ruleNameEn = value;
					}
				}

				public string RuleNameMds
				{
					get
					{
						return ruleNameMds;
					}
					set	
					{
						ruleNameMds = value;
					}
				}

				public string RuleDescMds
				{
					get
					{
						return ruleDescMds;
					}
					set	
					{
						ruleDescMds = value;
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

				public string Source
				{
					get
					{
						return source;
					}
					set	
					{
						source = value;
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

			public class ListCloudSiemPredefinedRules_PageInfo
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
