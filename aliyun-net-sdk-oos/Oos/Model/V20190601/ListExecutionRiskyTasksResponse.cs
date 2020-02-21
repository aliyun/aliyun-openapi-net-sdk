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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class ListExecutionRiskyTasksResponse : AcsResponse
	{

		private string requestId;

		private List<ListExecutionRiskyTasks_RiskyTask> riskyTasks;

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

		public List<ListExecutionRiskyTasks_RiskyTask> RiskyTasks
		{
			get
			{
				return riskyTasks;
			}
			set	
			{
				riskyTasks = value;
			}
		}

		public class ListExecutionRiskyTasks_RiskyTask
		{

			private string service;

			private string aPI;

			private List<string> task;

			private List<string> template;

			public string Service
			{
				get
				{
					return service;
				}
				set	
				{
					service = value;
				}
			}

			public string API
			{
				get
				{
					return aPI;
				}
				set	
				{
					aPI = value;
				}
			}

			public List<string> Task
			{
				get
				{
					return task;
				}
				set	
				{
					task = value;
				}
			}

			public List<string> Template
			{
				get
				{
					return template;
				}
				set	
				{
					template = value;
				}
			}
		}
	}
}
