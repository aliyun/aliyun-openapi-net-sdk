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
	public class CreateRepositoryProtectedBranchResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private CreateRepositoryProtectedBranch_Result result;

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

		public CreateRepositoryProtectedBranch_Result Result
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

		public class CreateRepositoryProtectedBranch_Result
		{

			private long? id;

			private string branch;

			private List<string> allowPushRoles;

			private List<string> allowMergeRoles;

			private CreateRepositoryProtectedBranch_MergeRequestSetting mergeRequestSetting;

			private CreateRepositoryProtectedBranch_TestSetting testSetting;

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

			public string Branch
			{
				get
				{
					return branch;
				}
				set	
				{
					branch = value;
				}
			}

			public List<string> AllowPushRoles
			{
				get
				{
					return allowPushRoles;
				}
				set	
				{
					allowPushRoles = value;
				}
			}

			public List<string> AllowMergeRoles
			{
				get
				{
					return allowMergeRoles;
				}
				set	
				{
					allowMergeRoles = value;
				}
			}

			public CreateRepositoryProtectedBranch_MergeRequestSetting MergeRequestSetting
			{
				get
				{
					return mergeRequestSetting;
				}
				set	
				{
					mergeRequestSetting = value;
				}
			}

			public CreateRepositoryProtectedBranch_TestSetting TestSetting
			{
				get
				{
					return testSetting;
				}
				set	
				{
					testSetting = value;
				}
			}

			public class CreateRepositoryProtectedBranch_MergeRequestSetting
			{

				private bool? required;

				private string mergeRequestMode;

				private bool? allowSelfApproval;

				private bool? isRequireDiscussionProcessed;

				private bool? isResetApprovalWhenNewPush;

				private int? minimualApproval;

				private List<string> allowMergeRequestRoles;

				private List<string> defaultAssignees;

				public bool? Required
				{
					get
					{
						return required;
					}
					set	
					{
						required = value;
					}
				}

				public string MergeRequestMode
				{
					get
					{
						return mergeRequestMode;
					}
					set	
					{
						mergeRequestMode = value;
					}
				}

				public bool? AllowSelfApproval
				{
					get
					{
						return allowSelfApproval;
					}
					set	
					{
						allowSelfApproval = value;
					}
				}

				public bool? IsRequireDiscussionProcessed
				{
					get
					{
						return isRequireDiscussionProcessed;
					}
					set	
					{
						isRequireDiscussionProcessed = value;
					}
				}

				public bool? IsResetApprovalWhenNewPush
				{
					get
					{
						return isResetApprovalWhenNewPush;
					}
					set	
					{
						isResetApprovalWhenNewPush = value;
					}
				}

				public int? MinimualApproval
				{
					get
					{
						return minimualApproval;
					}
					set	
					{
						minimualApproval = value;
					}
				}

				public List<string> AllowMergeRequestRoles
				{
					get
					{
						return allowMergeRequestRoles;
					}
					set	
					{
						allowMergeRequestRoles = value;
					}
				}

				public List<string> DefaultAssignees
				{
					get
					{
						return defaultAssignees;
					}
					set	
					{
						defaultAssignees = value;
					}
				}
			}

			public class CreateRepositoryProtectedBranch_TestSetting
			{

				private bool? required;

				private CreateRepositoryProtectedBranch_CodingGuidelinesDetection codingGuidelinesDetection;

				private CreateRepositoryProtectedBranch_SensitiveInfoDetection sensitiveInfoDetection;

				private CreateRepositoryProtectedBranch_CheckConfig checkConfig;

				public bool? Required
				{
					get
					{
						return required;
					}
					set	
					{
						required = value;
					}
				}

				public CreateRepositoryProtectedBranch_CodingGuidelinesDetection CodingGuidelinesDetection
				{
					get
					{
						return codingGuidelinesDetection;
					}
					set	
					{
						codingGuidelinesDetection = value;
					}
				}

				public CreateRepositoryProtectedBranch_SensitiveInfoDetection SensitiveInfoDetection
				{
					get
					{
						return sensitiveInfoDetection;
					}
					set	
					{
						sensitiveInfoDetection = value;
					}
				}

				public CreateRepositoryProtectedBranch_CheckConfig CheckConfig
				{
					get
					{
						return checkConfig;
					}
					set	
					{
						checkConfig = value;
					}
				}

				public class CreateRepositoryProtectedBranch_CodingGuidelinesDetection
				{

					private bool? enabled;

					private string message;

					public bool? Enabled
					{
						get
						{
							return enabled;
						}
						set	
						{
							enabled = value;
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
				}

				public class CreateRepositoryProtectedBranch_SensitiveInfoDetection
				{

					private bool? enabled;

					private string message;

					public bool? Enabled
					{
						get
						{
							return enabled;
						}
						set	
						{
							enabled = value;
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
				}

				public class CreateRepositoryProtectedBranch_CheckConfig
				{

					private List<CreateRepositoryProtectedBranch_CheckItemsItem> checkItems;

					public List<CreateRepositoryProtectedBranch_CheckItemsItem> CheckItems
					{
						get
						{
							return checkItems;
						}
						set	
						{
							checkItems = value;
						}
					}

					public class CreateRepositoryProtectedBranch_CheckItemsItem
					{

						private string name;

						private bool? required;

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

						public bool? Required
						{
							get
							{
								return required;
							}
							set	
							{
								required = value;
							}
						}
					}
				}
			}
		}
	}
}
