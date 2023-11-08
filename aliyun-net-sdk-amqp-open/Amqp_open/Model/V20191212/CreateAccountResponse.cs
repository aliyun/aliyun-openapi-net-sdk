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

namespace Aliyun.Acs.amqp_open.Model.V20191212
{
	public class CreateAccountResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private bool? success;

		private CreateAccount_Data data;

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

		public CreateAccount_Data Data
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

		public class CreateAccount_Data
		{

			private string accessKey;

			private string password;

			private long? createTimeStamp;

			private string instanceId;

			private long? masterUId;

			private string userName;

			public string AccessKey
			{
				get
				{
					return accessKey;
				}
				set	
				{
					accessKey = value;
				}
			}

			public string Password
			{
				get
				{
					return password;
				}
				set	
				{
					password = value;
				}
			}

			public long? CreateTimeStamp
			{
				get
				{
					return createTimeStamp;
				}
				set	
				{
					createTimeStamp = value;
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

			public long? MasterUId
			{
				get
				{
					return masterUId;
				}
				set	
				{
					masterUId = value;
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
		}
	}
}
