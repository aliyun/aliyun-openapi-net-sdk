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
	public class UpdateMediaWorkflowResponse : AcsResponse
	{

		private string requestId;

		private UpdateMediaWorkflow_MediaWorkflow mediaWorkflow;

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

		public UpdateMediaWorkflow_MediaWorkflow MediaWorkflow
		{
			get
			{
				return mediaWorkflow;
			}
			set	
			{
				mediaWorkflow = value;
			}
		}

		public class UpdateMediaWorkflow_MediaWorkflow
		{

			private string mediaWorkflowId;

			private string name;

			private string topology;

			private string triggerMode;

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

			public string TriggerMode
			{
				get
				{
					return triggerMode;
				}
				set	
				{
					triggerMode = value;
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