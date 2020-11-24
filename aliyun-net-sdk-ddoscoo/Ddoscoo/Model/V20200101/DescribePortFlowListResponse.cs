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
	public class DescribePortFlowListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribePortFlowList_PortFlow> portFlowList;

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

		public List<DescribePortFlowList_PortFlow> PortFlowList
		{
			get
			{
				return portFlowList;
			}
			set	
			{
				portFlowList = value;
			}
		}

		public class DescribePortFlowList_PortFlow
		{

			private long? attackBps;

			private long? attackPps;

			private long? outPps;

			private long? index;

			private long? time;

			private long? inBps;

			private long? outBps;

			private long? inPps;

			private string region;

			public long? AttackBps
			{
				get
				{
					return attackBps;
				}
				set	
				{
					attackBps = value;
				}
			}

			public long? AttackPps
			{
				get
				{
					return attackPps;
				}
				set	
				{
					attackPps = value;
				}
			}

			public long? OutPps
			{
				get
				{
					return outPps;
				}
				set	
				{
					outPps = value;
				}
			}

			public long? Index
			{
				get
				{
					return index;
				}
				set	
				{
					index = value;
				}
			}

			public long? Time
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

			public long? InBps
			{
				get
				{
					return inBps;
				}
				set	
				{
					inBps = value;
				}
			}

			public long? OutBps
			{
				get
				{
					return outBps;
				}
				set	
				{
					outBps = value;
				}
			}

			public long? InPps
			{
				get
				{
					return inPps;
				}
				set	
				{
					inPps = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}
		}
	}
}
