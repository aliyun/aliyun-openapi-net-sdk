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
	public class DescribeReadDBInstanceDelayResponse : AcsResponse
	{

		private string requestId;

		private string dBInstanceId;

		private string readDBInstanceId;

		private int? delayTime;

		private List<DescribeReadDBInstanceDelay_ItemsItem> items;

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

			private List<string> readDBInstanceNames;

			private List<string> readDelayTimes;

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

			public class DescribeReadDBInstanceDelay_ReadonlyInstanceDelayItem
			{

				private string replayLatency;

				private string flushLag;

				private string flushLatency;

				private string sendLatency;

				private string writeLag;

				private string replayLag;

				private string writeLatency;

				private string readDBInstanceName;

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
			}
		}
	}
}
