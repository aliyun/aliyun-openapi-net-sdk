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

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class GetUserByExtensionResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private GetUserByExtension_User user;

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

		public string Code
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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public GetUserByExtension_User User
		{
			get
			{
				return user;
			}
			set	
			{
				user = value;
			}
		}

		public class GetUserByExtension_User
		{

			private string userId;

			private string ramId;

			private string instanceId;

			private List<GetUserByExtension_Role> roles;

			private List<GetUserByExtension_SkillLevel> skillLevels;

			private GetUserByExtension_Detail detail;

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string RamId
			{
				get
				{
					return ramId;
				}
				set	
				{
					ramId = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public List<GetUserByExtension_Role> Roles
			{
				get
				{
					return roles;
				}
				set	
				{
					roles = value;
				}
			}

			public List<GetUserByExtension_SkillLevel> SkillLevels
			{
				get
				{
					return skillLevels;
				}
				set	
				{
					skillLevels = value;
				}
			}

			public GetUserByExtension_Detail Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}

			public class GetUserByExtension_Role
			{

				private string roleId;

				private string instanceId;

				private string roleName;

				private string roleDescription;

				public string RoleId
				{
					get
					{
						return roleId;
					}
					set	
					{
						roleId = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public string RoleName
				{
					get
					{
						return roleName;
					}
					set	
					{
						roleName = value;
					}
				}

				public string RoleDescription
				{
					get
					{
						return roleDescription;
					}
					set	
					{
						roleDescription = value;
					}
				}
			}

			public class GetUserByExtension_SkillLevel
			{

				private string skillLevelId;

				private int? level;

				private GetUserByExtension_Skill skill;

				public string SkillLevelId
				{
					get
					{
						return skillLevelId;
					}
					set	
					{
						skillLevelId = value;
					}
				}

				public int? Level
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

				public GetUserByExtension_Skill Skill
				{
					get
					{
						return skill;
					}
					set	
					{
						skill = value;
					}
				}

				public class GetUserByExtension_Skill
				{

					private string skillGroupId;

					private string instanceId;

					private string skillGroupName;

					private string skillGroupDescription;

					public string SkillGroupId
					{
						get
						{
							return skillGroupId;
						}
						set	
						{
							skillGroupId = value;
						}
					}

					public string InstanceId
					{
						get
						{
							return instanceId;
						}
						set	
						{
							instanceId = value;
						}
					}

					public string SkillGroupName
					{
						get
						{
							return skillGroupName;
						}
						set	
						{
							skillGroupName = value;
						}
					}

					public string SkillGroupDescription
					{
						get
						{
							return skillGroupDescription;
						}
						set	
						{
							skillGroupDescription = value;
						}
					}
				}
			}

			public class GetUserByExtension_Detail
			{

				private string loginName;

				private string displayName;

				private string phone;

				private string email;

				private string department;

				private string extension;

				public string LoginName
				{
					get
					{
						return loginName;
					}
					set	
					{
						loginName = value;
					}
				}

				public string DisplayName
				{
					get
					{
						return displayName;
					}
					set	
					{
						displayName = value;
					}
				}

				public string Phone
				{
					get
					{
						return phone;
					}
					set	
					{
						phone = value;
					}
				}

				public string Email
				{
					get
					{
						return email;
					}
					set	
					{
						email = value;
					}
				}

				public string Department
				{
					get
					{
						return department;
					}
					set	
					{
						department = value;
					}
				}

				public string Extension
				{
					get
					{
						return extension;
					}
					set	
					{
						extension = value;
					}
				}
			}
		}
	}
}
