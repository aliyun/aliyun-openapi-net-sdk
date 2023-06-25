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

namespace Aliyun.Acs.ddosbgp.Model.V20180720
{
	public class DescribeTrafficResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeTraffic_Flow> flowList;

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

		public List<DescribeTraffic_Flow> FlowList
		{
			get
			{
				return flowList;
			}
			set	
			{
				flowList = value;
			}
		}

		public class DescribeTraffic_Flow
		{

			private int? time;

			private string flowType;

			private long? attackPps;

			private string name;

			private int? pps;

			private int? kbps;

			private long? attackBps;

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

			public string FlowType
			{
				get
				{
					return flowType;
				}
				set	
				{
					flowType = value;
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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public int? Pps
			{
				get
				{
					return pps;
				}
				set	
				{
					pps = value;
				}
			}

			public int? Kbps
			{
				get
				{
					return kbps;
				}
				set	
				{
					kbps = value;
				}
			}

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
		}
	}
}
