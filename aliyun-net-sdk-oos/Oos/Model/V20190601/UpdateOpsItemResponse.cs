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
	public class UpdateOpsItemResponse : AcsResponse
	{

		private string requestId;

		private UpdateOpsItem_OpsItem opsItem;

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

		[JsonProperty(PropertyName = "OpsItem")]
		public UpdateOpsItem_OpsItem OpsItem
		{
			get
			{
				return opsItem;
			}
			set	
			{
				opsItem = value;
			}
		}

		public class UpdateOpsItem_OpsItem
		{

			private string tags;

			private string updateDate;

			private string description;

			private string opsItemId;

			private string createDate;

			private string title;

			private string status;

			private string severity;

			private string category;

			private string source;

			private int? priority;

			private string attributes;

			private string createdBy;

			private string lastModifiedBy;

			private string resourceGroupId;

			private List<string> solutions;

			private List<string> resources;

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

			[JsonProperty(PropertyName = "UpdateDate")]
			public string UpdateDate
			{
				get
				{
					return updateDate;
				}
				set	
				{
					updateDate = value;
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

			[JsonProperty(PropertyName = "OpsItemId")]
			public string OpsItemId
			{
				get
				{
					return opsItemId;
				}
				set	
				{
					opsItemId = value;
				}
			}

			[JsonProperty(PropertyName = "CreateDate")]
			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
				}
			}

			[JsonProperty(PropertyName = "Title")]
			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			[JsonProperty(PropertyName = "Severity")]
			public string Severity
			{
				get
				{
					return severity;
				}
				set	
				{
					severity = value;
				}
			}

			[JsonProperty(PropertyName = "Category")]
			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			[JsonProperty(PropertyName = "Source")]
			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			[JsonProperty(PropertyName = "Priority")]
			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			[JsonProperty(PropertyName = "Attributes")]
			public string Attributes
			{
				get
				{
					return attributes;
				}
				set	
				{
					attributes = value;
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

			[JsonProperty(PropertyName = "LastModifiedBy")]
			public string LastModifiedBy
			{
				get
				{
					return lastModifiedBy;
				}
				set	
				{
					lastModifiedBy = value;
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

			[JsonProperty(PropertyName = "Solutions")]
			public List<string> Solutions
			{
				get
				{
					return solutions;
				}
				set	
				{
					solutions = value;
				}
			}

			[JsonProperty(PropertyName = "Resources")]
			public List<string> Resources
			{
				get
				{
					return resources;
				}
				set	
				{
					resources = value;
				}
			}
		}
	}
}
