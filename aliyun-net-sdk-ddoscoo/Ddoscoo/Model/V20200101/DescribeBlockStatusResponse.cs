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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeBlockStatusResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeBlockStatus_StatusItem> statusList;

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

		public List<DescribeBlockStatus_StatusItem> StatusList
		{
			get
			{
				return statusList;
			}
			set	
			{
				statusList = value;
			}
		}

		public class DescribeBlockStatus_StatusItem
		{

			private string ip;

			private List<DescribeBlockStatus_BlockStatusItem> blockStatusList;

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
				}
			}

			public List<DescribeBlockStatus_BlockStatusItem> BlockStatusList
			{
				get
				{
					return blockStatusList;
				}
				set	
				{
					blockStatusList = value;
				}
			}

			public class DescribeBlockStatus_BlockStatusItem
			{

				private long? startTime;

				private string line;

				private long? endTime;

				private string blockStatus;

				public long? StartTime
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

				public string Line
				{
					get
					{
						return line;
					}
					set	
					{
						line = value;
					}
				}

				public long? EndTime
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

				public string BlockStatus
				{
					get
					{
						return blockStatus;
					}
					set	
					{
						blockStatus = value;
					}
				}
			}
		}
	}
}
