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
        public static DescribeSlbAPDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSlbAPDetailResponse describeSlbAPDetailResponse = new DescribeSlbAPDetailResponse();

			describeSlbAPDetailResponse.HttpResponse = context.HttpResponse;
			describeSlbAPDetailResponse.Code = context.IntegerValue("DescribeSlbAPDetail.Code");
			describeSlbAPDetailResponse.ErrMsg = context.StringValue("DescribeSlbAPDetail.ErrMsg");
			describeSlbAPDetailResponse.RequestId = context.StringValue("DescribeSlbAPDetail.RequestId");
			describeSlbAPDetailResponse.Success = context.BooleanValue("DescribeSlbAPDetail.Success");

			DescribeSlbAPDetailResponse.DescribeSlbAPDetail_Result result = new DescribeSlbAPDetailResponse.DescribeSlbAPDetail_Result();
			result.AppId = context.LongValue("DescribeSlbAPDetail.Result.AppId");
			result.CookieTimeout = context.IntegerValue("DescribeSlbAPDetail.Result.CookieTimeout");
			result.EnvId = context.LongValue("DescribeSlbAPDetail.Result.EnvId");
			result.EstablishedTimeout = context.IntegerValue("DescribeSlbAPDetail.Result.EstablishedTimeout");
			result.ListenerPort = context.IntegerValue("DescribeSlbAPDetail.Result.ListenerPort");
			result.Name = context.StringValue("DescribeSlbAPDetail.Result.Name");
			result.NetworkMode = context.StringValue("DescribeSlbAPDetail.Result.NetworkMode");
			result.Protocol = context.StringValue("DescribeSlbAPDetail.Result.Protocol");
			result.RealServerPort = context.IntegerValue("DescribeSlbAPDetail.Result.RealServerPort");
			result.SlbAPId = context.LongValue("DescribeSlbAPDetail.Result.SlbAPId");
			result.SlbId = context.StringValue("DescribeSlbAPDetail.Result.SlbId");
			result.SlbIp = context.StringValue("DescribeSlbAPDetail.Result.SlbIp");
			result.SslCertId = context.StringValue("DescribeSlbAPDetail.Result.SslCertId");
			result.StickySession = context.IntegerValue("DescribeSlbAPDetail.Result.StickySession");
			describeSlbAPDetailResponse.Result = result;
        
			return describeSlbAPDetailResponse;
        }
    }
}
