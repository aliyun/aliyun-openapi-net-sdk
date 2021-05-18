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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class ListJobTemplatesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<ListJobTemplates_JobTemplates> templates;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<ListJobTemplates_JobTemplates> Templates
		{
			get
			{
				return templates;
			}
			set	
			{
				templates = value;
			}
		}

		public class ListJobTemplates_JobTemplates
		{

			private string id;

			private string name;

			private string commandLine;

			private string runasUser;

			private int? priority;

			private string packagePath;

			private string stdoutRedirectPath;

			private string stderrRedirectPath;

			private bool? reRunable;

			private string arrayRequest;

			private string variables;

			private string queue;

			private string clockTime;

			private int? node;

			private int? task;

			private int? thread;

			private string mem;

			private int? gpu;

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

			public string CommandLine
			{
				get
				{
					return commandLine;
				}
				set	
				{
					commandLine = value;
				}
			}

			public string RunasUser
			{
				get
				{
					return runasUser;
				}
				set	
				{
					runasUser = value;
				}
			}

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public string PackagePath
			{
				get
				{
					return packagePath;
				}
				set	
				{
					packagePath = value;
				}
			}

			public string StdoutRedirectPath
			{
				get
				{
					return stdoutRedirectPath;
				}
				set	
				{
					stdoutRedirectPath = value;
				}
			}

			public string StderrRedirectPath
			{
				get
				{
					return stderrRedirectPath;
				}
				set	
				{
					stderrRedirectPath = value;
				}
			}

			public bool? ReRunable
			{
				get
				{
					return reRunable;
				}
				set	
				{
					reRunable = value;
				}
			}

			public string ArrayRequest
			{
				get
				{
					return arrayRequest;
				}
				set	
				{
					arrayRequest = value;
				}
			}

			public string Variables
			{
				get
				{
					return variables;
				}
				set	
				{
					variables = value;
				}
			}

			public string Queue
			{
				get
				{
					return queue;
				}
				set	
				{
					queue = value;
				}
			}

			public string ClockTime
			{
				get
				{
					return clockTime;
				}
				set	
				{
					clockTime = value;
				}
			}

			public int? Node
			{
				get
				{
					return node;
				}
				set	
				{
					node = value;
				}
			}

			public int? Task
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

			public int? Thread
			{
				get
				{
					return thread;
				}
				set	
				{
					thread = value;
				}
			}

			public string Mem
			{
				get
				{
					return mem;
				}
				set	
				{
					mem = value;
				}
			}

			public int? Gpu
			{
				get
				{
					return gpu;
				}
				set	
				{
					gpu = value;
				}
			}
		}
	}
}
