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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeAvailableClassesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeAvailableClasses_DBInstanceClass> dBInstanceClasses;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "DBInstanceClasses")]
		public List<DescribeAvailableClasses_DBInstanceClass> DBInstanceClasses
		{
			get
			{
				return dBInstanceClasses;
			}
			set	
			{
				dBInstanceClasses = value;
			}
		}

		public class DescribeAvailableClasses_DBInstanceClass
		{

			private string storageRange;

			private string dBInstanceClass;

			private DescribeAvailableClasses_DBInstanceStorageRange dBInstanceStorageRange;

			[JsonProperty(PropertyName = "StorageRange")]
			public string StorageRange
			{
				get
				{
					return storageRange;
				}
				set	
				{
					storageRange = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceClass")]
			public string DBInstanceClass
			{
				get
				{
					return dBInstanceClass;
				}
				set	
				{
					dBInstanceClass = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceStorageRange")]
			public DescribeAvailableClasses_DBInstanceStorageRange DBInstanceStorageRange
			{
				get
				{
					return dBInstanceStorageRange;
				}
				set	
				{
					dBInstanceStorageRange = value;
				}
			}

			public class DescribeAvailableClasses_DBInstanceStorageRange
			{

				private int? step;

				private int? minValue;

				private int? maxValue;

				[JsonProperty(PropertyName = "Step")]
				public int? Step
				{
					get
					{
						return step;
					}
					set	
					{
						step = value;
					}
				}

				[JsonProperty(PropertyName = "MinValue")]
				public int? MinValue
				{
					get
					{
						return minValue;
					}
					set	
					{
						minValue = value;
					}
				}

				[JsonProperty(PropertyName = "MaxValue")]
				public int? MaxValue
				{
					get
					{
						return maxValue;
					}
					set	
					{
						maxValue = value;
					}
				}
			}
		}
	}
}
