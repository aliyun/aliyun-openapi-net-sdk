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
	public class ListOwnedJoinPermissionsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private ListOwnedJoinPermissions_Data data;

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

		public ListOwnedJoinPermissions_Data Data
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

		public class ListOwnedJoinPermissions_Data
		{

			private long? totalCount;

			private List<ListOwnedJoinPermissions_JoinPermission> list;

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

			public List<ListOwnedJoinPermissions_JoinPermission> List
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

			public class ListOwnedJoinPermissions_JoinPermission
			{

				private string joinPermissionId;

				private string renterAliyunId;

				private string joinEui;

				private long? freqBandPlanGroupId;

				private string classMode;

				private string authState;

				private bool? enabled;

				private string joinPermissionName;

				private long? rxDelay;

				private long? dataRate;

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

				public long? FreqBandPlanGroupId
				{
					get
					{
						return freqBandPlanGroupId;
					}
					set	
					{
						freqBandPlanGroupId = value;
					}
				}

				public string ClassMode
				{
					get
					{
						return classMode;
					}
					set	
					{
						classMode = value;
					}
				}

				public string AuthState
				{
					get
					{
						return authState;
					}
					set	
					{
						authState = value;
					}
				}

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

				public long? RxDelay
				{
					get
					{
						return rxDelay;
					}
					set	
					{
						rxDelay = value;
					}
				}

				public long? DataRate
				{
					get
					{
						return dataRate;
					}
					set	
					{
						dataRate = value;
					}
				}
			}
		}
	}
}
