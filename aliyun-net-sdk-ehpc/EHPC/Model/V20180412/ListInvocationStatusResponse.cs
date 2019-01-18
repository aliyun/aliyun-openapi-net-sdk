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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class ListInvocationStatusResponse : AcsResponse
	{

		private string requestId;

		private string commandId;

		private string invokeStatus;

		private List<ListInvocationStatus_InvokeInstance> invokeInstances;

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

		public string CommandId
		{
			get
			{
				return commandId;
			}
			set	
			{
				commandId = value;
			}
		}

		public string InvokeStatus
		{
			get
			{
				return invokeStatus;
			}
			set	
			{
				invokeStatus = value;
			}
		}

		public List<ListInvocationStatus_InvokeInstance> InvokeInstances
		{
			get
			{
				return invokeInstances;
			}
			set	
			{
				invokeInstances = value;
			}
		}

		public class ListInvocationStatus_InvokeInstance
		{

			private string instanceId;

			private string instanceInvokeStatus;

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

			public string InstanceInvokeStatus
			{
				get
				{
					return instanceInvokeStatus;
				}
				set	
				{
					instanceInvokeStatus = value;
				}
			}
		}
	}
}