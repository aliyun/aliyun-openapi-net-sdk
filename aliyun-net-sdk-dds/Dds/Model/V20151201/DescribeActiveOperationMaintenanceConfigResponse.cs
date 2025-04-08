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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeActiveOperationMaintenanceConfigResponse : AcsResponse
	{

		private int? hasConfig;

		private string requestId;

		private DescribeActiveOperationMaintenanceConfig_Config config;

		public int? HasConfig
		{
			get
			{
				return hasConfig;
			}
			set	
			{
				hasConfig = value;
			}
		}

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

		public DescribeActiveOperationMaintenanceConfig_Config Config
		{
			get
			{
				return config;
			}
			set	
			{
				config = value;
			}
		}

		public class DescribeActiveOperationMaintenanceConfig_Config
		{

			private string cycleType;

			private int? status;

			private string modifiedTime;

			private string maintainStartTime;

			private string maintainEndTime;

			private string cycleTime;

			private string createdTime;

			public string CycleType
			{
				get
				{
					return cycleType;
				}
				set	
				{
					cycleType = value;
				}
			}

			public int? Status
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

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
				}
			}

			public string MaintainStartTime
			{
				get
				{
					return maintainStartTime;
				}
				set	
				{
					maintainStartTime = value;
				}
			}

			public string MaintainEndTime
			{
				get
				{
					return maintainEndTime;
				}
				set	
				{
					maintainEndTime = value;
				}
			}

			public string CycleTime
			{
				get
				{
					return cycleTime;
				}
				set	
				{
					cycleTime = value;
				}
			}

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}
		}
	}
}
