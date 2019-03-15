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
using Aliyun.Acs.finmall.Model.V20180723;

namespace Aliyun.Acs.finmall.Transform.V20180723
{
    public class GetLatestOverdueRecordResponseUnmarshaller
    {
        public static GetLatestOverdueRecordResponse Unmarshall(UnmarshallerContext context)
        {
			GetLatestOverdueRecordResponse getLatestOverdueRecordResponse = new GetLatestOverdueRecordResponse();

			getLatestOverdueRecordResponse.HttpResponse = context.HttpResponse;
			getLatestOverdueRecordResponse.Code = context.StringValue("GetLatestOverdueRecord.Code");
			getLatestOverdueRecordResponse.Message = context.StringValue("GetLatestOverdueRecord.Message");
			getLatestOverdueRecordResponse.RequestId = context.StringValue("GetLatestOverdueRecord.RequestId");

			GetLatestOverdueRecordResponse.GetLatestOverdueRecord_Data data = new GetLatestOverdueRecordResponse.GetLatestOverdueRecord_Data();
			data.OverdueId = context.StringValue("GetLatestOverdueRecord.Data.OverdueId");
			data.CreditId = context.StringValue("GetLatestOverdueRecord.Data.CreditId");
			data.OverdueType = context.StringValue("GetLatestOverdueRecord.Data.OverdueType");
			data.CreditAccount = context.StringValue("GetLatestOverdueRecord.Data.CreditAccount");
			data.Principal = context.StringValue("GetLatestOverdueRecord.Data.Principal");
			data.InterestAmount = context.StringValue("GetLatestOverdueRecord.Data.InterestAmount");
			data.InterestOfInterest = context.StringValue("GetLatestOverdueRecord.Data.InterestOfInterest");
			data.FineAmount = context.StringValue("GetLatestOverdueRecord.Data.FineAmount");
			data.FineInterest = context.StringValue("GetLatestOverdueRecord.Data.FineInterest");
			data.OverdueStartDate = context.StringValue("GetLatestOverdueRecord.Data.OverdueStartDate");
			data.OverdueDays = context.StringValue("GetLatestOverdueRecord.Data.OverdueDays");
			getLatestOverdueRecordResponse.Data = data;
        
			return getLatestOverdueRecordResponse;
        }
    }
}
