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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QueryLoRaJoinPermissionsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private string productKey;

		private List<QueryLoRaJoinPermissions_JoinPermission> joinPermissions;

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

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
			}
		}

		public List<QueryLoRaJoinPermissions_JoinPermission> JoinPermissions
		{
			get
			{
				return joinPermissions;
			}
			set	
			{
				joinPermissions = value;
			}
		}

		public class QueryLoRaJoinPermissions_JoinPermission
		{

			private string joinPermissionId;

			private string joinPermissionName;

			private string joinPermissionType;

			private string ownerAliyunPk;

			private bool? enabled;

			private string classMode;

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

			public string JoinPermissionType
			{
				get
				{
					return joinPermissionType;
				}
				set	
				{
					joinPermissionType = value;
				}
			}

			public string OwnerAliyunPk
			{
				get
				{
					return ownerAliyunPk;
				}
				set	
				{
					ownerAliyunPk = value;
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
		}
	}
}
