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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeCrossRegionLogBackupFilesResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private string dBInstanceId;

		private string startTime;

		private string endTime;

		private int? totalRecordCount;

		private int? pageRecordCount;

		private int? pageNumber;

		private List<DescribeCrossRegionLogBackupFiles_Item> items;

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

			private int? crossLogBackupId;

			private string crossBackupRegion;

			private long? crossLogBackupSize;

			private string logBeginTime;

			private string logEndTime;

			private string crossDownloadLink;

			private string crossIntranetDownloadLink;

			private string linkExpiredTime;

			private string logFileName;

			private int? instanceId;

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
		}
	}
}
