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
    public class DescribeRealTimeRecordListResponseUnmarshaller
    {
        public static DescribeRealTimeRecordListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRealTimeRecordListResponse describeRealTimeRecordListResponse = new DescribeRealTimeRecordListResponse();

			describeRealTimeRecordListResponse.HttpResponse = context.HttpResponse;
			describeRealTimeRecordListResponse.RequestId = context.StringValue("DescribeRealTimeRecordList.RequestId");

			List<DescribeRealTimeRecordListResponse.DescribeRealTimeRecordList_CommunicationRecordInfo> describeRealTimeRecordListResponse_communicationRecordInfos = new List<DescribeRealTimeRecordListResponse.DescribeRealTimeRecordList_CommunicationRecordInfo>();
			for (int i = 0; i < context.Length("DescribeRealTimeRecordList.CommunicationRecordInfos.Length"); i++) {
				DescribeRealTimeRecordListResponse.DescribeRealTimeRecordList_CommunicationRecordInfo communicationRecordInfo = new DescribeRealTimeRecordListResponse.DescribeRealTimeRecordList_CommunicationRecordInfo();
				communicationRecordInfo.ChannelId = context.StringValue("DescribeRealTimeRecordList.CommunicationRecordInfos["+ i +"].ChannelId");
				communicationRecordInfo.StartTime = context.StringValue("DescribeRealTimeRecordList.CommunicationRecordInfos["+ i +"].StartTime");
				communicationRecordInfo.EndTime = context.StringValue("DescribeRealTimeRecordList.CommunicationRecordInfos["+ i +"].EndTime");
				communicationRecordInfo.OnlineUserCnt = context.LongValue("DescribeRealTimeRecordList.CommunicationRecordInfos["+ i +"].OnlineUserCnt");
				communicationRecordInfo.Status = context.BooleanValue("DescribeRealTimeRecordList.CommunicationRecordInfos["+ i +"].Status");
				communicationRecordInfo.RecordId = context.StringValue("DescribeRealTimeRecordList.CommunicationRecordInfos["+ i +"].RecordId");

				List<string> communicationRecordInfo_callAreas = new List<string>();
				for (int j = 0; j < context.Length("DescribeRealTimeRecordList.CommunicationRecordInfos["+ i +"].CallAreas.Length"); j++) {
					communicationRecordInfo_callAreas.Add(context.StringValue("DescribeRealTimeRecordList.CommunicationRecordInfos["+ i +"].CallAreas["+ j +"]"));
				}
				communicationRecordInfo.CallAreas = communicationRecordInfo_callAreas;

				describeRealTimeRecordListResponse_communicationRecordInfos.Add(communicationRecordInfo);
			}
			describeRealTimeRecordListResponse.CommunicationRecordInfos = describeRealTimeRecordListResponse_communicationRecordInfos;
        
			return describeRealTimeRecordListResponse;
        }
    }
}