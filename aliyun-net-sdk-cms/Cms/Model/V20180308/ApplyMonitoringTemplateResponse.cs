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

namespace Aliyun.Acs.Cms.Model.V20180308
{
	public class ApplyMonitoringTemplateResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? errorCode;

		private string errorMessage;

		private ApplyMonitoringTemplate_Resource resource;

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

		public int? ErrorCode
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

		public ApplyMonitoringTemplate_Resource Resource
		{
			get
			{
				return resource;
			}
			set	
			{
				resource = value;
			}
		}

		public class ApplyMonitoringTemplate_Resource
		{

			private long? groupId;

			private List<ApplyMonitoringTemplate_Result> eventResults;

			private List<ApplyMonitoringTemplate_Result> alertResults;

			public long? GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public List<ApplyMonitoringTemplate_Result> EventResults
			{
				get
				{
					return eventResults;
				}
				set	
				{
					eventResults = value;
				}
			}

			public List<ApplyMonitoringTemplate_Result> AlertResults
			{
				get
				{
					return alertResults;
				}
				set	
				{
					alertResults = value;
				}
			}

			public class ApplyMonitoringTemplate_Result
			{

				private long? groupId;

				private string name;

				private string message;

				private string displayName;

				private int? code;

				private bool? success;

				public long? GroupId
				{
					get
					{
						return groupId;
					}
					set	
					{
						groupId = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
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

				public string DisplayName
				{
					get
					{
						return displayName;
					}
					set	
					{
						displayName = value;
					}
				}

				public int? Code
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
			}
		}
	}
}
