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
	public class PutEventTargetsResponse : AcsResponse
	{

		private bool? success;

		private string code;

		private string message;

		private string requestId;

		private string parameterCount;

		private string failedParameterCount;

		private List<PutEventTargets_ContactParameter> contactParameters;

		private List<PutEventTargets_MnsParameter> mnsParameters;

		private List<PutEventTargets_FcParameter> fcParameters;

		private List<PutEventTargets_ContactParameter> failedContactParameters;

		private List<PutEventTargets_MnsParameter> failedMnsParameters;

		private List<PutEventTargets_FcParameter> failedFcParameters;

		private List<PutEventTargets_FailedSlsParameter> failedSlsParameters;

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

		public string ParameterCount
		{
			get
			{
				return parameterCount;
			}
			set	
			{
				parameterCount = value;
			}
		}

		public string FailedParameterCount
		{
			get
			{
				return failedParameterCount;
			}
			set	
			{
				failedParameterCount = value;
			}
		}

		public List<PutEventTargets_ContactParameter> ContactParameters
		{
			get
			{
				return contactParameters;
			}
			set	
			{
				contactParameters = value;
			}
		}

		public List<PutEventTargets_MnsParameter> MnsParameters
		{
			get
			{
				return mnsParameters;
			}
			set	
			{
				mnsParameters = value;
			}
		}

		public List<PutEventTargets_FcParameter> FcParameters
		{
			get
			{
				return fcParameters;
			}
			set	
			{
				fcParameters = value;
			}
		}

		public List<PutEventTargets_ContactParameter> FailedContactParameters
		{
			get
			{
				return failedContactParameters;
			}
			set	
			{
				failedContactParameters = value;
			}
		}

		public List<PutEventTargets_MnsParameter> FailedMnsParameters
		{
			get
			{
				return failedMnsParameters;
			}
			set	
			{
				failedMnsParameters = value;
			}
		}

		public List<PutEventTargets_FcParameter> FailedFcParameters
		{
			get
			{
				return failedFcParameters;
			}
			set	
			{
				failedFcParameters = value;
			}
		}

		public List<PutEventTargets_FailedSlsParameter> FailedSlsParameters
		{
			get
			{
				return failedSlsParameters;
			}
			set	
			{
				failedSlsParameters = value;
			}
		}

		public class PutEventTargets_ContactParameter
		{

			private int? id;

			private string contactGroupName;

			private string level;

			public int? Id
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

			public string ContactGroupName
			{
				get
				{
					return contactGroupName;
				}
				set	
				{
					contactGroupName = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}
		}

		public class PutEventTargets_MnsParameter
		{

			private int? id;

			private string region;

			private string queue;

			public int? Id
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

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string Queue
			{
				get
				{
					return queue;
				}
				set	
				{
					queue = value;
				}
			}
		}

		public class PutEventTargets_FcParameter
		{

			private int? id;

			private string region;

			private string serviceName;

			private string functionName;

			public int? Id
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

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
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

			public string FunctionName
			{
				get
				{
					return functionName;
				}
				set	
				{
					functionName = value;
				}
			}
		}

		public class PutEventTargets_FailedSlsParameter
		{

			private string id;

			private string region;

			private string project;

			private string logStore;

			public string Id
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

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string Project
			{
				get
				{
					return project;
				}
				set	
				{
					project = value;
				}
			}

			public string LogStore
			{
				get
				{
					return logStore;
				}
				set	
				{
					logStore = value;
				}
			}
		}
	}
}
