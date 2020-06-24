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
        public static DescribeBackupPlanBillingResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBackupPlanBillingResponse describeBackupPlanBillingResponse = new DescribeBackupPlanBillingResponse();

			describeBackupPlanBillingResponse.HttpResponse = context.HttpResponse;
			describeBackupPlanBillingResponse.Success = context.BooleanValue("DescribeBackupPlanBilling.Success");
			describeBackupPlanBillingResponse.ErrCode = context.StringValue("DescribeBackupPlanBilling.ErrCode");
			describeBackupPlanBillingResponse.ErrMessage = context.StringValue("DescribeBackupPlanBilling.ErrMessage");
			describeBackupPlanBillingResponse.HttpStatusCode = context.IntegerValue("DescribeBackupPlanBilling.HttpStatusCode");
			describeBackupPlanBillingResponse.RequestId = context.StringValue("DescribeBackupPlanBilling.RequestId");

			DescribeBackupPlanBillingResponse.DescribeBackupPlanBilling_Item item = new DescribeBackupPlanBillingResponse.DescribeBackupPlanBilling_Item();
			item.BuySpec = context.StringValue("DescribeBackupPlanBilling.Item.BuySpec");
			item.BuyChargeType = context.StringValue("DescribeBackupPlanBilling.Item.BuyChargeType");
			item.BuyExpiredTimestamp = context.LongValue("DescribeBackupPlanBilling.Item.BuyExpiredTimestamp");
			item.TotalFreeBytes = context.LongValue("DescribeBackupPlanBilling.Item.TotalFreeBytes");
			item.PaiedBytes = context.LongValue("DescribeBackupPlanBilling.Item.PaiedBytes");
			item.UsedFullBytes = context.LongValue("DescribeBackupPlanBilling.Item.UsedFullBytes");
			item.UsedIncrementBytes = context.LongValue("DescribeBackupPlanBilling.Item.UsedIncrementBytes");
			item.QuotaStartTimestamp = context.LongValue("DescribeBackupPlanBilling.Item.QuotaStartTimestamp");
			item.QuotaEndTimestamp = context.LongValue("DescribeBackupPlanBilling.Item.QuotaEndTimestamp");
			item.BuyCreateTimestamp = context.LongValue("DescribeBackupPlanBilling.Item.BuyCreateTimestamp");
			item.FullStorageSize = context.LongValue("DescribeBackupPlanBilling.Item.FullStorageSize");
			item.ContStorageSize = context.LongValue("DescribeBackupPlanBilling.Item.ContStorageSize");
			item.IsExpired = context.BooleanValue("DescribeBackupPlanBilling.Item.IsExpired");
			item.IsFreeBytesUnlimited = context.BooleanValue("DescribeBackupPlanBilling.Item.IsFreeBytesUnlimited");
			describeBackupPlanBillingResponse.Item = item;
        
			return describeBackupPlanBillingResponse;
        }
    }
}
