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

namespace Aliyun.Acs.OnsMqtt.Model.V20200420
{
	public class BatchQuerySessionByClientIdsResponse : AcsResponse
	{

		private string requestId;

		private List<BatchQuerySessionByClientIds_OnlineStatusListItem> onlineStatusList;

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

		public List<BatchQuerySessionByClientIds_OnlineStatusListItem> OnlineStatusList
		{
			get
			{
				return onlineStatusList;
			}
			set	
			{
				onlineStatusList = value;
			}
		}

		public class BatchQuerySessionByClientIds_OnlineStatusListItem
		{

			private string clientId;

			private bool? onlineStatus;

			public string ClientId
			{
				get
				{
					return clientId;
				}
				set	
				{
					clientId = value;
				}
			}

			public bool? OnlineStatus
			{
				get
				{
					return onlineStatus;
				}
				set	
				{
					onlineStatus = value;
				}
			}
		}
	}
}
