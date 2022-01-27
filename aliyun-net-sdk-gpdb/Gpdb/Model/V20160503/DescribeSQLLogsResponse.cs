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

namespace Aliyun.Acs.gpdb.Model.V20160503
{
	public class DescribeSQLLogsResponse : AcsResponse
	{

		private int? pageRecordCount;

		private string requestId;

		private int? pageNumber;

		private List<DescribeSQLLogs_Item> items;

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
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

		public List<DescribeSQLLogs_Item> Items
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

		public class DescribeSQLLogs_Item
		{

			private string operationClass;

			private string executeState;

			private float? executeCost;

			private string sQLText;

			private int? sourcePort;

			private string dBRole;

			private string operationType;

			private string sourceIP;

			private string sQLPlan;

			private long? returnRowCounts;

			private string dBName;

			private string operationExecuteTime;

			private long? scanRowCounts;

			private string accountName;

			public string OperationClass
			{
				get
				{
					return operationClass;
				}
				set	
				{
					operationClass = value;
				}
			}

			public string ExecuteState
			{
				get
				{
					return executeState;
				}
				set	
				{
					executeState = value;
				}
			}

			public float? ExecuteCost
			{
				get
				{
					return executeCost;
				}
				set	
				{
					executeCost = value;
				}
			}

			public string SQLText
			{
				get
				{
					return sQLText;
				}
				set	
				{
					sQLText = value;
				}
			}

			public int? SourcePort
			{
				get
				{
					return sourcePort;
				}
				set	
				{
					sourcePort = value;
				}
			}

			public string DBRole
			{
				get
				{
					return dBRole;
				}
				set	
				{
					dBRole = value;
				}
			}

			public string OperationType
			{
				get
				{
					return operationType;
				}
				set	
				{
					operationType = value;
				}
			}

			public string SourceIP
			{
				get
				{
					return sourceIP;
				}
				set	
				{
					sourceIP = value;
				}
			}

			public string SQLPlan
			{
				get
				{
					return sQLPlan;
				}
				set	
				{
					sQLPlan = value;
				}
			}

			public long? ReturnRowCounts
			{
				get
				{
					return returnRowCounts;
				}
				set	
				{
					returnRowCounts = value;
				}
			}

			public string DBName
			{
				get
				{
					return dBName;
				}
				set	
				{
					dBName = value;
				}
			}

			public string OperationExecuteTime
			{
				get
				{
					return operationExecuteTime;
				}
				set	
				{
					operationExecuteTime = value;
				}
			}

			public long? ScanRowCounts
			{
				get
				{
					return scanRowCounts;
				}
				set	
				{
					scanRowCounts = value;
				}
			}

			public string AccountName
			{
				get
				{
					return accountName;
				}
				set	
				{
					accountName = value;
				}
			}
		}
	}
}
