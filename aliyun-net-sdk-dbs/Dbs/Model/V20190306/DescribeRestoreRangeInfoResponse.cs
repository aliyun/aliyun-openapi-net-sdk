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

namespace Aliyun.Acs.Dbs.Model.V20190306
{
	public class DescribeRestoreRangeInfoResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string requestId;

		private string errCode;

		private bool? success;

		private string errMessage;

		private List<DescribeRestoreRangeInfo_DBSRecoverRange> items;

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

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

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
			}
		}

		public List<DescribeRestoreRangeInfo_DBSRecoverRange> Items
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

		public class DescribeRestoreRangeInfo_DBSRecoverRange
		{

			private long? endTimestampForRestore;

			private string sourceEndpointInstanceType;

			private string rangeType;

			private long? beginTimestampForRestore;

			private string sourceEndpointInstanceID;

			private List<DescribeRestoreRangeInfo_FullBackupDetail> fullBackupList;

			public long? EndTimestampForRestore
			{
				get
				{
					return endTimestampForRestore;
				}
				set	
				{
					endTimestampForRestore = value;
				}
			}

			public string SourceEndpointInstanceType
			{
				get
				{
					return sourceEndpointInstanceType;
				}
				set	
				{
					sourceEndpointInstanceType = value;
				}
			}

			public string RangeType
			{
				get
				{
					return rangeType;
				}
				set	
				{
					rangeType = value;
				}
			}

			public long? BeginTimestampForRestore
			{
				get
				{
					return beginTimestampForRestore;
				}
				set	
				{
					beginTimestampForRestore = value;
				}
			}

			public string SourceEndpointInstanceID
			{
				get
				{
					return sourceEndpointInstanceID;
				}
				set	
				{
					sourceEndpointInstanceID = value;
				}
			}

			public List<DescribeRestoreRangeInfo_FullBackupDetail> FullBackupList
			{
				get
				{
					return fullBackupList;
				}
				set	
				{
					fullBackupList = value;
				}
			}

			public class DescribeRestoreRangeInfo_FullBackupDetail
			{

				private long? endTime;

				private long? startTime;

				private string backupSetId;

				public long? EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
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

				public string BackupSetId
				{
					get
					{
						return backupSetId;
					}
					set	
					{
						backupSetId = value;
					}
				}
			}
		}
	}
}
