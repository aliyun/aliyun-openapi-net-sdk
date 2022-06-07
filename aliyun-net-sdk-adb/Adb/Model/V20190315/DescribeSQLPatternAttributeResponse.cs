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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeSQLPatternAttributeResponse : AcsResponse
	{

		private string requestId;

		private DescribeSQLPatternAttribute_PatternDetail patternDetail;

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

		public DescribeSQLPatternAttribute_PatternDetail PatternDetail
		{
			get
			{
				return patternDetail;
			}
			set	
			{
				patternDetail = value;
			}
		}

		public class DescribeSQLPatternAttribute_PatternDetail
		{

			private string sQLPattern;

			private long? queryCount;

			private string totalQueryTime;

			private string averageQueryTime;

			private string averageMemory;

			public string SQLPattern
			{
				get
				{
					return sQLPattern;
				}
				set	
				{
					sQLPattern = value;
				}
			}

			public long? QueryCount
			{
				get
				{
					return queryCount;
				}
				set	
				{
					queryCount = value;
				}
			}

			public string TotalQueryTime
			{
				get
				{
					return totalQueryTime;
				}
				set	
				{
					totalQueryTime = value;
				}
			}

			public string AverageQueryTime
			{
				get
				{
					return averageQueryTime;
				}
				set	
				{
					averageQueryTime = value;
				}
			}

			public string AverageMemory
			{
				get
				{
					return averageMemory;
				}
				set	
				{
					averageMemory = value;
				}
			}
		}
	}
}
