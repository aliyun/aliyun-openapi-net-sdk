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
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetCDNStatisSumResponseUnmarshaller
    {
        public static GetCDNStatisSumResponse Unmarshall(UnmarshallerContext context)
        {
			GetCDNStatisSumResponse getCDNStatisSumResponse = new GetCDNStatisSumResponse();

			getCDNStatisSumResponse.HttpResponse = context.HttpResponse;
			getCDNStatisSumResponse.RequestId = context.StringValue("GetCDNStatisSum.RequestId");
			getCDNStatisSumResponse.SumFlowDataValue = context.LongValue("GetCDNStatisSum.SumFlowDataValue");
			getCDNStatisSumResponse.MaxBpsDataValue = context.LongValue("GetCDNStatisSum.MaxBpsDataValue");

			List<GetCDNStatisSumResponse.GetCDNStatisSum_CDNMetric> getCDNStatisSumResponse_cDNStatisList = new List<GetCDNStatisSumResponse.GetCDNStatisSum_CDNMetric>();
			for (int i = 0; i < context.Length("GetCDNStatisSum.CDNStatisList.Length"); i++) {
				GetCDNStatisSumResponse.GetCDNStatisSum_CDNMetric cDNMetric = new GetCDNStatisSumResponse.GetCDNStatisSum_CDNMetric();
				cDNMetric.StatTime = context.StringValue("GetCDNStatisSum.CDNStatisList["+ i +"].StatTime");
				cDNMetric.FlowDataDomesticValue = context.LongValue("GetCDNStatisSum.CDNStatisList["+ i +"].FlowDataDomesticValue");
				cDNMetric.FlowDataOverseasValue = context.LongValue("GetCDNStatisSum.CDNStatisList["+ i +"].FlowDataOverseasValue");
				cDNMetric.FlowDataValue = context.LongValue("GetCDNStatisSum.CDNStatisList["+ i +"].FlowDataValue");
				cDNMetric.BpsDataDomesticValue = context.LongValue("GetCDNStatisSum.CDNStatisList["+ i +"].BpsDataDomesticValue");
				cDNMetric.BpsDataOverseasValue = context.LongValue("GetCDNStatisSum.CDNStatisList["+ i +"].BpsDataOverseasValue");
				cDNMetric.BpsDataValue = context.LongValue("GetCDNStatisSum.CDNStatisList["+ i +"].BpsDataValue");

				getCDNStatisSumResponse_cDNStatisList.Add(cDNMetric);
			}
			getCDNStatisSumResponse.CDNStatisList = getCDNStatisSumResponse_cDNStatisList;
        
			return getCDNStatisSumResponse;
        }
    }
}