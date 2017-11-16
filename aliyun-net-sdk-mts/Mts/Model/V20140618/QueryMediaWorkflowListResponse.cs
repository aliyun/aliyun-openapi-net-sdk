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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class QueryMediaWorkflowListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryMediaWorkflowList_MediaWorkflow> mediaWorkflowList;

		private List<string> nonExistMediaWorkflowIds;

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

		public List<QueryMediaWorkflowList_MediaWorkflow> MediaWorkflowList
		{
			get
			{
				return mediaWorkflowList;
			}
			set	
			{
				mediaWorkflowList = value;
			}
		}

		public List<string> NonExistMediaWorkflowIds
		{
			get
			{
				return nonExistMediaWorkflowIds;
			}
			set	
			{
				nonExistMediaWorkflowIds = value;
			}
		}

		public class QueryMediaWorkflowList_MediaWorkflow
		{

			private string mediaWorkflowId;

			private string name;

			private string topology;

			private string state;

			private string creationTime;

			public string MediaWorkflowId
			{
				get
				{
					return mediaWorkflowId;
				}
				set	
				{
					mediaWorkflowId = value;
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

			public string Topology
			{
				get
				{
					return topology;
				}
				set	
				{
					topology = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}
		}
	}
}