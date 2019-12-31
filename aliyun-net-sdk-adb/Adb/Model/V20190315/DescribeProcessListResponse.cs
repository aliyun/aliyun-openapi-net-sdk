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
	public class DescribeProcessListResponse : AcsResponse
	{

		private string requestId;

		private string totalCount;

		private string pageNumber;

		private string pageSize;

		private List<DescribeProcessList_Process> items;

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

		public string PageNumber
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

		public string PageSize
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

		public List<DescribeProcessList_Process> Items
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

		public class DescribeProcessList_Process
		{

			private int? id;

			private string processId;

			private string user;

			private string host;

			private string dB;

			private string command;

			private int? time;

			private string startTime;

			private string info;

			public int? Id
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

			public string ProcessId
			{
				get
				{
					return processId;
				}
				set	
				{
					processId = value;
				}
			}

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

			public string Host
			{
				get
				{
					return host;
				}
				set	
				{
					host = value;
				}
			}

			public string DB
			{
				get
				{
					return dB;
				}
				set	
				{
					dB = value;
				}
			}

			public string Command
			{
				get
				{
					return command;
				}
				set	
				{
					command = value;
				}
			}

			public int? Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
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

			public string Info
			{
				get
				{
					return info;
				}
				set	
				{
					info = value;
				}
			}
		}
	}
}
