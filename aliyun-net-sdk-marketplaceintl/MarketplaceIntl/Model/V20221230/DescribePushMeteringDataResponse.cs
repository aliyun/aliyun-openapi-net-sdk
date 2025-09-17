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

namespace Aliyun.Acs.marketplaceIntl.Model.V20221230
{
	public class DescribePushMeteringDataResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private bool? forceFatal;

		private string dynamicMessage;

		private string code;

		private bool? success;

		private DescribePushMeteringData_Result result;

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

		public bool? ForceFatal
		{
			get
			{
				return forceFatal;
			}
			set	
			{
				forceFatal = value;
			}
		}

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
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

		public DescribePushMeteringData_Result Result
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

		public class DescribePushMeteringData_Result
		{

			private long? endTime;

			private string instanceId;

			private bool? isPushBilling;

			private string meteringAssist;

			private string meteringEntity;

			private string pushOrderBizId;

			private long? startTime;

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string InstanceId
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

			public bool? IsPushBilling
			{
				get
				{
					return isPushBilling;
				}
				set	
				{
					isPushBilling = value;
				}
			}

			public string MeteringAssist
			{
				get
				{
					return meteringAssist;
				}
				set	
				{
					meteringAssist = value;
				}
			}

			public string MeteringEntity
			{
				get
				{
					return meteringEntity;
				}
				set	
				{
					meteringEntity = value;
				}
			}

			public string PushOrderBizId
			{
				get
				{
					return pushOrderBizId;
				}
				set	
				{
					pushOrderBizId = value;
				}
			}

			public long? StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}
		}
	}
}
