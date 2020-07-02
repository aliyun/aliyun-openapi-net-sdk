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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetInstanceResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private int? httpStatusCode;

		private string requestId;

		private bool? success;

		private GetInstance_Data data;

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public GetInstance_Data Data
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

		public class GetInstance_Data
		{

			private long? nodeId;

			private long? instanceId;

			private long? dagId;

			private string dagType;

			private string status;

			private long? bizdate;

			private string paramValues;

			private long? cycTime;

			private long? finishTime;

			private long? beginWaitTimeTime;

			private long? beginWaitResTime;

			private long? beginRunningTime;

			private long? createTime;

			private long? modifyTime;

			private string nodeName;

			public long? NodeId
			{
				get
				{
					return nodeId;
				}
				set	
				{
					nodeId = value;
				}
			}

			public long? InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public long? DagId
			{
				get
				{
					return dagId;
				}
				set	
				{
					dagId = value;
				}
			}

			public string DagType
			{
				get
				{
					return dagType;
				}
				set	
				{
					dagType = value;
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

			public long? Bizdate
			{
				get
				{
					return bizdate;
				}
				set	
				{
					bizdate = value;
				}
			}

			public string ParamValues
			{
				get
				{
					return paramValues;
				}
				set	
				{
					paramValues = value;
				}
			}

			public long? CycTime
			{
				get
				{
					return cycTime;
				}
				set	
				{
					cycTime = value;
				}
			}

			public long? FinishTime
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

			public long? BeginWaitTimeTime
			{
				get
				{
					return beginWaitTimeTime;
				}
				set	
				{
					beginWaitTimeTime = value;
				}
			}

			public long? BeginWaitResTime
			{
				get
				{
					return beginWaitResTime;
				}
				set	
				{
					beginWaitResTime = value;
				}
			}

			public long? BeginRunningTime
			{
				get
				{
					return beginRunningTime;
				}
				set	
				{
					beginRunningTime = value;
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

			public long? ModifyTime
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

			public string NodeName
			{
				get
				{
					return nodeName;
				}
				set	
				{
					nodeName = value;
				}
			}
		}
	}
}
