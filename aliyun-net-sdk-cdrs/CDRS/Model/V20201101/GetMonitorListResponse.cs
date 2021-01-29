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

namespace Aliyun.Acs.CDRS.Model.V20201101
{
	public class GetMonitorListResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private GetMonitorList_Data data;

		public string Code
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

		public GetMonitorList_Data Data
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

		public class GetMonitorList_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private int? totalPage;

			private List<GetMonitorList_Record> records;

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

			public int? TotalPage
			{
				get
				{
					return totalPage;
				}
				set	
				{
					totalPage = value;
				}
			}

			public List<GetMonitorList_Record> Records
			{
				get
				{
					return records;
				}
				set	
				{
					records = value;
				}
			}

			public class GetMonitorList_Record
			{

				private string taskId;

				private string status;

				private string monitorType;

				private string ruleName;

				private string algorithmVendor;

				private string createDate;

				private string modifiedDate;

				private string deviceList;

				private string attributes;

				private string ruleExpression;

				private string notifierType;

				private string notifierExtra;

				private string description;

				private string expression;

				private string imageMatch;

				public string TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
					}
				}

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

				public string MonitorType
				{
					get
					{
						return monitorType;
					}
					set	
					{
						monitorType = value;
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

				public string AlgorithmVendor
				{
					get
					{
						return algorithmVendor;
					}
					set	
					{
						algorithmVendor = value;
					}
				}

				public string CreateDate
				{
					get
					{
						return createDate;
					}
					set	
					{
						createDate = value;
					}
				}

				public string ModifiedDate
				{
					get
					{
						return modifiedDate;
					}
					set	
					{
						modifiedDate = value;
					}
				}

				public string DeviceList
				{
					get
					{
						return deviceList;
					}
					set	
					{
						deviceList = value;
					}
				}

				public string Attributes
				{
					get
					{
						return attributes;
					}
					set	
					{
						attributes = value;
					}
				}

				public string RuleExpression
				{
					get
					{
						return ruleExpression;
					}
					set	
					{
						ruleExpression = value;
					}
				}

				public string NotifierType
				{
					get
					{
						return notifierType;
					}
					set	
					{
						notifierType = value;
					}
				}

				public string NotifierExtra
				{
					get
					{
						return notifierExtra;
					}
					set	
					{
						notifierExtra = value;
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

				public string Expression
				{
					get
					{
						return expression;
					}
					set	
					{
						expression = value;
					}
				}

				public string ImageMatch
				{
					get
					{
						return imageMatch;
					}
					set	
					{
						imageMatch = value;
					}
				}
			}
		}
	}
}
