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

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
	public class GetPipelineInstanceGroupStatusResponse : AcsResponse
	{

		private bool? success;

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private GetPipelineInstanceGroupStatus__Object _object;

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

		public GetPipelineInstanceGroupStatus__Object _Object
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

		public class GetPipelineInstanceGroupStatus__Object
		{

			private string status;

			private List<GetPipelineInstanceGroupStatus_Group> groups;

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

			public List<GetPipelineInstanceGroupStatus_Group> Groups
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

			public class GetPipelineInstanceGroupStatus_Group
			{

				private string name;

				private string status;

				private List<GetPipelineInstanceGroupStatus_Stage> stages;

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

				public List<GetPipelineInstanceGroupStatus_Stage> Stages
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

				public class GetPipelineInstanceGroupStatus_Stage
				{

					private string status;

					private string sign;

					private List<GetPipelineInstanceGroupStatus_Component> components;

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

					public List<GetPipelineInstanceGroupStatus_Component> Components
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

					public class GetPipelineInstanceGroupStatus_Component
					{

						private string name;

						private string status;

						private string jobId;

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

						public string JobId
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
