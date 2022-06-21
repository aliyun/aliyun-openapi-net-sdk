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
    public class DescribeLiveDomainBpsDataByTimeStampResponseUnmarshaller
    {
        public static DescribeLiveDomainBpsDataByTimeStampResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainBpsDataByTimeStampResponse describeLiveDomainBpsDataByTimeStampResponse = new DescribeLiveDomainBpsDataByTimeStampResponse();

			describeLiveDomainBpsDataByTimeStampResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainBpsDataByTimeStampResponse.RequestId = _ctx.StringValue("DescribeLiveDomainBpsDataByTimeStamp.RequestId");
			describeLiveDomainBpsDataByTimeStampResponse.DomainName = _ctx.StringValue("DescribeLiveDomainBpsDataByTimeStamp.DomainName");
			describeLiveDomainBpsDataByTimeStampResponse.TimeStamp = _ctx.StringValue("DescribeLiveDomainBpsDataByTimeStamp.TimeStamp");

			List<DescribeLiveDomainBpsDataByTimeStampResponse.DescribeLiveDomainBpsDataByTimeStamp_BpsDataModel> describeLiveDomainBpsDataByTimeStampResponse_bpsDataList = new List<DescribeLiveDomainBpsDataByTimeStampResponse.DescribeLiveDomainBpsDataByTimeStamp_BpsDataModel>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainBpsDataByTimeStamp.BpsDataList.Length"); i++) {
				DescribeLiveDomainBpsDataByTimeStampResponse.DescribeLiveDomainBpsDataByTimeStamp_BpsDataModel bpsDataModel = new DescribeLiveDomainBpsDataByTimeStampResponse.DescribeLiveDomainBpsDataByTimeStamp_BpsDataModel();
				bpsDataModel.TimeStamp = _ctx.StringValue("DescribeLiveDomainBpsDataByTimeStamp.BpsDataList["+ i +"].TimeStamp");
				bpsDataModel.LocationName = _ctx.StringValue("DescribeLiveDomainBpsDataByTimeStamp.BpsDataList["+ i +"].LocationName");
				bpsDataModel.IspName = _ctx.StringValue("DescribeLiveDomainBpsDataByTimeStamp.BpsDataList["+ i +"].IspName");
				bpsDataModel.Bps = _ctx.LongValue("DescribeLiveDomainBpsDataByTimeStamp.BpsDataList["+ i +"].Bps");

				describeLiveDomainBpsDataByTimeStampResponse_bpsDataList.Add(bpsDataModel);
			}
			describeLiveDomainBpsDataByTimeStampResponse.BpsDataList = describeLiveDomainBpsDataByTimeStampResponse_bpsDataList;
        
			return describeLiveDomainBpsDataByTimeStampResponse;
        }
    }
}
