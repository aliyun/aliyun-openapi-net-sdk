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
	public class ListMergeRequestsResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private long? total;

		private List<ListMergeRequests_ResultItem> result;

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

		public long? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<ListMergeRequests_ResultItem> Result
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

		public class ListMergeRequests_ResultItem
		{

			private string acceptedRevision;

			private int? aheadCommitCount;

			private int? behindCommitCount;

			private string createdAt;

			private string description;

			private long? id;

			private string mergeError;

			private string mergeStatus;

			private string mergeType;

			private string mergedRevision;

			private string nameWithNamespace;

			private long? projectId;

			private string sourceBranch;

			private string state;

			private string targetBranch;

			private string title;

			private string updatedAt;

			private string webUrl;

			private bool? isSupportMerge;

			private List<ListMergeRequests_AssigneeListItem> assigneeList;

			private ListMergeRequests_ApproveCheckResult approveCheckResult;

			private ListMergeRequests_Author author;

			public string AcceptedRevision
			{
				get
				{
					return acceptedRevision;
				}
				set	
				{
					acceptedRevision = value;
				}
			}

			public int? AheadCommitCount
			{
				get
				{
					return aheadCommitCount;
				}
				set	
				{
					aheadCommitCount = value;
				}
			}

			public int? BehindCommitCount
			{
				get
				{
					return behindCommitCount;
				}
				set	
				{
					behindCommitCount = value;
				}
			}

			public string CreatedAt
			{
				get
				{
					return createdAt;
				}
				set	
				{
					createdAt = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
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

			public string MergeError
			{
				get
				{
					return mergeError;
				}
				set	
				{
					mergeError = value;
				}
			}

			public string MergeStatus
			{
				get
				{
					return mergeStatus;
				}
				set	
				{
					mergeStatus = value;
				}
			}

			public string MergeType
			{
				get
				{
					return mergeType;
				}
				set	
				{
					mergeType = value;
				}
			}

			public string MergedRevision
			{
				get
				{
					return mergedRevision;
				}
				set	
				{
					mergedRevision = value;
				}
			}

			public string NameWithNamespace
			{
				get
				{
					return nameWithNamespace;
				}
				set	
				{
					nameWithNamespace = value;
				}
			}

			public long? ProjectId
			{
				get
				{
					return projectId;
				}
				set	
				{
					projectId = value;
				}
			}

			public string SourceBranch
			{
				get
				{
					return sourceBranch;
				}
				set	
				{
					sourceBranch = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string TargetBranch
			{
				get
				{
					return targetBranch;
				}
				set	
				{
					targetBranch = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public string UpdatedAt
			{
				get
				{
					return updatedAt;
				}
				set	
				{
					updatedAt = value;
				}
			}

			public string WebUrl
			{
				get
				{
					return webUrl;
				}
				set	
				{
					webUrl = value;
				}
			}

			public bool? IsSupportMerge
			{
				get
				{
					return isSupportMerge;
				}
				set	
				{
					isSupportMerge = value;
				}
			}

			public List<ListMergeRequests_AssigneeListItem> AssigneeList
			{
				get
				{
					return assigneeList;
				}
				set	
				{
					assigneeList = value;
				}
			}

			public ListMergeRequests_ApproveCheckResult ApproveCheckResult
			{
				get
				{
					return approveCheckResult;
				}
				set	
				{
					approveCheckResult = value;
				}
			}

			public ListMergeRequests_Author Author
			{
				get
				{
					return author;
				}
				set	
				{
					author = value;
				}
			}

			public class ListMergeRequests_AssigneeListItem
			{

				private string avatarUrl;

				private string externUserId;

				private string id;

				private string name;

				private string status;

				private string email;

				public string AvatarUrl
				{
					get
					{
						return avatarUrl;
					}
					set	
					{
						avatarUrl = value;
					}
				}

				public string ExternUserId
				{
					get
					{
						return externUserId;
					}
					set	
					{
						externUserId = value;
					}
				}

				public string Id
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

				public string Status
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
			}

			public class ListMergeRequests_ApproveCheckResult
			{

				private string totalCheckResult;

				private List<ListMergeRequests_SatisfiedCheckResultsItem> satisfiedCheckResults;

				private List<ListMergeRequests_UnsatisfiedCheckResultsItem> unsatisfiedCheckResults;

				public string TotalCheckResult
				{
					get
					{
						return totalCheckResult;
					}
					set	
					{
						totalCheckResult = value;
					}
				}

				public List<ListMergeRequests_SatisfiedCheckResultsItem> SatisfiedCheckResults
				{
					get
					{
						return satisfiedCheckResults;
					}
					set	
					{
						satisfiedCheckResults = value;
					}
				}

				public List<ListMergeRequests_UnsatisfiedCheckResultsItem> UnsatisfiedCheckResults
				{
					get
					{
						return unsatisfiedCheckResults;
					}
					set	
					{
						unsatisfiedCheckResults = value;
					}
				}

				public class ListMergeRequests_SatisfiedCheckResultsItem
				{

					private string checkName;

					private string checkStatus;

					private string checkType;

					private List<ListMergeRequests_ExtraUsersItem> extraUsers;

					private List<string> satisfiedItems;

					private List<string> unsatisfiedItems;

					public string CheckName
					{
						get
						{
							return checkName;
						}
						set	
						{
							checkName = value;
						}
					}

					public string CheckStatus
					{
						get
						{
							return checkStatus;
						}
						set	
						{
							checkStatus = value;
						}
					}

					public string CheckType
					{
						get
						{
							return checkType;
						}
						set	
						{
							checkType = value;
						}
					}

					public List<ListMergeRequests_ExtraUsersItem> ExtraUsers
					{
						get
						{
							return extraUsers;
						}
						set	
						{
							extraUsers = value;
						}
					}

					public List<string> SatisfiedItems
					{
						get
						{
							return satisfiedItems;
						}
						set	
						{
							satisfiedItems = value;
						}
					}

					public List<string> UnsatisfiedItems
					{
						get
						{
							return unsatisfiedItems;
						}
						set	
						{
							unsatisfiedItems = value;
						}
					}

					public class ListMergeRequests_ExtraUsersItem
					{

						private string avatarUrl;

						private string externUserId;

						private long? id;

						private string name;

						public string AvatarUrl
						{
							get
							{
								return avatarUrl;
							}
							set	
							{
								avatarUrl = value;
							}
						}

						public string ExternUserId
						{
							get
							{
								return externUserId;
							}
							set	
							{
								externUserId = value;
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

				public class ListMergeRequests_UnsatisfiedCheckResultsItem
				{

					private string checkName;

					private string checkStatus;

					private string checkType;

					private List<ListMergeRequests_ExtraUsersItem4> extraUsers3;

					private List<string> satisfiedItems1;

					private List<string> unsatisfiedItems2;

					public string CheckName
					{
						get
						{
							return checkName;
						}
						set	
						{
							checkName = value;
						}
					}

					public string CheckStatus
					{
						get
						{
							return checkStatus;
						}
						set	
						{
							checkStatus = value;
						}
					}

					public string CheckType
					{
						get
						{
							return checkType;
						}
						set	
						{
							checkType = value;
						}
					}

					public List<ListMergeRequests_ExtraUsersItem4> ExtraUsers3
					{
						get
						{
							return extraUsers3;
						}
						set	
						{
							extraUsers3 = value;
						}
					}

					public List<string> SatisfiedItems1
					{
						get
						{
							return satisfiedItems1;
						}
						set	
						{
							satisfiedItems1 = value;
						}
					}

					public List<string> UnsatisfiedItems2
					{
						get
						{
							return unsatisfiedItems2;
						}
						set	
						{
							unsatisfiedItems2 = value;
						}
					}

					public class ListMergeRequests_ExtraUsersItem4
					{

						private string avatarUrl;

						private string externUserId;

						private long? id;

						private string name;

						public string AvatarUrl
						{
							get
							{
								return avatarUrl;
							}
							set	
							{
								avatarUrl = value;
							}
						}

						public string ExternUserId
						{
							get
							{
								return externUserId;
							}
							set	
							{
								externUserId = value;
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

			public class ListMergeRequests_Author
			{

				private string avatarUrl;

				private string externUserId;

				private long? id;

				private string name;

				public string AvatarUrl
				{
					get
					{
						return avatarUrl;
					}
					set	
					{
						avatarUrl = value;
					}
				}

				public string ExternUserId
				{
					get
					{
						return externUserId;
					}
					set	
					{
						externUserId = value;
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
}
