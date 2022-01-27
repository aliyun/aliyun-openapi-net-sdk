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
	public class DescribePortConnsListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribePortConnsList_Conn> connsList;

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

		public List<DescribePortConnsList_Conn> ConnsList
		{
			get
			{
				return connsList;
			}
			set	
			{
				connsList = value;
			}
		}

		public class DescribePortConnsList_Conn
		{

			private long? conns;

			private long? actConns;

			private long? inActConns;

			private long? cps;

			private long? index;

			private long? time;

			public long? Conns
			{
				get
				{
					return conns;
				}
				set	
				{
					conns = value;
				}
			}

			public long? ActConns
			{
				get
				{
					return actConns;
				}
				set	
				{
					actConns = value;
				}
			}

			public long? InActConns
			{
				get
				{
					return inActConns;
				}
				set	
				{
					inActConns = value;
				}
			}

			public long? Cps
			{
				get
				{
					return cps;
				}
				set	
				{
					cps = value;
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
		}
	}
}
