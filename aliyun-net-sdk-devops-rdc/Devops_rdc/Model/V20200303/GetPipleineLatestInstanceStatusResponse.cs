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

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
	public class GetPipleineLatestInstanceStatusResponse : AcsResponse
	{

		private string requestId;

		private string errorMessage;

		private bool? success;

		private string errorCode;

		private GetPipleineLatestInstanceStatus__Object _object;

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

		public GetPipleineLatestInstanceStatus__Object _Object
		{
			get
			{
				return _object;
			}
			set	
			{
				_object = value;
			}
		}

		public class GetPipleineLatestInstanceStatus__Object
		{

			private string status;

			private List<GetPipleineLatestInstanceStatus_Group> groups;

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

			public List<GetPipleineLatestInstanceStatus_Group> Groups
			{
				get
				{
					return groups;
				}
				set	
				{
					groups = value;
				}
			}

			public class GetPipleineLatestInstanceStatus_Group
			{

				private string status;

				private string name;

				private List<GetPipleineLatestInstanceStatus_Stage> stages;

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

				public List<GetPipleineLatestInstanceStatus_Stage> Stages
				{
					get
					{
						return stages;
					}
					set	
					{
						stages = value;
					}
				}

				public class GetPipleineLatestInstanceStatus_Stage
				{

					private string status;

					private string sign;

					private List<GetPipleineLatestInstanceStatus_Component> components;

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

					public string Sign
					{
						get
						{
							return sign;
						}
						set	
						{
							sign = value;
						}
					}

					public List<GetPipleineLatestInstanceStatus_Component> Components
					{
						get
						{
							return components;
						}
						set	
						{
							components = value;
						}
					}

					public class GetPipleineLatestInstanceStatus_Component
					{

						private string status;

						private string name;

						private long? jobId;

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

						public long? JobId
						{
							get
							{
								return jobId;
							}
							set	
							{
								jobId = value;
							}
						}
					}
				}
			}
		}
	}
}
