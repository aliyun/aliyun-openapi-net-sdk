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
    public class DescribeDomainBpsDataByTimeStampResponseUnmarshaller
    {
        public static DescribeDomainBpsDataByTimeStampResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainBpsDataByTimeStampResponse describeDomainBpsDataByTimeStampResponse = new DescribeDomainBpsDataByTimeStampResponse();

			describeDomainBpsDataByTimeStampResponse.HttpResponse = context.HttpResponse;
			describeDomainBpsDataByTimeStampResponse.RequestId = context.StringValue("DescribeDomainBpsDataByTimeStamp.RequestId");
			describeDomainBpsDataByTimeStampResponse.DomainName = context.StringValue("DescribeDomainBpsDataByTimeStamp.DomainName");
			describeDomainBpsDataByTimeStampResponse.TimeStamp = context.StringValue("DescribeDomainBpsDataByTimeStamp.TimeStamp");

			List<DescribeDomainBpsDataByTimeStampResponse.DescribeDomainBpsDataByTimeStamp_BpsDataModel> describeDomainBpsDataByTimeStampResponse_bpsDataList = new List<DescribeDomainBpsDataByTimeStampResponse.DescribeDomainBpsDataByTimeStamp_BpsDataModel>();
			for (int i = 0; i < context.Length("DescribeDomainBpsDataByTimeStamp.BpsDataList.Length"); i++) {
				DescribeDomainBpsDataByTimeStampResponse.DescribeDomainBpsDataByTimeStamp_BpsDataModel bpsDataModel = new DescribeDomainBpsDataByTimeStampResponse.DescribeDomainBpsDataByTimeStamp_BpsDataModel();
				bpsDataModel.LocationName = context.StringValue("DescribeDomainBpsDataByTimeStamp.BpsDataList["+ i +"].LocationName");
				bpsDataModel.IspName = context.StringValue("DescribeDomainBpsDataByTimeStamp.BpsDataList["+ i +"].IspName");
				bpsDataModel.Bps = context.LongValue("DescribeDomainBpsDataByTimeStamp.BpsDataList["+ i +"].Bps");

				describeDomainBpsDataByTimeStampResponse_bpsDataList.Add(bpsDataModel);
			}
			describeDomainBpsDataByTimeStampResponse.BpsDataList = describeDomainBpsDataByTimeStampResponse_bpsDataList;
        
			return describeDomainBpsDataByTimeStampResponse;
        }
    }
}