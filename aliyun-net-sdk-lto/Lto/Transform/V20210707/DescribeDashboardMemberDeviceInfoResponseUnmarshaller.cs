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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class DescribeDashboardMemberDeviceInfoResponseUnmarshaller
    {
        public static DescribeDashboardMemberDeviceInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDashboardMemberDeviceInfoResponse describeDashboardMemberDeviceInfoResponse = new DescribeDashboardMemberDeviceInfoResponse();

			describeDashboardMemberDeviceInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeDashboardMemberDeviceInfoResponse.Code = _ctx.StringValue("DescribeDashboardMemberDeviceInfo.Code");
			describeDashboardMemberDeviceInfoResponse.HttpStatusCode = _ctx.IntegerValue("DescribeDashboardMemberDeviceInfo.HttpStatusCode");
			describeDashboardMemberDeviceInfoResponse.Message = _ctx.StringValue("DescribeDashboardMemberDeviceInfo.Message");
			describeDashboardMemberDeviceInfoResponse.RequestId = _ctx.StringValue("DescribeDashboardMemberDeviceInfo.RequestId");
			describeDashboardMemberDeviceInfoResponse.Success = _ctx.BooleanValue("DescribeDashboardMemberDeviceInfo.Success");

			List<DescribeDashboardMemberDeviceInfoResponse.DescribeDashboardMemberDeviceInfo_DataItem> describeDashboardMemberDeviceInfoResponse_data = new List<DescribeDashboardMemberDeviceInfoResponse.DescribeDashboardMemberDeviceInfo_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeDashboardMemberDeviceInfo.Data.Length"); i++) {
				DescribeDashboardMemberDeviceInfoResponse.DescribeDashboardMemberDeviceInfo_DataItem dataItem = new DescribeDashboardMemberDeviceInfoResponse.DescribeDashboardMemberDeviceInfo_DataItem();
				dataItem.MemberName = _ctx.StringValue("DescribeDashboardMemberDeviceInfo.Data["+ i +"].MemberName");

				List<DescribeDashboardMemberDeviceInfoResponse.DescribeDashboardMemberDeviceInfo_DataItem.DescribeDashboardMemberDeviceInfo_MemberInfo> dataItem_memberInfoList = new List<DescribeDashboardMemberDeviceInfoResponse.DescribeDashboardMemberDeviceInfo_DataItem.DescribeDashboardMemberDeviceInfo_MemberInfo>();
				for (int j = 0; j < _ctx.Length("DescribeDashboardMemberDeviceInfo.Data["+ i +"].MemberInfoList.Length"); j++) {
					DescribeDashboardMemberDeviceInfoResponse.DescribeDashboardMemberDeviceInfo_DataItem.DescribeDashboardMemberDeviceInfo_MemberInfo memberInfo = new DescribeDashboardMemberDeviceInfoResponse.DescribeDashboardMemberDeviceInfo_DataItem.DescribeDashboardMemberDeviceInfo_MemberInfo();
					memberInfo.Time = _ctx.LongValue("DescribeDashboardMemberDeviceInfo.Data["+ i +"].MemberInfoList["+ j +"].Time");
					memberInfo.DeviceCount = _ctx.IntegerValue("DescribeDashboardMemberDeviceInfo.Data["+ i +"].MemberInfoList["+ j +"].DeviceCount");

					dataItem_memberInfoList.Add(memberInfo);
				}
				dataItem.MemberInfoList = dataItem_memberInfoList;

				describeDashboardMemberDeviceInfoResponse_data.Add(dataItem);
			}
			describeDashboardMemberDeviceInfoResponse.Data = describeDashboardMemberDeviceInfoResponse_data;
        
			return describeDashboardMemberDeviceInfoResponse;
        }
    }
}
