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
	public class ValidateTemplateContentResponse : AcsResponse
	{

		private string outputs;

		private string requestId;

		private string parameters;

		private string ramRole;

		private List<ValidateTemplateContent_Task> tasks;

		[JsonProperty(PropertyName = "Outputs")]
		public string Outputs
		{
			get
			{
				return outputs;
			}
			set	
			{
				outputs = value;
			}
		}

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

		[JsonProperty(PropertyName = "RamRole")]
		public string RamRole
		{
			get
			{
				return ramRole;
			}
			set	
			{
				ramRole = value;
			}
		}

		[JsonProperty(PropertyName = "Tasks")]
		public List<ValidateTemplateContent_Task> Tasks
		{
			get
			{
				return tasks;
			}
			set	
			{
				tasks = value;
			}
		}

		public class ValidateTemplateContent_Task
		{

			private string outputs;

			private string type;

			private string description;

			private string name;

			private string properties;

			[JsonProperty(PropertyName = "Outputs")]
			public string Outputs
			{
				get
				{
					return outputs;
				}
				set	
				{
					outputs = value;
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
				}
			}

			[JsonProperty(PropertyName = "Properties")]
			public string Properties
			{
				get
				{
					return properties;
				}
				set	
				{
					properties = value;
				}
			}
		}
	}
}
