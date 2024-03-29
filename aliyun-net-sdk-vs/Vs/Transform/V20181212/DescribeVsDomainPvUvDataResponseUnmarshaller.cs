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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeVsDomainPvUvDataResponseUnmarshaller
    {
        public static DescribeVsDomainPvUvDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVsDomainPvUvDataResponse describeVsDomainPvUvDataResponse = new DescribeVsDomainPvUvDataResponse();

			describeVsDomainPvUvDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVsDomainPvUvDataResponse.RequestId = _ctx.StringValue("DescribeVsDomainPvUvData.RequestId");
			describeVsDomainPvUvDataResponse.DomainName = _ctx.StringValue("DescribeVsDomainPvUvData.DomainName");
			describeVsDomainPvUvDataResponse.StartTime = _ctx.StringValue("DescribeVsDomainPvUvData.StartTime");
			describeVsDomainPvUvDataResponse.EndTime = _ctx.StringValue("DescribeVsDomainPvUvData.EndTime");
			describeVsDomainPvUvDataResponse.DataInterval = _ctx.StringValue("DescribeVsDomainPvUvData.DataInterval");

			List<DescribeVsDomainPvUvDataResponse.DescribeVsDomainPvUvData_PvUvDataInfo> describeVsDomainPvUvDataResponse_pvUvDataInfos = new List<DescribeVsDomainPvUvDataResponse.DescribeVsDomainPvUvData_PvUvDataInfo>();
			for (int i = 0; i < _ctx.Length("DescribeVsDomainPvUvData.PvUvDataInfos.Length"); i++) {
				DescribeVsDomainPvUvDataResponse.DescribeVsDomainPvUvData_PvUvDataInfo pvUvDataInfo = new DescribeVsDomainPvUvDataResponse.DescribeVsDomainPvUvData_PvUvDataInfo();
				pvUvDataInfo.PV = _ctx.StringValue("DescribeVsDomainPvUvData.PvUvDataInfos["+ i +"].PV");
				pvUvDataInfo.UV = _ctx.StringValue("DescribeVsDomainPvUvData.PvUvDataInfos["+ i +"].UV");
				pvUvDataInfo.TimeStamp = _ctx.StringValue("DescribeVsDomainPvUvData.PvUvDataInfos["+ i +"].TimeStamp");

				describeVsDomainPvUvDataResponse_pvUvDataInfos.Add(pvUvDataInfo);
			}
			describeVsDomainPvUvDataResponse.PvUvDataInfos = describeVsDomainPvUvDataResponse_pvUvDataInfos;
        
			return describeVsDomainPvUvDataResponse;
        }
    }
}
