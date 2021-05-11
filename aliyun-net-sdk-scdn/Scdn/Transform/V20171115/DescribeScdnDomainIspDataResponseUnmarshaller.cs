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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnDomainIspDataResponseUnmarshaller
    {
        public static DescribeScdnDomainIspDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnDomainIspDataResponse describeScdnDomainIspDataResponse = new DescribeScdnDomainIspDataResponse();

			describeScdnDomainIspDataResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnDomainIspDataResponse.RequestId = _ctx.StringValue("DescribeScdnDomainIspData.RequestId");
			describeScdnDomainIspDataResponse.DomainName = _ctx.StringValue("DescribeScdnDomainIspData.DomainName");
			describeScdnDomainIspDataResponse.DataInterval = _ctx.StringValue("DescribeScdnDomainIspData.DataInterval");
			describeScdnDomainIspDataResponse.StartTime = _ctx.StringValue("DescribeScdnDomainIspData.StartTime");
			describeScdnDomainIspDataResponse.EndTime = _ctx.StringValue("DescribeScdnDomainIspData.EndTime");

			List<DescribeScdnDomainIspDataResponse.DescribeScdnDomainIspData_ISPProportionData> describeScdnDomainIspDataResponse_value = new List<DescribeScdnDomainIspDataResponse.DescribeScdnDomainIspData_ISPProportionData>();
			for (int i = 0; i < _ctx.Length("DescribeScdnDomainIspData.Value.Length"); i++) {
				DescribeScdnDomainIspDataResponse.DescribeScdnDomainIspData_ISPProportionData iSPProportionData = new DescribeScdnDomainIspDataResponse.DescribeScdnDomainIspData_ISPProportionData();
				iSPProportionData.ISP = _ctx.StringValue("DescribeScdnDomainIspData.Value["+ i +"].ISP");
				iSPProportionData.Proportion = _ctx.StringValue("DescribeScdnDomainIspData.Value["+ i +"].Proportion");
				iSPProportionData.IspEname = _ctx.StringValue("DescribeScdnDomainIspData.Value["+ i +"].IspEname");
				iSPProportionData.AvgObjectSize = _ctx.StringValue("DescribeScdnDomainIspData.Value["+ i +"].AvgObjectSize");
				iSPProportionData.AvgResponseTime = _ctx.StringValue("DescribeScdnDomainIspData.Value["+ i +"].AvgResponseTime");
				iSPProportionData.Bps = _ctx.StringValue("DescribeScdnDomainIspData.Value["+ i +"].Bps");
				iSPProportionData.Qps = _ctx.StringValue("DescribeScdnDomainIspData.Value["+ i +"].Qps");
				iSPProportionData.AvgResponseRate = _ctx.StringValue("DescribeScdnDomainIspData.Value["+ i +"].AvgResponseRate");
				iSPProportionData.ReqErrRate = _ctx.StringValue("DescribeScdnDomainIspData.Value["+ i +"].ReqErrRate");
				iSPProportionData.TotalBytes = _ctx.StringValue("DescribeScdnDomainIspData.Value["+ i +"].TotalBytes");
				iSPProportionData.BytesProportion = _ctx.StringValue("DescribeScdnDomainIspData.Value["+ i +"].BytesProportion");
				iSPProportionData.TotalQuery = _ctx.StringValue("DescribeScdnDomainIspData.Value["+ i +"].TotalQuery");

				describeScdnDomainIspDataResponse_value.Add(iSPProportionData);
			}
			describeScdnDomainIspDataResponse._Value = describeScdnDomainIspDataResponse_value;
        
			return describeScdnDomainIspDataResponse;
        }
    }
}
