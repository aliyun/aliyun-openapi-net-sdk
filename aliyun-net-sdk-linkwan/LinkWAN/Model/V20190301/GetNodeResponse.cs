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

namespace Aliyun.Acs.LinkWAN.Model.V20190301
{
	public class GetNodeResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private GetNode_Data data;

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

		public GetNode_Data Data
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

		public class GetNode_Data
		{

			private string devEui;

			private string devAddr;

			private string classMode;

			private long? lastJoinMillis;

			private long? boundMillis;

			private string authTypes;

			public string DevEui
			{
				get
				{
					return devEui;
				}
				set	
				{
					devEui = value;
				}
			}

			public string DevAddr
			{
				get
				{
					return devAddr;
				}
				set	
				{
					devAddr = value;
				}
			}

			public string ClassMode
			{
				get
				{
					return classMode;
				}
				set	
				{
					classMode = value;
				}
			}

			public long? LastJoinMillis
			{
				get
				{
					return lastJoinMillis;
				}
				set	
				{
					lastJoinMillis = value;
				}
			}

			public long? BoundMillis
			{
				get
				{
					return boundMillis;
				}
				set	
				{
					boundMillis = value;
				}
			}

			public string AuthTypes
			{
				get
				{
					return authTypes;
				}
				set	
				{
					authTypes = value;
				}
			}
		}
	}
}
