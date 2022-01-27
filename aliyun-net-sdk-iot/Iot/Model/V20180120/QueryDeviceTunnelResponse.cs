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
	public class QueryDeviceTunnelResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryDeviceTunnel_Data data;

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

		public QueryDeviceTunnel_Data Data
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

		public class QueryDeviceTunnel_Data
		{

			private string tunnelId;

			private string tunnelState;

			private string productKey;

			private string deviceName;

			private string iotId;

			private string deviceConnState;

			private string sourceConnState;

			private string udi;

			private string description;

			private string utcCreated;

			private string utcClosed;

			private string productName;

			public string TunnelId
			{
				get
				{
					return tunnelId;
				}
				set	
				{
					tunnelId = value;
				}
			}

			public string TunnelState
			{
				get
				{
					return tunnelState;
				}
				set	
				{
					tunnelState = value;
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

			public string IotId
			{
				get
				{
					return iotId;
				}
				set	
				{
					iotId = value;
				}
			}

			public string DeviceConnState
			{
				get
				{
					return deviceConnState;
				}
				set	
				{
					deviceConnState = value;
				}
			}

			public string SourceConnState
			{
				get
				{
					return sourceConnState;
				}
				set	
				{
					sourceConnState = value;
				}
			}

			public string Udi
			{
				get
				{
					return udi;
				}
				set	
				{
					udi = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string UtcCreated
			{
				get
				{
					return utcCreated;
				}
				set	
				{
					utcCreated = value;
				}
			}

			public string UtcClosed
			{
				get
				{
					return utcClosed;
				}
				set	
				{
					utcClosed = value;
				}
			}

			public string ProductName
			{
				get
				{
					return productName;
				}
				set	
				{
					productName = value;
				}
			}
		}
	}
}
