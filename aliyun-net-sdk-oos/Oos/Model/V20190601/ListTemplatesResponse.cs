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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class ListTemplatesResponse : AcsResponse
	{

		private string requestId;

		private int? maxResults;

		private string nextToken;

		private List<ListTemplates_Template> templates;

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

			private string templateName;

			private string templateId;

			private string createdDate;

			private string createdBy;

			private string updatedDate;

			private string updatedBy;

			private string hash;

			private string description;

			private string shareType;

			private string templateFormat;

			private string templateVersion;

			private bool? hasTrigger;

			private int? totalExecutionCount;

			private int? popularity;

			private string tags;

			private string category;

			private string templateType;

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
		}
	}
}
