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
	public class DescribeBinlogFilesResponse : AcsResponse
	{

		private int? totalRecordCount;

		private int? pageNumber;

		private int? pageRecordCount;

		private long? totalFileSize;

		private List<BinLogFile> items;

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

		public List<BinLogFile> Items
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

		public class BinLogFile{

			private long? fileSize;

			private string logBeginTime;

			private string logEndTime;

			private string downloadLink;

			private string intranetDownloadLink;

			private string linkExpiredTime;

			private string checksum;

			private string hostInstanceID;

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

			public string Checksum
			{
				get
				{
					return checksum;
				}
				set	
				{
					checksum = value;
				}
			}

			public string HostInstanceID
			{
				get
				{
					return hostInstanceID;
				}
				set	
				{
					hostInstanceID = value;
				}
			}
		}
	}
}