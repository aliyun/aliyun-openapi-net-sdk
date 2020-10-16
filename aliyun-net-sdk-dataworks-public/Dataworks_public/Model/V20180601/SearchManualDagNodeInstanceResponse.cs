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

namespace Aliyun.Acs.dataworks_public.Model.V20180601
{
	public class SearchManualDagNodeInstanceResponse : AcsResponse
	{

		private string requestId;

		private string errCode;

		private string errMsg;

		private bool? success;

		private List<SearchManualDagNodeInstance_NodeInsInfo> data;

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

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public string ErrMsg
		{
			get
			{
				return errMsg;
			}
			set	
			{
				errMsg = value;
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

		public List<SearchManualDagNodeInstance_NodeInsInfo> Data
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

		public class SearchManualDagNodeInstance_NodeInsInfo
		{

			private long? instanceId;

			private long? dagId;

			private int? dagType;

			private int? status;

			private string bizdate;

			private string paraValue;

			private string finishTime;

			private string beginWaitTimeTime;

			private string beginWaitResTime;

			private string beginRunningTime;

			private string createTime;

			private string modifyTime;

			private string nodeName;

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

			public int? DagType
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

			public int? Status
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

			public string Bizdate
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

			public string ParaValue
			{
				get
				{
					return paraValue;
				}
				set	
				{
					paraValue = value;
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

			public string BeginWaitTimeTime
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

			public string BeginWaitResTime
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

			public string BeginRunningTime
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
