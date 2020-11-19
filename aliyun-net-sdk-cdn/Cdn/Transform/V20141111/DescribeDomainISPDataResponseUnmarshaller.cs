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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainISPDataResponseUnmarshaller
    {
        public static DescribeDomainISPDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainISPDataResponse describeDomainISPDataResponse = new DescribeDomainISPDataResponse();

			describeDomainISPDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainISPDataResponse.RequestId = _ctx.StringValue("DescribeDomainISPData.RequestId");
			describeDomainISPDataResponse.DomainName = _ctx.StringValue("DescribeDomainISPData.DomainName");
			describeDomainISPDataResponse.DataInterval = _ctx.StringValue("DescribeDomainISPData.DataInterval");
			describeDomainISPDataResponse.StartTime = _ctx.StringValue("DescribeDomainISPData.StartTime");
			describeDomainISPDataResponse.EndTime = _ctx.StringValue("DescribeDomainISPData.EndTime");

			List<DescribeDomainISPDataResponse.DescribeDomainISPData_ISPProportionData> describeDomainISPDataResponse_value = new List<DescribeDomainISPDataResponse.DescribeDomainISPData_ISPProportionData>();
			for (int i = 0; i < _ctx.Length("DescribeDomainISPData.Value.Length"); i++) {
				DescribeDomainISPDataResponse.DescribeDomainISPData_ISPProportionData iSPProportionData = new DescribeDomainISPDataResponse.DescribeDomainISPData_ISPProportionData();
				iSPProportionData.ISP = _ctx.StringValue("DescribeDomainISPData.Value["+ i +"].ISP");
				iSPProportionData.Proportion = _ctx.StringValue("DescribeDomainISPData.Value["+ i +"].Proportion");
				iSPProportionData.IspEname = _ctx.StringValue("DescribeDomainISPData.Value["+ i +"].IspEname");
				iSPProportionData.AvgObjectSize = _ctx.StringValue("DescribeDomainISPData.Value["+ i +"].AvgObjectSize");
				iSPProportionData.AvgResponseTime = _ctx.StringValue("DescribeDomainISPData.Value["+ i +"].AvgResponseTime");
				iSPProportionData.Bps = _ctx.StringValue("DescribeDomainISPData.Value["+ i +"].Bps");
				iSPProportionData.Qps = _ctx.StringValue("DescribeDomainISPData.Value["+ i +"].Qps");
				iSPProportionData.AvgResponseRate = _ctx.StringValue("DescribeDomainISPData.Value["+ i +"].AvgResponseRate");
				iSPProportionData.ByteHitRate = _ctx.StringValue("DescribeDomainISPData.Value["+ i +"].ByteHitRate");
				iSPProportionData.ReqHitRate = _ctx.StringValue("DescribeDomainISPData.Value["+ i +"].ReqHitRate");
				iSPProportionData.ReqErrRate = _ctx.StringValue("DescribeDomainISPData.Value["+ i +"].ReqErrRate");
				iSPProportionData.TotalBytes = _ctx.StringValue("DescribeDomainISPData.Value["+ i +"].TotalBytes");
				iSPProportionData.BytesProportion = _ctx.StringValue("DescribeDomainISPData.Value["+ i +"].BytesProportion");
				iSPProportionData.TotalQuery = _ctx.StringValue("DescribeDomainISPData.Value["+ i +"].TotalQuery");

				describeDomainISPDataResponse_value.Add(iSPProportionData);
			}
			describeDomainISPDataResponse._Value = describeDomainISPDataResponse_value;
        
			return describeDomainISPDataResponse;
        }
    }
}
