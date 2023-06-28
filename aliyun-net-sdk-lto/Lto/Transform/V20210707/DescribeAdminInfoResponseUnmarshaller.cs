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
    public class DescribeAdminInfoResponseUnmarshaller
    {
        public static DescribeAdminInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAdminInfoResponse describeAdminInfoResponse = new DescribeAdminInfoResponse();

			describeAdminInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeAdminInfoResponse.Code = _ctx.StringValue("DescribeAdminInfo.Code");
			describeAdminInfoResponse.HttpStatusCode = _ctx.IntegerValue("DescribeAdminInfo.HttpStatusCode");
			describeAdminInfoResponse.Message = _ctx.StringValue("DescribeAdminInfo.Message");
			describeAdminInfoResponse.RequestId = _ctx.StringValue("DescribeAdminInfo.RequestId");
			describeAdminInfoResponse.Success = _ctx.BooleanValue("DescribeAdminInfo.Success");

			DescribeAdminInfoResponse.DescribeAdminInfo_Data data = new DescribeAdminInfoResponse.DescribeAdminInfo_Data();
			data.MemberId = _ctx.StringValue("DescribeAdminInfo.Data.MemberId");
			data.Uid = _ctx.StringValue("DescribeAdminInfo.Data.Uid");
			data.Name = _ctx.StringValue("DescribeAdminInfo.Data.Name");
			data.AuthorizedCount = _ctx.LongValue("DescribeAdminInfo.Data.AuthorizedCount");
			data.AuthorizedDeviceCount = _ctx.LongValue("DescribeAdminInfo.Data.AuthorizedDeviceCount");
			data.Contactor = _ctx.StringValue("DescribeAdminInfo.Data.Contactor");
			data.Telephony = _ctx.StringValue("DescribeAdminInfo.Data.Telephony");
			data.Remark = _ctx.StringValue("DescribeAdminInfo.Data.Remark");
			data.Status = _ctx.StringValue("DescribeAdminInfo.Data.Status");
			data.AccessStatus = _ctx.StringValue("DescribeAdminInfo.Data.AccessStatus");
			data.AccessDate = _ctx.LongValue("DescribeAdminInfo.Data.AccessDate");
			describeAdminInfoResponse.Data = data;
        
			return describeAdminInfoResponse;
        }
    }
}
