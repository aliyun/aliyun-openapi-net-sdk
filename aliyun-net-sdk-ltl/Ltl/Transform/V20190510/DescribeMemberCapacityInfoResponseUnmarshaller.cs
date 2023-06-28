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
using Aliyun.Acs.ltl.Model.V20190510;

namespace Aliyun.Acs.ltl.Transform.V20190510
{
    public class DescribeMemberCapacityInfoResponseUnmarshaller
    {
        public static DescribeMemberCapacityInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMemberCapacityInfoResponse describeMemberCapacityInfoResponse = new DescribeMemberCapacityInfoResponse();

			describeMemberCapacityInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeMemberCapacityInfoResponse.Code = _ctx.IntegerValue("DescribeMemberCapacityInfo.Code");
			describeMemberCapacityInfoResponse.Message = _ctx.StringValue("DescribeMemberCapacityInfo.Message");
			describeMemberCapacityInfoResponse.RequestId = _ctx.StringValue("DescribeMemberCapacityInfo.RequestId");
			describeMemberCapacityInfoResponse.Success = _ctx.BooleanValue("DescribeMemberCapacityInfo.Success");

			List<DescribeMemberCapacityInfoResponse.DescribeMemberCapacityInfo_MemberCapacityInfo> describeMemberCapacityInfoResponse_data = new List<DescribeMemberCapacityInfoResponse.DescribeMemberCapacityInfo_MemberCapacityInfo>();
			for (int i = 0; i < _ctx.Length("DescribeMemberCapacityInfo.Data.Length"); i++) {
				DescribeMemberCapacityInfoResponse.DescribeMemberCapacityInfo_MemberCapacityInfo memberCapacityInfo = new DescribeMemberCapacityInfoResponse.DescribeMemberCapacityInfo_MemberCapacityInfo();
				memberCapacityInfo.UsedCapacity = _ctx.StringValue("DescribeMemberCapacityInfo.Data["+ i +"].UsedCapacity");
				memberCapacityInfo.MemberId = _ctx.StringValue("DescribeMemberCapacityInfo.Data["+ i +"].MemberId");
				memberCapacityInfo.MemberName = _ctx.StringValue("DescribeMemberCapacityInfo.Data["+ i +"].MemberName");
				memberCapacityInfo.UsedCount = _ctx.StringValue("DescribeMemberCapacityInfo.Data["+ i +"].UsedCount");
				memberCapacityInfo.MemberUid = _ctx.StringValue("DescribeMemberCapacityInfo.Data["+ i +"].MemberUid");

				describeMemberCapacityInfoResponse_data.Add(memberCapacityInfo);
			}
			describeMemberCapacityInfoResponse.Data = describeMemberCapacityInfoResponse_data;
        
			return describeMemberCapacityInfoResponse;
        }
    }
}
