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
	public class QueryBatchRegisterDeviceStatusResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryBatchRegisterDeviceStatus_Data data;

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

		public QueryBatchRegisterDeviceStatus_Data Data
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

		public class QueryBatchRegisterDeviceStatus_Data
		{

			private string status;

			private List<QueryBatchRegisterDeviceStatus_InvalidDetailListItem> invalidDetailList;

			private List<string> validList;

			private List<string> invalidList;

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

			public List<QueryBatchRegisterDeviceStatus_InvalidDetailListItem> InvalidDetailList
			{
				get
				{
					return invalidDetailList;
				}
				set	
				{
					invalidDetailList = value;
				}
			}

			public List<string> ValidList
			{
				get
				{
					return validList;
				}
				set	
				{
					validList = value;
				}
			}

			public List<string> InvalidList
			{
				get
				{
					return invalidList;
				}
				set	
				{
					invalidList = value;
				}
			}

			public class QueryBatchRegisterDeviceStatus_InvalidDetailListItem
			{

				private string deviceName;

				private string errorMsg;

				private string nickName;

				public string DeviceName
				{
					get
					{
						return deviceName;
					}
					set	
					{
						deviceName = value;
					}
				}

				public string ErrorMsg
				{
					get
					{
						return errorMsg;
					}
					set	
					{
						errorMsg = value;
					}
				}

				public string NickName
				{
					get
					{
						return nickName;
					}
					set	
					{
						nickName = value;
					}
				}
			}
		}
	}
}
