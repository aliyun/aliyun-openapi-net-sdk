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

namespace Aliyun.Acs.jarvis_public.Model.V20180621
{
	public class DescribeAttackEventResponse : AcsResponse
	{

		private string requestId;

		private string module;

		private List<DescribeAttackEvent__Event> eventList;

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

		public string Module
		{
			get
			{
				return module;
			}
			set	
			{
				module = value;
			}
		}

		public List<DescribeAttackEvent__Event> EventList
		{
			get
			{
				return eventList;
			}
			set	
			{
				eventList = value;
			}
		}

		public class DescribeAttackEvent__Event
		{

			private string vmIp;

			private string sourceIp;

			private string url;

			private string attackType;

			private string gmtCreate;

			private int? gmtCreateStamp;

			private string gmtModified;

			public string VmIp
			{
				get
				{
					return vmIp;
				}
				set	
				{
					vmIp = value;
				}
			}

			public string SourceIp
			{
				get
				{
					return sourceIp;
				}
				set	
				{
					sourceIp = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public string AttackType
			{
				get
				{
					return attackType;
				}
				set	
				{
					attackType = value;
				}
			}

			public string GmtCreate
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

			public int? GmtCreateStamp
			{
				get
				{
					return gmtCreateStamp;
				}
				set	
				{
					gmtCreateStamp = value;
				}
			}

			public string GmtModified
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
		}
	}
}
