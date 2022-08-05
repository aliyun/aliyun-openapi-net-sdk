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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class ListStateConfigurationsResponse : AcsResponse
	{

		private string requestId;

		private List<ListStateConfigurations_StateConfiguration> stateConfigurations;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "StateConfigurations")]
		public List<ListStateConfigurations_StateConfiguration> StateConfigurations
		{
			get
			{
				return stateConfigurations;
			}
			set	
			{
				stateConfigurations = value;
			}
		}

		public class ListStateConfigurations_StateConfiguration
		{

			private string updateTime;

			private string createTime;

			private string targets;

			private string tags;

			private string stateConfigurationId;

			private string scheduleExpression;

			private string templateName;

			private string templateVersion;

			private string configureMode;

			private string scheduleType;

			private string parameters;

			private string description;

			private string resourceGroupId;

			private string templateId;

			[JsonProperty(PropertyName = "UpdateTime")]
			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			[JsonProperty(PropertyName = "CreateTime")]
			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
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
				}
			}

			[JsonProperty(PropertyName = "StateConfigurationId")]
			public string StateConfigurationId
			{
				get
				{
					return stateConfigurationId;
				}
				set	
				{
					stateConfigurationId = value;
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
				}
			}

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
				}
			}

			[JsonProperty(PropertyName = "TemplateId")]
			public string TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
				}
			}
		}
	}
}
