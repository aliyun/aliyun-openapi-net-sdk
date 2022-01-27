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
    public class DescribeLiveDomainRecordDataResponseUnmarshaller
    {
        public static DescribeLiveDomainRecordDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainRecordDataResponse describeLiveDomainRecordDataResponse = new DescribeLiveDomainRecordDataResponse();

			describeLiveDomainRecordDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainRecordDataResponse.RequestId = _ctx.StringValue("DescribeLiveDomainRecordData.RequestId");

			List<DescribeLiveDomainRecordDataResponse.DescribeLiveDomainRecordData_RecordDataInfo> describeLiveDomainRecordDataResponse_recordDataInfos = new List<DescribeLiveDomainRecordDataResponse.DescribeLiveDomainRecordData_RecordDataInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainRecordData.RecordDataInfos.Length"); i++) {
				DescribeLiveDomainRecordDataResponse.DescribeLiveDomainRecordData_RecordDataInfo recordDataInfo = new DescribeLiveDomainRecordDataResponse.DescribeLiveDomainRecordData_RecordDataInfo();
				recordDataInfo.Date = _ctx.StringValue("DescribeLiveDomainRecordData.RecordDataInfos["+ i +"].Date");
				recordDataInfo.Total = _ctx.IntegerValue("DescribeLiveDomainRecordData.RecordDataInfos["+ i +"].Total");

				DescribeLiveDomainRecordDataResponse.DescribeLiveDomainRecordData_RecordDataInfo.DescribeLiveDomainRecordData_Detail detail = new DescribeLiveDomainRecordDataResponse.DescribeLiveDomainRecordData_RecordDataInfo.DescribeLiveDomainRecordData_Detail();
				detail.MP4 = _ctx.IntegerValue("DescribeLiveDomainRecordData.RecordDataInfos["+ i +"].Detail.MP4");
				detail.FLV = _ctx.IntegerValue("DescribeLiveDomainRecordData.RecordDataInfos["+ i +"].Detail.FLV");
				detail.TS = _ctx.IntegerValue("DescribeLiveDomainRecordData.RecordDataInfos["+ i +"].Detail.TS");
				recordDataInfo.Detail = detail;

				describeLiveDomainRecordDataResponse_recordDataInfos.Add(recordDataInfo);
			}
			describeLiveDomainRecordDataResponse.RecordDataInfos = describeLiveDomainRecordDataResponse_recordDataInfos;
        
			return describeLiveDomainRecordDataResponse;
        }
    }
}
