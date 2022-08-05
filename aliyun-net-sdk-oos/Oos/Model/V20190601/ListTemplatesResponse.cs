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
	public class ListTemplatesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? maxResults;

		private List<ListTemplates_Template> templates;

		[JsonProperty(PropertyName = "NextToken")]
		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
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

		[JsonProperty(PropertyName = "MaxResults")]
		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		[JsonProperty(PropertyName = "Templates")]
		public List<ListTemplates_Template> Templates
		{
			get
			{
				return templates;
			}
			set	
			{
				templates = value;
			}
		}

		public class ListTemplates_Template
		{

			private string hash;

			private string updatedDate;

			private string updatedBy;

			private string templateType;

			private string tags;

			private string templateName;

			private string templateVersion;

			private string templateFormat;

			private int? popularity;

			private int? totalExecutionCount;

			private string description;

			private string resourceGroupId;

			private string createdBy;

			private string createdDate;

			private string category;

			private bool? hasTrigger;

			private string templateId;

			private string shareType;

			[JsonProperty(PropertyName = "Hash")]
			public string Hash
			{
				get
				{
					return hash;
				}
				set	
				{
					hash = value;
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

			[JsonProperty(PropertyName = "TemplateType")]
			public string TemplateType
			{
				get
				{
					return templateType;
				}
				set	
				{
					templateType = value;
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

			[JsonProperty(PropertyName = "TemplateFormat")]
			public string TemplateFormat
			{
				get
				{
					return templateFormat;
				}
				set	
				{
					templateFormat = value;
				}
			}

			[JsonProperty(PropertyName = "Popularity")]
			public int? Popularity
			{
				get
				{
					return popularity;
				}
				set	
				{
					popularity = value;
				}
			}

			[JsonProperty(PropertyName = "TotalExecutionCount")]
			public int? TotalExecutionCount
			{
				get
				{
					return totalExecutionCount;
				}
				set	
				{
					totalExecutionCount = value;
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

			[JsonProperty(PropertyName = "HasTrigger")]
			public bool? HasTrigger
			{
				get
				{
					return hasTrigger;
				}
				set	
				{
					hasTrigger = value;
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
