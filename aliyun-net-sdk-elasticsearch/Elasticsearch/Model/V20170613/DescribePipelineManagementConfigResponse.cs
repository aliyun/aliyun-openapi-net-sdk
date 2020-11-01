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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class DescribePipelineManagementConfigResponse : AcsResponse
	{

		private string requestId;

		private DescribePipelineManagementConfig_Result result;

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

		public DescribePipelineManagementConfig_Result Result
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

		public class DescribePipelineManagementConfig_Result
		{

			private string pipelineManagementType;

			private string endpoints;

			private string userName;

			private string esInstanceId;

			private List<string> pipelineIds;

			public string PipelineManagementType
			{
				get
				{
					return pipelineManagementType;
				}
				set	
				{
					pipelineManagementType = value;
				}
			}

			public string Endpoints
			{
				get
				{
					return endpoints;
				}
				set	
				{
					endpoints = value;
				}
			}

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}

			public string EsInstanceId
			{
				get
				{
					return esInstanceId;
				}
				set	
				{
					esInstanceId = value;
				}
			}

			public List<string> PipelineIds
			{
				get
				{
					return pipelineIds;
				}
				set	
				{
					pipelineIds = value;
				}
			}
		}
	}
}
