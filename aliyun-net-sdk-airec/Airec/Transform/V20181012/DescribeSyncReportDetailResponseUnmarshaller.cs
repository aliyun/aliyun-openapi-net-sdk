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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class DescribeSyncReportDetailResponseUnmarshaller
    {
        public static DescribeSyncReportDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSyncReportDetailResponse describeSyncReportDetailResponse = new DescribeSyncReportDetailResponse();

			describeSyncReportDetailResponse.HttpResponse = context.HttpResponse;
			describeSyncReportDetailResponse.RequestId = context.StringValue("DescribeSyncReportDetail.RequestId");
			describeSyncReportDetailResponse.Code = context.StringValue("DescribeSyncReportDetail.Code");
			describeSyncReportDetailResponse.Message = context.StringValue("DescribeSyncReportDetail.Message");

			List<DescribeSyncReportDetailResponse.DescribeSyncReportDetail_ResultItem> describeSyncReportDetailResponse_result = new List<DescribeSyncReportDetailResponse.DescribeSyncReportDetail_ResultItem>();
			for (int i = 0; i < context.Length("DescribeSyncReportDetail.Result.Length"); i++) {
				DescribeSyncReportDetailResponse.DescribeSyncReportDetail_ResultItem resultItem = new DescribeSyncReportDetailResponse.DescribeSyncReportDetail_ResultItem();
				resultItem.Type = context.StringValue("DescribeSyncReportDetail.Result["+ i +"].Type");
				resultItem.ErrorPercent = context.FloatValue("DescribeSyncReportDetail.Result["+ i +"].ErrorPercent");
				resultItem.ErrorCount = context.IntegerValue("DescribeSyncReportDetail.Result["+ i +"].ErrorCount");
				resultItem.DefaultDisplay = context.BooleanValue("DescribeSyncReportDetail.Result["+ i +"].DefaultDisplay");
				resultItem.SampleDisplay = context.BooleanValue("DescribeSyncReportDetail.Result["+ i +"].SampleDisplay");

				List<DescribeSyncReportDetailResponse.DescribeSyncReportDetail_ResultItem.DescribeSyncReportDetail_HistoryDataItem> resultItem_historyData = new List<DescribeSyncReportDetailResponse.DescribeSyncReportDetail_ResultItem.DescribeSyncReportDetail_HistoryDataItem>();
				for (int j = 0; j < context.Length("DescribeSyncReportDetail.Result["+ i +"].HistoryData.Length"); j++) {
					DescribeSyncReportDetailResponse.DescribeSyncReportDetail_ResultItem.DescribeSyncReportDetail_HistoryDataItem historyDataItem = new DescribeSyncReportDetailResponse.DescribeSyncReportDetail_ResultItem.DescribeSyncReportDetail_HistoryDataItem();
					historyDataItem.ErrorPercent = context.FloatValue("DescribeSyncReportDetail.Result["+ i +"].HistoryData["+ j +"].ErrorPercent");
					historyDataItem.StartTime = context.LongValue("DescribeSyncReportDetail.Result["+ i +"].HistoryData["+ j +"].StartTime");
					historyDataItem.EndTime = context.LongValue("DescribeSyncReportDetail.Result["+ i +"].HistoryData["+ j +"].EndTime");

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
