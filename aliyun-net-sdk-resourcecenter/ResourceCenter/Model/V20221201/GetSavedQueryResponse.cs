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

namespace Aliyun.Acs.ResourceCenter.Model.V20221201
{
	public class GetSavedQueryResponse : AcsResponse
	{

		private string requestId;

		private GetSavedQuery_SavedQuery savedQuery;

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

		public GetSavedQuery_SavedQuery SavedQuery
		{
			get
			{
				return savedQuery;
			}
			set	
			{
				savedQuery = value;
			}
		}

		public class GetSavedQuery_SavedQuery
		{

			private string queryId;

			private string expression;

			private string name;

			private string description;

			private string createTime;

			private string updateTime;

			public string QueryId
			{
				get
				{
					return queryId;
				}
				set	
				{
					queryId = value;
				}
			}

			public string Expression
			{
				get
				{
					return expression;
				}
				set	
				{
					expression = value;
				}
			}

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

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}
		}
	}
}
