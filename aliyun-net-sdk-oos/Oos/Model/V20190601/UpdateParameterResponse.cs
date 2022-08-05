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
	public class UpdateParameterResponse : AcsResponse
	{

		private string requestId;

		private UpdateParameter_Parameter parameter;

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

		[JsonProperty(PropertyName = "Parameter")]
		public UpdateParameter_Parameter Parameter
		{
			get
			{
				return parameter;
			}
			set	
			{
				parameter = value;
			}
		}

		public class UpdateParameter_Parameter
		{

			private string type;

			private string updatedDate;

			private string updatedBy;

			private string tags;

			private string description;

			private string constraints;

			private string resourceGroupId;

			private string createdBy;

			private string createdDate;

			private int? parameterVersion;

			private string name;

			private string id;

			private string shareType;

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

			[JsonProperty(PropertyName = "UpdatedDate")]
			public string UpdatedDate
			{
				get
				{
					return updatedDate;
				}
				set	
				{
					updatedDate = value;
				}
			}

			[JsonProperty(PropertyName = "UpdatedBy")]
			public string UpdatedBy
			{
				get
				{
					return updatedBy;
				}
				set	
				{
					updatedBy = value;
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

			[JsonProperty(PropertyName = "Constraints")]
			public string Constraints
			{
				get
				{
					return constraints;
				}
				set	
				{
					constraints = value;
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

			[JsonProperty(PropertyName = "CreatedBy")]
			public string CreatedBy
			{
				get
				{
					return createdBy;
				}
				set	
				{
					createdBy = value;
				}
			}

			[JsonProperty(PropertyName = "CreatedDate")]
			public string CreatedDate
			{
				get
				{
					return createdDate;
				}
				set	
				{
					createdDate = value;
				}
			}

			[JsonProperty(PropertyName = "ParameterVersion")]
			public int? ParameterVersion
			{
				get
				{
					return parameterVersion;
				}
				set	
				{
					parameterVersion = value;
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

			[JsonProperty(PropertyName = "Id")]
			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			[JsonProperty(PropertyName = "ShareType")]
			public string ShareType
			{
				get
				{
					return shareType;
				}
				set	
				{
					shareType = value;
				}
			}
		}
	}
}
