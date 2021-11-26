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

namespace Aliyun.Acs.Qualitycheck.Model.V20190115
{
	public class GetCustomizationConfigListResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private List<GetCustomizationConfigList_ModelCustomizationDataSetPo> data;

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

		public List<GetCustomizationConfigList_ModelCustomizationDataSetPo> Data
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

		public class GetCustomizationConfigList_ModelCustomizationDataSetPo
		{

			private int? taskType;

			private string createTime;

			private int? modelStatus;

			private string modelName;

			private long? modelId;

			private string modeCustomizationId;

			public int? TaskType
			{
				get
				{
					return taskType;
				}
				set	
				{
					taskType = value;
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

			public int? ModelStatus
			{
				get
				{
					return modelStatus;
				}
				set	
				{
					modelStatus = value;
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

			public long? ModelId
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

			public string ModeCustomizationId
			{
				get
				{
					return modeCustomizationId;
				}
				set	
				{
					modeCustomizationId = value;
				}
			}
		}
	}
}
