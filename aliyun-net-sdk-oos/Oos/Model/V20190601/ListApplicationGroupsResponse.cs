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
	public class ListApplicationGroupsResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? maxResults;

		private List<ListApplicationGroups_ApplicationGroup> applicationGroups;

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

		[JsonProperty(PropertyName = "ApplicationGroups")]
		public List<ListApplicationGroups_ApplicationGroup> ApplicationGroups
		{
			get
			{
				return applicationGroups;
			}
			set	
			{
				applicationGroups = value;
			}
		}

		public class ListApplicationGroups_ApplicationGroup
		{

			private string cmsGroupId;

			private string deployRegionId;

			private string updateDate;

			private string description;

			private string importTagKey;

			private string applicationName;

			private string importTagValue;

			private string name;

			private string createDate;

			private string status;

			private string deployParameters;

			private string statusReason;

			[JsonProperty(PropertyName = "CmsGroupId")]
			public string CmsGroupId
			{
				get
				{
					return cmsGroupId;
				}
				set	
				{
					cmsGroupId = value;
				}
			}

			[JsonProperty(PropertyName = "DeployRegionId")]
			public string DeployRegionId
			{
				get
				{
					return deployRegionId;
				}
				set	
				{
					deployRegionId = value;
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

			[JsonProperty(PropertyName = "ImportTagKey")]
			public string ImportTagKey
			{
				get
				{
					return importTagKey;
				}
				set	
				{
					importTagKey = value;
				}
			}

			[JsonProperty(PropertyName = "ApplicationName")]
			public string ApplicationName
			{
				get
				{
					return applicationName;
				}
				set	
				{
					applicationName = value;
				}
			}

			[JsonProperty(PropertyName = "ImportTagValue")]
			public string ImportTagValue
			{
				get
				{
					return importTagValue;
				}
				set	
				{
					importTagValue = value;
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

			[JsonProperty(PropertyName = "DeployParameters")]
			public string DeployParameters
			{
				get
				{
					return deployParameters;
				}
				set	
				{
					deployParameters = value;
				}
			}

			[JsonProperty(PropertyName = "StatusReason")]
			public string StatusReason
			{
				get
				{
					return statusReason;
				}
				set	
				{
					statusReason = value;
				}
			}
		}
	}
}
