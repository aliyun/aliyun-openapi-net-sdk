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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeSagWifiResponse : AcsResponse
	{

		private string requestId;

		private string isEnable;

		private string ssid;

		private string isBroadcast;

		private string channel;

		private string bandwidth;

		private string isAuth;

		private string authenticationType;

		private string encryptAlgorithm;

		private List<DescribeSagWifi_TaskState> taskStates;

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

		public string IsEnable
		{
			get
			{
				return isEnable;
			}
			set	
			{
				isEnable = value;
			}
		}

		public string Ssid
		{
			get
			{
				return ssid;
			}
			set	
			{
				ssid = value;
			}
		}

		public string IsBroadcast
		{
			get
			{
				return isBroadcast;
			}
			set	
			{
				isBroadcast = value;
			}
		}

		public string Channel
		{
			get
			{
				return channel;
			}
			set	
			{
				channel = value;
			}
		}

		public string Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
			}
		}

		public string IsAuth
		{
			get
			{
				return isAuth;
			}
			set	
			{
				isAuth = value;
			}
		}

		public string AuthenticationType
		{
			get
			{
				return authenticationType;
			}
			set	
			{
				authenticationType = value;
			}
		}

		public string EncryptAlgorithm
		{
			get
			{
				return encryptAlgorithm;
			}
			set	
			{
				encryptAlgorithm = value;
			}
		}

		public List<DescribeSagWifi_TaskState> TaskStates
		{
			get
			{
				return taskStates;
			}
			set	
			{
				taskStates = value;
			}
		}

		public class DescribeSagWifi_TaskState
		{

			private string state;

			private string errorCode;

			private string errorMessage;

			private string createTime;

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string ErrorCode
			{
				get
				{
					return errorCode;
				}
				set	
				{
					errorCode = value;
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

			public string CreateTime
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
		}
	}
}
