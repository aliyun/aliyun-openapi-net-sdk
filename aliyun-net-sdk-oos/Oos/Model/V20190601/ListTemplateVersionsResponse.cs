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
	public class ListTemplateVersionsResponse : AcsResponse
	{

		private string requestId;

		private int? maxResults;

		private string nextToken;

		private List<ListTemplateVersions_TemplateVersion> templateVersions;

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

		public List<ListTemplateVersions_TemplateVersion> TemplateVersions
		{
			get
			{
				return templateVersions;
			}
			set	
			{
				templateVersions = value;
			}
		}

		public class ListTemplateVersions_TemplateVersion
		{

			private string description;

			private string templateFormat;

			private string templateVersion;

			private string updatedDate;

			private string updatedBy;

			private string versionName;

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

			public string VersionName
			{
				get
				{
					return versionName;
				}
				set	
				{
					versionName = value;
				}
			}
		}
	}
}
