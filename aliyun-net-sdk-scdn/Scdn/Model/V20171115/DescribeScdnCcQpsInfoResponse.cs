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

namespace Aliyun.Acs.scdn.Model.V20171115
{
	public class DescribeScdnCcQpsInfoResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeScdnCcQpsInfo_TimeScope> timeScopes;

		private List<string> totals;

		private List<string> attacks;

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

		public List<DescribeScdnCcQpsInfo_TimeScope> TimeScopes
		{
			get
			{
				return timeScopes;
			}
			set	
			{
				timeScopes = value;
			}
		}

		public List<string> Totals
		{
			get
			{
				return totals;
			}
			set	
			{
				totals = value;
			}
		}

		public List<string> Attacks
		{
			get
			{
				return attacks;
			}
			set	
			{
				attacks = value;
			}
		}

		public class DescribeScdnCcQpsInfo_TimeScope
		{

			private string interval;

			private string start;

			public string Interval
			{
				get
				{
					return interval;
				}
				set	
				{
					interval = value;
				}
			}

			public string Start
			{
				get
				{
					return start;
				}
				set	
				{
					start = value;
				}
			}
		}
	}
}
