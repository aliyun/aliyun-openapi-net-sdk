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
	public class ListSkillGroupsOfUserResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private List<ListSkillGroupsOfUser_SkillLevel> skillLevels;

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

		public List<ListSkillGroupsOfUser_SkillLevel> SkillLevels
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

		public class ListSkillGroupsOfUser_SkillLevel
		{

			private string skillLevelId;

			private int? level;

			private ListSkillGroupsOfUser_Skill skill;

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

			public ListSkillGroupsOfUser_Skill Skill
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

			public class ListSkillGroupsOfUser_Skill
			{

				private string skillGroupId;

				private string instanceId;

				private string skillGroupName;

				private string skillGroupDescription;

				private List<ListSkillGroupsOfUser_PhoneNumber> outboundPhoneNumbers;

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

				public List<ListSkillGroupsOfUser_PhoneNumber> OutboundPhoneNumbers
				{
					get
					{
						return outboundPhoneNumbers;
					}
					set	
					{
						outboundPhoneNumbers = value;
					}
				}

				public class ListSkillGroupsOfUser_PhoneNumber
				{

					private string phoneNumberId;

					private string instanceId;

					private string number;

					private string phoneNumberDescription;

					private bool? testOnly;

					private int? remainingTime;

					private bool? allowOutbound;

					private string usage;

					private int? trunks;

					private string province;

					private string city;

					public string PhoneNumberId
					{
						get
						{
							return phoneNumberId;
						}
						set	
						{
							phoneNumberId = value;
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

					public string Number
					{
						get
						{
							return number;
						}
						set	
						{
							number = value;
						}
					}

					public string PhoneNumberDescription
					{
						get
						{
							return phoneNumberDescription;
						}
						set	
						{
							phoneNumberDescription = value;
						}
					}

					public bool? TestOnly
					{
						get
						{
							return testOnly;
						}
						set	
						{
							testOnly = value;
						}
					}

					public int? RemainingTime
					{
						get
						{
							return remainingTime;
						}
						set	
						{
							remainingTime = value;
						}
					}

					public bool? AllowOutbound
					{
						get
						{
							return allowOutbound;
						}
						set	
						{
							allowOutbound = value;
						}
					}

					public string Usage
					{
						get
						{
							return usage;
						}
						set	
						{
							usage = value;
						}
					}

					public int? Trunks
					{
						get
						{
							return trunks;
						}
						set	
						{
							trunks = value;
						}
					}

					public string Province
					{
						get
						{
							return province;
						}
						set	
						{
							province = value;
						}
					}

					public string City
					{
						get
						{
							return city;
						}
						set	
						{
							city = value;
						}
					}
				}
			}
		}
	}
}
