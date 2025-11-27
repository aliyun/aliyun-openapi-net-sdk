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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class SmartqAuthorizeResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<SmartqAuthorize_Data> result;

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

		public List<SmartqAuthorize_Data> Result
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

		public class SmartqAuthorize_Data
		{

			private string userId;

			private string llmCube;

			private string llmCubeTheme;

			private string detailMessage;

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string LlmCube
			{
				get
				{
					return llmCube;
				}
				set	
				{
					llmCube = value;
				}
			}

			public string LlmCubeTheme
			{
				get
				{
					return llmCubeTheme;
				}
				set	
				{
					llmCubeTheme = value;
				}
			}

			public string DetailMessage
			{
				get
				{
					return detailMessage;
				}
				set	
				{
					detailMessage = value;
				}
			}
		}
	}
}
