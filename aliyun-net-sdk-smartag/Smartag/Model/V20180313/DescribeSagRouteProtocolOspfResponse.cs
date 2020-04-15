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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeSagRouteProtocolOspfResponse : AcsResponse
	{

		private string requestId;

		private string routerId;

		private string areaId;

		private string areaType;

		private int? deadTime;

		private int? helloTime;

		private string authenticationType;

		private int? md5KeyId;

		private string md5Key;

		private List<DescribeSagRouteProtocolOspf_TaskState> taskStates;

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

		public string RouterId
		{
			get
			{
				return routerId;
			}
			set	
			{
				routerId = value;
			}
		}

		public string AreaId
		{
			get
			{
				return areaId;
			}
			set	
			{
				areaId = value;
			}
		}

		public string AreaType
		{
			get
			{
				return areaType;
			}
			set	
			{
				areaType = value;
			}
		}

		public int? DeadTime
		{
			get
			{
				return deadTime;
			}
			set	
			{
				deadTime = value;
			}
		}

		public int? HelloTime
		{
			get
			{
				return helloTime;
			}
			set	
			{
				helloTime = value;
			}
		}

		public string AuthenticationType
		{
			get
			{
				return authenticationType;
			}
			set	
			{
				authenticationType = value;
			}
		}

		public int? Md5KeyId
		{
			get
			{
				return md5KeyId;
			}
			set	
			{
				md5KeyId = value;
			}
		}

		public string Md5Key
		{
			get
			{
				return md5Key;
			}
			set	
			{
				md5Key = value;
			}
		}

		public List<DescribeSagRouteProtocolOspf_TaskState> TaskStates
		{
			get
			{
				return taskStates;
			}
			set	
			{
				taskStates = value;
			}
		}

		public class DescribeSagRouteProtocolOspf_TaskState
		{

			private string state;

			private string errorCode;

			private string errorMessage;

			private string createTime;

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
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
		}
	}
}
