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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeBinlogFilesResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? maxRecordsPerPage;

		private int? totalRecordCount;

		private List<DescribeBinlogFiles_LogFile> items;

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

		public int? MaxRecordsPerPage
		{
			get
			{
				return maxRecordsPerPage;
			}
			set	
			{
				maxRecordsPerPage = value;
			}
		}

		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		public List<DescribeBinlogFiles_LogFile> Items
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

		public class DescribeBinlogFiles_LogFile
		{

			private string logFileName;

			private string dumpDownloadURL;

			private string logBeginTime;

			private string dumpBucket;

			private string linkExpiredTime;

			private string downloadLink;

			private string oSSEndpoint;

			private string logEndTime;

			private int? dumpState;

			private string fileSize;

			private string fileId;

			private string binLogId;

			private string logStatus;

			public string LogFileName
			{
				get
				{
					return logFileName;
				}
				set	
				{
					logFileName = value;
				}
			}

			public string DumpDownloadURL
			{
				get
				{
					return dumpDownloadURL;
				}
				set	
				{
					dumpDownloadURL = value;
				}
			}

			public string LogBeginTime
			{
				get
				{
					return logBeginTime;
				}
				set	
				{
					logBeginTime = value;
				}
			}

			public string DumpBucket
			{
				get
				{
					return dumpBucket;
				}
				set	
				{
					dumpBucket = value;
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

			public string OSSEndpoint
			{
				get
				{
					return oSSEndpoint;
				}
				set	
				{
					oSSEndpoint = value;
				}
			}

			public string LogEndTime
			{
				get
				{
					return logEndTime;
				}
				set	
				{
					logEndTime = value;
				}
			}

			public int? DumpState
			{
				get
				{
					return dumpState;
				}
				set	
				{
					dumpState = value;
				}
			}

			public string FileSize
			{
				get
				{
					return fileSize;
				}
				set	
				{
					fileSize = value;
				}
			}

			public string FileId
			{
				get
				{
					return fileId;
				}
				set	
				{
					fileId = value;
				}
			}

			public string BinLogId
			{
				get
				{
					return binLogId;
				}
				set	
				{
					binLogId = value;
				}
			}

			public string LogStatus
			{
				get
				{
					return logStatus;
				}
				set	
				{
					logStatus = value;
				}
			}
		}
	}
}
