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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class ModifyCostUnitResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string code;

		private bool? success;

		private List<ModifyCostUnit_DataItem> data;

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

		public List<ModifyCostUnit_DataItem> Data
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

		public class ModifyCostUnit_DataItem
		{

			private bool? isSuccess;

			private long? unitId;

			private long? ownerUid;

			public bool? IsSuccess
			{
				get
				{
					return isSuccess;
				}
				set	
				{
					isSuccess = value;
				}
			}

			public long? UnitId
			{
				get
				{
					return unitId;
				}
				set	
				{
					unitId = value;
				}
			}

			public long? OwnerUid
			{
				get
				{
					return ownerUid;
				}
				set	
				{
					ownerUid = value;
				}
			}
		}
	}
}
