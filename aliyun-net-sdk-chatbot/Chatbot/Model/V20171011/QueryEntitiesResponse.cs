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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Model.V20171011
{
	public class QueryEntitiesResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<QueryEntities_Entity> entities;

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

		public List<QueryEntities_Entity> Entities
		{
			get
			{
				return entities;
			}
			set	
			{
				entities = value;
			}
		}

		public class QueryEntities_Entity
		{

			private long? entityId;

			private string entityName;

			private string entityType;

			private string regex;

			private string createTime;

			private string modifyTime;

			private string createUserId;

			private string createUserName;

			private string modifyUserId;

			private string modifyUserName;

			private List<QueryEntities_MembersItem> members;

			public long? EntityId
			{
				get
				{
					return entityId;
				}
				set	
				{
					entityId = value;
				}
			}

			public string EntityName
			{
				get
				{
					return entityName;
				}
				set	
				{
					entityName = value;
				}
			}

			public string EntityType
			{
				get
				{
					return entityType;
				}
				set	
				{
					entityType = value;
				}
			}

			public string Regex
			{
				get
				{
					return regex;
				}
				set	
				{
					regex = value;
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

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public string CreateUserId
			{
				get
				{
					return createUserId;
				}
				set	
				{
					createUserId = value;
				}
			}

			public string CreateUserName
			{
				get
				{
					return createUserName;
				}
				set	
				{
					createUserName = value;
				}
			}

			public string ModifyUserId
			{
				get
				{
					return modifyUserId;
				}
				set	
				{
					modifyUserId = value;
				}
			}

			public string ModifyUserName
			{
				get
				{
					return modifyUserName;
				}
				set	
				{
					modifyUserName = value;
				}
			}

			public List<QueryEntities_MembersItem> Members
			{
				get
				{
					return members;
				}
				set	
				{
					members = value;
				}
			}

			public class QueryEntities_MembersItem
			{

				private string memberName;

				private List<string> synonyms;

				public string MemberName
				{
					get
					{
						return memberName;
					}
					set	
					{
						memberName = value;
					}
				}

				public List<string> Synonyms
				{
					get
					{
						return synonyms;
					}
					set	
					{
						synonyms = value;
					}
				}
			}
		}
	}
}