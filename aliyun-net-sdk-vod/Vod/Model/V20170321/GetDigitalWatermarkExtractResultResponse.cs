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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetDigitalWatermarkExtractResultResponse : AcsResponse
	{

		private string requestId;

		private List<GetDigitalWatermarkExtractResult_AiExtractResult> aiExtractResultList;

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

		public List<GetDigitalWatermarkExtractResult_AiExtractResult> AiExtractResultList
		{
			get
			{
				return aiExtractResultList;
			}
			set	
			{
				aiExtractResultList = value;
			}
		}

		public class GetDigitalWatermarkExtractResult_AiExtractResult
		{

			private string jobId;

			private string createTime;

			private string modifyTime;

			private string status;

			private string errorMessage;

			private string waterMarkText;

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

			public string CreateTime
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

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
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

			public string WaterMarkText
			{
				get
				{
					return waterMarkText;
				}
				set	
				{
					waterMarkText = value;
				}
			}
		}
	}
}
