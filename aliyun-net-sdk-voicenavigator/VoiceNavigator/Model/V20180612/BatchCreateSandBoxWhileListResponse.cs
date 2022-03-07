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

namespace Aliyun.Acs.VoiceNavigator.Model.V20180612
{
	public class BatchCreateSandBoxWhileListResponse : AcsResponse
	{

		private string requestId;

		private bool? repeat;

		private List<BatchCreateSandBoxWhileList_WhiteListItem> whiteList;

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

		public bool? Repeat
		{
			get
			{
				return repeat;
			}
			set	
			{
				repeat = value;
			}
		}

		public List<BatchCreateSandBoxWhileList_WhiteListItem> WhiteList
		{
			get
			{
				return whiteList;
			}
			set	
			{
				whiteList = value;
			}
		}

		public class BatchCreateSandBoxWhileList_WhiteListItem
		{

			private string uuid;

			private string phoneNumber;

			private string description;

			private int? isEnable;

			private long? gmtCreate;

			private string instanceId;

			private long? gmtModified;

			private string name;

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public string PhoneNumber
			{
				get
				{
					return phoneNumber;
				}
				set	
				{
					phoneNumber = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public int? IsEnable
			{
				get
				{
					return isEnable;
				}
				set	
				{
					isEnable = value;
				}
			}

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
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

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}
		}
	}
}
