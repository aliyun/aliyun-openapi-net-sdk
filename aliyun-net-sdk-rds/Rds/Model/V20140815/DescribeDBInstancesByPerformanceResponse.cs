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
	public class DescribeDBInstancesByPerformanceResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? totalRecordCount;

		private int? pageRecordCount;

		private List<DescribeDBInstancesByPerformance_DBInstancePerformance> items;

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

		public List<DescribeDBInstancesByPerformance_DBInstancePerformance> Items
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

		public class DescribeDBInstancesByPerformance_DBInstancePerformance
		{

			private string cPUUsage;

			private string iOPSUsage;

			private string diskUsage;

			private string sessionUsage;

			private string dBInstanceId;

			private string dBInstanceDescription;

			public string CPUUsage
			{
				get
				{
					return cPUUsage;
				}
				set	
				{
					cPUUsage = value;
				}
			}

			public string IOPSUsage
			{
				get
				{
					return iOPSUsage;
				}
				set	
				{
					iOPSUsage = value;
				}
			}

			public string DiskUsage
			{
				get
				{
					return diskUsage;
				}
				set	
				{
					diskUsage = value;
				}
			}

			public string SessionUsage
			{
				get
				{
					return sessionUsage;
				}
				set	
				{
					sessionUsage = value;
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

			public string DBInstanceDescription
			{
				get
				{
					return dBInstanceDescription;
				}
				set	
				{
					dBInstanceDescription = value;
				}
			}
		}
	}
}
