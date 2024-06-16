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
	public class GetThingModelStatusInnerResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private int? code;

		private string localizedMsg;

		private GetThingModelStatusInner_Data data;

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

		public string LocalizedMsg
		{
			get
			{
				return localizedMsg;
			}
			set	
			{
				localizedMsg = value;
			}
		}

		public GetThingModelStatusInner_Data Data
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

		public class GetThingModelStatusInner_Data
		{

			private long? modifiedTime;

			private string productKey;

			private string instanceId;

			private string rbacTenantId;

			private int? status;

			private string info;

			private long? outTime;

			public long? ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
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

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string RbacTenantId
			{
				get
				{
					return rbacTenantId;
				}
				set	
				{
					rbacTenantId = value;
				}
			}

			public int? Status
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

			public string Info
			{
				get
				{
					return info;
				}
				set	
				{
					info = value;
				}
			}

			public long? OutTime
			{
				get
				{
					return outTime;
				}
				set	
				{
					outTime = value;
				}
			}
		}
	}
}
