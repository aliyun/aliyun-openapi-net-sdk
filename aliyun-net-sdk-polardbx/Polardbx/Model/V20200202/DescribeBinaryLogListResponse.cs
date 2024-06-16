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
	public class DescribeBinaryLogListResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalNumber;

		private List<DescribeBinaryLogList_LogListItem> logList;

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

		public int? TotalNumber
		{
			get
			{
				return totalNumber;
			}
			set	
			{
				totalNumber = value;
			}
		}

		public List<DescribeBinaryLogList_LogListItem> LogList
		{
			get
			{
				return logList;
			}
			set	
			{
				logList = value;
			}
		}

		public class DescribeBinaryLogList_LogListItem
		{

			private string endTime;

			private string modifiedTime;

			private string uploadHost;

			private int? uploadStatus;

			private string downloadLink;

			private string beginTime;

			private long? logSize;

			private string fileName;

			private string createdTime;

			private int? purgeStatus;

			private long? id;

			public string EndTime
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

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
				}
			}

			public string UploadHost
			{
				get
				{
					return uploadHost;
				}
				set	
				{
					uploadHost = value;
				}
			}

			public int? UploadStatus
			{
				get
				{
					return uploadStatus;
				}
				set	
				{
					uploadStatus = value;
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

			public string BeginTime
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

			public long? LogSize
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

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public int? PurgeStatus
			{
				get
				{
					return purgeStatus;
				}
				set	
				{
					purgeStatus = value;
				}
			}

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}
		}
	}
}
