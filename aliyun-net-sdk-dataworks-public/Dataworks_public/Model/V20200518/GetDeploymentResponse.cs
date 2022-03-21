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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetDeploymentResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string errorMessage;

		private string requestId;

		private string errorCode;

		private bool? success;

		private GetDeployment_Data data;

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public GetDeployment_Data Data
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

		public class GetDeployment_Data
		{

			private GetDeployment_Deployment deployment;

			public GetDeployment_Deployment Deployment
			{
				get
				{
					return deployment;
				}
				set	
				{
					deployment = value;
				}
			}

			public class GetDeployment_Deployment
			{

				private int? status;

				private string errorMessage;

				private int? fromEnvironment;

				private int? toEnvironment;

				private int? checkingStatus;

				private long? createTime;

				private string handlerId;

				private string creatorId;

				private long? executeTime;

				private string name;

				public int? Status
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

				public int? FromEnvironment
				{
					get
					{
						return fromEnvironment;
					}
					set	
					{
						fromEnvironment = value;
					}
				}

				public int? ToEnvironment
				{
					get
					{
						return toEnvironment;
					}
					set	
					{
						toEnvironment = value;
					}
				}

				public int? CheckingStatus
				{
					get
					{
						return checkingStatus;
					}
					set	
					{
						checkingStatus = value;
					}
				}

				public long? CreateTime
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

				public string HandlerId
				{
					get
					{
						return handlerId;
					}
					set	
					{
						handlerId = value;
					}
				}

				public string CreatorId
				{
					get
					{
						return creatorId;
					}
					set	
					{
						creatorId = value;
					}
				}

				public long? ExecuteTime
				{
					get
					{
						return executeTime;
					}
					set	
					{
						executeTime = value;
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
			}
		}
	}
}
