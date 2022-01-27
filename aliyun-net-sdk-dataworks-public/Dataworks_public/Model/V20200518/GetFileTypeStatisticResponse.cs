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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetFileTypeStatisticResponse : AcsResponse
	{

		private string requestId;

		private List<GetFileTypeStatistic_ProgramTypeAndCount> programTypeAndCounts;

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

		public List<GetFileTypeStatistic_ProgramTypeAndCount> ProgramTypeAndCounts
		{
			get
			{
				return programTypeAndCounts;
			}
			set	
			{
				programTypeAndCounts = value;
			}
		}

		public class GetFileTypeStatistic_ProgramTypeAndCount
		{

			private string programType;

			private int? count;

			public string ProgramType
			{
				get
				{
					return programType;
				}
				set	
				{
					programType = value;
				}
			}

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}
		}
	}
}
