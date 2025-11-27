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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class ListFpShotImportJobResponse : AcsResponse
	{

		private string requestId;

		private List<ListFpShotImportJob_FpShotImportJob> fpShotImportJobList;

		private List<string> nonExistIds;

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

		public List<ListFpShotImportJob_FpShotImportJob> FpShotImportJobList
		{
			get
			{
				return fpShotImportJobList;
			}
			set	
			{
				fpShotImportJobList = value;
			}
		}

		public List<string> NonExistIds
		{
			get
			{
				return nonExistIds;
			}
			set	
			{
				nonExistIds = value;
			}
		}

		public class ListFpShotImportJob_FpShotImportJob
		{

			private string id;

			private string fpDBId;

			private string pipelineId;

			private string fpImportConfig;

			private string status;

			private string code;

			private string message;

			private string createTime;

			private string finishTime;

			private string userData;

			private string input;

			private string processMessage;

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

			public string FpDBId
			{
				get
				{
					return fpDBId;
				}
				set	
				{
					fpDBId = value;
				}
			}

			public string PipelineId
			{
				get
				{
					return pipelineId;
				}
				set	
				{
					pipelineId = value;
				}
			}

			public string FpImportConfig
			{
				get
				{
					return fpImportConfig;
				}
				set	
				{
					fpImportConfig = value;
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

			public string FinishTime
			{
				get
				{
					return finishTime;
				}
				set	
				{
					finishTime = value;
				}
			}

			public string UserData
			{
				get
				{
					return userData;
				}
				set	
				{
					userData = value;
				}
			}

			public string Input
			{
				get
				{
					return input;
				}
				set	
				{
					input = value;
				}
			}

			public string ProcessMessage
			{
				get
				{
					return processMessage;
				}
				set	
				{
					processMessage = value;
				}
			}
		}
	}
}
