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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeGrantRulesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeGrantRules_GrantRule> grantRules;

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

		public List<DescribeGrantRules_GrantRule> GrantRules
		{
			get
			{
				return grantRules;
			}
			set	
			{
				grantRules = value;
			}
		}

		public class DescribeGrantRules_GrantRule
		{

			private string grantRuleId;

			private long? cenUid;

			private long? ccnUid;

			private string cenInstanceId;

			private string ccnInstanceId;

			private long? gmtCreate;

			private long? gmtModified;

			private string regionId;

			public string GrantRuleId
			{
				get
				{
					return grantRuleId;
				}
				set	
				{
					grantRuleId = value;
				}
			}

			public long? CenUid
			{
				get
				{
					return cenUid;
				}
				set	
				{
					cenUid = value;
				}
			}

			public long? CcnUid
			{
				get
				{
					return ccnUid;
				}
				set	
				{
					ccnUid = value;
				}
			}

			public string CenInstanceId
			{
				get
				{
					return cenInstanceId;
				}
				set	
				{
					cenInstanceId = value;
				}
			}

			public string CcnInstanceId
			{
				get
				{
					return ccnInstanceId;
				}
				set	
				{
					ccnInstanceId = value;
				}
			}

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}
		}
	}
}
