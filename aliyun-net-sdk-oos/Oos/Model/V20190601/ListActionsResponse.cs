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
	public class ListActionsResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? maxResults;

		private List<ListActions_Action> actions;

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

		[JsonProperty(PropertyName = "Actions")]
		public List<ListActions_Action> Actions
		{
			get
			{
				return actions;
			}
			set	
			{
				actions = value;
			}
		}

		public class ListActions_Action
		{

			private int? popularity;

			private string actionType;

			private string description;

			private string createdDate;

			private string templateVersion;

			private string oOSActionName;

			private string properties;

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

			[JsonProperty(PropertyName = "ActionType")]
			public string ActionType
			{
				get
				{
					return actionType;
				}
				set	
				{
					actionType = value;
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

			[JsonProperty(PropertyName = "OOSActionName")]
			public string OOSActionName
			{
				get
				{
					return oOSActionName;
				}
				set	
				{
					oOSActionName = value;
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
