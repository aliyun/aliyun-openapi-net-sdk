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

namespace Aliyun.Acs.LinkWAN.Model.V20190301
{
	public class GetRentedJoinPermissionResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private GetRentedJoinPermission_Data data;

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

		public GetRentedJoinPermission_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetRentedJoinPermission_Data
		{

			private string joinPermissionId;

			private string joinEui;

			private long? freqBandPlanGroupId;

			private string classMode;

			private string type;

			private bool? enabled;

			private long? rxDailySum;

			private long? rxMonthSum;

			private long? txDailySum;

			private long? txMonthSum;

			private long? createMillis;

			private long? nodesCnt;

			private string joinPermissionName;

			private string boundNodeGroupId;

			private string boundNodeGroupName;

			private long? rxDelay;

			private long? dataRate;

			public string JoinPermissionId
			{
				get
				{
					return joinPermissionId;
				}
				set	
				{
					joinPermissionId = value;
				}
			}

			public string JoinEui
			{
				get
				{
					return joinEui;
				}
				set	
				{
					joinEui = value;
				}
			}

			public long? FreqBandPlanGroupId
			{
				get
				{
					return freqBandPlanGroupId;
				}
				set	
				{
					freqBandPlanGroupId = value;
				}
			}

			public string ClassMode
			{
				get
				{
					return classMode;
				}
				set	
				{
					classMode = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public bool? Enabled
			{
				get
				{
					return enabled;
				}
				set	
				{
					enabled = value;
				}
			}

			public long? RxDailySum
			{
				get
				{
					return rxDailySum;
				}
				set	
				{
					rxDailySum = value;
				}
			}

			public long? RxMonthSum
			{
				get
				{
					return rxMonthSum;
				}
				set	
				{
					rxMonthSum = value;
				}
			}

			public long? TxDailySum
			{
				get
				{
					return txDailySum;
				}
				set	
				{
					txDailySum = value;
				}
			}

			public long? TxMonthSum
			{
				get
				{
					return txMonthSum;
				}
				set	
				{
					txMonthSum = value;
				}
			}

			public long? CreateMillis
			{
				get
				{
					return createMillis;
				}
				set	
				{
					createMillis = value;
				}
			}

			public long? NodesCnt
			{
				get
				{
					return nodesCnt;
				}
				set	
				{
					nodesCnt = value;
				}
			}

			public string JoinPermissionName
			{
				get
				{
					return joinPermissionName;
				}
				set	
				{
					joinPermissionName = value;
				}
			}

			public string BoundNodeGroupId
			{
				get
				{
					return boundNodeGroupId;
				}
				set	
				{
					boundNodeGroupId = value;
				}
			}

			public string BoundNodeGroupName
			{
				get
				{
					return boundNodeGroupName;
				}
				set	
				{
					boundNodeGroupName = value;
				}
			}

			public long? RxDelay
			{
				get
				{
					return rxDelay;
				}
				set	
				{
					rxDelay = value;
				}
			}

			public long? DataRate
			{
				get
				{
					return dataRate;
				}
				set	
				{
					dataRate = value;
				}
			}
		}
	}
}
