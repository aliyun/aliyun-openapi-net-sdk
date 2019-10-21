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

namespace Aliyun.Acs.iqa.Model.V20190813
{
	public class DescribeProjectResponse : AcsResponse
	{

		private string requestId;

		private string projectType;

		private string projectId;

		private string projectName;

		private long? createTime;

		private long? deployTime;

		private string modelId;

		private string modelName;

		private int? questionCount;

		private string dataStatus;

		private string testServiceStatus;

		private string onlineServiceStatus;

		private string deployAvailable;

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

		public string ProjectType
		{
			get
			{
				return projectType;
			}
			set	
			{
				projectType = value;
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

		public long? DeployTime
		{
			get
			{
				return deployTime;
			}
			set	
			{
				deployTime = value;
			}
		}

		public string ModelId
		{
			get
			{
				return modelId;
			}
			set	
			{
				modelId = value;
			}
		}

		public string ModelName
		{
			get
			{
				return modelName;
			}
			set	
			{
				modelName = value;
			}
		}

		public int? QuestionCount
		{
			get
			{
				return questionCount;
			}
			set	
			{
				questionCount = value;
			}
		}

		public string DataStatus
		{
			get
			{
				return dataStatus;
			}
			set	
			{
				dataStatus = value;
			}
		}

		public string TestServiceStatus
		{
			get
			{
				return testServiceStatus;
			}
			set	
			{
				testServiceStatus = value;
			}
		}

		public string OnlineServiceStatus
		{
			get
			{
				return onlineServiceStatus;
			}
			set	
			{
				onlineServiceStatus = value;
			}
		}

		public string DeployAvailable
		{
			get
			{
				return deployAvailable;
			}
			set	
			{
				deployAvailable = value;
			}
		}
	}
}
