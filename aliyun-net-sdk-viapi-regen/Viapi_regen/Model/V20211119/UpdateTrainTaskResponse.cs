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
	public class UpdateTrainTaskResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private UpdateTrainTask_Data data;

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

		public UpdateTrainTask_Data Data
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

		public class UpdateTrainTask_Data
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

			private string advancedParameters;

			private string trainStatus;

			private long? modelId;

			private string modelEffect;

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

			public string AdvancedParameters
			{
				get
				{
					return advancedParameters;
				}
				set	
				{
					advancedParameters = value;
				}
			}

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
		}
	}
}
