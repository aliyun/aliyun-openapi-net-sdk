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

namespace Aliyun.Acs.adb.Model.V20211201
{
	public class DescribeDownloadRecordsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDownloadRecords_Items> records;

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

		public List<DescribeDownloadRecords_Items> Records
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

		public class DescribeDownloadRecords_Items
		{

			private string status;

			private long? downloadId;

			private string exceptionMsg;

			private string url;

			private string fileName;

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

			public long? DownloadId
			{
				get
				{
					return downloadId;
				}
				set	
				{
					downloadId = value;
				}
			}

			public string ExceptionMsg
			{
				get
				{
					return exceptionMsg;
				}
				set	
				{
					exceptionMsg = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public string FileName
			{
				get
				{
					return fileName;
				}
				set	
				{
					fileName = value;
				}
			}
		}
	}
}
