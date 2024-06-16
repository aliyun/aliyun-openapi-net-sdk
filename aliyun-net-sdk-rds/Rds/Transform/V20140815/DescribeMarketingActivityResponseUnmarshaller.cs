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
    public class DescribeMarketingActivityResponseUnmarshaller
    {
        public static DescribeMarketingActivityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMarketingActivityResponse describeMarketingActivityResponse = new DescribeMarketingActivityResponse();

			describeMarketingActivityResponse.HttpResponse = _ctx.HttpResponse;
			describeMarketingActivityResponse.RequestId = _ctx.StringValue("DescribeMarketingActivity.RequestId");
			describeMarketingActivityResponse.AliUid = _ctx.LongValue("DescribeMarketingActivity.AliUid");
			describeMarketingActivityResponse.RegionId = _ctx.StringValue("DescribeMarketingActivity.RegionId");
			describeMarketingActivityResponse.Bid = _ctx.StringValue("DescribeMarketingActivity.Bid");

			List<DescribeMarketingActivityResponse.DescribeMarketingActivity_ItemsItem> describeMarketingActivityResponse_items = new List<DescribeMarketingActivityResponse.DescribeMarketingActivity_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeMarketingActivity.Items.Length"); i++) {
				DescribeMarketingActivityResponse.DescribeMarketingActivity_ItemsItem itemsItem = new DescribeMarketingActivityResponse.DescribeMarketingActivity_ItemsItem();
				itemsItem.InstanceId = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].InstanceId");
				itemsItem.InstanceName = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].InstanceName");
				itemsItem.ClassCode = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].ClassCode");
				itemsItem.DiskSize = _ctx.IntegerValue("DescribeMarketingActivity.Items["+ i +"].DiskSize");
				itemsItem.Memory = _ctx.LongValue("DescribeMarketingActivity.Items["+ i +"].Memory");
				itemsItem.Cpu = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].Cpu");
				itemsItem.Category = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].Category");
				itemsItem.StorageType = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].StorageType");
				itemsItem.ClassGroup = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].ClassGroup");
				itemsItem.MaxIombps = _ctx.IntegerValue("DescribeMarketingActivity.Items["+ i +"].MaxIombps");
				itemsItem.MaxIops = _ctx.IntegerValue("DescribeMarketingActivity.Items["+ i +"].MaxIops");
				itemsItem.MaxConnections = _ctx.IntegerValue("DescribeMarketingActivity.Items["+ i +"].MaxConnections");
				itemsItem.UpgradeClassCode = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].UpgradeClassCode");
				itemsItem.UpgradeDiskSize = _ctx.IntegerValue("DescribeMarketingActivity.Items["+ i +"].UpgradeDiskSize");
				itemsItem.UpgradeMemory = _ctx.LongValue("DescribeMarketingActivity.Items["+ i +"].UpgradeMemory");
				itemsItem.UpgradeCpu = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].UpgradeCpu");
				itemsItem.UpgradeCategory = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].UpgradeCategory");
				itemsItem.UpgradeStorageType = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].UpgradeStorageType");
				itemsItem.UpgradeClassGroup = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].UpgradeClassGroup");
				itemsItem.UpgradeMaxIombps = _ctx.IntegerValue("DescribeMarketingActivity.Items["+ i +"].UpgradeMaxIombps");
				itemsItem.UpgradeMaxIops = _ctx.IntegerValue("DescribeMarketingActivity.Items["+ i +"].UpgradeMaxIops");
				itemsItem.UpgradeMaxConnections = _ctx.IntegerValue("DescribeMarketingActivity.Items["+ i +"].UpgradeMaxConnections");
				itemsItem.UpgradeDescContent = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].UpgradeDescContent");
				itemsItem.UpgradeReferencePrice = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].UpgradeReferencePrice");
				itemsItem.ChargeType = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].ChargeType");
				itemsItem.Engine = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].Engine");
				itemsItem.EngineVersion = _ctx.StringValue("DescribeMarketingActivity.Items["+ i +"].EngineVersion");

				describeMarketingActivityResponse_items.Add(itemsItem);
			}
			describeMarketingActivityResponse.Items = describeMarketingActivityResponse_items;
        
			return describeMarketingActivityResponse;
        }
    }
}
