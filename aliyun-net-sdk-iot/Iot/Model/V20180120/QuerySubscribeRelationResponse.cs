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
	public class QuerySubscribeRelationResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private string productKey;

		private string type;

		private bool? deviceDataFlag;

		private bool? deviceLifeCycleFlag;

		private bool? deviceStatusChangeFlag;

		private bool? deviceTopoLifeCycleFlag;

		private bool? foundDeviceListFlag;

		private bool? otaEventFlag;

		private bool? thingHistoryFlag;

		private string mnsConfiguration;

		private bool? deviceTagFlag;

		private bool? otaVersionFlag;

		private bool? otaJobFlag;

		private List<string> consumerGroupIds;

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

		public bool? DeviceDataFlag
		{
			get
			{
				return deviceDataFlag;
			}
			set	
			{
				deviceDataFlag = value;
			}
		}

		public bool? DeviceLifeCycleFlag
		{
			get
			{
				return deviceLifeCycleFlag;
			}
			set	
			{
				deviceLifeCycleFlag = value;
			}
		}

		public bool? DeviceStatusChangeFlag
		{
			get
			{
				return deviceStatusChangeFlag;
			}
			set	
			{
				deviceStatusChangeFlag = value;
			}
		}

		public bool? DeviceTopoLifeCycleFlag
		{
			get
			{
				return deviceTopoLifeCycleFlag;
			}
			set	
			{
				deviceTopoLifeCycleFlag = value;
			}
		}

		public bool? FoundDeviceListFlag
		{
			get
			{
				return foundDeviceListFlag;
			}
			set	
			{
				foundDeviceListFlag = value;
			}
		}

		public bool? OtaEventFlag
		{
			get
			{
				return otaEventFlag;
			}
			set	
			{
				otaEventFlag = value;
			}
		}

		public bool? ThingHistoryFlag
		{
			get
			{
				return thingHistoryFlag;
			}
			set	
			{
				thingHistoryFlag = value;
			}
		}

		public string MnsConfiguration
		{
			get
			{
				return mnsConfiguration;
			}
			set	
			{
				mnsConfiguration = value;
			}
		}

		public bool? DeviceTagFlag
		{
			get
			{
				return deviceTagFlag;
			}
			set	
			{
				deviceTagFlag = value;
			}
		}

		public bool? OtaVersionFlag
		{
			get
			{
				return otaVersionFlag;
			}
			set	
			{
				otaVersionFlag = value;
			}
		}

		public bool? OtaJobFlag
		{
			get
			{
				return otaJobFlag;
			}
			set	
			{
				otaJobFlag = value;
			}
		}

		public List<string> ConsumerGroupIds
		{
			get
			{
				return consumerGroupIds;
			}
			set	
			{
				consumerGroupIds = value;
			}
		}
	}
}
