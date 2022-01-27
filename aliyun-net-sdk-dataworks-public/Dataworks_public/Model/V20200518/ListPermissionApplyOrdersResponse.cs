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
	public class ListPermissionApplyOrdersResponse : AcsResponse
	{

		private string requestId;

		private ListPermissionApplyOrders_ApplyOrders applyOrders;

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

		public ListPermissionApplyOrders_ApplyOrders ApplyOrders
		{
			get
			{
				return applyOrders;
			}
			set	
			{
				applyOrders = value;
			}
		}

		public class ListPermissionApplyOrders_ApplyOrders
		{

			private int? pageSize;

			private int? pageNumber;

			private int? totalCount;

			private List<ListPermissionApplyOrders_Orders> applyOrder;

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

			public List<ListPermissionApplyOrders_Orders> ApplyOrder
			{
				get
				{
					return applyOrder;
				}
				set	
				{
					applyOrder = value;
				}
			}

			public class ListPermissionApplyOrders_Orders
			{

				private string flowId;

				private string applyBaseId;

				private long? applyTimestamp;

				private int? flowStatus;

				private ListPermissionApplyOrders_ApproveContent approveContent;

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

				public ListPermissionApplyOrders_ApproveContent ApproveContent
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

				public class ListPermissionApplyOrders_ApproveContent
				{

					private string applyReason;

					private int? orderType;

					private ListPermissionApplyOrders_ProjectMeta projectMeta;

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

					public ListPermissionApplyOrders_ProjectMeta ProjectMeta
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

					public class ListPermissionApplyOrders_ProjectMeta
					{

						private string workspaceName;

						private List<ListPermissionApplyOrders_ObjectMetaListItem> objectMetaList;

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

						public List<ListPermissionApplyOrders_ObjectMetaListItem> ObjectMetaList
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

						public class ListPermissionApplyOrders_ObjectMetaListItem
						{

							private string objectName;

							private List<string> actions;

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

							public List<string> Actions
							{
								get
								{
									return actions;
								}
								set	
								{
									actions = value;
								}
							}
						}
					}
				}
			}
		}
	}
}
