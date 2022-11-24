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

namespace Aliyun.Acs.viapi_regen.Model.V20211119
{
	public class GetTrainTaskResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private GetTrainTask_Data data;

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Data")]
		public GetTrainTask_Data Data
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

		public class GetTrainTask_Data
		{

			private long? id;

			private long? gmtCreate;

			private string taskName;

			private string description;

			private long? datasetId;

			private string datasetName;

			private long? labelId;

			private string labelName;

			private string trainMode;

			private string trainStatus;

			private long? modelId;

			private string modelEffect;

			private string failureReason;

			private long? trainUseTime;

			[JsonProperty(PropertyName = "Id")]
			public long? Id
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

			[JsonProperty(PropertyName = "GmtCreate")]
			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			[JsonProperty(PropertyName = "TaskName")]
			public string TaskName
			{
				get
				{
					return taskName;
				}
				set	
				{
					taskName = value;
				}
			}

			[JsonProperty(PropertyName = "Description")]
			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			[JsonProperty(PropertyName = "DatasetId")]
			public long? DatasetId
			{
				get
				{
					return datasetId;
				}
				set	
				{
					datasetId = value;
				}
			}

			[JsonProperty(PropertyName = "DatasetName")]
			public string DatasetName
			{
				get
				{
					return datasetName;
				}
				set	
				{
					datasetName = value;
				}
			}

			[JsonProperty(PropertyName = "LabelId")]
			public long? LabelId
			{
				get
				{
					return labelId;
				}
				set	
				{
					labelId = value;
				}
			}

			[JsonProperty(PropertyName = "LabelName")]
			public string LabelName
			{
				get
				{
					return labelName;
				}
				set	
				{
					labelName = value;
				}
			}

			[JsonProperty(PropertyName = "TrainMode")]
			public string TrainMode
			{
				get
				{
					return trainMode;
				}
				set	
				{
					trainMode = value;
				}
			}

			[JsonProperty(PropertyName = "TrainStatus")]
			public string TrainStatus
			{
				get
				{
					return trainStatus;
				}
				set	
				{
					trainStatus = value;
				}
			}

			[JsonProperty(PropertyName = "ModelId")]
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

			[JsonProperty(PropertyName = "ModelEffect")]
			public string ModelEffect
			{
				get
				{
					return modelEffect;
				}
				set	
				{
					modelEffect = value;
				}
			}

			[JsonProperty(PropertyName = "FailureReason")]
			public string FailureReason
			{
				get
				{
					return failureReason;
				}
				set	
				{
					failureReason = value;
				}
			}

			[JsonProperty(PropertyName = "TrainUseTime")]
			public long? TrainUseTime
			{
				get
				{
					return trainUseTime;
				}
				set	
				{
					trainUseTime = value;
				}
			}
		}
	}
}
