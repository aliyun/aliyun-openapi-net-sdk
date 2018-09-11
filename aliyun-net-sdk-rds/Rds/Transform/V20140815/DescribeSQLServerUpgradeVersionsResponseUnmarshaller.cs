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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSQLServerUpgradeVersionsResponseUnmarshaller
    {
        public static DescribeSQLServerUpgradeVersionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSQLServerUpgradeVersionsResponse describeSQLServerUpgradeVersionsResponse = new DescribeSQLServerUpgradeVersionsResponse();

			describeSQLServerUpgradeVersionsResponse.HttpResponse = context.HttpResponse;
			describeSQLServerUpgradeVersionsResponse.RequestId = context.StringValue("DescribeSQLServerUpgradeVersions.RequestId");

			List<DescribeSQLServerUpgradeVersionsResponse.DescribeSQLServerUpgradeVersions_Item> describeSQLServerUpgradeVersionsResponse_items = new List<DescribeSQLServerUpgradeVersionsResponse.DescribeSQLServerUpgradeVersions_Item>();
			for (int i = 0; i < context.Length("DescribeSQLServerUpgradeVersions.Items.Length"); i++) {
				DescribeSQLServerUpgradeVersionsResponse.DescribeSQLServerUpgradeVersions_Item item = new DescribeSQLServerUpgradeVersionsResponse.DescribeSQLServerUpgradeVersions_Item();
				item.CurrentVersion = context.StringValue("DescribeSQLServerUpgradeVersions.Items["+ i +"].CurrentVersion");

				List<DescribeSQLServerUpgradeVersionsResponse.DescribeSQLServerUpgradeVersions_Item.DescribeSQLServerUpgradeVersions_SQLServerUpgradeVersion> item_sQLServerUpgradeVersions = new List<DescribeSQLServerUpgradeVersionsResponse.DescribeSQLServerUpgradeVersions_Item.DescribeSQLServerUpgradeVersions_SQLServerUpgradeVersion>();
				for (int j = 0; j < context.Length("DescribeSQLServerUpgradeVersions.Items["+ i +"].SQLServerUpgradeVersions.Length"); j++) {
					DescribeSQLServerUpgradeVersionsResponse.DescribeSQLServerUpgradeVersions_Item.DescribeSQLServerUpgradeVersions_SQLServerUpgradeVersion sQLServerUpgradeVersion = new DescribeSQLServerUpgradeVersionsResponse.DescribeSQLServerUpgradeVersions_Item.DescribeSQLServerUpgradeVersions_SQLServerUpgradeVersion();
					sQLServerUpgradeVersion.Version = context.StringValue("DescribeSQLServerUpgradeVersions.Items["+ i +"].SQLServerUpgradeVersions["+ j +"].Version");
					sQLServerUpgradeVersion.EnableUpgrade = context.StringValue("DescribeSQLServerUpgradeVersions.Items["+ i +"].SQLServerUpgradeVersions["+ j +"].EnableUpgrade");

					item_sQLServerUpgradeVersions.Add(sQLServerUpgradeVersion);
				}
				item.SQLServerUpgradeVersions = item_sQLServerUpgradeVersions;

				describeSQLServerUpgradeVersionsResponse_items.Add(item);
			}
			describeSQLServerUpgradeVersionsResponse.Items = describeSQLServerUpgradeVersionsResponse_items;
        
			return describeSQLServerUpgradeVersionsResponse;
        }
    }
}