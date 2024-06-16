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
using Aliyun.Acs.sae.Transform;
using Aliyun.Acs.sae.Transform.V20190506;

namespace Aliyun.Acs.sae.Model.V20190506
{
    public class ExecJobRequest : RoaAcsRequest<ExecJobResponse>
    {
        public ExecJobRequest()
            : base("sae", "2019-05-06", "ExecJob", "serverless", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v1/sam/job/execJob";
			Method = MethodType.GET;
        }

		private string eventId;

		private string jarStartOptions;

		private string jarStartArgs;

		private string commandArgs;

		private string replicas;

		private string appId;

		private string envs;

		private string time;

		private string command;

		private string warStartOptions;

		public string EventId
		{
			get
			{
				return eventId;
			}
			set	
			{
				eventId = value;
				DictionaryUtil.Add(QueryParameters, "EventId", value);
			}
		}

		public string JarStartOptions
		{
			get
			{
				return jarStartOptions;
			}
			set	
			{
				jarStartOptions = value;
				DictionaryUtil.Add(QueryParameters, "JarStartOptions", value);
			}
		}

		public string JarStartArgs
		{
			get
			{
				return jarStartArgs;
			}
			set	
			{
				jarStartArgs = value;
				DictionaryUtil.Add(QueryParameters, "JarStartArgs", value);
			}
		}

		public string CommandArgs
		{
			get
			{
				return commandArgs;
			}
			set	
			{
				commandArgs = value;
				DictionaryUtil.Add(QueryParameters, "CommandArgs", value);
			}
		}

		public string Replicas
		{
			get
			{
				return replicas;
			}
			set	
			{
				replicas = value;
				DictionaryUtil.Add(QueryParameters, "Replicas", value);
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public string Envs
		{
			get
			{
				return envs;
			}
			set	
			{
				envs = value;
				DictionaryUtil.Add(QueryParameters, "Envs", value);
			}
		}

		public string Time
		{
			get
			{
				return time;
			}
			set	
			{
				time = value;
				DictionaryUtil.Add(QueryParameters, "Time", value);
			}
		}

		public string Command
		{
			get
			{
				return command;
			}
			set	
			{
				command = value;
				DictionaryUtil.Add(QueryParameters, "Command", value);
			}
		}

		public string WarStartOptions
		{
			get
			{
				return warStartOptions;
			}
			set	
			{
				warStartOptions = value;
				DictionaryUtil.Add(QueryParameters, "WarStartOptions", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ExecJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ExecJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
