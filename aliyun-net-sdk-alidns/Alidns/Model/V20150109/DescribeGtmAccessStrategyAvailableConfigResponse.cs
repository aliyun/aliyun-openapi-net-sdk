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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeGtmAccessStrategyAvailableConfigResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeGtmAccessStrategyAvailableConfig_AddrPool> addrPools;

		private List<DescribeGtmAccessStrategyAvailableConfig_Line> lines;

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

		public List<DescribeGtmAccessStrategyAvailableConfig_AddrPool> AddrPools
		{
			get
			{
				return addrPools;
			}
			set	
			{
				addrPools = value;
			}
		}

		public List<DescribeGtmAccessStrategyAvailableConfig_Line> Lines
		{
			get
			{
				return lines;
			}
			set	
			{
				lines = value;
			}
		}

		public class DescribeGtmAccessStrategyAvailableConfig_AddrPool
		{

			private string addrPoolId;

			private string addrPoolName;

			public string AddrPoolId
			{
				get
				{
					return addrPoolId;
				}
				set	
				{
					addrPoolId = value;
				}
			}

			public string AddrPoolName
			{
				get
				{
					return addrPoolName;
				}
				set	
				{
					addrPoolName = value;
				}
			}
		}

		public class DescribeGtmAccessStrategyAvailableConfig_Line
		{

			private string lineCode;

			private string lineName;

			private string groupCode;

			private string groupName;

			private string status;

			private string fatherCode;

			public string LineCode
			{
				get
				{
					return lineCode;
				}
				set	
				{
					lineCode = value;
				}
			}

			public string LineName
			{
				get
				{
					return lineName;
				}
				set	
				{
					lineName = value;
				}
			}

			public string GroupCode
			{
				get
				{
					return groupCode;
				}
				set	
				{
					groupCode = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string FatherCode
			{
				get
				{
					return fatherCode;
				}
				set	
				{
					fatherCode = value;
				}
			}
		}
	}
}
