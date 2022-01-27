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

namespace Aliyun.Acs.Dts.Model.V20200101
{
	public class DescribeConsumerGroupResponse : AcsResponse
	{

		private int? pageNumber;

		private int? pageRecordCount;

		private string requestId;

		private int? totalRecordCount;

		private string errCode;

		private string errMessage;

		private string success;

		private List<DescribeConsumerGroup_DescribeConsumerChannel> consumerChannels;

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

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
			}
		}

		public string Success
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

		public List<DescribeConsumerGroup_DescribeConsumerChannel> ConsumerChannels
		{
			get
			{
				return consumerChannels;
			}
			set	
			{
				consumerChannels = value;
			}
		}

		public class DescribeConsumerGroup_DescribeConsumerChannel
		{

			private string consumerGroupID;

			private string consumerGroupName;

			private string consumerGroupUserName;

			private string consumptionCheckpoint;

			private long? messageDelay;

			private long? unconsumedData;

			public string ConsumerGroupID
			{
				get
				{
					return consumerGroupID;
				}
				set	
				{
					consumerGroupID = value;
				}
			}

			public string ConsumerGroupName
			{
				get
				{
					return consumerGroupName;
				}
				set	
				{
					consumerGroupName = value;
				}
			}

			public string ConsumerGroupUserName
			{
				get
				{
					return consumerGroupUserName;
				}
				set	
				{
					consumerGroupUserName = value;
				}
			}

			public string ConsumptionCheckpoint
			{
				get
				{
					return consumptionCheckpoint;
				}
				set	
				{
					consumptionCheckpoint = value;
				}
			}

			public long? MessageDelay
			{
				get
				{
					return messageDelay;
				}
				set	
				{
					messageDelay = value;
				}
			}

			public long? UnconsumedData
			{
				get
				{
					return unconsumedData;
				}
				set	
				{
					unconsumedData = value;
				}
			}
		}
	}
}
