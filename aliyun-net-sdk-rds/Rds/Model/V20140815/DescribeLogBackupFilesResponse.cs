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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeLogBackupFilesResponse : AcsResponse
	{

		private long? totalFileSize;

		private int? pageNumber;

		private string requestId;

		private int? pageRecordCount;

		private int? totalRecordCount;

		private List<DescribeLogBackupFiles_BinLogFile> items;

		[JsonProperty(PropertyName = "TotalFileSize")]
		public long? TotalFileSize
		{
			get
			{
				return totalFileSize;
			}
			set	
			{
				totalFileSize = value;
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "PageRecordCount")]
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

		[JsonProperty(PropertyName = "TotalRecordCount")]
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

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeLogBackupFiles_BinLogFile> Items
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

		public class DescribeLogBackupFiles_BinLogFile
		{

			private string logBeginTime;

			private string intranetDownloadLink;

			private string linkExpiredTime;

			private string downloadLink;

			private string logEndTime;

			private long? fileSize;

			[JsonProperty(PropertyName = "LogBeginTime")]
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

			[JsonProperty(PropertyName = "IntranetDownloadLink")]
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

			[JsonProperty(PropertyName = "LinkExpiredTime")]
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

			[JsonProperty(PropertyName = "DownloadLink")]
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

			[JsonProperty(PropertyName = "LogEndTime")]
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

			[JsonProperty(PropertyName = "FileSize")]
			public long? FileSize
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
		}
	}
}
