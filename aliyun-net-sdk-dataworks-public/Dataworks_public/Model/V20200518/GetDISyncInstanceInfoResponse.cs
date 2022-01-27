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
	public class GetDISyncInstanceInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private GetDISyncInstanceInfo_Data data;

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

		public GetDISyncInstanceInfo_Data Data
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

		public class GetDISyncInstanceInfo_Data
		{

			private string status;

			private string name;

			private string message;

			private GetDISyncInstanceInfo_SolutionInfo solutionInfo;

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

			public GetDISyncInstanceInfo_SolutionInfo SolutionInfo
			{
				get
				{
					return solutionInfo;
				}
				set	
				{
					solutionInfo = value;
				}
			}

			public class GetDISyncInstanceInfo_SolutionInfo
			{

				private long? id;

				private string status;

				private string creatorName;

				private List<GetDISyncInstanceInfo_StepDetailItem> stepDetail;

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

				public string CreatorName
				{
					get
					{
						return creatorName;
					}
					set	
					{
						creatorName = value;
					}
				}

				public List<GetDISyncInstanceInfo_StepDetailItem> StepDetail
				{
					get
					{
						return stepDetail;
					}
					set	
					{
						stepDetail = value;
					}
				}

				public class GetDISyncInstanceInfo_StepDetailItem
				{

					private string stepName;

					private long? stepId;

					private string status;

					public string StepName
					{
						get
						{
							return stepName;
						}
						set	
						{
							stepName = value;
						}
					}

					public long? StepId
					{
						get
						{
							return stepId;
						}
						set	
						{
							stepId = value;
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
				}
			}
		}
	}
}
