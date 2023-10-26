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

namespace Aliyun.Acs.fnf.Model.V20190315
{
	public class ListFlowsResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private List<ListFlows_FlowsItem> flows;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
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

		public List<ListFlows_FlowsItem> Flows
		{
			get
			{
				return flows;
			}
			set	
			{
				flows = value;
			}
		}

		public class ListFlows_FlowsItem
		{

			private string type;

			private string definition;

			private string roleArn;

			private string description;

			private string externalStorageLocation;

			private string name;

			private string createdTime;

			private string lastModifiedTime;

			private string id;

			private string executionMode;

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string Definition
			{
				get
				{
					return definition;
				}
				set	
				{
					definition = value;
				}
			}

			public string RoleArn
			{
				get
				{
					return roleArn;
				}
				set	
				{
					roleArn = value;
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

			public string ExternalStorageLocation
			{
				get
				{
					return externalStorageLocation;
				}
				set	
				{
					externalStorageLocation = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
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

			public string LastModifiedTime
			{
				get
				{
					return lastModifiedTime;
				}
				set	
				{
					lastModifiedTime = value;
				}
			}

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string ExecutionMode
			{
				get
				{
					return executionMode;
				}
				set	
				{
					executionMode = value;
				}
			}
		}
	}
}
