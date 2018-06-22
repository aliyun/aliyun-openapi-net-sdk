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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Model.V20180308
{
	public class ApplyTemplateResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? errorCode;

		private string errorMessage;

		private ApplyTemplate_Resource resource;

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

		public ApplyTemplate_Resource Resource
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

		public class ApplyTemplate_Resource
		{

			private List<ApplyTemplate_AlertResult> createAlertResults;

			public List<ApplyTemplate_AlertResult> CreateAlertResults
			{
				get
				{
					return createAlertResults;
				}
				set	
				{
					createAlertResults = value;
				}
			}

			public class ApplyTemplate_AlertResult
			{

				private string name;

				private string displayName;

				private string metricNamespace;

				private string metricName;

				private string message;

				private string success;

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

				public string MetricNamespace
				{
					get
					{
						return metricNamespace;
					}
					set	
					{
						metricNamespace = value;
					}
				}

				public string MetricName
				{
					get
					{
						return metricName;
					}
					set	
					{
						metricName = value;
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

				public string Success
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