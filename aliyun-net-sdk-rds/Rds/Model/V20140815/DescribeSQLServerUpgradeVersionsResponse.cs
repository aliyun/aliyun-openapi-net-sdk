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
	public class DescribeSQLServerUpgradeVersionsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSQLServerUpgradeVersions_Item> items;

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

		public List<DescribeSQLServerUpgradeVersions_Item> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeSQLServerUpgradeVersions_Item
		{

			private string currentVersion;

			private List<DescribeSQLServerUpgradeVersions_SQLServerUpgradeVersion> sQLServerUpgradeVersions;

			public string CurrentVersion
			{
				get
				{
					return currentVersion;
				}
				set	
				{
					currentVersion = value;
				}
			}

			public List<DescribeSQLServerUpgradeVersions_SQLServerUpgradeVersion> SQLServerUpgradeVersions
			{
				get
				{
					return sQLServerUpgradeVersions;
				}
				set	
				{
					sQLServerUpgradeVersions = value;
				}
			}

			public class DescribeSQLServerUpgradeVersions_SQLServerUpgradeVersion
			{

				private string version;

				private string enableUpgrade;

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public string EnableUpgrade
				{
					get
					{
						return enableUpgrade;
					}
					set	
					{
						enableUpgrade = value;
					}
				}
			}
		}
	}
}