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
	public class DescribePortMaxConnsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribePortMaxConns_PortMaxConnsItem> portMaxConns;

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

		public List<DescribePortMaxConns_PortMaxConnsItem> PortMaxConns
		{
			get
			{
				return portMaxConns;
			}
			set	
			{
				portMaxConns = value;
			}
		}

		public class DescribePortMaxConns_PortMaxConnsItem
		{

			private string port;

			private string ip;

			private long? cps;

			public string Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

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
		}
	}
}
