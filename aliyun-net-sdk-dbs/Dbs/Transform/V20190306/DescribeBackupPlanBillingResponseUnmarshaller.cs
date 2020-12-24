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
using Aliyun.Acs.Dbs.Model.V20190306;

namespace Aliyun.Acs.Dbs.Transform.V20190306
{
    public class DescribeBackupPlanBillingResponseUnmarshaller
    {
        public static DescribeBackupPlanBillingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupPlanBillingResponse describeBackupPlanBillingResponse = new DescribeBackupPlanBillingResponse();

			describeBackupPlanBillingResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupPlanBillingResponse.Success = _ctx.BooleanValue("DescribeBackupPlanBilling.Success");
			describeBackupPlanBillingResponse.ErrCode = _ctx.StringValue("DescribeBackupPlanBilling.ErrCode");
			describeBackupPlanBillingResponse.ErrMessage = _ctx.StringValue("DescribeBackupPlanBilling.ErrMessage");
			describeBackupPlanBillingResponse.HttpStatusCode = _ctx.IntegerValue("DescribeBackupPlanBilling.HttpStatusCode");
			describeBackupPlanBillingResponse.RequestId = _ctx.StringValue("DescribeBackupPlanBilling.RequestId");

			DescribeBackupPlanBillingResponse.DescribeBackupPlanBilling_Item item = new DescribeBackupPlanBillingResponse.DescribeBackupPlanBilling_Item();
			item.BuySpec = _ctx.StringValue("DescribeBackupPlanBilling.Item.BuySpec");
			item.BuyChargeType = _ctx.StringValue("DescribeBackupPlanBilling.Item.BuyChargeType");
			item.BuyExpiredTimestamp = _ctx.LongValue("DescribeBackupPlanBilling.Item.BuyExpiredTimestamp");
			item.TotalFreeBytes = _ctx.LongValue("DescribeBackupPlanBilling.Item.TotalFreeBytes");
			item.PaiedBytes = _ctx.LongValue("DescribeBackupPlanBilling.Item.PaiedBytes");
			item.UsedFullBytes = _ctx.LongValue("DescribeBackupPlanBilling.Item.UsedFullBytes");
			item.UsedIncrementBytes = _ctx.LongValue("DescribeBackupPlanBilling.Item.UsedIncrementBytes");
			item.QuotaStartTimestamp = _ctx.LongValue("DescribeBackupPlanBilling.Item.QuotaStartTimestamp");
			item.QuotaEndTimestamp = _ctx.LongValue("DescribeBackupPlanBilling.Item.QuotaEndTimestamp");
			item.BuyCreateTimestamp = _ctx.LongValue("DescribeBackupPlanBilling.Item.BuyCreateTimestamp");
			item.FullStorageSize = _ctx.LongValue("DescribeBackupPlanBilling.Item.FullStorageSize");
			item.ContStorageSize = _ctx.LongValue("DescribeBackupPlanBilling.Item.ContStorageSize");
			item.IsExpired = _ctx.BooleanValue("DescribeBackupPlanBilling.Item.IsExpired");
			item.IsFreeBytesUnlimited = _ctx.BooleanValue("DescribeBackupPlanBilling.Item.IsFreeBytesUnlimited");
			describeBackupPlanBillingResponse.Item = item;
        
			return describeBackupPlanBillingResponse;
        }
    }
}
