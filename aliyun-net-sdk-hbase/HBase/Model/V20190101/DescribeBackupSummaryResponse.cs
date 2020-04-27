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
	public class DescribeBackupSummaryResponse : AcsResponse
	{

		private string requestId;

		private DescribeBackupSummary_Incr incr;

		private DescribeBackupSummary_Full full;

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

		public DescribeBackupSummary_Incr Incr
		{
			get
			{
				return incr;
			}
			set	
			{
				incr = value;
			}
		}

		public DescribeBackupSummary_Full Full
		{
			get
			{
				return full;
			}
			set	
			{
				full = value;
			}
		}

		public class DescribeBackupSummary_Incr
		{

			private string pos;

			private string queueLogNum;

			private string speed;

			private string status;

			private string runningLogNum;

			private string backupLogSize;

			public string Pos
			{
				get
				{
					return pos;
				}
				set	
				{
					pos = value;
				}
			}

			public string QueueLogNum
			{
				get
				{
					return queueLogNum;
				}
				set	
				{
					queueLogNum = value;
				}
			}

			public string Speed
			{
				get
				{
					return speed;
				}
				set	
				{
					speed = value;
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

			public string RunningLogNum
			{
				get
				{
					return runningLogNum;
				}
				set	
				{
					runningLogNum = value;
				}
			}

			public string BackupLogSize
			{
				get
				{
					return backupLogSize;
				}
				set	
				{
					backupLogSize = value;
				}
			}
		}

		public class DescribeBackupSummary_Full
		{

			private string hasMore;

			private string recordSize;

			private string nextFullBackupDate;

			private List<DescribeBackupSummary_Record> records;

			public string HasMore
			{
				get
				{
					return hasMore;
				}
				set	
				{
					hasMore = value;
				}
			}

			public string RecordSize
			{
				get
				{
					return recordSize;
				}
				set	
				{
					recordSize = value;
				}
			}

			public string NextFullBackupDate
			{
				get
				{
					return nextFullBackupDate;
				}
				set	
				{
					nextFullBackupDate = value;
				}
			}

			public List<DescribeBackupSummary_Record> Records
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

			public class DescribeBackupSummary_Record
			{

				private string recordId;

				private string finishTime;

				private string process;

				private string createTime;

				private string dataSize;

				private string speed;

				private string status;

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

				public string Process
				{
					get
					{
						return process;
					}
					set	
					{
						process = value;
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

				public string DataSize
				{
					get
					{
						return dataSize;
					}
					set	
					{
						dataSize = value;
					}
				}

				public string Speed
				{
					get
					{
						return speed;
					}
					set	
					{
						speed = value;
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
			}
		}
	}
}
