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

namespace Aliyun.Acs.Ims.Model.V20190815
{
	public class GetUserMFAInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? isMFAEnable;

		private GetUserMFAInfo_MFADevice mFADevice;

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

		public bool? IsMFAEnable
		{
			get
			{
				return isMFAEnable;
			}
			set	
			{
				isMFAEnable = value;
			}
		}

		public GetUserMFAInfo_MFADevice MFADevice
		{
			get
			{
				return mFADevice;
			}
			set	
			{
				mFADevice = value;
			}
		}

		public class GetUserMFAInfo_MFADevice
		{

			private string serialNumber;

			private string type;

			public string SerialNumber
			{
				get
				{
					return serialNumber;
				}
				set	
				{
					serialNumber = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}
		}
	}
}
