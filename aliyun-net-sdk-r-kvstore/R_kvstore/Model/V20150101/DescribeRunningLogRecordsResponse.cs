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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeRunningLogRecordsResponse : AcsResponse
	{

		private string startTime;

		private string requestId;

		private int? pageRecordCount;

		private int? totalRecordCount;

		private int? pageSize;

		private string instanceId;

		private string engine;

		private int? pageNumber;

		private List<DescribeRunningLogRecords_LogRecords> items;

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

		public string InstanceId
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

		public string Engine
		{
			get
			{
				return engine;
			}
			set	
			{
				engine = value;
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

		public List<DescribeRunningLogRecords_LogRecords> Items
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

		public class DescribeRunningLogRecords_LogRecords
		{

			private string connInfo;

			private string createTime;

			private string category;

			private string instanceId;

			private string content;

			private string nodeId;

			private string level;

			private int? id;

			public string ConnInfo
			{
				get
				{
					return connInfo;
				}
				set	
				{
					connInfo = value;
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

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			public string InstanceId
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

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public string NodeId
			{
				get
				{
					return nodeId;
				}
				set	
				{
					nodeId = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

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
		}
	}
}
