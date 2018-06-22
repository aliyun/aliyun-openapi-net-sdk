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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.rtc.Model.V20180111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeRealTimeRecordDetailResponseUnmarshaller
    {
        public static DescribeRealTimeRecordDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRealTimeRecordDetailResponse describeRealTimeRecordDetailResponse = new DescribeRealTimeRecordDetailResponse();

			describeRealTimeRecordDetailResponse.HttpResponse = context.HttpResponse;
			describeRealTimeRecordDetailResponse.RequestId = context.StringValue("DescribeRealTimeRecordDetail.RequestId");

			List<DescribeRealTimeRecordDetailResponse.DescribeRealTimeRecordDetail_RecordDetailInfo> describeRealTimeRecordDetailResponse_recordDetailInfos = new List<DescribeRealTimeRecordDetailResponse.DescribeRealTimeRecordDetail_RecordDetailInfo>();
			for (int i = 0; i < context.Length("DescribeRealTimeRecordDetail.RecordDetailInfos.Length"); i++) {
				DescribeRealTimeRecordDetailResponse.DescribeRealTimeRecordDetail_RecordDetailInfo recordDetailInfo = new DescribeRealTimeRecordDetailResponse.DescribeRealTimeRecordDetail_RecordDetailInfo();
				recordDetailInfo.Uid = context.StringValue("DescribeRealTimeRecordDetail.RecordDetailInfos["+ i +"].Uid");
				recordDetailInfo.StartTime = context.StringValue("DescribeRealTimeRecordDetail.RecordDetailInfos["+ i +"].StartTime");
				recordDetailInfo.DeviceType = context.StringValue("DescribeRealTimeRecordDetail.RecordDetailInfos["+ i +"].DeviceType");
				recordDetailInfo.SDKVersion = context.StringValue("DescribeRealTimeRecordDetail.RecordDetailInfos["+ i +"].SDKVersion");

				describeRealTimeRecordDetailResponse_recordDetailInfos.Add(recordDetailInfo);
			}
			describeRealTimeRecordDetailResponse.RecordDetailInfos = describeRealTimeRecordDetailResponse_recordDetailInfos;
        
			return describeRealTimeRecordDetailResponse;
        }
    }
}