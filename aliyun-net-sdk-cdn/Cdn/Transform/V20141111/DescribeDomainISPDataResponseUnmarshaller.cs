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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainISPDataResponseUnmarshaller
    {
        public static DescribeDomainISPDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainISPDataResponse describeDomainISPDataResponse = new DescribeDomainISPDataResponse();

			describeDomainISPDataResponse.HttpResponse = context.HttpResponse;
			describeDomainISPDataResponse.RequestId = context.StringValue("DescribeDomainISPData.RequestId");
			describeDomainISPDataResponse.DomainName = context.StringValue("DescribeDomainISPData.DomainName");
			describeDomainISPDataResponse.DataInterval = context.StringValue("DescribeDomainISPData.DataInterval");
			describeDomainISPDataResponse.StartTime = context.StringValue("DescribeDomainISPData.StartTime");
			describeDomainISPDataResponse.EndTime = context.StringValue("DescribeDomainISPData.EndTime");

			List<DescribeDomainISPDataResponse.DescribeDomainISPData_ISPProportionData> describeDomainISPDataResponse_value = new List<DescribeDomainISPDataResponse.DescribeDomainISPData_ISPProportionData>();
			for (int i = 0; i < context.Length("DescribeDomainISPData.Value.Length"); i++) {
				DescribeDomainISPDataResponse.DescribeDomainISPData_ISPProportionData iSPProportionData = new DescribeDomainISPDataResponse.DescribeDomainISPData_ISPProportionData();
				iSPProportionData.ISP = context.StringValue("DescribeDomainISPData.Value["+ i +"].ISP");
				iSPProportionData.Proportion = context.StringValue("DescribeDomainISPData.Value["+ i +"].Proportion");
				iSPProportionData.IspEname = context.StringValue("DescribeDomainISPData.Value["+ i +"].IspEname");
				iSPProportionData.AvgObjectSize = context.StringValue("DescribeDomainISPData.Value["+ i +"].AvgObjectSize");
				iSPProportionData.AvgResponseTime = context.StringValue("DescribeDomainISPData.Value["+ i +"].AvgResponseTime");
				iSPProportionData.Bps = context.StringValue("DescribeDomainISPData.Value["+ i +"].Bps");
				iSPProportionData.ByteHitRate = context.StringValue("DescribeDomainISPData.Value["+ i +"].ByteHitRate");
				iSPProportionData.Qps = context.StringValue("DescribeDomainISPData.Value["+ i +"].Qps");
				iSPProportionData.ReqErrRate = context.StringValue("DescribeDomainISPData.Value["+ i +"].ReqErrRate");
				iSPProportionData.ReqHitRate = context.StringValue("DescribeDomainISPData.Value["+ i +"].ReqHitRate");
				iSPProportionData.AvgResponseRate = context.StringValue("DescribeDomainISPData.Value["+ i +"].AvgResponseRate");
				iSPProportionData.TotalBytes = context.StringValue("DescribeDomainISPData.Value["+ i +"].TotalBytes");
				iSPProportionData.BytesProportion = context.StringValue("DescribeDomainISPData.Value["+ i +"].BytesProportion");
				iSPProportionData.TotalQuery = context.StringValue("DescribeDomainISPData.Value["+ i +"].TotalQuery");

				describeDomainISPDataResponse_value.Add(iSPProportionData);
			}
			describeDomainISPDataResponse._Value = describeDomainISPDataResponse_value;
        
			return describeDomainISPDataResponse;
        }
    }
}