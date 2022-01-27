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

namespace Aliyun.Acs.quickbi_public.Model.V20201111
{
	public class ListDataLevelPermissionWhiteListResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private ListDataLevelPermissionWhiteList_Result result;

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

		public ListDataLevelPermissionWhiteList_Result Result
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

		public class ListDataLevelPermissionWhiteList_Result
		{

			private string cubeId;

			private string ruleType;

			private ListDataLevelPermissionWhiteList_UsersModel usersModel;

			public string CubeId
			{
				get
				{
					return cubeId;
				}
				set	
				{
					cubeId = value;
				}
			}

			public string RuleType
			{
				get
				{
					return ruleType;
				}
				set	
				{
					ruleType = value;
				}
			}

			public ListDataLevelPermissionWhiteList_UsersModel UsersModel
			{
				get
				{
					return usersModel;
				}
				set	
				{
					usersModel = value;
				}
			}

			public class ListDataLevelPermissionWhiteList_UsersModel
			{

				private List<string> userGroups;

				private List<string> users;

				public List<string> UserGroups
				{
					get
					{
						return userGroups;
					}
					set	
					{
						userGroups = value;
					}
				}

				public List<string> Users
				{
					get
					{
						return users;
					}
					set	
					{
						users = value;
					}
				}
			}
		}
	}
}
