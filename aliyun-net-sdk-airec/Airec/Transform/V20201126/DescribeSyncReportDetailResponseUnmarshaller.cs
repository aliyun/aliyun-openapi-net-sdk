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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class DescribeSyncReportDetailResponseUnmarshaller
    {
        public static DescribeSyncReportDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSyncReportDetailResponse describeSyncReportDetailResponse = new DescribeSyncReportDetailResponse();

			describeSyncReportDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeSyncReportDetailResponse.Code = _ctx.StringValue("DescribeSyncReportDetail.code");
			describeSyncReportDetailResponse.Message = _ctx.StringValue("DescribeSyncReportDetail.message");
			describeSyncReportDetailResponse.RequestId = _ctx.StringValue("DescribeSyncReportDetail.requestId");

			List<DescribeSyncReportDetailResponse.DescribeSyncReportDetail_ResultItem> describeSyncReportDetailResponse_result = new List<DescribeSyncReportDetailResponse.DescribeSyncReportDetail_ResultItem>();
			for (int i = 0; i < _ctx.Length("DescribeSyncReportDetail.Result.Length"); i++) {
				DescribeSyncReportDetailResponse.DescribeSyncReportDetail_ResultItem resultItem = new DescribeSyncReportDetailResponse.DescribeSyncReportDetail_ResultItem();
				resultItem.DefaultDisplay = _ctx.BooleanValue("DescribeSyncReportDetail.Result["+ i +"].defaultDisplay");
				resultItem.ErrorCount = _ctx.IntegerValue("DescribeSyncReportDetail.Result["+ i +"].errorCount");
				resultItem.ErrorPercent = _ctx.FloatValue("DescribeSyncReportDetail.Result["+ i +"].errorPercent");
				resultItem.SampleDisplay = _ctx.BooleanValue("DescribeSyncReportDetail.Result["+ i +"].sampleDisplay");
				resultItem.Type = _ctx.StringValue("DescribeSyncReportDetail.Result["+ i +"].type");

				List<DescribeSyncReportDetailResponse.DescribeSyncReportDetail_ResultItem.DescribeSyncReportDetail_HistoryDataItem> resultItem_historyData = new List<DescribeSyncReportDetailResponse.DescribeSyncReportDetail_ResultItem.DescribeSyncReportDetail_HistoryDataItem>();
				for (int j = 0; j < _ctx.Length("DescribeSyncReportDetail.Result["+ i +"].HistoryData.Length"); j++) {
					DescribeSyncReportDetailResponse.DescribeSyncReportDetail_ResultItem.DescribeSyncReportDetail_HistoryDataItem historyDataItem = new DescribeSyncReportDetailResponse.DescribeSyncReportDetail_ResultItem.DescribeSyncReportDetail_HistoryDataItem();
					historyDataItem.EndTime = _ctx.LongValue("DescribeSyncReportDetail.Result["+ i +"].HistoryData["+ j +"].endTime");
					historyDataItem.ErrorPercent = _ctx.FloatValue("DescribeSyncReportDetail.Result["+ i +"].HistoryData["+ j +"].errorPercent");
					historyDataItem.StartTime = _ctx.LongValue("DescribeSyncReportDetail.Result["+ i +"].HistoryData["+ j +"].startTime");

					resultItem_historyData.Add(historyDataItem);
				}
				resultItem.HistoryData = resultItem_historyData;

				describeSyncReportDetailResponse_result.Add(resultItem);
			}
			describeSyncReportDetailResponse.Result = describeSyncReportDetailResponse_result;
        
			return describeSyncReportDetailResponse;
        }
    }
}
