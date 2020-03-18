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

namespace Aliyun.Acs.Tag.Model.V20180828
{
	public class UntagResourcesResponse : AcsResponse
	{

		private string requestId;

		private List<UntagResources_FailedResource> failedResources;

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

		public List<UntagResources_FailedResource> FailedResources
		{
			get
			{
				return failedResources;
			}
			set	
			{
				failedResources = value;
			}
		}

		public class UntagResources_FailedResource
		{

			private string resourceARN;

			private UntagResources_Result result;

			public string ResourceARN
			{
				get
				{
					return resourceARN;
				}
				set	
				{
					resourceARN = value;
				}
			}

			public UntagResources_Result Result
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

			public class UntagResources_Result
			{

				private string code;

				private string message;

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
			}
		}
	}
}
