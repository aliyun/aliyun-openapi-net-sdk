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

namespace Aliyun.Acs.HBase.Model.V20190101
{
	public class DescribeRestoreSummaryResponse : AcsResponse
	{

		private string requestId;

		private int? hasMoreRestoreRecord;

		private int? pageNumber;

		private int? pageSize;

		private int? total;

		private List<DescribeRestoreSummary_Rescord> rescords;

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

		public int? HasMoreRestoreRecord
		{
			get
			{
				return hasMoreRestoreRecord;
			}
			set	
			{
				hasMoreRestoreRecord = value;
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

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<DescribeRestoreSummary_Rescord> Rescords
		{
			get
			{
				return rescords;
			}
			set	
			{
				rescords = value;
			}
		}

		public class DescribeRestoreSummary_Rescord
		{

			private string recordId;

			private string finishTime;

			private string schemaProcess;

			private string hfileRestoreProcess;

			private string createTime;

			private string bulkLoadProcess;

			private string status;

			private string logProcess;

			public string RecordId
			{
				get
				{
					return recordId;
				}
				set	
				{
					recordId = value;
				}
			}

			public string FinishTime
			{
				get
				{
					return finishTime;
				}
				set	
				{
					finishTime = value;
				}
			}

			public string SchemaProcess
			{
				get
				{
					return schemaProcess;
				}
				set	
				{
					schemaProcess = value;
				}
			}

			public string HfileRestoreProcess
			{
				get
				{
					return hfileRestoreProcess;
				}
				set	
				{
					hfileRestoreProcess = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string BulkLoadProcess
			{
				get
				{
					return bulkLoadProcess;
				}
				set	
				{
					bulkLoadProcess = value;
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

			public string LogProcess
			{
				get
				{
					return logProcess;
				}
				set	
				{
					logProcess = value;
				}
			}
		}
	}
}
