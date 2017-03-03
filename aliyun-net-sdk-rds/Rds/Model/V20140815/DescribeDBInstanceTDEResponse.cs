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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstanceTDEResponse : AcsResponse
	{

		private string tDEStatus;

		private List<Database> databases;

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

		public List<Database> Databases
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

		public class Database{

			private string dBName;

			private string tDEStatus;

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