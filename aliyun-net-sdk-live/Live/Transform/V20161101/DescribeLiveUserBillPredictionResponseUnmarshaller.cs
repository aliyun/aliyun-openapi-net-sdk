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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveUserBillPredictionResponseUnmarshaller
    {
        public static DescribeLiveUserBillPredictionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveUserBillPredictionResponse describeLiveUserBillPredictionResponse = new DescribeLiveUserBillPredictionResponse();

			describeLiveUserBillPredictionResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveUserBillPredictionResponse.EndTime = _ctx.StringValue("DescribeLiveUserBillPrediction.EndTime");
			describeLiveUserBillPredictionResponse.StartTime = _ctx.StringValue("DescribeLiveUserBillPrediction.StartTime");
			describeLiveUserBillPredictionResponse.RequestId = _ctx.StringValue("DescribeLiveUserBillPrediction.RequestId");
			describeLiveUserBillPredictionResponse.BillType = _ctx.StringValue("DescribeLiveUserBillPrediction.BillType");

			List<DescribeLiveUserBillPredictionResponse.DescribeLiveUserBillPrediction_BillPredictionDataItem> describeLiveUserBillPredictionResponse_billPredictionData = new List<DescribeLiveUserBillPredictionResponse.DescribeLiveUserBillPrediction_BillPredictionDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeLiveUserBillPrediction.BillPredictionData.Length"); i++) {
				DescribeLiveUserBillPredictionResponse.DescribeLiveUserBillPrediction_BillPredictionDataItem billPredictionDataItem = new DescribeLiveUserBillPredictionResponse.DescribeLiveUserBillPrediction_BillPredictionDataItem();
				billPredictionDataItem._Value = _ctx.FloatValue("DescribeLiveUserBillPrediction.BillPredictionData["+ i +"].Value");
				billPredictionDataItem.TimeStp = _ctx.StringValue("DescribeLiveUserBillPrediction.BillPredictionData["+ i +"].TimeStp");
				billPredictionDataItem.Area = _ctx.StringValue("DescribeLiveUserBillPrediction.BillPredictionData["+ i +"].Area");

				describeLiveUserBillPredictionResponse_billPredictionData.Add(billPredictionDataItem);
			}
			describeLiveUserBillPredictionResponse.BillPredictionData = describeLiveUserBillPredictionResponse_billPredictionData;
        
			return describeLiveUserBillPredictionResponse;
        }
    }
}
