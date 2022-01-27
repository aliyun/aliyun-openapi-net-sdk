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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.EHPC;
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class SubmitJobRequest : RpcAcsRequest<SubmitJobResponse>
    {
        public SubmitJobRequest()
            : base("EHPC", "2018-04-12", "SubmitJob")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointRegionalType, null);
            }
        }

		private string stderrRedirectPath;

		private string runasUserPassword;

		private string clockTime;

		private string commandLine;

		private string jobQueue;

		private string arrayRequest;

		private string unzipCmd;

		private string packagePath;

		private string mem;

		private string stdoutRedirectPath;

		private string variables;

		private string postCmdLine;

		private string runasUser;

		private string clusterId;

		private bool? reRunable;

		private int? thread;

		private int? priority;

		private int? gpu;

		private int? node;

		private int? task;

		private string inputFileUrl;

		private string name;

		private string containerId;

		public string StderrRedirectPath
		{
			get
			{
				return stderrRedirectPath;
			}
			set	
			{
				stderrRedirectPath = value;
				DictionaryUtil.Add(QueryParameters, "StderrRedirectPath", value);
			}
		}

		public string RunasUserPassword
		{
			get
			{
				return runasUserPassword;
			}
			set	
			{
				runasUserPassword = value;
				DictionaryUtil.Add(QueryParameters, "RunasUserPassword", value);
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
				DictionaryUtil.Add(QueryParameters, "ClockTime", value);
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
				DictionaryUtil.Add(QueryParameters, "CommandLine", value);
			}
		}

		public string JobQueue
		{
			get
			{
				return jobQueue;
			}
			set	
			{
				jobQueue = value;
				DictionaryUtil.Add(QueryParameters, "JobQueue", value);
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
				DictionaryUtil.Add(QueryParameters, "ArrayRequest", value);
			}
		}

		public string UnzipCmd
		{
			get
			{
				return unzipCmd;
			}
			set	
			{
				unzipCmd = value;
				DictionaryUtil.Add(QueryParameters, "UnzipCmd", value);
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
				DictionaryUtil.Add(QueryParameters, "PackagePath", value);
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
				DictionaryUtil.Add(QueryParameters, "Mem", value);
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
				DictionaryUtil.Add(QueryParameters, "StdoutRedirectPath", value);
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
				DictionaryUtil.Add(QueryParameters, "Variables", value);
			}
		}

		public string PostCmdLine
		{
			get
			{
				return postCmdLine;
			}
			set	
			{
				postCmdLine = value;
				DictionaryUtil.Add(QueryParameters, "PostCmdLine", value);
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
				DictionaryUtil.Add(QueryParameters, "RunasUser", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
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
				DictionaryUtil.Add(QueryParameters, "ReRunable", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Thread", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Priority", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Gpu", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Node", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Task", value.ToString());
			}
		}

		public string InputFileUrl
		{
			get
			{
				return inputFileUrl;
			}
			set	
			{
				inputFileUrl = value;
				DictionaryUtil.Add(QueryParameters, "InputFileUrl", value);
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
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string ContainerId
		{
			get
			{
				return containerId;
			}
			set	
			{
				containerId = value;
				DictionaryUtil.Add(QueryParameters, "ContainerId", value);
			}
		}

        public override SubmitJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
