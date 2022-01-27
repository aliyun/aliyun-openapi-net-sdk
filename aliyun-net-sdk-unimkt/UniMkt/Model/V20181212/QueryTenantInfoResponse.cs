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
	public class QueryTenantInfoResponse : AcsResponse
	{

		private string code;

		private string requestId;

		private bool? success;

		private string message;

		private QueryTenantInfo_Model model;

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

		public QueryTenantInfo_Model Model
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

		public class QueryTenantInfo_Model
		{

			private long? createTime;

			private long? modifyTime;

			private string tenantId;

			private string business;

			private string tenantName;

			private string tenantDescription;

			private string status;

			private string settleInfo;

			private string extInfo;

			private long? version;

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

			public string TenantDescription
			{
				get
				{
					return tenantDescription;
				}
				set	
				{
					tenantDescription = value;
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

			public long? Version
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
