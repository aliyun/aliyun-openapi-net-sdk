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
	public class QueryPerspectivesResponse : AcsResponse
	{

		private string requestId;

		private List<QueryPerspectives_Perspective> perspectives;

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

		public List<QueryPerspectives_Perspective> Perspectives
		{
			get
			{
				return perspectives;
			}
			set	
			{
				perspectives = value;
			}
		}

		public class QueryPerspectives_Perspective
		{

			private string modifyUserName;

			private string modifyTime;

			private string createTime;

			private string selfDefine;

			private string perspectiveId;

			private string createUserName;

			private string perspectiveCode;

			private int? status;

			private string name;

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

			public string SelfDefine
			{
				get
				{
					return selfDefine;
				}
				set	
				{
					selfDefine = value;
				}
			}

			public string PerspectiveId
			{
				get
				{
					return perspectiveId;
				}
				set	
				{
					perspectiveId = value;
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

			public string PerspectiveCode
			{
				get
				{
					return perspectiveCode;
				}
				set	
				{
					perspectiveCode = value;
				}
			}

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
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
		}
	}
}