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
    public class CreateStateConfigurationRequest : RpcAcsRequest<CreateStateConfigurationResponse>
    {
        public CreateStateConfigurationRequest()
            : base("oos", "2019-06-01", "CreateStateConfiguration", "oos", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string scheduleType;

		private string clientToken;

		private string description;

		private string targets;

		private string resourceGroupId;

		private string templateVersion;

		private string scheduleExpression;

		private string templateName;

		private string configureMode;

		private string tags;

		private string parameters;

		[JsonProperty(PropertyName = "ScheduleType")]
		public string ScheduleType
		{
			get
			{
				return scheduleType;
			}
			set	
			{
				scheduleType = value;
				DictionaryUtil.Add(QueryParameters, "ScheduleType", value);
			}
		}

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

		[JsonProperty(PropertyName = "Targets")]
		public string Targets
		{
			get
			{
				return targets;
			}
			set	
			{
				targets = value;
				DictionaryUtil.Add(QueryParameters, "Targets", value);
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

		[JsonProperty(PropertyName = "ScheduleExpression")]
		public string ScheduleExpression
		{
			get
			{
				return scheduleExpression;
			}
			set	
			{
				scheduleExpression = value;
				DictionaryUtil.Add(QueryParameters, "ScheduleExpression", value);
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

		[JsonProperty(PropertyName = "ConfigureMode")]
		public string ConfigureMode
		{
			get
			{
				return configureMode;
			}
			set	
			{
				configureMode = value;
				DictionaryUtil.Add(QueryParameters, "ConfigureMode", value);
			}
		}

		[JsonProperty(PropertyName = "Tags")]
		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
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

        public override CreateStateConfigurationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateStateConfigurationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
