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
	public class ListActionsResponse : AcsResponse
	{

		private string requestId;

		private int? maxResults;

		private string nextToken;

		private List<ListActions_Action> actions;

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

			private string oOSActionName;

			private string description;

			private string actionType;

			private string createdDate;

			private string properties;

			private string templateVersion;

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
		}
	}
}
