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
	public class DescribeDBInstanceTDEResponse : AcsResponse
	{

		private string tDEStatus;

		private string requestId;

		private List<DescribeDBInstanceTDE_Database> databases;

		[JsonProperty(PropertyName = "TDEStatus")]
		public string TDEStatus
		{
			get
			{
				return tDEStatus;
			}
			set	
			{
				tDEStatus = value;
			}
		}

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

		[JsonProperty(PropertyName = "Databases")]
		public List<DescribeDBInstanceTDE_Database> Databases
		{
			get
			{
				return databases;
			}
			set	
			{
				databases = value;
			}
		}

		public class DescribeDBInstanceTDE_Database
		{

			private string dBName;

			private string tDEStatus;

			[JsonProperty(PropertyName = "DBName")]
			public string DBName
			{
				get
				{
					return dBName;
				}
				set	
				{
					dBName = value;
				}
			}

			[JsonProperty(PropertyName = "TDEStatus")]
			public string TDEStatus
			{
				get
				{
					return tDEStatus;
				}
				set	
				{
					tDEStatus = value;
				}
			}
		}
	}
}
