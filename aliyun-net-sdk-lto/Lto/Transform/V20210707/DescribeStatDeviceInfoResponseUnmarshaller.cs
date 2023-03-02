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
    public class DescribeStatDeviceInfoResponseUnmarshaller
    {
        public static DescribeStatDeviceInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStatDeviceInfoResponse describeStatDeviceInfoResponse = new DescribeStatDeviceInfoResponse();

			describeStatDeviceInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeStatDeviceInfoResponse.Code = _ctx.StringValue("DescribeStatDeviceInfo.Code");
			describeStatDeviceInfoResponse.HttpStatusCode = _ctx.IntegerValue("DescribeStatDeviceInfo.HttpStatusCode");
			describeStatDeviceInfoResponse.Message = _ctx.StringValue("DescribeStatDeviceInfo.Message");
			describeStatDeviceInfoResponse.RequestId = _ctx.StringValue("DescribeStatDeviceInfo.RequestId");
			describeStatDeviceInfoResponse.Success = _ctx.BooleanValue("DescribeStatDeviceInfo.Success");

			DescribeStatDeviceInfoResponse.DescribeStatDeviceInfo_Data data = new DescribeStatDeviceInfoResponse.DescribeStatDeviceInfo_Data();
			data.TotalAuthorizedCount = _ctx.IntegerValue("DescribeStatDeviceInfo.Data.TotalAuthorizedCount");
			data.DistributableCount = _ctx.IntegerValue("DescribeStatDeviceInfo.Data.DistributableCount");

			List<DescribeStatDeviceInfoResponse.DescribeStatDeviceInfo_Data.DescribeStatDeviceInfo_BizChainInfo> data_bizChainList = new List<DescribeStatDeviceInfoResponse.DescribeStatDeviceInfo_Data.DescribeStatDeviceInfo_BizChainInfo>();
			for (int i = 0; i < _ctx.Length("DescribeStatDeviceInfo.Data.BizChainList.Length"); i++) {
				DescribeStatDeviceInfoResponse.DescribeStatDeviceInfo_Data.DescribeStatDeviceInfo_BizChainInfo bizChainInfo = new DescribeStatDeviceInfoResponse.DescribeStatDeviceInfo_Data.DescribeStatDeviceInfo_BizChainInfo();
				bizChainInfo.BizChainName = _ctx.StringValue("DescribeStatDeviceInfo.Data.BizChainList["+ i +"].BizChainName");
				bizChainInfo.AuthorizedCount = _ctx.IntegerValue("DescribeStatDeviceInfo.Data.BizChainList["+ i +"].AuthorizedCount");

				data_bizChainList.Add(bizChainInfo);
			}
			data.BizChainList = data_bizChainList;
			describeStatDeviceInfoResponse.Data = data;
        
			return describeStatDeviceInfoResponse;
        }
    }
}
