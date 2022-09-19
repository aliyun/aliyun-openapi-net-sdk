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

namespace Aliyun.Acs.viapi_regen.Model.V20211119
{
	public class GetServiceResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private GetService_Data data;

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

		public GetService_Data Data
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

		public class GetService_Data
		{

			private long? id;

			private long? gmtCreate;

			private string serviceName;

			private string serviceDescription;

			private string status;

			private string serviceId;

			private string inputParams;

			private string outputParams;

			private string errorcodes;

			private string inputExample;

			private string outputExample;

			private GetService_DataReflowInfo dataReflowInfo;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}

			public string ServiceDescription
			{
				get
				{
					return serviceDescription;
				}
				set	
				{
					serviceDescription = value;
				}
			}

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

			public string ServiceId
			{
				get
				{
					return serviceId;
				}
				set	
				{
					serviceId = value;
				}
			}

			public string InputParams
			{
				get
				{
					return inputParams;
				}
				set	
				{
					inputParams = value;
				}
			}

			public string OutputParams
			{
				get
				{
					return outputParams;
				}
				set	
				{
					outputParams = value;
				}
			}

			public string Errorcodes
			{
				get
				{
					return errorcodes;
				}
				set	
				{
					errorcodes = value;
				}
			}

			public string InputExample
			{
				get
				{
					return inputExample;
				}
				set	
				{
					inputExample = value;
				}
			}

			public string OutputExample
			{
				get
				{
					return outputExample;
				}
				set	
				{
					outputExample = value;
				}
			}

			public GetService_DataReflowInfo DataReflowInfo
			{
				get
				{
					return dataReflowInfo;
				}
				set	
				{
					dataReflowInfo = value;
				}
			}

			public class GetService_DataReflowInfo
			{

				private long? dataReflowCount;

				private long? dataReflowRate;

				private string dataReflowOssPath;

				private bool? enableDataReflowFlag;

				public long? DataReflowCount
				{
					get
					{
						return dataReflowCount;
					}
					set	
					{
						dataReflowCount = value;
					}
				}

				public long? DataReflowRate
				{
					get
					{
						return dataReflowRate;
					}
					set	
					{
						dataReflowRate = value;
					}
				}

				public string DataReflowOssPath
				{
					get
					{
						return dataReflowOssPath;
					}
					set	
					{
						dataReflowOssPath = value;
					}
				}

				public bool? EnableDataReflowFlag
				{
					get
					{
						return enableDataReflowFlag;
					}
					set	
					{
						enableDataReflowFlag = value;
					}
				}
			}
		}
	}
}
