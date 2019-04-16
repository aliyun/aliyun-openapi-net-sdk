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
	public class DescribeOssDownloadsForSQLServerResponse : AcsResponse
	{

		private string requestId;

		private string dBInstanceName;

		private string migrateIaskId;

		private List<DescribeOssDownloadsForSQLServer_OssDownload> items;

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

		public string DBInstanceName
		{
			get
			{
				return dBInstanceName;
			}
			set	
			{
				dBInstanceName = value;
			}
		}

		public string MigrateIaskId
		{
			get
			{
				return migrateIaskId;
			}
			set	
			{
				migrateIaskId = value;
			}
		}

		public List<DescribeOssDownloadsForSQLServer_OssDownload> Items
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

		public class DescribeOssDownloadsForSQLServer_OssDownload
		{

			private string fileName;

			private string createTime;

			private string createTime1;

			private string bakType;

			private string fileSize;

			private string status;

			private string isAvail;

			private string desc;

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

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string CreateTime1
			{
				get
				{
					return createTime1;
				}
				set	
				{
					createTime1 = value;
				}
			}

			public string BakType
			{
				get
				{
					return bakType;
				}
				set	
				{
					bakType = value;
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

			public string IsAvail
			{
				get
				{
					return isAvail;
				}
				set	
				{
					isAvail = value;
				}
			}

			public string Desc
			{
				get
				{
					return desc;
				}
				set	
				{
					desc = value;
				}
			}
		}
	}
}
