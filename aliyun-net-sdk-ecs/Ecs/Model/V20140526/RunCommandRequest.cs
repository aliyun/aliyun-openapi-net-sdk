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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class RunCommandRequest : RpcAcsRequest<RunCommandResponse>
    {
        public RunCommandRequest()
            : base("Ecs", "2014-05-26", "RunCommand", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string workingDir;

		private string description;

		private string type;

		private string commandContent;

		private long? timeout;

		private string frequency;

		private string contentEncoding;

		private bool? keepCommand;

		private bool? timed;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private List<string> instanceIds = new List<string>(){ };

		private string name;

		private Dictionary<object,object> parameters;

		private bool? enableParameter;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

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

		public long? Timeout
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

		public string Frequency
		{
			get
			{
				return frequency;
			}
			set	
			{
				frequency = value;
				DictionaryUtil.Add(QueryParameters, "Frequency", value);
			}
		}

		public string ContentEncoding
		{
			get
			{
				return contentEncoding;
			}
			set	
			{
				contentEncoding = value;
				DictionaryUtil.Add(QueryParameters, "ContentEncoding", value);
			}
		}

		public bool? KeepCommand
		{
			get
			{
				return keepCommand;
			}
			set	
			{
				keepCommand = value;
				DictionaryUtil.Add(QueryParameters, "KeepCommand", value.ToString());
			}
		}

		public bool? Timed
		{
			get
			{
				return timed;
			}
			set	
			{
				timed = value;
				DictionaryUtil.Add(QueryParameters, "Timed", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public List<string> InstanceIds
		{
			get
			{
				return instanceIds;
			}

			set
			{
				instanceIds = value;
				for (int i = 0; i < instanceIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceId." + (i + 1) , instanceIds[i]);
				}
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

		public Dictionary<object,object> Parameters
		{
			get
			{
				return parameters;
			}
			set	
			{
				parameters = value;
				DictionaryUtil.Add(QueryParameters, "Parameters", JsonConvert.SerializeObject(value));
			}
		}

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

        public override RunCommandResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RunCommandResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
