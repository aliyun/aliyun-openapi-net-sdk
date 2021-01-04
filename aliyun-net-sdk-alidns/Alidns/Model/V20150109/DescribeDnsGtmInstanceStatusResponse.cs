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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeDnsGtmInstanceStatusResponse : AcsResponse
	{

		private string requestId;

		private int? addrNotAvailableNum;

		private int? addrPoolGroupNotAvailableNum;

		private int? switchToFailoverStrategyNum;

		private int? strategyNotAvailableNum;

		private int? addrAvailableNum;

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

		public int? AddrNotAvailableNum
		{
			get
			{
				return addrNotAvailableNum;
			}
			set	
			{
				addrNotAvailableNum = value;
			}
		}

		public int? AddrPoolGroupNotAvailableNum
		{
			get
			{
				return addrPoolGroupNotAvailableNum;
			}
			set	
			{
				addrPoolGroupNotAvailableNum = value;
			}
		}

		public int? SwitchToFailoverStrategyNum
		{
			get
			{
				return switchToFailoverStrategyNum;
			}
			set	
			{
				switchToFailoverStrategyNum = value;
			}
		}

		public int? StrategyNotAvailableNum
		{
			get
			{
				return strategyNotAvailableNum;
			}
			set	
			{
				strategyNotAvailableNum = value;
			}
		}

		public int? AddrAvailableNum
		{
			get
			{
				return addrAvailableNum;
			}
			set	
			{
				addrAvailableNum = value;
			}
		}
	}
}
