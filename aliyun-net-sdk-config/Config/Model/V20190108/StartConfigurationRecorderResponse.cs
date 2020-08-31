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

namespace Aliyun.Acs.Config.Model.V20190108
{
	public class StartConfigurationRecorderResponse : AcsResponse
	{

		private string requestId;

		private StartConfigurationRecorder_ConfigurationRecorder configurationRecorder;

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

		public StartConfigurationRecorder_ConfigurationRecorder ConfigurationRecorder
		{
			get
			{
				return configurationRecorder;
			}
			set	
			{
				configurationRecorder = value;
			}
		}

		public class StartConfigurationRecorder_ConfigurationRecorder
		{

			private long? accountId;

			private string configurationRecorderStatus;

			private long? organizationMasterId;

			private string organizationEnableStatus;

			private List<string> resourceTypes;

			public long? AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
				}
			}

			public string ConfigurationRecorderStatus
			{
				get
				{
					return configurationRecorderStatus;
				}
				set	
				{
					configurationRecorderStatus = value;
				}
			}

			public long? OrganizationMasterId
			{
				get
				{
					return organizationMasterId;
				}
				set	
				{
					organizationMasterId = value;
				}
			}

			public string OrganizationEnableStatus
			{
				get
				{
					return organizationEnableStatus;
				}
				set	
				{
					organizationEnableStatus = value;
				}
			}

			public List<string> ResourceTypes
			{
				get
				{
					return resourceTypes;
				}
				set	
				{
					resourceTypes = value;
				}
			}
		}
	}
}
