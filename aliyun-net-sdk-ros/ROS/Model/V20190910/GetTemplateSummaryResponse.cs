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

namespace Aliyun.Acs.ROS.Model.V20190910
{
	public class GetTemplateSummaryResponse : AcsResponse
	{

		private string requestId;

		private string description;

		private string metadata;

		private string version;

		private List<GetTemplateSummary_ResourceIdentifierSummary> resourceIdentifierSummaries;

		private List<Dictionary<string, string>> parameters;

		private List<string> resourceTypes;

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

		public string Metadata
		{
			get
			{
				return metadata;
			}
			set	
			{
				metadata = value;
			}
		}

		public string Version
		{
			get
			{
				return version;
			}
			set	
			{
				version = value;
			}
		}

		public List<GetTemplateSummary_ResourceIdentifierSummary> ResourceIdentifierSummaries
		{
			get
			{
				return resourceIdentifierSummaries;
			}
			set	
			{
				resourceIdentifierSummaries = value;
			}
		}

		public List<Dictionary<string, string>> Parameters
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

		public List<string> ResourceTypes
		{
			get
			{
				return resourceTypes;
			}
			set	
			{
				resourceTypes = value;
			}
		}

		public class GetTemplateSummary_ResourceIdentifierSummary
		{

			private string resourceType;

			private List<string> logicalResourceIds;

			private List<string> resourceIdentifiers;

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

			public List<string> LogicalResourceIds
			{
				get
				{
					return logicalResourceIds;
				}
				set	
				{
					logicalResourceIds = value;
				}
			}

			public List<string> ResourceIdentifiers
			{
				get
				{
					return resourceIdentifiers;
				}
				set	
				{
					resourceIdentifiers = value;
				}
			}
		}
	}
}
