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
	public class GetEdgeDriverVersionResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private GetEdgeDriverVersion_Data data;

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

		public GetEdgeDriverVersion_Data Data
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

		public class GetEdgeDriverVersion_Data
		{

			private string driverId;

			private string driverVersion;

			private string versionState;

			private string edgeVersion;

			private string description;

			private string sourceConfig;

			private string driverConfig;

			private string containerConfig;

			private string configCheckRule;

			private long? gmtCreateTimestamp;

			private long? gmtModifiedTimestamp;

			private string argument;

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

			public string DriverVersion
			{
				get
				{
					return driverVersion;
				}
				set	
				{
					driverVersion = value;
				}
			}

			public string VersionState
			{
				get
				{
					return versionState;
				}
				set	
				{
					versionState = value;
				}
			}

			public string EdgeVersion
			{
				get
				{
					return edgeVersion;
				}
				set	
				{
					edgeVersion = value;
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

			public string SourceConfig
			{
				get
				{
					return sourceConfig;
				}
				set	
				{
					sourceConfig = value;
				}
			}

			public string DriverConfig
			{
				get
				{
					return driverConfig;
				}
				set	
				{
					driverConfig = value;
				}
			}

			public string ContainerConfig
			{
				get
				{
					return containerConfig;
				}
				set	
				{
					containerConfig = value;
				}
			}

			public string ConfigCheckRule
			{
				get
				{
					return configCheckRule;
				}
				set	
				{
					configCheckRule = value;
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

			public string Argument
			{
				get
				{
					return argument;
				}
				set	
				{
					argument = value;
				}
			}
		}
	}
}
