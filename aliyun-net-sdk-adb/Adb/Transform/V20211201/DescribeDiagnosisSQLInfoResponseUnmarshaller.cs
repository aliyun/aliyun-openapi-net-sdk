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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class DescribeDiagnosisSQLInfoResponseUnmarshaller
    {
        public static DescribeDiagnosisSQLInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDiagnosisSQLInfoResponse describeDiagnosisSQLInfoResponse = new DescribeDiagnosisSQLInfoResponse();

			describeDiagnosisSQLInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeDiagnosisSQLInfoResponse.DiagnosisSQLInfo = _ctx.StringValue("DescribeDiagnosisSQLInfo.DiagnosisSQLInfo");
			describeDiagnosisSQLInfoResponse.RequestId = _ctx.StringValue("DescribeDiagnosisSQLInfo.RequestId");

			List<DescribeDiagnosisSQLInfoResponse.DescribeDiagnosisSQLInfo_StageInfosItem> describeDiagnosisSQLInfoResponse_stageInfos = new List<DescribeDiagnosisSQLInfoResponse.DescribeDiagnosisSQLInfo_StageInfosItem>();
			for (int i = 0; i < _ctx.Length("DescribeDiagnosisSQLInfo.StageInfos.Length"); i++) {
				DescribeDiagnosisSQLInfoResponse.DescribeDiagnosisSQLInfo_StageInfosItem stageInfosItem = new DescribeDiagnosisSQLInfoResponse.DescribeDiagnosisSQLInfo_StageInfosItem();
				stageInfosItem.InputRows = _ctx.LongValue("DescribeDiagnosisSQLInfo.StageInfos["+ i +"].InputRows");
				stageInfosItem.InputDataSize = _ctx.LongValue("DescribeDiagnosisSQLInfo.StageInfos["+ i +"].InputDataSize");
				stageInfosItem.OutputRows = _ctx.LongValue("DescribeDiagnosisSQLInfo.StageInfos["+ i +"].OutputRows");
				stageInfosItem.OutputDataSize = _ctx.LongValue("DescribeDiagnosisSQLInfo.StageInfos["+ i +"].OutputDataSize");
				stageInfosItem.PeakMemory = _ctx.LongValue("DescribeDiagnosisSQLInfo.StageInfos["+ i +"].PeakMemory");
				stageInfosItem.OperatorCost = _ctx.LongValue("DescribeDiagnosisSQLInfo.StageInfos["+ i +"].OperatorCost");
				stageInfosItem.StageId = _ctx.StringValue("DescribeDiagnosisSQLInfo.StageInfos["+ i +"].StageId");
				stageInfosItem.State = _ctx.StringValue("DescribeDiagnosisSQLInfo.StageInfos["+ i +"].State");
				stageInfosItem.Progress = _ctx.DoubleValue("DescribeDiagnosisSQLInfo.StageInfos["+ i +"].Progress");

				describeDiagnosisSQLInfoResponse_stageInfos.Add(stageInfosItem);
			}
			describeDiagnosisSQLInfoResponse.StageInfos = describeDiagnosisSQLInfoResponse_stageInfos;
        
			return describeDiagnosisSQLInfoResponse;
        }
    }
}
