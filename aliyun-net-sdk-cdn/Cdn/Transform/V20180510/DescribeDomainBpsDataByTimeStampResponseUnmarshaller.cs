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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeDomainBpsDataByTimeStampResponseUnmarshaller
    {
        public static DescribeDomainBpsDataByTimeStampResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainBpsDataByTimeStampResponse describeDomainBpsDataByTimeStampResponse = new DescribeDomainBpsDataByTimeStampResponse();

			describeDomainBpsDataByTimeStampResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainBpsDataByTimeStampResponse.RequestId = _ctx.StringValue("DescribeDomainBpsDataByTimeStamp.RequestId");
			describeDomainBpsDataByTimeStampResponse.DomainName = _ctx.StringValue("DescribeDomainBpsDataByTimeStamp.DomainName");
			describeDomainBpsDataByTimeStampResponse.TimeStamp = _ctx.StringValue("DescribeDomainBpsDataByTimeStamp.TimeStamp");

			List<DescribeDomainBpsDataByTimeStampResponse.DescribeDomainBpsDataByTimeStamp_BpsDataModel> describeDomainBpsDataByTimeStampResponse_bpsDataList = new List<DescribeDomainBpsDataByTimeStampResponse.DescribeDomainBpsDataByTimeStamp_BpsDataModel>();
			for (int i = 0; i < _ctx.Length("DescribeDomainBpsDataByTimeStamp.BpsDataList.Length"); i++) {
				DescribeDomainBpsDataByTimeStampResponse.DescribeDomainBpsDataByTimeStamp_BpsDataModel bpsDataModel = new DescribeDomainBpsDataByTimeStampResponse.DescribeDomainBpsDataByTimeStamp_BpsDataModel();
				bpsDataModel.TimeStamp = _ctx.StringValue("DescribeDomainBpsDataByTimeStamp.BpsDataList["+ i +"].TimeStamp");
				bpsDataModel.LocationName = _ctx.StringValue("DescribeDomainBpsDataByTimeStamp.BpsDataList["+ i +"].LocationName");
				bpsDataModel.IspName = _ctx.StringValue("DescribeDomainBpsDataByTimeStamp.BpsDataList["+ i +"].IspName");
				bpsDataModel.Bps = _ctx.LongValue("DescribeDomainBpsDataByTimeStamp.BpsDataList["+ i +"].Bps");

				describeDomainBpsDataByTimeStampResponse_bpsDataList.Add(bpsDataModel);
			}
			describeDomainBpsDataByTimeStampResponse.BpsDataList = describeDomainBpsDataByTimeStampResponse_bpsDataList;
        
			return describeDomainBpsDataByTimeStampResponse;
        }
    }
}
