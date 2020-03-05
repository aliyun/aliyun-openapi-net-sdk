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
	public class BatchGetEdgeDriverResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private List<BatchGetEdgeDriver_Driver> driverList;

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

		public List<BatchGetEdgeDriver_Driver> DriverList
		{
			get
			{
				return driverList;
			}
			set	
			{
				driverList = value;
			}
		}

		public class BatchGetEdgeDriver_Driver
		{

			private string driverId;

			private string driverName;

			private string driverProtocol;

			private string runtime;

			private string cpuArch;

			private int? type;

			private bool? isBuiltIn;

			private long? gmtCreateTimestamp;

			private long? gmtModifiedTimestamp;

			public string DriverId
			{
				get
				{
					return driverId;
				}
				set	
				{
					driverId = value;
				}
			}

			public string DriverName
			{
				get
				{
					return driverName;
				}
				set	
				{
					driverName = value;
				}
			}

			public string DriverProtocol
			{
				get
				{
					return driverProtocol;
				}
				set	
				{
					driverProtocol = value;
				}
			}

			public string Runtime
			{
				get
				{
					return runtime;
				}
				set	
				{
					runtime = value;
				}
			}

			public string CpuArch
			{
				get
				{
					return cpuArch;
				}
				set	
				{
					cpuArch = value;
				}
			}

			public int? Type
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

			public bool? IsBuiltIn
			{
				get
				{
					return isBuiltIn;
				}
				set	
				{
					isBuiltIn = value;
				}
			}

			public long? GmtCreateTimestamp
			{
				get
				{
					return gmtCreateTimestamp;
				}
				set	
				{
					gmtCreateTimestamp = value;
				}
			}

			public long? GmtModifiedTimestamp
			{
				get
				{
					return gmtModifiedTimestamp;
				}
				set	
				{
					gmtModifiedTimestamp = value;
				}
			}
		}
	}
}
