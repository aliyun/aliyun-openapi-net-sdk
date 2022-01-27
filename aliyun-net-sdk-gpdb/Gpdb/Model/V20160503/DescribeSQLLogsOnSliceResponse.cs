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
	public class DescribeSQLLogsOnSliceResponse : AcsResponse
	{

		private string requestId;

		private int? pageRecordCount;

		private int? pageNumber;

		private List<DescribeSQLLogsOnSlice_SQLLogsSliceItem> sliceLogItems;

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

		public List<DescribeSQLLogsOnSlice_SQLLogsSliceItem> SliceLogItems
		{
			get
			{
				return sliceLogItems;
			}
			set	
			{
				sliceLogItems = value;
			}
		}

		public class DescribeSQLLogsOnSlice_SQLLogsSliceItem
		{

			private string executeStatus;

			private float? executeCost;

			private long? returnRowCounts;

			private string operationExecuteTime;

			private string segmentId;

			private float? peakMemory;

			private string operationExecuteEndTime;

			private string segmentName;

			public string ExecuteStatus
			{
				get
				{
					return executeStatus;
				}
				set	
				{
					executeStatus = value;
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

			public string SegmentId
			{
				get
				{
					return segmentId;
				}
				set	
				{
					segmentId = value;
				}
			}

			public float? PeakMemory
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

			public string OperationExecuteEndTime
			{
				get
				{
					return operationExecuteEndTime;
				}
				set	
				{
					operationExecuteEndTime = value;
				}
			}

			public string SegmentName
			{
				get
				{
					return segmentName;
				}
				set	
				{
					segmentName = value;
				}
			}
		}
	}
}
