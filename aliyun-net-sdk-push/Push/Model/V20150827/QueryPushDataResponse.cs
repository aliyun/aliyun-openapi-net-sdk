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

namespace Aliyun.Acs.Push.Model.V20150827
{
	public class QueryPushDataResponse : AcsResponse
	{

		private List<BillInfo> pushDataInfos;

		public List<BillInfo> PushDataInfos
		{
			get
			{
				return pushDataInfos;
			}
			set	
			{
				pushDataInfos = value;
			}
		}

		public class BillInfo{

			private string date;

			private int? accepted;

			private int? sent;

			private int? received;

			private int? opened;

			private int? deleted;

			public string Date
			{
				get
				{
					return date;
				}
				set	
				{
					date = value;
				}
			}

			public int? Accepted
			{
				get
				{
					return accepted;
				}
				set	
				{
					accepted = value;
				}
			}

			public int? Sent
			{
				get
				{
					return sent;
				}
				set	
				{
					sent = value;
				}
			}

			public int? Received
			{
				get
				{
					return received;
				}
				set	
				{
					received = value;
				}
			}

			public int? Opened
			{
				get
				{
					return opened;
				}
				set	
				{
					opened = value;
				}
			}

			public int? Deleted
			{
				get
				{
					return deleted;
				}
				set	
				{
					deleted = value;
				}
			}
		}
	}
}