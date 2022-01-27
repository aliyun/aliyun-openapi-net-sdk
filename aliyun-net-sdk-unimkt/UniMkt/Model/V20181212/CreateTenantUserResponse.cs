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

namespace Aliyun.Acs.UniMkt.Model.V20181212
{
	public class CreateTenantUserResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private string requestId;

		private CreateTenantUser_Model model;

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

		public CreateTenantUser_Model Model
		{
			get
			{
				return model;
			}
			set	
			{
				model = value;
			}
		}

		public class CreateTenantUser_Model
		{

			private long? createTime;

			private long? modifyTime;

			private string tenantId;

			private string tenantName;

			private string business;

			private string userId;

			private string userName;

			private string settleInfo;

			private string extInfo;

			private string status;

			private string originSite;

			private string originSiteUserId;

			private string originSiteUserName;

			private string status1;

			private string extInfo2;

			private string version;

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

			public long? ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public string TenantName
			{
				get
				{
					return tenantName;
				}
				set	
				{
					tenantName = value;
				}
			}

			public string Business
			{
				get
				{
					return business;
				}
				set	
				{
					business = value;
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

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}

			public string SettleInfo
			{
				get
				{
					return settleInfo;
				}
				set	
				{
					settleInfo = value;
				}
			}

			public string ExtInfo
			{
				get
				{
					return extInfo;
				}
				set	
				{
					extInfo = value;
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

			public string OriginSite
			{
				get
				{
					return originSite;
				}
				set	
				{
					originSite = value;
				}
			}

			public string OriginSiteUserId
			{
				get
				{
					return originSiteUserId;
				}
				set	
				{
					originSiteUserId = value;
				}
			}

			public string OriginSiteUserName
			{
				get
				{
					return originSiteUserName;
				}
				set	
				{
					originSiteUserName = value;
				}
			}

			public string Status1
			{
				get
				{
					return status1;
				}
				set	
				{
					status1 = value;
				}
			}

			public string ExtInfo2
			{
				get
				{
					return extInfo2;
				}
				set	
				{
					extInfo2 = value;
				}
			}

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}
		}
	}
}
