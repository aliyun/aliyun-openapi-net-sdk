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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class GetSubAccountInfoResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetSubAccountInfo_Authorization authorization;

		public int? Code
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

		public GetSubAccountInfo_Authorization Authorization
		{
			get
			{
				return authorization;
			}
			set	
			{
				authorization = value;
			}
		}

		public class GetSubAccountInfo_Authorization
		{

			private string adminUserId;

			private string adminEdasId;

			private string userId;

			private string edasId;

			private string appIdData;

			private string roleIdData;

			private long? createTime;

			private long? updateTime;

			private long? resGroupId;

			private string resGroupIdData;

			private bool? isRamSlave;

			private bool? isRamDel;

			private string subUserKp;

			private bool? ramOperation;

			private bool? delegateAdmin;

			private bool? sts;

			public string AdminUserId
			{
				get
				{
					return adminUserId;
				}
				set	
				{
					adminUserId = value;
				}
			}

			public string AdminEdasId
			{
				get
				{
					return adminEdasId;
				}
				set	
				{
					adminEdasId = value;
				}
			}

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

			public string EdasId
			{
				get
				{
					return edasId;
				}
				set	
				{
					edasId = value;
				}
			}

			public string AppIdData
			{
				get
				{
					return appIdData;
				}
				set	
				{
					appIdData = value;
				}
			}

			public string RoleIdData
			{
				get
				{
					return roleIdData;
				}
				set	
				{
					roleIdData = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public long? ResGroupId
			{
				get
				{
					return resGroupId;
				}
				set	
				{
					resGroupId = value;
				}
			}

			public string ResGroupIdData
			{
				get
				{
					return resGroupIdData;
				}
				set	
				{
					resGroupIdData = value;
				}
			}

			public bool? IsRamSlave
			{
				get
				{
					return isRamSlave;
				}
				set	
				{
					isRamSlave = value;
				}
			}

			public bool? IsRamDel
			{
				get
				{
					return isRamDel;
				}
				set	
				{
					isRamDel = value;
				}
			}

			public string SubUserKp
			{
				get
				{
					return subUserKp;
				}
				set	
				{
					subUserKp = value;
				}
			}

			public bool? RamOperation
			{
				get
				{
					return ramOperation;
				}
				set	
				{
					ramOperation = value;
				}
			}

			public bool? DelegateAdmin
			{
				get
				{
					return delegateAdmin;
				}
				set	
				{
					delegateAdmin = value;
				}
			}

			public bool? Sts
			{
				get
				{
					return sts;
				}
				set	
				{
					sts = value;
				}
			}
		}
	}
}
