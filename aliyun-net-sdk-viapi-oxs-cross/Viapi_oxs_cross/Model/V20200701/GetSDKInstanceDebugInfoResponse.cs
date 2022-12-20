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

namespace Aliyun.Acs.viapi_oxs_cross.Model.V20200701
{
	public class GetSDKInstanceDebugInfoResponse : AcsResponse
	{

		private bool? ok;

		private string code;

		private int? httpCode;

		private string errorMessage;

		private string requestId;

		private GetSDKInstanceDebugInfo_Data data;

		public bool? Ok
		{
			get
			{
				return ok;
			}
			set	
			{
				ok = value;
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

		public int? HttpCode
		{
			get
			{
				return httpCode;
			}
			set	
			{
				httpCode = value;
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

		public GetSDKInstanceDebugInfo_Data Data
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

		public class GetSDKInstanceDebugInfo_Data
		{

			private string status;

			private string latestBuild;

			private string validFromDate;

			private string validToDate;

			private string platform;

			private string createdAt;

			private string recipe;

			private string updatedAt;

			private string instanceId;

			private string bundleId;

			private List<GetSDKInstanceDebugInfo__Event> events;

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

			public string LatestBuild
			{
				get
				{
					return latestBuild;
				}
				set	
				{
					latestBuild = value;
				}
			}

			public string ValidFromDate
			{
				get
				{
					return validFromDate;
				}
				set	
				{
					validFromDate = value;
				}
			}

			public string ValidToDate
			{
				get
				{
					return validToDate;
				}
				set	
				{
					validToDate = value;
				}
			}

			public string Platform
			{
				get
				{
					return platform;
				}
				set	
				{
					platform = value;
				}
			}

			public string CreatedAt
			{
				get
				{
					return createdAt;
				}
				set	
				{
					createdAt = value;
				}
			}

			public string Recipe
			{
				get
				{
					return recipe;
				}
				set	
				{
					recipe = value;
				}
			}

			public string UpdatedAt
			{
				get
				{
					return updatedAt;
				}
				set	
				{
					updatedAt = value;
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

			public string BundleId
			{
				get
				{
					return bundleId;
				}
				set	
				{
					bundleId = value;
				}
			}

			public List<GetSDKInstanceDebugInfo__Event> Events
			{
				get
				{
					return events;
				}
				set	
				{
					events = value;
				}
			}

			public class GetSDKInstanceDebugInfo__Event
			{

				private string timeStamp;

				private bool? success;

				private string content;

				private long? id;

				public string TimeStamp
				{
					get
					{
						return timeStamp;
					}
					set	
					{
						timeStamp = value;
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

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}

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
			}
		}
	}
}
