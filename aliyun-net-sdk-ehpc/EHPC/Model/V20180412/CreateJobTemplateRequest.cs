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
    public class CreateJobTemplateRequest : RpcAcsRequest<CreateJobTemplateResponse>
    {
        public CreateJobTemplateRequest()
            : base("EHPC", "2018-04-12", "CreateJobTemplate")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointRegionalType, null);
            }
        }

		private string stderrRedirectPath;

		private string commandLine;

		private string arrayRequest;

		private string packagePath;

		private string stdoutRedirectPath;

		private string variables;

		private string runasUser;

		private bool? reRunable;

		private int? priority;

		private string name;

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

        public override CreateJobTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateJobTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
