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
	public class DescribeInstanceVpcMigrateInfoResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeInstanceVpcMigrateInfo_DBInstanceMigrateInfo> dBInstanceMigrateInfos;

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

		public List<DescribeInstanceVpcMigrateInfo_DBInstanceMigrateInfo> DBInstanceMigrateInfos
		{
			get
			{
				return dBInstanceMigrateInfos;
			}
			set	
			{
				dBInstanceMigrateInfos = value;
			}
		}

		public class DescribeInstanceVpcMigrateInfo_DBInstanceMigrateInfo
		{

			private string dBInstanceId;

			private string targetRegionId;

			private string targetZoneId;

			private string targetVPCId;

			private string targetVSwitchId;

			private string targetIPAddress;

			private string targetVpcInstanceId;

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

			public string TargetRegionId
			{
				get
				{
					return targetRegionId;
				}
				set	
				{
					targetRegionId = value;
				}
			}

			public string TargetZoneId
			{
				get
				{
					return targetZoneId;
				}
				set	
				{
					targetZoneId = value;
				}
			}

			public string TargetVPCId
			{
				get
				{
					return targetVPCId;
				}
				set	
				{
					targetVPCId = value;
				}
			}

			public string TargetVSwitchId
			{
				get
				{
					return targetVSwitchId;
				}
				set	
				{
					targetVSwitchId = value;
				}
			}

			public string TargetIPAddress
			{
				get
				{
					return targetIPAddress;
				}
				set	
				{
					targetIPAddress = value;
				}
			}

			public string TargetVpcInstanceId
			{
				get
				{
					return targetVpcInstanceId;
				}
				set	
				{
					targetVpcInstanceId = value;
				}
			}
		}
	}
}
