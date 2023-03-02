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
    public class DescribeMPCoSResourceInfoResponseUnmarshaller
    {
        public static DescribeMPCoSResourceInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMPCoSResourceInfoResponse describeMPCoSResourceInfoResponse = new DescribeMPCoSResourceInfoResponse();

			describeMPCoSResourceInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeMPCoSResourceInfoResponse.Code = _ctx.IntegerValue("DescribeMPCoSResourceInfo.Code");
			describeMPCoSResourceInfoResponse.Message = _ctx.StringValue("DescribeMPCoSResourceInfo.Message");
			describeMPCoSResourceInfoResponse.RequestId = _ctx.StringValue("DescribeMPCoSResourceInfo.RequestId");
			describeMPCoSResourceInfoResponse.Success = _ctx.BooleanValue("DescribeMPCoSResourceInfo.Success");

			DescribeMPCoSResourceInfoResponse.DescribeMPCoSResourceInfo_Data data = new DescribeMPCoSResourceInfoResponse.DescribeMPCoSResourceInfo_Data();
			data.PhaseGroupQuota = _ctx.LongValue("DescribeMPCoSResourceInfo.Data.PhaseGroupQuota");
			data.MemberQuota = _ctx.LongValue("DescribeMPCoSResourceInfo.Data.MemberQuota");
			data.UsedMember = _ctx.LongValue("DescribeMPCoSResourceInfo.Data.UsedMember");
			data.UsedPhaseGroup = _ctx.LongValue("DescribeMPCoSResourceInfo.Data.UsedPhaseGroup");

			List<DescribeMPCoSResourceInfoResponse.DescribeMPCoSResourceInfo_Data.DescribeMPCoSResourceInfo_PhaseQuotaInfo> data_phaseQuotaInfoList = new List<DescribeMPCoSResourceInfoResponse.DescribeMPCoSResourceInfo_Data.DescribeMPCoSResourceInfo_PhaseQuotaInfo>();
			for (int i = 0; i < _ctx.Length("DescribeMPCoSResourceInfo.Data.PhaseQuotaInfoList.Length"); i++) {
				DescribeMPCoSResourceInfoResponse.DescribeMPCoSResourceInfo_Data.DescribeMPCoSResourceInfo_PhaseQuotaInfo phaseQuotaInfo = new DescribeMPCoSResourceInfoResponse.DescribeMPCoSResourceInfo_Data.DescribeMPCoSResourceInfo_PhaseQuotaInfo();
				phaseQuotaInfo.PhaseGroupId = _ctx.StringValue("DescribeMPCoSResourceInfo.Data.PhaseQuotaInfoList["+ i +"].PhaseGroupId");
				phaseQuotaInfo.PhaseGroupName = _ctx.StringValue("DescribeMPCoSResourceInfo.Data.PhaseQuotaInfoList["+ i +"].PhaseGroupName");
				phaseQuotaInfo.PhaseQuota = _ctx.LongValue("DescribeMPCoSResourceInfo.Data.PhaseQuotaInfoList["+ i +"].PhaseQuota");
				phaseQuotaInfo.UsedPhase = _ctx.LongValue("DescribeMPCoSResourceInfo.Data.PhaseQuotaInfoList["+ i +"].UsedPhase");

				data_phaseQuotaInfoList.Add(phaseQuotaInfo);
			}
			data.PhaseQuotaInfoList = data_phaseQuotaInfoList;
			describeMPCoSResourceInfoResponse.Data = data;
        
			return describeMPCoSResourceInfoResponse;
        }
    }
}
