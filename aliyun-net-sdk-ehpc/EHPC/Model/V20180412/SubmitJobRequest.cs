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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class SubmitJobRequest : RpcAcsRequest<SubmitJobResponse>
    {
        public SubmitJobRequest()
            : base("EHPC", "2018-04-12", "SubmitJob", "ehs", "openAPI")
        {
        }

		private string stderrRedirectPath;

		private string variables;

		private string runasUserPassword;

		private string postCmdLine;

		private string runasUser;

		private string clusterId;

		private bool? reRunable;

		private int? priority;

		private string commandLine;

		private string accessKeyId;

		private string arrayRequest;

		private string unzipCmd;

		private string packagePath;

		private string inputFileUrl;

		private string name;

		private string action;

		private string stdoutRedirectPath;

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

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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

        public override SubmitJobResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SubmitJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}