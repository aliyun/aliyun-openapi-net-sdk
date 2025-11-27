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

namespace Aliyun.Acs.PaiFeatureStore.Model.V20230621
{
	public class GetTaskResponse : AcsResponse
	{

		private string requestId;

		private string projectId;

		private string projectName;

		private string type;

		private string objectType;

		private string objectId;

		private string status;

		private string config;

		private string runningConfig;

		private string gmtCreateTime;

		private string gmtModifiedTime;

		private string gmtExecutedTime;

		private string gmtFinishedTime;

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

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
			}
		}

		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		public string ObjectType
		{
			get
			{
				return objectType;
			}
			set	
			{
				objectType = value;
			}
		}

		public string ObjectId
		{
			get
			{
				return objectId;
			}
			set	
			{
				objectId = value;
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

		public string Config
		{
			get
			{
				return config;
			}
			set	
			{
				config = value;
			}
		}

		public string RunningConfig
		{
			get
			{
				return runningConfig;
			}
			set	
			{
				runningConfig = value;
			}
		}

		public string GmtCreateTime
		{
			get
			{
				return gmtCreateTime;
			}
			set	
			{
				gmtCreateTime = value;
			}
		}

		public string GmtModifiedTime
		{
			get
			{
				return gmtModifiedTime;
			}
			set	
			{
				gmtModifiedTime = value;
			}
		}

		public string GmtExecutedTime
		{
			get
			{
				return gmtExecutedTime;
			}
			set	
			{
				gmtExecutedTime = value;
			}
		}

		public string GmtFinishedTime
		{
			get
			{
				return gmtFinishedTime;
			}
			set	
			{
				gmtFinishedTime = value;
			}
		}
	}
}
