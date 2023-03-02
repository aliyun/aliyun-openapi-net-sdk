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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.SWAS_OPEN.Transform;
using Aliyun.Acs.SWAS_OPEN.Transform.V20200601;

namespace Aliyun.Acs.SWAS_OPEN.Model.V20200601
{
    public class RunCommandRequest : RpcAcsRequest<RunCommandResponse>
    {
        public RunCommandRequest()
            : base("SWAS-OPEN", "2020-06-01", "RunCommand", "SWAS-OPEN", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string workingDir;

		private string type;

		private string commandContent;

		private int? timeout;

		private string windowsPasswordName;

		private string instanceId;

		private string workingUser;

		private string name;

		private string parameters;

		private bool? enableParameter;

		[JsonProperty(PropertyName = "WorkingDir")]
		public string WorkingDir
		{
			get
			{
				return workingDir;
			}
			set	
			{
				workingDir = value;
				DictionaryUtil.Add(QueryParameters, "WorkingDir", value);
			}
		}

		[JsonProperty(PropertyName = "Type")]
		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		[JsonProperty(PropertyName = "CommandContent")]
		public string CommandContent
		{
			get
			{
				return commandContent;
			}
			set	
			{
				commandContent = value;
				DictionaryUtil.Add(QueryParameters, "CommandContent", value);
			}
		}

		[JsonProperty(PropertyName = "Timeout")]
		public int? Timeout
		{
			get
			{
				return timeout;
			}
			set	
			{
				timeout = value;
				DictionaryUtil.Add(QueryParameters, "Timeout", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "WindowsPasswordName")]
		public string WindowsPasswordName
		{
			get
			{
				return windowsPasswordName;
			}
			set	
			{
				windowsPasswordName = value;
				DictionaryUtil.Add(QueryParameters, "WindowsPasswordName", value);
			}
		}

		[JsonProperty(PropertyName = "InstanceId")]
		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		[JsonProperty(PropertyName = "WorkingUser")]
		public string WorkingUser
		{
			get
			{
				return workingUser;
			}
			set	
			{
				workingUser = value;
				DictionaryUtil.Add(QueryParameters, "WorkingUser", value);
			}
		}

		[JsonProperty(PropertyName = "Name")]
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

		[JsonProperty(PropertyName = "Parameters")]
		public string Parameters
		{
			get
			{
				return parameters;
			}
			set	
			{
				parameters = value;
				DictionaryUtil.Add(QueryParameters, "Parameters", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "EnableParameter")]
		public bool? EnableParameter
		{
			get
			{
				return enableParameter;
			}
			set	
			{
				enableParameter = value;
				DictionaryUtil.Add(QueryParameters, "EnableParameter", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RunCommandResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RunCommandResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
