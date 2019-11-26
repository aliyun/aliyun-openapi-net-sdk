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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeAccessRulesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeAccessRules_AccessRule> accessRules;

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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public List<DescribeAccessRules_AccessRule> AccessRules
		{
			get
			{
				return accessRules;
			}
			set	
			{
				accessRules = value;
			}
		}

		public class DescribeAccessRules_AccessRule
		{

			private string sourceCidrIp;

			private int? priority;

			private string accessRuleId;

			private string rWAccess;

			private string userAccess;

			public string SourceCidrIp
			{
				get
				{
					return sourceCidrIp;
				}
				set	
				{
					sourceCidrIp = value;
				}
			}

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

			public string AccessRuleId
			{
				get
				{
					return accessRuleId;
				}
				set	
				{
					accessRuleId = value;
				}
			}

			public string RWAccess
			{
				get
				{
					return rWAccess;
				}
				set	
				{
					rWAccess = value;
				}
			}

			public string UserAccess
			{
				get
				{
					return userAccess;
				}
				set	
				{
					userAccess = value;
				}
			}
		}
	}
}
