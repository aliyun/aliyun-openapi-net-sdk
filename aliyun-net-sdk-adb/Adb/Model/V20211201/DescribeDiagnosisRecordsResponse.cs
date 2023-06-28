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

namespace Aliyun.Acs.adb.Model.V20211201
{
	public class DescribeDiagnosisRecordsResponse : AcsResponse
	{

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private string requestId;

		private List<DescribeDiagnosisRecords_Items> querys;

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

		public List<DescribeDiagnosisRecords_Items> Querys
		{
			get
			{
				return querys;
			}
			set	
			{
				querys = value;
			}
		}

		public class DescribeDiagnosisRecords_Items
		{

			private string sQL;

			private long? sQLTruncatedThreshold;

			private string status;

			private long? outputDataSize;

			private long? cost;

			private long? outputRows;

			private string rcHost;

			private long? scanSize;

			private string processId;

			private long? startTime;

			private bool? sQLTruncated;

			private string database;

			private long? scanRows;

			private int? resourceCostRank;

			private string clientIp;

			private long? peakMemory;

			private long? queueTime;

			private string resourceGroup;

			private string userName;

			private long? executionTime;

			private long? totalPlanningTime;

			private long? etlWriteRows;

			private int? totalStages;

			public string SQL
			{
				get
				{
					return sQL;
				}
				set	
				{
					sQL = value;
				}
			}

			public long? SQLTruncatedThreshold
			{
				get
				{
					return sQLTruncatedThreshold;
				}
				set	
				{
					sQLTruncatedThreshold = value;
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

			public long? OutputDataSize
			{
				get
				{
					return outputDataSize;
				}
				set	
				{
					outputDataSize = value;
				}
			}

			public long? Cost
			{
				get
				{
					return cost;
				}
				set	
				{
					cost = value;
				}
			}

			public long? OutputRows
			{
				get
				{
					return outputRows;
				}
				set	
				{
					outputRows = value;
				}
			}

			public string RcHost
			{
				get
				{
					return rcHost;
				}
				set	
				{
					rcHost = value;
				}
			}

			public long? ScanSize
			{
				get
				{
					return scanSize;
				}
				set	
				{
					scanSize = value;
				}
			}

			public string ProcessId
			{
				get
				{
					return processId;
				}
				set	
				{
					processId = value;
				}
			}

			public long? StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public bool? SQLTruncated
			{
				get
				{
					return sQLTruncated;
				}
				set	
				{
					sQLTruncated = value;
				}
			}

			public string Database
			{
				get
				{
					return database;
				}
				set	
				{
					database = value;
				}
			}

			public long? ScanRows
			{
				get
				{
					return scanRows;
				}
				set	
				{
					scanRows = value;
				}
			}

			public int? ResourceCostRank
			{
				get
				{
					return resourceCostRank;
				}
				set	
				{
					resourceCostRank = value;
				}
			}

			public string ClientIp
			{
				get
				{
					return clientIp;
				}
				set	
				{
					clientIp = value;
				}
			}

			public long? PeakMemory
			{
				get
				{
					return peakMemory;
				}
				set	
				{
					peakMemory = value;
				}
			}

			public long? QueueTime
			{
				get
				{
					return queueTime;
				}
				set	
				{
					queueTime = value;
				}
			}

			public string ResourceGroup
			{
				get
				{
					return resourceGroup;
				}
				set	
				{
					resourceGroup = value;
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

			public long? ExecutionTime
			{
				get
				{
					return executionTime;
				}
				set	
				{
					executionTime = value;
				}
			}

			public long? TotalPlanningTime
			{
				get
				{
					return totalPlanningTime;
				}
				set	
				{
					totalPlanningTime = value;
				}
			}

			public long? EtlWriteRows
			{
				get
				{
					return etlWriteRows;
				}
				set	
				{
					etlWriteRows = value;
				}
			}

			public int? TotalStages
			{
				get
				{
					return totalStages;
				}
				set	
				{
					totalStages = value;
				}
			}
		}
	}
}
