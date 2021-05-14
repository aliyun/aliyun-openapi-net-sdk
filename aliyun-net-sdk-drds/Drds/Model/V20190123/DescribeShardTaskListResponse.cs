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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeShardTaskListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? pageNumber;

		private int? pageSize;

		private int? total;

		private List<DescribeShardTaskList_ListItem> list;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<DescribeShardTaskList_ListItem> List
		{
			get
			{
				return list;
			}
			set	
			{
				list = value;
			}
		}

		public class DescribeShardTaskList_ListItem
		{

			private string sourceTableName;

			private string targetTableName;

			private string expired;

			private long? expired1;

			private int? stage;

			private int? progress;

			private int? delay;

			public string SourceTableName
			{
				get
				{
					return sourceTableName;
				}
				set	
				{
					sourceTableName = value;
				}
			}

			public string TargetTableName
			{
				get
				{
					return targetTableName;
				}
				set	
				{
					targetTableName = value;
				}
			}

			public string Expired
			{
				get
				{
					return expired;
				}
				set	
				{
					expired = value;
				}
			}

			public long? Expired1
			{
				get
				{
					return expired1;
				}
				set	
				{
					expired1 = value;
				}
			}

			public int? Stage
			{
				get
				{
					return stage;
				}
				set	
				{
					stage = value;
				}
			}

			public int? Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}

			public int? Delay
			{
				get
				{
					return delay;
				}
				set	
				{
					delay = value;
				}
			}
		}
	}
}
