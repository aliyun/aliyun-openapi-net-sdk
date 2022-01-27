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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetPermissionApplyOrderDetailResponse : AcsResponse
	{

		private string requestId;

		private GetPermissionApplyOrderDetail_ApplyOrderDetail applyOrderDetail;

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

		public GetPermissionApplyOrderDetail_ApplyOrderDetail ApplyOrderDetail
		{
			get
			{
				return applyOrderDetail;
			}
			set	
			{
				applyOrderDetail = value;
			}
		}

		public class GetPermissionApplyOrderDetail_ApplyOrderDetail
		{

			private string applyBaseId;

			private long? applyTimestamp;

			private string flowId;

			private int? flowStatus;

			private List<GetPermissionApplyOrderDetail_ApproveAccountListItem> approveAccountList;

			private List<GetPermissionApplyOrderDetail_GranteeObjectListItem> granteeObjectList;

			private GetPermissionApplyOrderDetail_ApproveContent approveContent;

			public string ApplyBaseId
			{
				get
				{
					return applyBaseId;
				}
				set	
				{
					applyBaseId = value;
				}
			}

			public long? ApplyTimestamp
			{
				get
				{
					return applyTimestamp;
				}
				set	
				{
					applyTimestamp = value;
				}
			}

			public string FlowId
			{
				get
				{
					return flowId;
				}
				set	
				{
					flowId = value;
				}
			}

			public int? FlowStatus
			{
				get
				{
					return flowStatus;
				}
				set	
				{
					flowStatus = value;
				}
			}

			public List<GetPermissionApplyOrderDetail_ApproveAccountListItem> ApproveAccountList
			{
				get
				{
					return approveAccountList;
				}
				set	
				{
					approveAccountList = value;
				}
			}

			public List<GetPermissionApplyOrderDetail_GranteeObjectListItem> GranteeObjectList
			{
				get
				{
					return granteeObjectList;
				}
				set	
				{
					granteeObjectList = value;
				}
			}

			public GetPermissionApplyOrderDetail_ApproveContent ApproveContent
			{
				get
				{
					return approveContent;
				}
				set	
				{
					approveContent = value;
				}
			}

			public class GetPermissionApplyOrderDetail_ApproveAccountListItem
			{

				private string baseId;

				public string BaseId
				{
					get
					{
						return baseId;
					}
					set	
					{
						baseId = value;
					}
				}
			}

			public class GetPermissionApplyOrderDetail_GranteeObjectListItem
			{

				private string granteeId;

				private string granteeName;

				private int? granteeType;

				private int? granteeTypeSub;

				public string GranteeId
				{
					get
					{
						return granteeId;
					}
					set	
					{
						granteeId = value;
					}
				}

				public string GranteeName
				{
					get
					{
						return granteeName;
					}
					set	
					{
						granteeName = value;
					}
				}

				public int? GranteeType
				{
					get
					{
						return granteeType;
					}
					set	
					{
						granteeType = value;
					}
				}

				public int? GranteeTypeSub
				{
					get
					{
						return granteeTypeSub;
					}
					set	
					{
						granteeTypeSub = value;
					}
				}
			}

			public class GetPermissionApplyOrderDetail_ApproveContent
			{

				private string applyReason;

				private long? deadline;

				private int? orderType;

				private GetPermissionApplyOrderDetail_ProjectMeta projectMeta;

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

				public long? Deadline
				{
					get
					{
						return deadline;
					}
					set	
					{
						deadline = value;
					}
				}

				public int? OrderType
				{
					get
					{
						return orderType;
					}
					set	
					{
						orderType = value;
					}
				}

				public GetPermissionApplyOrderDetail_ProjectMeta ProjectMeta
				{
					get
					{
						return projectMeta;
					}
					set	
					{
						projectMeta = value;
					}
				}

				public class GetPermissionApplyOrderDetail_ProjectMeta
				{

					private int? workspaceId;

					private string maxComputeProjectName;

					private List<GetPermissionApplyOrderDetail_ObjectMetaListItem> objectMetaList;

					public int? WorkspaceId
					{
						get
						{
							return workspaceId;
						}
						set	
						{
							workspaceId = value;
						}
					}

					public string MaxComputeProjectName
					{
						get
						{
							return maxComputeProjectName;
						}
						set	
						{
							maxComputeProjectName = value;
						}
					}

					public List<GetPermissionApplyOrderDetail_ObjectMetaListItem> ObjectMetaList
					{
						get
						{
							return objectMetaList;
						}
						set	
						{
							objectMetaList = value;
						}
					}

					public class GetPermissionApplyOrderDetail_ObjectMetaListItem
					{

						private string objectName;

						private List<GetPermissionApplyOrderDetail_ColumnMetaListItem> columnMetaList;

						public string ObjectName
						{
							get
							{
								return objectName;
							}
							set	
							{
								objectName = value;
							}
						}

						public List<GetPermissionApplyOrderDetail_ColumnMetaListItem> ColumnMetaList
						{
							get
							{
								return columnMetaList;
							}
							set	
							{
								columnMetaList = value;
							}
						}

						public class GetPermissionApplyOrderDetail_ColumnMetaListItem
						{

							private string columnComment;

							private string columnName;

							public string ColumnComment
							{
								get
								{
									return columnComment;
								}
								set	
								{
									columnComment = value;
								}
							}

							public string ColumnName
							{
								get
								{
									return columnName;
								}
								set	
								{
									columnName = value;
								}
							}
						}
					}
				}
			}
		}
	}
}
