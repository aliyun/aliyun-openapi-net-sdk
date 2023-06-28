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
using Aliyun.Acs.ltl.Model.V20190510;

namespace Aliyun.Acs.ltl.Transform.V20190510
{
    public class DescribeMPCoSPhaseInfoResponseUnmarshaller
    {
        public static DescribeMPCoSPhaseInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMPCoSPhaseInfoResponse describeMPCoSPhaseInfoResponse = new DescribeMPCoSPhaseInfoResponse();

			describeMPCoSPhaseInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeMPCoSPhaseInfoResponse.Code = _ctx.IntegerValue("DescribeMPCoSPhaseInfo.Code");
			describeMPCoSPhaseInfoResponse.Message = _ctx.StringValue("DescribeMPCoSPhaseInfo.Message");
			describeMPCoSPhaseInfoResponse.RequestId = _ctx.StringValue("DescribeMPCoSPhaseInfo.RequestId");
			describeMPCoSPhaseInfoResponse.Success = _ctx.BooleanValue("DescribeMPCoSPhaseInfo.Success");

			DescribeMPCoSPhaseInfoResponse.DescribeMPCoSPhaseInfo_Data data = new DescribeMPCoSPhaseInfoResponse.DescribeMPCoSPhaseInfo_Data();
			data.PreviousHash = _ctx.StringValue("DescribeMPCoSPhaseInfo.Data.PreviousHash");
			data.ProductKey = _ctx.StringValue("DescribeMPCoSPhaseInfo.Data.ProductKey");
			data.DataHash = _ctx.StringValue("DescribeMPCoSPhaseInfo.Data.DataHash");
			data.DataValue = _ctx.StringValue("DescribeMPCoSPhaseInfo.Data.DataValue");
			data.Timestamp = _ctx.LongValue("DescribeMPCoSPhaseInfo.Data.Timestamp");
			data.TransactionHash = _ctx.StringValue("DescribeMPCoSPhaseInfo.Data.TransactionHash");
			data.BlockHash = _ctx.StringValue("DescribeMPCoSPhaseInfo.Data.BlockHash");
			data.BlockNumber = _ctx.LongValue("DescribeMPCoSPhaseInfo.Data.BlockNumber");
			data.IotId = _ctx.StringValue("DescribeMPCoSPhaseInfo.Data.IotId");

			List<DescribeMPCoSPhaseInfoResponse.DescribeMPCoSPhaseInfo_Data.DescribeMPCoSPhaseInfo_RelatedData> data_relatedDataList = new List<DescribeMPCoSPhaseInfoResponse.DescribeMPCoSPhaseInfo_Data.DescribeMPCoSPhaseInfo_RelatedData>();
			for (int i = 0; i < _ctx.Length("DescribeMPCoSPhaseInfo.Data.RelatedDataList.Length"); i++) {
				DescribeMPCoSPhaseInfoResponse.DescribeMPCoSPhaseInfo_Data.DescribeMPCoSPhaseInfo_RelatedData relatedData = new DescribeMPCoSPhaseInfoResponse.DescribeMPCoSPhaseInfo_Data.DescribeMPCoSPhaseInfo_RelatedData();
				relatedData.RelatedDataKey = _ctx.StringValue("DescribeMPCoSPhaseInfo.Data.RelatedDataList["+ i +"].RelatedDataKey");
				relatedData.RelatedPhaseDataHash = _ctx.StringValue("DescribeMPCoSPhaseInfo.Data.RelatedDataList["+ i +"].RelatedPhaseDataHash");
				relatedData.RelatedDataSeq = _ctx.StringValue("DescribeMPCoSPhaseInfo.Data.RelatedDataList["+ i +"].RelatedDataSeq");
				relatedData.RelatedPhaseName = _ctx.StringValue("DescribeMPCoSPhaseInfo.Data.RelatedDataList["+ i +"].RelatedPhaseName");
				relatedData.RelatedPhaseId = _ctx.StringValue("DescribeMPCoSPhaseInfo.Data.RelatedDataList["+ i +"].RelatedPhaseId");

				data_relatedDataList.Add(relatedData);
			}
			data.RelatedDataList = data_relatedDataList;
			describeMPCoSPhaseInfoResponse.Data = data;
        
			return describeMPCoSPhaseInfoResponse;
        }
    }
}
