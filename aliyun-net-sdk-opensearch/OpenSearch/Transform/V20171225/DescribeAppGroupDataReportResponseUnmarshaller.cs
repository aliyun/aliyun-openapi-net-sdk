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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class DescribeAppGroupDataReportResponseUnmarshaller
    {
        public static DescribeAppGroupDataReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAppGroupDataReportResponse describeAppGroupDataReportResponse = new DescribeAppGroupDataReportResponse();

			describeAppGroupDataReportResponse.HttpResponse = _ctx.HttpResponse;
			describeAppGroupDataReportResponse.RequestId = _ctx.StringValue("DescribeAppGroupDataReport.requestId");

			DescribeAppGroupDataReportResponse.DescribeAppGroupDataReport_Result result = new DescribeAppGroupDataReportResponse.DescribeAppGroupDataReport_Result();
			result.ReceivedCount = _ctx.IntegerValue("DescribeAppGroupDataReport.Result.receivedCount");

			List<DescribeAppGroupDataReportResponse.DescribeAppGroupDataReport_Result.DescribeAppGroupDataReport_ReceivedSampleItem> result_receivedSample = new List<DescribeAppGroupDataReportResponse.DescribeAppGroupDataReport_Result.DescribeAppGroupDataReport_ReceivedSampleItem>();
			for (int i = 0; i < _ctx.Length("DescribeAppGroupDataReport.Result.ReceivedSample.Length"); i++) {
				DescribeAppGroupDataReportResponse.DescribeAppGroupDataReport_Result.DescribeAppGroupDataReport_ReceivedSampleItem receivedSampleItem = new DescribeAppGroupDataReportResponse.DescribeAppGroupDataReport_Result.DescribeAppGroupDataReport_ReceivedSampleItem();
				receivedSampleItem.ReceivedTimeMs = _ctx.LongValue("DescribeAppGroupDataReport.Result.ReceivedSample["+ i +"].receivedTimeMs");

				DescribeAppGroupDataReportResponse.DescribeAppGroupDataReport_Result.DescribeAppGroupDataReport_ReceivedSampleItem.DescribeAppGroupDataReport_Message message = new DescribeAppGroupDataReportResponse.DescribeAppGroupDataReport_Result.DescribeAppGroupDataReport_ReceivedSampleItem.DescribeAppGroupDataReport_Message();
				message.ClientIp = _ctx.StringValue("DescribeAppGroupDataReport.Result.ReceivedSample["+ i +"].Message.clientIp");
				message.Arg3 = _ctx.StringValue("DescribeAppGroupDataReport.Result.ReceivedSample["+ i +"].Message.arg3");
				message.UserId = _ctx.StringValue("DescribeAppGroupDataReport.Result.ReceivedSample["+ i +"].Message.userId");
				message.Args = _ctx.StringValue("DescribeAppGroupDataReport.Result.ReceivedSample["+ i +"].Message.args");
				message.Arg1 = _ctx.StringValue("DescribeAppGroupDataReport.Result.ReceivedSample["+ i +"].Message.arg1");
				message.SdkType = _ctx.StringValue("DescribeAppGroupDataReport.Result.ReceivedSample["+ i +"].Message.sdkType");
				message.SessionId = _ctx.StringValue("DescribeAppGroupDataReport.Result.ReceivedSample["+ i +"].Message.sessionId");
				message.EventId = _ctx.IntegerValue("DescribeAppGroupDataReport.Result.ReceivedSample["+ i +"].Message.eventId");
				message.SdkVersion = _ctx.StringValue("DescribeAppGroupDataReport.Result.ReceivedSample["+ i +"].Message.sdkVersion");
				message.Page = _ctx.StringValue("DescribeAppGroupDataReport.Result.ReceivedSample["+ i +"].Message.page");
				receivedSampleItem.Message = message;

				result_receivedSample.Add(receivedSampleItem);
			}
			result.ReceivedSample = result_receivedSample;
			describeAppGroupDataReportResponse.Result = result;
        
			return describeAppGroupDataReportResponse;
        }
    }
}
