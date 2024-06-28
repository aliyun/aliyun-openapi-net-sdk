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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class QueryApprovalInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private QueryApprovalInfo_Result result;

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

		public QueryApprovalInfo_Result Result
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

		public class QueryApprovalInfo_Result
		{

			private int? total;

			private int? totalPages;

			private int? start;

			private int? pageSize;

			private int? page;

			private List<QueryApprovalInfo_ApprovalsResultModel> data;

			public int? Total
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

			public int? TotalPages
			{
				get
				{
					return totalPages;
				}
				set	
				{
					totalPages = value;
				}
			}

			public int? Start
			{
				get
				{
					return start;
				}
				set	
				{
					start = value;
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

			public int? Page
			{
				get
				{
					return page;
				}
				set	
				{
					page = value;
				}
			}

			public List<QueryApprovalInfo_ApprovalsResultModel> Data
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

			public class QueryApprovalInfo_ApprovalsResultModel
			{

				private string workspaceName;

				private string applicationId;

				private string applicantId;

				private string applicantName;

				private string approverId;

				private string approverName;

				private string resourceId;

				private string resourceName;

				private string resourceType;

				private string applyReason;

				private string handleReason;

				private long? expireDate;

				private long? gmtCreate;

				private long? gmtModified;

				private int? flagStatus;

				private bool? deleteFlag;

				public string WorkspaceName
				{
					get
					{
						return workspaceName;
					}
					set	
					{
						workspaceName = value;
					}
				}

				public string ApplicationId
				{
					get
					{
						return applicationId;
					}
					set	
					{
						applicationId = value;
					}
				}

				public string ApplicantId
				{
					get
					{
						return applicantId;
					}
					set	
					{
						applicantId = value;
					}
				}

				public string ApplicantName
				{
					get
					{
						return applicantName;
					}
					set	
					{
						applicantName = value;
					}
				}

				public string ApproverId
				{
					get
					{
						return approverId;
					}
					set	
					{
						approverId = value;
					}
				}

				public string ApproverName
				{
					get
					{
						return approverName;
					}
					set	
					{
						approverName = value;
					}
				}

				public string ResourceId
				{
					get
					{
						return resourceId;
					}
					set	
					{
						resourceId = value;
					}
				}

				public string ResourceName
				{
					get
					{
						return resourceName;
					}
					set	
					{
						resourceName = value;
					}
				}

				public string ResourceType
				{
					get
					{
						return resourceType;
					}
					set	
					{
						resourceType = value;
					}
				}

				public string ApplyReason
				{
					get
					{
						return applyReason;
					}
					set	
					{
						applyReason = value;
					}
				}

				public string HandleReason
				{
					get
					{
						return handleReason;
					}
					set	
					{
						handleReason = value;
					}
				}

				public long? ExpireDate
				{
					get
					{
						return expireDate;
					}
					set	
					{
						expireDate = value;
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

				public int? FlagStatus
				{
					get
					{
						return flagStatus;
					}
					set	
					{
						flagStatus = value;
					}
				}

				public bool? DeleteFlag
				{
					get
					{
						return deleteFlag;
					}
					set	
					{
						deleteFlag = value;
					}
				}
			}
		}
	}
}
