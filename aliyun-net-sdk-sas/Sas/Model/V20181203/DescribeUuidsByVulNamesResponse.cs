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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeUuidsByVulNamesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeUuidsByVulNames_MachineInfoStatistic> machineInfoStatistics;

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

		public List<DescribeUuidsByVulNames_MachineInfoStatistic> MachineInfoStatistics
		{
			get
			{
				return machineInfoStatistics;
			}
			set	
			{
				machineInfoStatistics = value;
			}
		}

		public class DescribeUuidsByVulNames_MachineInfoStatistic
		{

			private string machineIp;

			private string machineName;

			private string os;

			private string machineInstanceId;

			private string uuid;

			private string regionId;

			public string MachineIp
			{
				get
				{
					return machineIp;
				}
				set	
				{
					machineIp = value;
				}
			}

			public string MachineName
			{
				get
				{
					return machineName;
				}
				set	
				{
					machineName = value;
				}
			}

			public string Os
			{
				get
				{
					return os;
				}
				set	
				{
					os = value;
				}
			}

			public string MachineInstanceId
			{
				get
				{
					return machineInstanceId;
				}
				set	
				{
					machineInstanceId = value;
				}
			}

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}
		}
	}
}
