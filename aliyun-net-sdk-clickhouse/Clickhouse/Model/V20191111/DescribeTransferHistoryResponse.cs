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

namespace Aliyun.Acs.clickhouse.Model.V20191111
{
	public class DescribeTransferHistoryResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeTransferHistory_HistoryDetail> historyDetails;

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

		public List<DescribeTransferHistory_HistoryDetail> HistoryDetails
		{
			get
			{
				return historyDetails;
			}
			set	
			{
				historyDetails = value;
			}
		}

		public class DescribeTransferHistory_HistoryDetail
		{

			private string sourceDBCluster;

			private string sourceControlVersion;

			private string targetDBCluster;

			private string targetControlVersion;

			private string status;

			private string progress;

			private string disableWriteWindows;

			private long? unsyncedBytes;

			private long? unsyncedParts;

			private double? partsPerMinute;

			private long? bytesPerMinute;

			private string subJob;

			private string subJobStatus;

			public string SourceDBCluster
			{
				get
				{
					return sourceDBCluster;
				}
				set	
				{
					sourceDBCluster = value;
				}
			}

			public string SourceControlVersion
			{
				get
				{
					return sourceControlVersion;
				}
				set	
				{
					sourceControlVersion = value;
				}
			}

			public string TargetDBCluster
			{
				get
				{
					return targetDBCluster;
				}
				set	
				{
					targetDBCluster = value;
				}
			}

			public string TargetControlVersion
			{
				get
				{
					return targetControlVersion;
				}
				set	
				{
					targetControlVersion = value;
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

			public string Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}

			public string DisableWriteWindows
			{
				get
				{
					return disableWriteWindows;
				}
				set	
				{
					disableWriteWindows = value;
				}
			}

			public long? UnsyncedBytes
			{
				get
				{
					return unsyncedBytes;
				}
				set	
				{
					unsyncedBytes = value;
				}
			}

			public long? UnsyncedParts
			{
				get
				{
					return unsyncedParts;
				}
				set	
				{
					unsyncedParts = value;
				}
			}

			public double? PartsPerMinute
			{
				get
				{
					return partsPerMinute;
				}
				set	
				{
					partsPerMinute = value;
				}
			}

			public long? BytesPerMinute
			{
				get
				{
					return bytesPerMinute;
				}
				set	
				{
					bytesPerMinute = value;
				}
			}

			public string SubJob
			{
				get
				{
					return subJob;
				}
				set	
				{
					subJob = value;
				}
			}

			public string SubJobStatus
			{
				get
				{
					return subJobStatus;
				}
				set	
				{
					subJobStatus = value;
				}
			}
		}
	}
}
