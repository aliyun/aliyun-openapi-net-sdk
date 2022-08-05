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
using Aliyun.Acs.oos.Transform;
using Aliyun.Acs.oos.Transform.V20190601;

namespace Aliyun.Acs.oos.Model.V20190601
{
    public class StartExecutionRequest : RpcAcsRequest<StartExecutionResponse>
    {
        public StartExecutionRequest()
            : base("oos", "2019-06-01", "StartExecution", "oos", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string description;

		private string mode;

		private string resourceGroupId;

		private string templateVersion;

		private string templateName;

		private string loopMode;

		private string safetyCheck;

		private Dictionary<object,object> tags;

		private string templateContent;

		private string parentExecutionId;

		private string parameters;

		[JsonProperty(PropertyName = "ClientToken")]
		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		[JsonProperty(PropertyName = "Description")]
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

		[JsonProperty(PropertyName = "Mode")]
		public string Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
				DictionaryUtil.Add(QueryParameters, "Mode", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceGroupId")]
		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		[JsonProperty(PropertyName = "TemplateVersion")]
		public string TemplateVersion
		{
			get
			{
				return templateVersion;
			}
			set	
			{
				templateVersion = value;
				DictionaryUtil.Add(QueryParameters, "TemplateVersion", value);
			}
		}

		[JsonProperty(PropertyName = "TemplateName")]
		public string TemplateName
		{
			get
			{
				return templateName;
			}
			set	
			{
				templateName = value;
				DictionaryUtil.Add(QueryParameters, "TemplateName", value);
			}
		}

		[JsonProperty(PropertyName = "LoopMode")]
		public string LoopMode
		{
			get
			{
				return loopMode;
			}
			set	
			{
				loopMode = value;
				DictionaryUtil.Add(QueryParameters, "LoopMode", value);
			}
		}

		[JsonProperty(PropertyName = "SafetyCheck")]
		public string SafetyCheck
		{
			get
			{
				return safetyCheck;
			}
			set	
			{
				safetyCheck = value;
				DictionaryUtil.Add(QueryParameters, "SafetyCheck", value);
			}
		}

		[JsonProperty(PropertyName = "Tags")]
		public Dictionary<object,object> Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", JsonConvert.SerializeObject(value));
			}
		}

		[JsonProperty(PropertyName = "TemplateContent")]
		public string TemplateContent
		{
			get
			{
				return templateContent;
			}
			set	
			{
				templateContent = value;
				DictionaryUtil.Add(QueryParameters, "TemplateContent", value);
			}
		}

		[JsonProperty(PropertyName = "ParentExecutionId")]
		public string ParentExecutionId
		{
			get
			{
				return parentExecutionId;
			}
			set	
			{
				parentExecutionId = value;
				DictionaryUtil.Add(QueryParameters, "ParentExecutionId", value);
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
				DictionaryUtil.Add(QueryParameters, "Parameters", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override StartExecutionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StartExecutionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
