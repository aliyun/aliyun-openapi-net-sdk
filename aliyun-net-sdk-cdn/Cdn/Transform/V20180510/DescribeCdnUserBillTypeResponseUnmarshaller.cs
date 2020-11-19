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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeCdnUserBillTypeResponseUnmarshaller
    {
        public static DescribeCdnUserBillTypeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnUserBillTypeResponse describeCdnUserBillTypeResponse = new DescribeCdnUserBillTypeResponse();

			describeCdnUserBillTypeResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnUserBillTypeResponse.RequestId = _ctx.StringValue("DescribeCdnUserBillType.RequestId");

			List<DescribeCdnUserBillTypeResponse.DescribeCdnUserBillType_BillTypeDataItem> describeCdnUserBillTypeResponse_billTypeData = new List<DescribeCdnUserBillTypeResponse.DescribeCdnUserBillType_BillTypeDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeCdnUserBillType.BillTypeData.Length"); i++) {
				DescribeCdnUserBillTypeResponse.DescribeCdnUserBillType_BillTypeDataItem billTypeDataItem = new DescribeCdnUserBillTypeResponse.DescribeCdnUserBillType_BillTypeDataItem();
				billTypeDataItem.StartTime = _ctx.StringValue("DescribeCdnUserBillType.BillTypeData["+ i +"].StartTime");
				billTypeDataItem.EndTime = _ctx.StringValue("DescribeCdnUserBillType.BillTypeData["+ i +"].EndTime");
				billTypeDataItem.Product = _ctx.StringValue("DescribeCdnUserBillType.BillTypeData["+ i +"].Product");
				billTypeDataItem.Dimension = _ctx.StringValue("DescribeCdnUserBillType.BillTypeData["+ i +"].Dimension");
				billTypeDataItem.BillType = _ctx.StringValue("DescribeCdnUserBillType.BillTypeData["+ i +"].BillType");
				billTypeDataItem.BillingCycle = _ctx.StringValue("DescribeCdnUserBillType.BillTypeData["+ i +"].BillingCycle");

				describeCdnUserBillTypeResponse_billTypeData.Add(billTypeDataItem);
			}
			describeCdnUserBillTypeResponse.BillTypeData = describeCdnUserBillTypeResponse_billTypeData;
        
			return describeCdnUserBillTypeResponse;
        }
    }
}
