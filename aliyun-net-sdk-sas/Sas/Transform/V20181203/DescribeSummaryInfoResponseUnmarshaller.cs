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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeSummaryInfoResponseUnmarshaller
    {
        public static DescribeSummaryInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSummaryInfoResponse describeSummaryInfoResponse = new DescribeSummaryInfoResponse();

			describeSummaryInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeSummaryInfoResponse.RequestId = _ctx.StringValue("DescribeSummaryInfo.RequestId");
			describeSummaryInfoResponse.Success = _ctx.BooleanValue("DescribeSummaryInfo.Success");
			describeSummaryInfoResponse.AegisClientOfflineCount = _ctx.IntegerValue("DescribeSummaryInfo.AegisClientOfflineCount");
			describeSummaryInfoResponse.AegisClientOnlineCount = _ctx.IntegerValue("DescribeSummaryInfo.AegisClientOnlineCount");
			describeSummaryInfoResponse.SecurityScore = _ctx.IntegerValue("DescribeSummaryInfo.SecurityScore");
        
			return describeSummaryInfoResponse;
        }
    }
}
