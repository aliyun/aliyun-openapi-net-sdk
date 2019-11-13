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
	public class DescribeGtmAccessStrategyResponse : AcsResponse
	{

		private string requestId;

		private string strategyId;

		private string strategyName;

		private string defultAddrPoolId;

		private string defaultAddrPoolName;

		private string failoverAddrPoolId;

		private string failoverAddrPoolName;

		private string strategyMode;

		private string accessMode;

		private string accessStatus;

		private string instanceId;

		private string defaultAddrPoolStatus;

		private string failoverAddrPoolStatus;

		private string defaultAddrPoolMonitorStatus;

		private string failoverAddrPoolMonitorStatus;

		private List<DescribeGtmAccessStrategy_Line> lines;

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

		public string StrategyId
		{
			get
			{
				return strategyId;
			}
			set	
			{
				strategyId = value;
			}
		}

		public string StrategyName
		{
			get
			{
				return strategyName;
			}
			set	
			{
				strategyName = value;
			}
		}

		public string DefultAddrPoolId
		{
			get
			{
				return defultAddrPoolId;
			}
			set	
			{
				defultAddrPoolId = value;
			}
		}

		public string DefaultAddrPoolName
		{
			get
			{
				return defaultAddrPoolName;
			}
			set	
			{
				defaultAddrPoolName = value;
			}
		}

		public string FailoverAddrPoolId
		{
			get
			{
				return failoverAddrPoolId;
			}
			set	
			{
				failoverAddrPoolId = value;
			}
		}

		public string FailoverAddrPoolName
		{
			get
			{
				return failoverAddrPoolName;
			}
			set	
			{
				failoverAddrPoolName = value;
			}
		}

		public string StrategyMode
		{
			get
			{
				return strategyMode;
			}
			set	
			{
				strategyMode = value;
			}
		}

		public string AccessMode
		{
			get
			{
				return accessMode;
			}
			set	
			{
				accessMode = value;
			}
		}

		public string AccessStatus
		{
			get
			{
				return accessStatus;
			}
			set	
			{
				accessStatus = value;
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
			}
		}

		public string DefaultAddrPoolStatus
		{
			get
			{
				return defaultAddrPoolStatus;
			}
			set	
			{
				defaultAddrPoolStatus = value;
			}
		}

		public string FailoverAddrPoolStatus
		{
			get
			{
				return failoverAddrPoolStatus;
			}
			set	
			{
				failoverAddrPoolStatus = value;
			}
		}

		public string DefaultAddrPoolMonitorStatus
		{
			get
			{
				return defaultAddrPoolMonitorStatus;
			}
			set	
			{
				defaultAddrPoolMonitorStatus = value;
			}
		}

		public string FailoverAddrPoolMonitorStatus
		{
			get
			{
				return failoverAddrPoolMonitorStatus;
			}
			set	
			{
				failoverAddrPoolMonitorStatus = value;
			}
		}

		public List<DescribeGtmAccessStrategy_Line> Lines
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

		public class DescribeGtmAccessStrategy_Line
		{

			private string lineCode;

			private string lineName;

			private string groupCode;

			private string groupName;

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
		}
	}
}
