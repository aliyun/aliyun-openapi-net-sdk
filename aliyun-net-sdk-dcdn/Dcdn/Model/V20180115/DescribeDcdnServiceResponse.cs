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

namespace Aliyun.Acs.dcdn.Model.V20180115
{
	public class DescribeDcdnServiceResponse : AcsResponse
	{

		private string requestId;

		private string instanceId;

		private string internetChargeType;

		private string openingTime;

		private string changingChargeType;

		private string changingAffectTime;

		private string websocketChangingType;

		private string websocketType;

		private string websocketChangingTime;

		private List<DescribeDcdnService_LockReason> operationLocks;

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

		public string InternetChargeType
		{
			get
			{
				return internetChargeType;
			}
			set	
			{
				internetChargeType = value;
			}
		}

		public string OpeningTime
		{
			get
			{
				return openingTime;
			}
			set	
			{
				openingTime = value;
			}
		}

		public string ChangingChargeType
		{
			get
			{
				return changingChargeType;
			}
			set	
			{
				changingChargeType = value;
			}
		}

		public string ChangingAffectTime
		{
			get
			{
				return changingAffectTime;
			}
			set	
			{
				changingAffectTime = value;
			}
		}

		public string WebsocketChangingType
		{
			get
			{
				return websocketChangingType;
			}
			set	
			{
				websocketChangingType = value;
			}
		}

		public string WebsocketType
		{
			get
			{
				return websocketType;
			}
			set	
			{
				websocketType = value;
			}
		}

		public string WebsocketChangingTime
		{
			get
			{
				return websocketChangingTime;
			}
			set	
			{
				websocketChangingTime = value;
			}
		}

		public List<DescribeDcdnService_LockReason> OperationLocks
		{
			get
			{
				return operationLocks;
			}
			set	
			{
				operationLocks = value;
			}
		}

		public class DescribeDcdnService_LockReason
		{

			private string lockReason;

			public string LockReason
			{
				get
				{
					return lockReason;
				}
				set	
				{
					lockReason = value;
				}
			}
		}
	}
}
