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

namespace Aliyun.Acs.LinkWAN.Model.V20190301
{
	public class ListNotificationsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private ListNotifications_Data data;

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

		public ListNotifications_Data Data
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

		public class ListNotifications_Data
		{

			private long? totalCount;

			private List<ListNotifications_Notification> list;

			public long? TotalCount
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

			public List<ListNotifications_Notification> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListNotifications_Notification
			{

				private string notificationId;

				private string category;

				private string handleState;

				private long? noticeMillis;

				private long? handledMillis;

				private ListNotifications_GatewayOfflineInfo gatewayOfflineInfo;

				private ListNotifications_JoinPermissionAuthInfo joinPermissionAuthInfo;

				private ListNotifications_GatewayDataflowLimit gatewayDataflowLimit;

				public string NotificationId
				{
					get
					{
						return notificationId;
					}
					set	
					{
						notificationId = value;
					}
				}

				public string Category
				{
					get
					{
						return category;
					}
					set	
					{
						category = value;
					}
				}

				public string HandleState
				{
					get
					{
						return handleState;
					}
					set	
					{
						handleState = value;
					}
				}

				public long? NoticeMillis
				{
					get
					{
						return noticeMillis;
					}
					set	
					{
						noticeMillis = value;
					}
				}

				public long? HandledMillis
				{
					get
					{
						return handledMillis;
					}
					set	
					{
						handledMillis = value;
					}
				}

				public ListNotifications_GatewayOfflineInfo GatewayOfflineInfo
				{
					get
					{
						return gatewayOfflineInfo;
					}
					set	
					{
						gatewayOfflineInfo = value;
					}
				}

				public ListNotifications_JoinPermissionAuthInfo JoinPermissionAuthInfo
				{
					get
					{
						return joinPermissionAuthInfo;
					}
					set	
					{
						joinPermissionAuthInfo = value;
					}
				}

				public ListNotifications_GatewayDataflowLimit GatewayDataflowLimit
				{
					get
					{
						return gatewayDataflowLimit;
					}
					set	
					{
						gatewayDataflowLimit = value;
					}
				}

				public class ListNotifications_GatewayOfflineInfo
				{

					private string gwEui;

					private long? offlineMillis;

					public string GwEui
					{
						get
						{
							return gwEui;
						}
						set	
						{
							gwEui = value;
						}
					}

					public long? OfflineMillis
					{
						get
						{
							return offlineMillis;
						}
						set	
						{
							offlineMillis = value;
						}
					}
				}

				public class ListNotifications_JoinPermissionAuthInfo
				{

					private string orderId;

					private string joinPermissionId;

					private string ownerAliyunId;

					private string renterAliyunId;

					private string orderState;

					private long? applyingMillis;

					private long? acceptedMillis;

					private long? canceledMillis;

					private long? rejectedMillis;

					private string joinEui;

					private string joinPermissionName;

					public string OrderId
					{
						get
						{
							return orderId;
						}
						set	
						{
							orderId = value;
						}
					}

					public string JoinPermissionId
					{
						get
						{
							return joinPermissionId;
						}
						set	
						{
							joinPermissionId = value;
						}
					}

					public string OwnerAliyunId
					{
						get
						{
							return ownerAliyunId;
						}
						set	
						{
							ownerAliyunId = value;
						}
					}

					public string RenterAliyunId
					{
						get
						{
							return renterAliyunId;
						}
						set	
						{
							renterAliyunId = value;
						}
					}

					public string OrderState
					{
						get
						{
							return orderState;
						}
						set	
						{
							orderState = value;
						}
					}

					public long? ApplyingMillis
					{
						get
						{
							return applyingMillis;
						}
						set	
						{
							applyingMillis = value;
						}
					}

					public long? AcceptedMillis
					{
						get
						{
							return acceptedMillis;
						}
						set	
						{
							acceptedMillis = value;
						}
					}

					public long? CanceledMillis
					{
						get
						{
							return canceledMillis;
						}
						set	
						{
							canceledMillis = value;
						}
					}

					public long? RejectedMillis
					{
						get
						{
							return rejectedMillis;
						}
						set	
						{
							rejectedMillis = value;
						}
					}

					public string JoinEui
					{
						get
						{
							return joinEui;
						}
						set	
						{
							joinEui = value;
						}
					}

					public string JoinPermissionName
					{
						get
						{
							return joinPermissionName;
						}
						set	
						{
							joinPermissionName = value;
						}
					}
				}

				public class ListNotifications_GatewayDataflowLimit
				{

					private long? dataflowLimitMillis;

					private string alarmDetail;

					private string gwEui;

					public long? DataflowLimitMillis
					{
						get
						{
							return dataflowLimitMillis;
						}
						set	
						{
							dataflowLimitMillis = value;
						}
					}

					public string AlarmDetail
					{
						get
						{
							return alarmDetail;
						}
						set	
						{
							alarmDetail = value;
						}
					}

					public string GwEui
					{
						get
						{
							return gwEui;
						}
						set	
						{
							gwEui = value;
						}
					}
				}
			}
		}
	}
}
