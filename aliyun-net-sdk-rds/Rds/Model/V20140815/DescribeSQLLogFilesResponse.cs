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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeSQLLogFilesResponse : AcsResponse
	{

		private int? totalRecordCount;

		private int? pageNumber;

		private int? pageRecordCount;

		private List<LogFile> items;

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

		public List<LogFile> Items
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

		public class LogFile{

			private string fileID;

			private LogStatusEnum? logStatus;

			private string logDownloadURL;

			private string logSize;

			private string logStartTime;

			private string logEndTime;

			public string FileID
			{
				get
				{
					return fileID;
				}
				set	
				{
					fileID = value;
				}
			}

			public LogStatusEnum? LogStatus
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

			public string LogDownloadURL
			{
				get
				{
					return logDownloadURL;
				}
				set	
				{
					logDownloadURL = value;
				}
			}

			public string LogSize
			{
				get
				{
					return logSize;
				}
				set	
				{
					logSize = value;
				}
			}

			public string LogStartTime
			{
				get
				{
					return logStartTime;
				}
				set	
				{
					logStartTime = value;
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

public enum LogStatusEnum {

					Generating,
					NoStart,
					Failed,
					Success,
}
		}
	}
}