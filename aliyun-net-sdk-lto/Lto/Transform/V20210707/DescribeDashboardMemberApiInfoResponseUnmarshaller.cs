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
    public class DescribeDashboardMemberApiInfoResponseUnmarshaller
    {
        public static DescribeDashboardMemberApiInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDashboardMemberApiInfoResponse describeDashboardMemberApiInfoResponse = new DescribeDashboardMemberApiInfoResponse();

			describeDashboardMemberApiInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeDashboardMemberApiInfoResponse.Code = _ctx.StringValue("DescribeDashboardMemberApiInfo.Code");
			describeDashboardMemberApiInfoResponse.HttpStatusCode = _ctx.IntegerValue("DescribeDashboardMemberApiInfo.HttpStatusCode");
			describeDashboardMemberApiInfoResponse.Message = _ctx.StringValue("DescribeDashboardMemberApiInfo.Message");
			describeDashboardMemberApiInfoResponse.RequestId = _ctx.StringValue("DescribeDashboardMemberApiInfo.RequestId");
			describeDashboardMemberApiInfoResponse.Success = _ctx.BooleanValue("DescribeDashboardMemberApiInfo.Success");

			List<DescribeDashboardMemberApiInfoResponse.DescribeDashboardMemberApiInfo_DataItem> describeDashboardMemberApiInfoResponse_data = new List<DescribeDashboardMemberApiInfoResponse.DescribeDashboardMemberApiInfo_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeDashboardMemberApiInfo.Data.Length"); i++) {
				DescribeDashboardMemberApiInfoResponse.DescribeDashboardMemberApiInfo_DataItem dataItem = new DescribeDashboardMemberApiInfoResponse.DescribeDashboardMemberApiInfo_DataItem();
				dataItem.MemberName = _ctx.StringValue("DescribeDashboardMemberApiInfo.Data["+ i +"].MemberName");

				List<DescribeDashboardMemberApiInfoResponse.DescribeDashboardMemberApiInfo_DataItem.DescribeDashboardMemberApiInfo_MemberInfo> dataItem_memberInfoList = new List<DescribeDashboardMemberApiInfoResponse.DescribeDashboardMemberApiInfo_DataItem.DescribeDashboardMemberApiInfo_MemberInfo>();
				for (int j = 0; j < _ctx.Length("DescribeDashboardMemberApiInfo.Data["+ i +"].MemberInfoList.Length"); j++) {
					DescribeDashboardMemberApiInfoResponse.DescribeDashboardMemberApiInfo_DataItem.DescribeDashboardMemberApiInfo_MemberInfo memberInfo = new DescribeDashboardMemberApiInfoResponse.DescribeDashboardMemberApiInfo_DataItem.DescribeDashboardMemberApiInfo_MemberInfo();
					memberInfo.Time = _ctx.LongValue("DescribeDashboardMemberApiInfo.Data["+ i +"].MemberInfoList["+ j +"].Time");
					memberInfo.ApiInvokeCount = _ctx.LongValue("DescribeDashboardMemberApiInfo.Data["+ i +"].MemberInfoList["+ j +"].ApiInvokeCount");

					dataItem_memberInfoList.Add(memberInfo);
				}
				dataItem.MemberInfoList = dataItem_memberInfoList;

				describeDashboardMemberApiInfoResponse_data.Add(dataItem);
			}
			describeDashboardMemberApiInfoResponse.Data = describeDashboardMemberApiInfoResponse_data;
        
			return describeDashboardMemberApiInfoResponse;
        }
    }
}
