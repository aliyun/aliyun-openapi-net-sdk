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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeConnectionCountRecordsResponse : AcsResponse
	{

		private string totalCount;

		private string requestId;

		private string dBClusterId;

		private List<DescribeConnectionCountRecords_Users> userRecords;

		private List<DescribeConnectionCountRecords_AccessIps> accessIpRecords;

		public string TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

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

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
			}
		}

		public List<DescribeConnectionCountRecords_Users> UserRecords
		{
			get
			{
				return userRecords;
			}
			set	
			{
				userRecords = value;
			}
		}

		public List<DescribeConnectionCountRecords_AccessIps> AccessIpRecords
		{
			get
			{
				return accessIpRecords;
			}
			set	
			{
				accessIpRecords = value;
			}
		}

		public class DescribeConnectionCountRecords_Users
		{

			private string user;

			private long? count;

			public string User
			{
				get
				{
					return user;
				}
				set	
				{
					user = value;
				}
			}

			public long? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}
		}

		public class DescribeConnectionCountRecords_AccessIps
		{

			private string accessIp;

			private long? count;

			public string AccessIp
			{
				get
				{
					return accessIp;
				}
				set	
				{
					accessIp = value;
				}
			}

			public long? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}
		}
	}
}
