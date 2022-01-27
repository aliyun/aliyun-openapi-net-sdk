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
    public class InvokeCommandRequest : RpcAcsRequest<InvokeCommandResponse>
    {
        public InvokeCommandRequest()
            : base("Ecs", "2014-05-26", "InvokeCommand", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string commandId;

		private string frequency;

		private string repeatMode;

		private string windowsPasswordName;

		private bool? timed;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private List<string> instanceIds = new List<string>(){ };

		private Dictionary<object,object> parameters;

		private string username;

		[JsonProperty(PropertyName = "ResourceOwnerId")]
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

		[JsonProperty(PropertyName = "CommandId")]
		public string CommandId
		{
			get
			{
				return commandId;
			}
			set	
			{
				commandId = value;
				DictionaryUtil.Add(QueryParameters, "CommandId", value);
			}
		}

		[JsonProperty(PropertyName = "Frequency")]
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

		[JsonProperty(PropertyName = "RepeatMode")]
		public string RepeatMode
		{
			get
			{
				return repeatMode;
			}
			set	
			{
				repeatMode = value;
				DictionaryUtil.Add(QueryParameters, "RepeatMode", value);
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

		[JsonProperty(PropertyName = "Timed")]
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

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
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

		[JsonProperty(PropertyName = "OwnerAccount")]
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

		[JsonProperty(PropertyName = "OwnerId")]
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

		[JsonProperty(PropertyName = "InstanceId")]
		public List<string> InstanceIds
		{
			get
			{
				return instanceIds;
			}

			set
			{
				instanceIds = value;
			}
		}

		[JsonProperty(PropertyName = "Parameters")]
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

		[JsonProperty(PropertyName = "Username")]
		public string Username
		{
			get
			{
				return username;
			}
			set	
			{
				username = value;
				DictionaryUtil.Add(QueryParameters, "Username", value);
			}
		}

        public override InvokeCommandResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InvokeCommandResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
