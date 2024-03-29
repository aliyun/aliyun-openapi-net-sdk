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
        public static DescribeCrossRegionBackupDBInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCrossRegionBackupDBInstanceResponse describeCrossRegionBackupDBInstanceResponse = new DescribeCrossRegionBackupDBInstanceResponse();

			describeCrossRegionBackupDBInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeCrossRegionBackupDBInstanceResponse.RequestId = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.RequestId");
			describeCrossRegionBackupDBInstanceResponse.TotalRecords = _ctx.IntegerValue("DescribeCrossRegionBackupDBInstance.TotalRecords");
			describeCrossRegionBackupDBInstanceResponse.ItemsNumbers = _ctx.IntegerValue("DescribeCrossRegionBackupDBInstance.ItemsNumbers");
			describeCrossRegionBackupDBInstanceResponse.PageSize = _ctx.IntegerValue("DescribeCrossRegionBackupDBInstance.PageSize");
			describeCrossRegionBackupDBInstanceResponse.PageNumber = _ctx.IntegerValue("DescribeCrossRegionBackupDBInstance.PageNumber");
			describeCrossRegionBackupDBInstanceResponse.RegionId = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.RegionId");

			List<DescribeCrossRegionBackupDBInstanceResponse.DescribeCrossRegionBackupDBInstance_Item> describeCrossRegionBackupDBInstanceResponse_items = new List<DescribeCrossRegionBackupDBInstanceResponse.DescribeCrossRegionBackupDBInstance_Item>();
			for (int i = 0; i < _ctx.Length("DescribeCrossRegionBackupDBInstance.Items.Length"); i++) {
				DescribeCrossRegionBackupDBInstanceResponse.DescribeCrossRegionBackupDBInstance_Item item = new DescribeCrossRegionBackupDBInstanceResponse.DescribeCrossRegionBackupDBInstance_Item();
				item.RelServiceId = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].RelServiceId");
				item.LogBackupEnabledTime = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].LogBackupEnabledTime");
				item.DBInstanceStatusDesc = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].DBInstanceStatusDesc");
				item.RelService = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].RelService");
				item.BackupEnabled = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].BackupEnabled");
				item.DBInstanceStatus = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].DBInstanceStatus");
				item.LockMode = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].LockMode");
				item.EngineVersion = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].EngineVersion");
				item.LogBackupEnabled = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].LogBackupEnabled");
				item.RetentType = _ctx.IntegerValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].RetentType");
				item.Retention = _ctx.IntegerValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].Retention");
				item.CrossBackupType = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].CrossBackupType");
				item.CrossBackupRegion = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].CrossBackupRegion");
				item.DBInstanceId = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].DBInstanceId");
				item.Engine = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].Engine");
				item.BackupEnabledTime = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].BackupEnabledTime");
				item.DBInstanceDescription = _ctx.StringValue("DescribeCrossRegionBackupDBInstance.Items["+ i +"].DBInstanceDescription");

				describeCrossRegionBackupDBInstanceResponse_items.Add(item);
			}
			describeCrossRegionBackupDBInstanceResponse.Items = describeCrossRegionBackupDBInstanceResponse_items;
        
			return describeCrossRegionBackupDBInstanceResponse;
        }
    }
}
