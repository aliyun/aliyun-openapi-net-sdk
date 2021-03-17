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

namespace Aliyun.Acs.codeup.Model.V20200414
{
	public class ListOrganizationSecurityScoresResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private List<ListOrganizationSecurityScores_ResultItem> result;

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<ListOrganizationSecurityScores_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListOrganizationSecurityScores_ResultItem
		{

			private bool? enable;

			private long? id;

			private string organizationId;

			private ListOrganizationSecurityScores_OrganizationSecurityScore organizationSecurityScore;

			public bool? Enable
			{
				get
				{
					return enable;
				}
				set	
				{
					enable = value;
				}
			}

			public long? Id
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

			public string OrganizationId
			{
				get
				{
					return organizationId;
				}
				set	
				{
					organizationId = value;
				}
			}

			public ListOrganizationSecurityScores_OrganizationSecurityScore OrganizationSecurityScore
			{
				get
				{
					return organizationSecurityScore;
				}
				set	
				{
					organizationSecurityScore = value;
				}
			}

			public class ListOrganizationSecurityScores_OrganizationSecurityScore
			{

				private int? authorityControlScore;

				private int? codeContentScore;

				private int? memberBehaviorScore;

				private string level;

				public int? AuthorityControlScore
				{
					get
					{
						return authorityControlScore;
					}
					set	
					{
						authorityControlScore = value;
					}
				}

				public int? CodeContentScore
				{
					get
					{
						return codeContentScore;
					}
					set	
					{
						codeContentScore = value;
					}
				}

				public int? MemberBehaviorScore
				{
					get
					{
						return memberBehaviorScore;
					}
					set	
					{
						memberBehaviorScore = value;
					}
				}

				public string Level
				{
					get
					{
						return level;
					}
					set	
					{
						level = value;
					}
				}
			}
		}
	}
}
