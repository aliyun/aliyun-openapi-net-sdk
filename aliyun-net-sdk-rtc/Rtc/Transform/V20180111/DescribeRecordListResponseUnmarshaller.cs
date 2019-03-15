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
    public class DescribeRecordListResponseUnmarshaller
    {
        public static DescribeRecordListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRecordListResponse describeRecordListResponse = new DescribeRecordListResponse();

			describeRecordListResponse.HttpResponse = context.HttpResponse;
			describeRecordListResponse.RequestId = context.StringValue("DescribeRecordList.RequestId");
			describeRecordListResponse.PageSize = context.LongValue("DescribeRecordList.PageSize");
			describeRecordListResponse.PageNo = context.LongValue("DescribeRecordList.PageNo");
			describeRecordListResponse.TotalCnt = context.LongValue("DescribeRecordList.TotalCnt");

			List<DescribeRecordListResponse.DescribeRecordList_CommunicationRecordInfo> describeRecordListResponse_communicationRecordInfos = new List<DescribeRecordListResponse.DescribeRecordList_CommunicationRecordInfo>();
			for (int i = 0; i < context.Length("DescribeRecordList.CommunicationRecordInfos.Length"); i++) {
				DescribeRecordListResponse.DescribeRecordList_CommunicationRecordInfo communicationRecordInfo = new DescribeRecordListResponse.DescribeRecordList_CommunicationRecordInfo();
				communicationRecordInfo.ChannelId = context.StringValue("DescribeRecordList.CommunicationRecordInfos["+ i +"].ChannelId");
				communicationRecordInfo.StartTime = context.StringValue("DescribeRecordList.CommunicationRecordInfos["+ i +"].StartTime");
				communicationRecordInfo.EndTime = context.StringValue("DescribeRecordList.CommunicationRecordInfos["+ i +"].EndTime");
				communicationRecordInfo.TotalUserCnt = context.LongValue("DescribeRecordList.CommunicationRecordInfos["+ i +"].TotalUserCnt");
				communicationRecordInfo.Status = context.BooleanValue("DescribeRecordList.CommunicationRecordInfos["+ i +"].Status");
				communicationRecordInfo.RecordId = context.StringValue("DescribeRecordList.CommunicationRecordInfos["+ i +"].RecordId");

				List<string> communicationRecordInfo_callAreas = new List<string>();
				for (int j = 0; j < context.Length("DescribeRecordList.CommunicationRecordInfos["+ i +"].CallAreas.Length"); j++) {
					communicationRecordInfo_callAreas.Add(context.StringValue("DescribeRecordList.CommunicationRecordInfos["+ i +"].CallAreas["+ j +"]"));
				}
				communicationRecordInfo.CallAreas = communicationRecordInfo_callAreas;

				describeRecordListResponse_communicationRecordInfos.Add(communicationRecordInfo);
			}
			describeRecordListResponse.CommunicationRecordInfos = describeRecordListResponse_communicationRecordInfos;
        
			return describeRecordListResponse;
        }
    }
}
