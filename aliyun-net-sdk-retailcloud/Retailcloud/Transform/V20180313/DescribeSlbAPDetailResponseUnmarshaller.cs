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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class DescribeSlbAPDetailResponseUnmarshaller
    {
        public static DescribeSlbAPDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSlbAPDetailResponse describeSlbAPDetailResponse = new DescribeSlbAPDetailResponse();

			describeSlbAPDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeSlbAPDetailResponse.Code = _ctx.IntegerValue("DescribeSlbAPDetail.Code");
			describeSlbAPDetailResponse.ErrMsg = _ctx.StringValue("DescribeSlbAPDetail.ErrMsg");
			describeSlbAPDetailResponse.RequestId = _ctx.StringValue("DescribeSlbAPDetail.RequestId");
			describeSlbAPDetailResponse.Success = _ctx.BooleanValue("DescribeSlbAPDetail.Success");

			DescribeSlbAPDetailResponse.DescribeSlbAPDetail_Result result = new DescribeSlbAPDetailResponse.DescribeSlbAPDetail_Result();
			result.AppId = _ctx.LongValue("DescribeSlbAPDetail.Result.AppId");
			result.CookieTimeout = _ctx.IntegerValue("DescribeSlbAPDetail.Result.CookieTimeout");
			result.EnvId = _ctx.LongValue("DescribeSlbAPDetail.Result.EnvId");
			result.EstablishedTimeout = _ctx.IntegerValue("DescribeSlbAPDetail.Result.EstablishedTimeout");
			result.ListenerPort = _ctx.IntegerValue("DescribeSlbAPDetail.Result.ListenerPort");
			result.Name = _ctx.StringValue("DescribeSlbAPDetail.Result.Name");
			result.NetworkMode = _ctx.StringValue("DescribeSlbAPDetail.Result.NetworkMode");
			result.Protocol = _ctx.StringValue("DescribeSlbAPDetail.Result.Protocol");
			result.RealServerPort = _ctx.IntegerValue("DescribeSlbAPDetail.Result.RealServerPort");
			result.SlbAPId = _ctx.LongValue("DescribeSlbAPDetail.Result.SlbAPId");
			result.SlbId = _ctx.StringValue("DescribeSlbAPDetail.Result.SlbId");
			result.SlbIp = _ctx.StringValue("DescribeSlbAPDetail.Result.SlbIp");
			result.SslCertId = _ctx.StringValue("DescribeSlbAPDetail.Result.SslCertId");
			result.StickySession = _ctx.IntegerValue("DescribeSlbAPDetail.Result.StickySession");
			describeSlbAPDetailResponse.Result = result;
        
			return describeSlbAPDetailResponse;
        }
    }
}
