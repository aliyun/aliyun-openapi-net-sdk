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

namespace Aliyun.Acs.CSB.Model.V20171118
{
	public class FindAllLinkRuleResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private FindAllLinkRule_Data data;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public FindAllLinkRule_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class FindAllLinkRule_Data
		{

			private List<FindAllLinkRule_LinkRuleListItem> linkRuleList;

			public List<FindAllLinkRule_LinkRuleListItem> LinkRuleList
			{
				get
				{
					return linkRuleList;
				}
				set	
				{
					linkRuleList = value;
				}
			}

			public class FindAllLinkRule_LinkRuleListItem
			{

				private long? csbId;

				private string ownerId;

				private long? gmtCreate;

				private long? gmtModified;

				private long? id;

				private int? deleted;

				private string originName;

				private string targetName;

				public long? CsbId
				{
					get
					{
						return csbId;
					}
					set	
					{
						csbId = value;
					}
				}

				public string OwnerId
				{
					get
					{
						return ownerId;
					}
					set	
					{
						ownerId = value;
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

				public int? Deleted
				{
					get
					{
						return deleted;
					}
					set	
					{
						deleted = value;
					}
				}

				public string OriginName
				{
					get
					{
						return originName;
					}
					set	
					{
						originName = value;
					}
				}

				public string TargetName
				{
					get
					{
						return targetName;
					}
					set	
					{
						targetName = value;
					}
				}
			}
		}
	}
}
