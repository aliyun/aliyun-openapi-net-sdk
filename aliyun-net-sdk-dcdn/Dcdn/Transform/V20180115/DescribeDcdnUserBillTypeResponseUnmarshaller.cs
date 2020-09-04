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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnUserBillTypeResponseUnmarshaller
    {
        public static DescribeDcdnUserBillTypeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnUserBillTypeResponse describeDcdnUserBillTypeResponse = new DescribeDcdnUserBillTypeResponse();

			describeDcdnUserBillTypeResponse.HttpResponse = context.HttpResponse;
			describeDcdnUserBillTypeResponse.RequestId = context.StringValue("DescribeDcdnUserBillType.RequestId");

			List<DescribeDcdnUserBillTypeResponse.DescribeDcdnUserBillType_BillTypeDataItem> describeDcdnUserBillTypeResponse_billTypeData = new List<DescribeDcdnUserBillTypeResponse.DescribeDcdnUserBillType_BillTypeDataItem>();
			for (int i = 0; i < context.Length("DescribeDcdnUserBillType.BillTypeData.Length"); i++) {
				DescribeDcdnUserBillTypeResponse.DescribeDcdnUserBillType_BillTypeDataItem billTypeDataItem = new DescribeDcdnUserBillTypeResponse.DescribeDcdnUserBillType_BillTypeDataItem();
				billTypeDataItem.StartTime = context.StringValue("DescribeDcdnUserBillType.BillTypeData["+ i +"].StartTime");
				billTypeDataItem.EndTime = context.StringValue("DescribeDcdnUserBillType.BillTypeData["+ i +"].EndTime");
				billTypeDataItem.Product = context.StringValue("DescribeDcdnUserBillType.BillTypeData["+ i +"].Product");
				billTypeDataItem.Dimension = context.StringValue("DescribeDcdnUserBillType.BillTypeData["+ i +"].Dimension");
				billTypeDataItem.BillType = context.StringValue("DescribeDcdnUserBillType.BillTypeData["+ i +"].BillType");
				billTypeDataItem.BillingCycle = context.StringValue("DescribeDcdnUserBillType.BillTypeData["+ i +"].BillingCycle");

				describeDcdnUserBillTypeResponse_billTypeData.Add(billTypeDataItem);
			}
			describeDcdnUserBillTypeResponse.BillTypeData = describeDcdnUserBillTypeResponse_billTypeData;
        
			return describeDcdnUserBillTypeResponse;
        }
    }
}
