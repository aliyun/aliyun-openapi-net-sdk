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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeScreenHostStatisticsResponse : AcsResponse
	{

		private string requestId;

		private DescribeScreenHostStatistics_Data data;

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

		public DescribeScreenHostStatistics_Data Data
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

		public class DescribeScreenHostStatistics_Data
		{

			private List<string> weaknessUuids;

			private List<string> suspEventUuids;

			private List<string> suspEventMachineNames;

			private List<string> weaknessMachineNames;

			public List<string> WeaknessUuids
			{
				get
				{
					return weaknessUuids;
				}
				set	
				{
					weaknessUuids = value;
				}
			}

			public List<string> SuspEventUuids
			{
				get
				{
					return suspEventUuids;
				}
				set	
				{
					suspEventUuids = value;
				}
			}

			public List<string> SuspEventMachineNames
			{
				get
				{
					return suspEventMachineNames;
				}
				set	
				{
					suspEventMachineNames = value;
				}
			}

			public List<string> WeaknessMachineNames
			{
				get
				{
					return weaknessMachineNames;
				}
				set	
				{
					weaknessMachineNames = value;
				}
			}
		}
	}
}
