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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class ModifyInstanceChargeTypeResponse : AcsResponse
	{

		private string orderId;

		private string requestId;

		private List<ModifyInstanceChargeType_FeeOfInstance> feeOfInstances;

		public string OrderId
		{
			get
			{
				return orderId;
			}
			set	
			{
				orderId = value;
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

		public List<ModifyInstanceChargeType_FeeOfInstance> FeeOfInstances
		{
			get
			{
				return feeOfInstances;
			}
			set	
			{
				feeOfInstances = value;
			}
		}

		public class ModifyInstanceChargeType_FeeOfInstance
		{

			private string instanceId;

			private string currency;

			private string fee;

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

			public string Currency
			{
				get
				{
					return currency;
				}
				set	
				{
					currency = value;
				}
			}

			public string Fee
			{
				get
				{
					return fee;
				}
				set	
				{
					fee = value;
				}
			}
		}
	}
}
