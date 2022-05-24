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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeReadDBInstanceDelayResponse : AcsResponse
	{

		private string dBInstanceId;

		private string requestId;

		private int? delayTime;

		private string readDBInstanceId;

		private List<DescribeReadDBInstanceDelay_ItemsItem> items;

		[JsonProperty(PropertyName = "DBInstanceId")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "DelayTime")]
		public int? DelayTime
		{
			get
			{
				return delayTime;
			}
			set	
			{
				delayTime = value;
			}
		}

		[JsonProperty(PropertyName = "ReadDBInstanceId")]
		public string ReadDBInstanceId
		{
			get
			{
				return readDBInstanceId;
			}
			set	
			{
				readDBInstanceId = value;
			}
		}

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeReadDBInstanceDelay_ItemsItem> Items
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

		public class DescribeReadDBInstanceDelay_ItemsItem
		{

			private string dBInstanceId;

			private List<DescribeReadDBInstanceDelay_ReadonlyInstanceDelayItem> readonlyInstanceDelay;

			private List<string> readDelayTimes;

			private List<string> readDBInstanceNames;

			[JsonProperty(PropertyName = "DBInstanceId")]
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

			[JsonProperty(PropertyName = "ReadonlyInstanceDelay")]
			public List<DescribeReadDBInstanceDelay_ReadonlyInstanceDelayItem> ReadonlyInstanceDelay
			{
				get
				{
					return readonlyInstanceDelay;
				}
				set	
				{
					readonlyInstanceDelay = value;
				}
			}

			[JsonProperty(PropertyName = "ReadDelayTimes")]
			public List<string> ReadDelayTimes
			{
				get
				{
					return readDelayTimes;
				}
				set	
				{
					readDelayTimes = value;
				}
			}

			[JsonProperty(PropertyName = "ReadDBInstanceNames")]
			public List<string> ReadDBInstanceNames
			{
				get
				{
					return readDBInstanceNames;
				}
				set	
				{
					readDBInstanceNames = value;
				}
			}

			public class DescribeReadDBInstanceDelay_ReadonlyInstanceDelayItem
			{

				private string writeLatency;

				private string flushLatency;

				private string readDBInstanceName;

				private string writeLag;

				private string flushLag;

				private string sendLatency;

				private string replayLag;

				private string replayLatency;

				[JsonProperty(PropertyName = "WriteLatency")]
				public string WriteLatency
				{
					get
					{
						return writeLatency;
					}
					set	
					{
						writeLatency = value;
					}
				}

				[JsonProperty(PropertyName = "FlushLatency")]
				public string FlushLatency
				{
					get
					{
						return flushLatency;
					}
					set	
					{
						flushLatency = value;
					}
				}

				[JsonProperty(PropertyName = "ReadDBInstanceName")]
				public string ReadDBInstanceName
				{
					get
					{
						return readDBInstanceName;
					}
					set	
					{
						readDBInstanceName = value;
					}
				}

				[JsonProperty(PropertyName = "WriteLag")]
				public string WriteLag
				{
					get
					{
						return writeLag;
					}
					set	
					{
						writeLag = value;
					}
				}

				[JsonProperty(PropertyName = "FlushLag")]
				public string FlushLag
				{
					get
					{
						return flushLag;
					}
					set	
					{
						flushLag = value;
					}
				}

				[JsonProperty(PropertyName = "SendLatency")]
				public string SendLatency
				{
					get
					{
						return sendLatency;
					}
					set	
					{
						sendLatency = value;
					}
				}

				[JsonProperty(PropertyName = "ReplayLag")]
				public string ReplayLag
				{
					get
					{
						return replayLag;
					}
					set	
					{
						replayLag = value;
					}
				}

				[JsonProperty(PropertyName = "ReplayLatency")]
				public string ReplayLatency
				{
					get
					{
						return replayLatency;
					}
					set	
					{
						replayLatency = value;
					}
				}
			}
		}
	}
}
