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

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeLogConfigResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLogConfig_LogInfo> logInfos;

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

		public List<DescribeLogConfig_LogInfo> LogInfos
		{
			get
			{
				return logInfos;
			}
			set	
			{
				logInfos = value;
			}
		}

		public class DescribeLogConfig_LogInfo
		{

			private string regionId;

			private string slsProject;

			private string slsLogStore;

			private string logType;

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

			public string SlsProject
			{
				get
				{
					return slsProject;
				}
				set	
				{
					slsProject = value;
				}
			}

			public string SlsLogStore
			{
				get
				{
					return slsLogStore;
				}
				set	
				{
					slsLogStore = value;
				}
			}

			public string LogType
			{
				get
				{
					return logType;
				}
				set	
				{
					logType = value;
				}
			}
		}
	}
}
