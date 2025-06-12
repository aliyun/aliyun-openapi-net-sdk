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

namespace Aliyun.Acs.clickhouse.Model.V20191111
{
	public class DescribeAccountAuthorityResponse : AcsResponse
	{

		private bool? ddlAuthority;

		private string dmlAuthority;

		private string requestId;

		private string accountName;

		private List<string> totalDatabases;

		private List<string> totalDictionaries;

		private List<string> allowDictionaries;

		private List<string> allowDatabases;

		public bool? DdlAuthority
		{
			get
			{
				return ddlAuthority;
			}
			set	
			{
				ddlAuthority = value;
			}
		}

		public string DmlAuthority
		{
			get
			{
				return dmlAuthority;
			}
			set	
			{
				dmlAuthority = value;
			}
		}

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

		public string AccountName
		{
			get
			{
				return accountName;
			}
			set	
			{
				accountName = value;
			}
		}

		public List<string> TotalDatabases
		{
			get
			{
				return totalDatabases;
			}
			set	
			{
				totalDatabases = value;
			}
		}

		public List<string> TotalDictionaries
		{
			get
			{
				return totalDictionaries;
			}
			set	
			{
				totalDictionaries = value;
			}
		}

		public List<string> AllowDictionaries
		{
			get
			{
				return allowDictionaries;
			}
			set	
			{
				allowDictionaries = value;
			}
		}

		public List<string> AllowDatabases
		{
			get
			{
				return allowDatabases;
			}
			set	
			{
				allowDatabases = value;
			}
		}
	}
}
