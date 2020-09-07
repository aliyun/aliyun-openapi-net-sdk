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
	public class ListSecretParameterVersionsResponse : AcsResponse
	{

		private string requestId;

		private int? maxResults;

		private string nextToken;

		private int? totalCount;

		private string name;

		private string id;

		private string type;

		private string description;

		private string createdDate;

		private string createdBy;

		private List<ListSecretParameterVersions_ParameterVersion> parameterVersions;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
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

		public List<ListSecretParameterVersions_ParameterVersion> ParameterVersions
		{
			get
			{
				return parameterVersions;
			}
			set	
			{
				parameterVersions = value;
			}
		}

		public class ListSecretParameterVersions_ParameterVersion
		{

			private string updatedDate;

			private string updatedBy;

			private int? parameterVersion;

			private string _value;

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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}
	}
}
