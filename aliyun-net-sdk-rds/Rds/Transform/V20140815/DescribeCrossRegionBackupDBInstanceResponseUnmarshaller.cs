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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeCrossRegionBackupDBInstanceResponseUnmarshaller
    {
        public static DescribeCrossRegionBackupDBInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCrossRegionBackupDBInstanceResponse describeCrossRegionBackupDBInstanceResponse = new DescribeCrossRegionBackupDBInstanceResponse();

			describeCrossRegionBackupDBInstanceResponse.HttpResponse = context.HttpResponse;
			describeCrossRegionBackupDBInstanceResponse.RequestId = context.StringValue("DescribeCrossRegionBackupDBInstance.RequestId");
			describeCrossRegionBackupDBInstanceResponse.RegionId = context.StringValue("DescribeCrossRegionBackupDBInstance.RegionId");
			describeCrossRegionBackupDBInstanceResponse.TotalRecords = context.IntegerValue("DescribeCrossRegionBackupDBInstance.TotalRecords");
			describeCrossRegionBackupDBInstanceResponse.PageSize = context.IntegerValue("DescribeCrossRegionBackupDBInstance.PageSize");
			describeCrossRegionBackupDBInstanceResponse.PageNumber = context.IntegerValue("DescribeCrossRegionBackupDBInstance.PageNumber");
			describeCrossRegionBackupDBInstanceResponse.ItemsNumbers = context.IntegerValue("DescribeCrossRegionBackupDBInstance.ItemsNumbers");

			List<DescribeCrossRegionBackupDBInstanceResponse.DescribeCrossRegionBackupDBInstance_Item> describeCrossRegionBackupDBInstanceResponse_items = new List<DescribeCrossRegionBackupDBInstanceResponse.DescribeCrossRegionBackupDBInstance_Item>();
			for (int i = 0; i < context.Length("DescribeCrossRegionBackupDBInstance.Items.Length"); i++) {
				DescribeCrossRegionBackupDBInstanceResponse.DescribeCrossRegionBackupDBInstance_Item item = new DescribeCrossRegionBackupDBInstanceResponse.DescribeCrossRegionBackupDBInstance_Item();
				item.DBInstanceId = context.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].DBInstanceId");
				item.DBInstanceDescription = context.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].DBInstanceDescription");
				item.DBInstanceStatus = context.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].DBInstanceStatus");
				item.DBInstanceStatusDesc = context.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].DBInstanceStatusDesc");
				item.Engine = context.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].Engine");
				item.EngineVersion = context.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].EngineVersion");
				item.CrossBackupRegion = context.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].CrossBackupRegion");
				item.CrossBackupType = context.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].CrossBackupType");
				item.BackupEnabled = context.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].BackupEnabled");
				item.LogBackupEnabled = context.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].LogBackupEnabled");
				item.LogBackupEnabledTime = context.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].LogBackupEnabledTime");
				item.BackupEnabledTime = context.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].BackupEnabledTime");
				item.RetentType = context.IntegerValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].RetentType");
				item.Retention = context.IntegerValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].Retention");
				item.LockMode = context.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].LockMode");
				item.RelService = context.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].RelService");
				item.RelServiceId = context.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].RelServiceId");

				describeCrossRegionBackupDBInstanceResponse_items.Add(item);
			}
			describeCrossRegionBackupDBInstanceResponse.Items = describeCrossRegionBackupDBInstanceResponse_items;
        
			return describeCrossRegionBackupDBInstanceResponse;
        }
    }
}
