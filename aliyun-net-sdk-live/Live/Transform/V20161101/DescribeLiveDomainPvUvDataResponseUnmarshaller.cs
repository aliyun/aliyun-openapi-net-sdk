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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveDomainPvUvDataResponseUnmarshaller
    {
        public static DescribeLiveDomainPvUvDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainPvUvDataResponse describeLiveDomainPvUvDataResponse = new DescribeLiveDomainPvUvDataResponse();

			describeLiveDomainPvUvDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainPvUvDataResponse.RequestId = _ctx.StringValue("DescribeLiveDomainPvUvData.RequestId");
			describeLiveDomainPvUvDataResponse.DomainName = _ctx.StringValue("DescribeLiveDomainPvUvData.DomainName");
			describeLiveDomainPvUvDataResponse.StartTime = _ctx.StringValue("DescribeLiveDomainPvUvData.StartTime");
			describeLiveDomainPvUvDataResponse.EndTime = _ctx.StringValue("DescribeLiveDomainPvUvData.EndTime");
			describeLiveDomainPvUvDataResponse.DataInterval = _ctx.StringValue("DescribeLiveDomainPvUvData.DataInterval");

			List<DescribeLiveDomainPvUvDataResponse.DescribeLiveDomainPvUvData_PvUvDataInfo> describeLiveDomainPvUvDataResponse_pvUvDataInfos = new List<DescribeLiveDomainPvUvDataResponse.DescribeLiveDomainPvUvData_PvUvDataInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainPvUvData.PvUvDataInfos.Length"); i++) {
				DescribeLiveDomainPvUvDataResponse.DescribeLiveDomainPvUvData_PvUvDataInfo pvUvDataInfo = new DescribeLiveDomainPvUvDataResponse.DescribeLiveDomainPvUvData_PvUvDataInfo();
				pvUvDataInfo.PV = _ctx.StringValue("DescribeLiveDomainPvUvData.PvUvDataInfos["+ i +"].PV");
				pvUvDataInfo.UV = _ctx.StringValue("DescribeLiveDomainPvUvData.PvUvDataInfos["+ i +"].UV");
				pvUvDataInfo.TimeStamp = _ctx.StringValue("DescribeLiveDomainPvUvData.PvUvDataInfos["+ i +"].TimeStamp");

				describeLiveDomainPvUvDataResponse_pvUvDataInfos.Add(pvUvDataInfo);
			}
			describeLiveDomainPvUvDataResponse.PvUvDataInfos = describeLiveDomainPvUvDataResponse_pvUvDataInfos;
        
			return describeLiveDomainPvUvDataResponse;
        }
    }
}
