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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeRecordDetailResponseUnmarshaller
    {
        public static DescribeRecordDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRecordDetailResponse describeRecordDetailResponse = new DescribeRecordDetailResponse();

			describeRecordDetailResponse.HttpResponse = context.HttpResponse;
			describeRecordDetailResponse.RequestId = context.StringValue("DescribeRecordDetail.RequestId");

			DescribeRecordDetailResponse.DescribeRecordDetail_Duration duration = new DescribeRecordDetailResponse.DescribeRecordDetail_Duration();
			duration.Audio = context.FloatValue("DescribeRecordDetail.Duration.Audio");
			duration.Sd = context.FloatValue("DescribeRecordDetail.Duration.Sd");
			duration.Hd = context.FloatValue("DescribeRecordDetail.Duration.Hd");
			duration.Fhd = context.FloatValue("DescribeRecordDetail.Duration.Fhd");
			duration.All = context.FloatValue("DescribeRecordDetail.Duration.All");
			describeRecordDetailResponse.Duration = duration;

			List<DescribeRecordDetailResponse.DescribeRecordDetail_RecordDetailInfo> describeRecordDetailResponse_recordDetailInfos = new List<DescribeRecordDetailResponse.DescribeRecordDetail_RecordDetailInfo>();
			for (int i = 0; i < context.Length("DescribeRecordDetail.RecordDetailInfos.Length"); i++) {
				DescribeRecordDetailResponse.DescribeRecordDetail_RecordDetailInfo recordDetailInfo = new DescribeRecordDetailResponse.DescribeRecordDetail_RecordDetailInfo();
				recordDetailInfo.Uid = context.StringValue("DescribeRecordDetail.RecordDetailInfos["+ i +"].Uid");
				recordDetailInfo.StartTime = context.StringValue("DescribeRecordDetail.RecordDetailInfos["+ i +"].StartTime");
				recordDetailInfo.EndTime = context.StringValue("DescribeRecordDetail.RecordDetailInfos["+ i +"].EndTime");
				recordDetailInfo.DeviceType = context.StringValue("DescribeRecordDetail.RecordDetailInfos["+ i +"].DeviceType");
				recordDetailInfo.SDKVersion = context.StringValue("DescribeRecordDetail.RecordDetailInfos["+ i +"].SDKVersion");

				describeRecordDetailResponse_recordDetailInfos.Add(recordDetailInfo);
			}
			describeRecordDetailResponse.RecordDetailInfos = describeRecordDetailResponse_recordDetailInfos;
        
			return describeRecordDetailResponse;
        }
    }
}
