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
	public class DescribeCrossRegionLogBackupFilesResponse : AcsResponse
	{

		private string endTime;

		private string startTime;

		private string requestId;

		private int? pageRecordCount;

		private int? totalRecordCount;

		private string dBInstanceId;

		private int? pageNumber;

		private string regionId;

		private List<DescribeCrossRegionLogBackupFiles_Item> items;

		[JsonProperty(PropertyName = "EndTime")]
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

		[JsonProperty(PropertyName = "StartTime")]
		public string StartTime
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

		[JsonProperty(PropertyName = "DBInstanceId")]
		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
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

		[JsonProperty(PropertyName = "RegionId")]
		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
			}
		}

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeCrossRegionLogBackupFiles_Item> Items
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

		public class DescribeCrossRegionLogBackupFiles_Item
		{

			private string logBeginTime;

			private string linkExpiredTime;

			private string crossIntranetDownloadLink;

			private string logFileName;

			private string crossBackupRegion;

			private string crossDownloadLink;

			private long? crossLogBackupSize;

			private int? instanceId;

			private int? crossLogBackupId;

			private string logEndTime;

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

			[JsonProperty(PropertyName = "CrossIntranetDownloadLink")]
			public string CrossIntranetDownloadLink
			{
				get
				{
					return crossIntranetDownloadLink;
				}
				set	
				{
					crossIntranetDownloadLink = value;
				}
			}

			[JsonProperty(PropertyName = "LogFileName")]
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

			[JsonProperty(PropertyName = "CrossBackupRegion")]
			public string CrossBackupRegion
			{
				get
				{
					return crossBackupRegion;
				}
				set	
				{
					crossBackupRegion = value;
				}
			}

			[JsonProperty(PropertyName = "CrossDownloadLink")]
			public string CrossDownloadLink
			{
				get
				{
					return crossDownloadLink;
				}
				set	
				{
					crossDownloadLink = value;
				}
			}

			[JsonProperty(PropertyName = "CrossLogBackupSize")]
			public long? CrossLogBackupSize
			{
				get
				{
					return crossLogBackupSize;
				}
				set	
				{
					crossLogBackupSize = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceId")]
			public int? InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			[JsonProperty(PropertyName = "CrossLogBackupId")]
			public int? CrossLogBackupId
			{
				get
				{
					return crossLogBackupId;
				}
				set	
				{
					crossLogBackupId = value;
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
		}
	}
}
