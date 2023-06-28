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
    public class DescribeStatMemberDeviceInfoResponseUnmarshaller
    {
        public static DescribeStatMemberDeviceInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStatMemberDeviceInfoResponse describeStatMemberDeviceInfoResponse = new DescribeStatMemberDeviceInfoResponse();

			describeStatMemberDeviceInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeStatMemberDeviceInfoResponse.Code = _ctx.StringValue("DescribeStatMemberDeviceInfo.Code");
			describeStatMemberDeviceInfoResponse.HttpStatusCode = _ctx.IntegerValue("DescribeStatMemberDeviceInfo.HttpStatusCode");
			describeStatMemberDeviceInfoResponse.Message = _ctx.StringValue("DescribeStatMemberDeviceInfo.Message");
			describeStatMemberDeviceInfoResponse.RequestId = _ctx.StringValue("DescribeStatMemberDeviceInfo.RequestId");
			describeStatMemberDeviceInfoResponse.Success = _ctx.BooleanValue("DescribeStatMemberDeviceInfo.Success");

			List<DescribeStatMemberDeviceInfoResponse.DescribeStatMemberDeviceInfo_DataItem> describeStatMemberDeviceInfoResponse_data = new List<DescribeStatMemberDeviceInfoResponse.DescribeStatMemberDeviceInfo_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeStatMemberDeviceInfo.Data.Length"); i++) {
				DescribeStatMemberDeviceInfoResponse.DescribeStatMemberDeviceInfo_DataItem dataItem = new DescribeStatMemberDeviceInfoResponse.DescribeStatMemberDeviceInfo_DataItem();
				dataItem.MemberId = _ctx.StringValue("DescribeStatMemberDeviceInfo.Data["+ i +"].MemberId");
				dataItem.MemberName = _ctx.StringValue("DescribeStatMemberDeviceInfo.Data["+ i +"].MemberName");
				dataItem.BizChainCount = _ctx.StringValue("DescribeStatMemberDeviceInfo.Data["+ i +"].BizChainCount");
				dataItem.AuthorizedCount = _ctx.StringValue("DescribeStatMemberDeviceInfo.Data["+ i +"].AuthorizedCount");
				dataItem.UsedCount = _ctx.StringValue("DescribeStatMemberDeviceInfo.Data["+ i +"].UsedCount");

				describeStatMemberDeviceInfoResponse_data.Add(dataItem);
			}
			describeStatMemberDeviceInfoResponse.Data = describeStatMemberDeviceInfoResponse_data;
        
			return describeStatMemberDeviceInfoResponse;
        }
    }
}
