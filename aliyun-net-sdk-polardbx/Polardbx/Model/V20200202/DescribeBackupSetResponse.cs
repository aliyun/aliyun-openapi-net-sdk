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

namespace Aliyun.Acs.polardbx.Model.V20200202
{
	public class DescribeBackupSetResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private bool? success;

		private List<DescribeBackupSet_BackupSet> data;

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

		public List<DescribeBackupSet_BackupSet> Data
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

		public class DescribeBackupSet_BackupSet
		{

			private long? endTime;

			private int? status;

			private long? backupSetSize;

			private long? backupSetId;

			private int? backupType;

			private long? beginTime;

			private int? backupModel;

			private List<DescribeBackupSet_OSS> oSSList;

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

			public long? BackupSetSize
			{
				get
				{
					return backupSetSize;
				}
				set	
				{
					backupSetSize = value;
				}
			}

			public long? BackupSetId
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

			public int? BackupType
			{
				get
				{
					return backupType;
				}
				set	
				{
					backupType = value;
				}
			}

			public long? BeginTime
			{
				get
				{
					return beginTime;
				}
				set	
				{
					beginTime = value;
				}
			}

			public int? BackupModel
			{
				get
				{
					return backupModel;
				}
				set	
				{
					backupModel = value;
				}
			}

			public List<DescribeBackupSet_OSS> OSSList
			{
				get
				{
					return oSSList;
				}
				set	
				{
					oSSList = value;
				}
			}

			public class DescribeBackupSet_OSS
			{

				private string backupSetFile;

				private string linkExpiredTime;

				private string intranetDownloadLink;

				private string downloadLink;

				public string BackupSetFile
				{
					get
					{
						return backupSetFile;
					}
					set	
					{
						backupSetFile = value;
					}
				}

				public string LinkExpiredTime
				{
					get
					{
						return linkExpiredTime;
					}
					set	
					{
						linkExpiredTime = value;
					}
				}

				public string IntranetDownloadLink
				{
					get
					{
						return intranetDownloadLink;
					}
					set	
					{
						intranetDownloadLink = value;
					}
				}

				public string DownloadLink
				{
					get
					{
						return downloadLink;
					}
					set	
					{
						downloadLink = value;
					}
				}
			}
		}
	}
}
