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
	public class DescribeConsumerChannelResponse : AcsResponse
	{

		private string errCode;

		private string errMessage;

		private string requestId;

		private string success;

		private string httpStatusCode;

		private int? pageNumber;

		private int? pageRecordCount;

		private long? totalRecordCount;

		private List<DescribeConsumerChannel_ConsumerChannel> consumerChannels;

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

		public string HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public long? TotalRecordCount
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

		public List<DescribeConsumerChannel_ConsumerChannel> ConsumerChannels
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

		public class DescribeConsumerChannel_ConsumerChannel
		{

			private string consumerGroupId;

			private string consumerGroupName;

			private string consumptionCheckpoint;

			private long? unconsumedData;

			private long? messageDelay;

			private string consumerGroupUserName;

			public string ConsumerGroupId
			{
				get
				{
					return consumerGroupId;
				}
				set	
				{
					consumerGroupId = value;
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
		}
	}
}
