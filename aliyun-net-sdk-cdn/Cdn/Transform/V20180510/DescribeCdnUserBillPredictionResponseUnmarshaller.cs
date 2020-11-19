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
    public class DescribeCdnUserBillPredictionResponseUnmarshaller
    {
        public static DescribeCdnUserBillPredictionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnUserBillPredictionResponse describeCdnUserBillPredictionResponse = new DescribeCdnUserBillPredictionResponse();

			describeCdnUserBillPredictionResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnUserBillPredictionResponse.RequestId = _ctx.StringValue("DescribeCdnUserBillPrediction.RequestId");
			describeCdnUserBillPredictionResponse.StartTime = _ctx.StringValue("DescribeCdnUserBillPrediction.StartTime");
			describeCdnUserBillPredictionResponse.EndTime = _ctx.StringValue("DescribeCdnUserBillPrediction.EndTime");
			describeCdnUserBillPredictionResponse.BillType = _ctx.StringValue("DescribeCdnUserBillPrediction.BillType");

			List<DescribeCdnUserBillPredictionResponse.DescribeCdnUserBillPrediction_BillPredictionDataItem> describeCdnUserBillPredictionResponse_billPredictionData = new List<DescribeCdnUserBillPredictionResponse.DescribeCdnUserBillPrediction_BillPredictionDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeCdnUserBillPrediction.BillPredictionData.Length"); i++) {
				DescribeCdnUserBillPredictionResponse.DescribeCdnUserBillPrediction_BillPredictionDataItem billPredictionDataItem = new DescribeCdnUserBillPredictionResponse.DescribeCdnUserBillPrediction_BillPredictionDataItem();
				billPredictionDataItem._Value = _ctx.FloatValue("DescribeCdnUserBillPrediction.BillPredictionData["+ i +"].Value");
				billPredictionDataItem.Area = _ctx.StringValue("DescribeCdnUserBillPrediction.BillPredictionData["+ i +"].Area");
				billPredictionDataItem.TimeStp = _ctx.StringValue("DescribeCdnUserBillPrediction.BillPredictionData["+ i +"].TimeStp");

				describeCdnUserBillPredictionResponse_billPredictionData.Add(billPredictionDataItem);
			}
			describeCdnUserBillPredictionResponse.BillPredictionData = describeCdnUserBillPredictionResponse_billPredictionData;
        
			return describeCdnUserBillPredictionResponse;
        }
    }
}
