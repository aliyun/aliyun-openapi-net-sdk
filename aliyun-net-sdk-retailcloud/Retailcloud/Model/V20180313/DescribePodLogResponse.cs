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

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
	public class DescribePodLogResponse : AcsResponse
	{

		private int? code;

		private string errMsg;

		private string requestId;

		private bool? success;

		private DescribePodLog_Result result;

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

		public string ErrMsg
		{
			get
			{
				return errMsg;
			}
			set	
			{
				errMsg = value;
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

		public DescribePodLog_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribePodLog_Result
		{

			private string deployOrderName;

			private string envTypeName;

			private List<DescribePodLog_DeployLogStepRC> deployStepList;

			public string DeployOrderName
			{
				get
				{
					return deployOrderName;
				}
				set	
				{
					deployOrderName = value;
				}
			}

			public string EnvTypeName
			{
				get
				{
					return envTypeName;
				}
				set	
				{
					envTypeName = value;
				}
			}

			public List<DescribePodLog_DeployLogStepRC> DeployStepList
			{
				get
				{
					return deployStepList;
				}
				set	
				{
					deployStepList = value;
				}
			}

			public class DescribePodLog_DeployLogStepRC
			{

				private string stepName;

				private string stepCode;

				private string stepLog;

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

				public string StepCode
				{
					get
					{
						return stepCode;
					}
					set	
					{
						stepCode = value;
					}
				}

				public string StepLog
				{
					get
					{
						return stepLog;
					}
					set	
					{
						stepLog = value;
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
