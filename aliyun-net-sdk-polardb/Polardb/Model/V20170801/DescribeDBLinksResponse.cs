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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBLinksResponse : AcsResponse
	{

		private string requestId;

		private string dBInstanceName;

		private List<DescribeDBLinks_DBLinkInfosItem> dBLinkInfos;

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

		public string DBInstanceName
		{
			get
			{
				return dBInstanceName;
			}
			set	
			{
				dBInstanceName = value;
			}
		}

		public List<DescribeDBLinks_DBLinkInfosItem> DBLinkInfos
		{
			get
			{
				return dBLinkInfos;
			}
			set	
			{
				dBLinkInfos = value;
			}
		}

		public class DescribeDBLinks_DBLinkInfosItem
		{

			private string targetDBInstanceName;

			private string dBInstanceName;

			private string targetDBName;

			private string targetAccount;

			private string dBLinkName;

			private string sourceDBName;

			public string TargetDBInstanceName
			{
				get
				{
					return targetDBInstanceName;
				}
				set	
				{
					targetDBInstanceName = value;
				}
			}

			public string DBInstanceName
			{
				get
				{
					return dBInstanceName;
				}
				set	
				{
					dBInstanceName = value;
				}
			}

			public string TargetDBName
			{
				get
				{
					return targetDBName;
				}
				set	
				{
					targetDBName = value;
				}
			}

			public string TargetAccount
			{
				get
				{
					return targetAccount;
				}
				set	
				{
					targetAccount = value;
				}
			}

			public string DBLinkName
			{
				get
				{
					return dBLinkName;
				}
				set	
				{
					dBLinkName = value;
				}
			}

			public string SourceDBName
			{
				get
				{
					return sourceDBName;
				}
				set	
				{
					sourceDBName = value;
				}
			}
		}
	}
}
