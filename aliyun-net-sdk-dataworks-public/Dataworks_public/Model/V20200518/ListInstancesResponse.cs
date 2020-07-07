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
	public class ListInstancesResponse : AcsResponse
	{

		private bool? success;

		private int? httpStatusCode;

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private ListInstances_Data data;

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

		public ListInstances_Data Data
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

		public class ListInstances_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListInstances_Instance> instances;

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
				}
			}

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public int? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public List<ListInstances_Instance> Instances
			{
				get
				{
					return instances;
				}
				set	
				{
					instances = value;
				}
			}

			public class ListInstances_Instance
			{

				private int? nodeId;

				private long? instanceId;

				private int? dagId;

				private string dagType;

				private string status;

				private long? bizdate;

				private long? cycTime;

				private long? createTime;

				private long? modifyTime;

				private string nodeName;

				private long? beginWaitTimeTime;

				private long? beginWaitResTime;

				private long? beginRunningTime;

				private string paramValues;

				private long? finishTime;

				public int? NodeId
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

				public int? DagId
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
			}
		}
	}
}
