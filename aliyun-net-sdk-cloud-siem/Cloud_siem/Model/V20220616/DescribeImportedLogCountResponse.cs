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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class DescribeImportedLogCountResponse : AcsResponse
	{

		private string requestId;

		private DescribeImportedLogCount_Data data;

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

		public DescribeImportedLogCount_Data Data
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

		public class DescribeImportedLogCount_Data
		{

			private int? totalLogCount;

			private int? importedLogCount;

			private int? unImportedLogCount;

			public int? TotalLogCount
			{
				get
				{
					return totalLogCount;
				}
				set	
				{
					totalLogCount = value;
				}
			}

			public int? ImportedLogCount
			{
				get
				{
					return importedLogCount;
				}
				set	
				{
					importedLogCount = value;
				}
			}

			public int? UnImportedLogCount
			{
				get
				{
					return unImportedLogCount;
				}
				set	
				{
					unImportedLogCount = value;
				}
			}
		}
	}
}
