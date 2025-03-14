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

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
	public class DescribeComponentPlaybookResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeComponentPlaybook_Data> playbooks;

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

		public List<DescribeComponentPlaybook_Data> Playbooks
		{
			get
			{
				return playbooks;
			}
			set	
			{
				playbooks = value;
			}
		}

		public class DescribeComponentPlaybook_Data
		{

			private string displayName;

			private string playbookUuid;

			private string ownType;

			private string inputParams;

			private string outputParams;

			private string description;

			private string tenantId;

			public string DisplayName
			{
				get
				{
					return displayName;
				}
				set	
				{
					displayName = value;
				}
			}

			public string PlaybookUuid
			{
				get
				{
					return playbookUuid;
				}
				set	
				{
					playbookUuid = value;
				}
			}

			public string OwnType
			{
				get
				{
					return ownType;
				}
				set	
				{
					ownType = value;
				}
			}

			public string InputParams
			{
				get
				{
					return inputParams;
				}
				set	
				{
					inputParams = value;
				}
			}

			public string OutputParams
			{
				get
				{
					return outputParams;
				}
				set	
				{
					outputParams = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}
		}
	}
}
