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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeBatchResultDetailResponseUnmarshaller
    {
        public static DescribeBatchResultDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBatchResultDetailResponse describeBatchResultDetailResponse = new DescribeBatchResultDetailResponse();

			describeBatchResultDetailResponse.HttpResponse = context.HttpResponse;
			describeBatchResultDetailResponse.RequestId = context.StringValue("DescribeBatchResultDetail.RequestId");
			describeBatchResultDetailResponse.TotalCount = context.LongValue("DescribeBatchResultDetail.TotalCount");
			describeBatchResultDetailResponse.PageNumber = context.LongValue("DescribeBatchResultDetail.PageNumber");
			describeBatchResultDetailResponse.PageSize = context.LongValue("DescribeBatchResultDetail.PageSize");

			List<DescribeBatchResultDetailResponse.DescribeBatchResultDetail_BatchResultDetail> describeBatchResultDetailResponse_batchResultDetails = new List<DescribeBatchResultDetailResponse.DescribeBatchResultDetail_BatchResultDetail>();
			for (int i = 0; i < context.Length("DescribeBatchResultDetail.BatchResultDetails.Length"); i++) {
				DescribeBatchResultDetailResponse.DescribeBatchResultDetail_BatchResultDetail batchResultDetail = new DescribeBatchResultDetailResponse.DescribeBatchResultDetail_BatchResultDetail();
				batchResultDetail.Domain = context.StringValue("DescribeBatchResultDetail.BatchResultDetails["+ i +"].Domain");
				batchResultDetail.Type = context.StringValue("DescribeBatchResultDetail.BatchResultDetails["+ i +"].Type");
				batchResultDetail.Rr = context.StringValue("DescribeBatchResultDetail.BatchResultDetails["+ i +"].Rr");
				batchResultDetail._Value = context.StringValue("DescribeBatchResultDetail.BatchResultDetails["+ i +"].Value");
				batchResultDetail.Status = context.BooleanValue("DescribeBatchResultDetail.BatchResultDetails["+ i +"].Status");
				batchResultDetail.Reason = context.StringValue("DescribeBatchResultDetail.BatchResultDetails["+ i +"].Reason");
				batchResultDetail.NewRr = context.StringValue("DescribeBatchResultDetail.BatchResultDetails["+ i +"].NewRr");
				batchResultDetail.NewValue = context.StringValue("DescribeBatchResultDetail.BatchResultDetails["+ i +"].NewValue");
				batchResultDetail.BatchType = context.StringValue("DescribeBatchResultDetail.BatchResultDetails["+ i +"].BatchType");
				batchResultDetail.OperateDateStr = context.StringValue("DescribeBatchResultDetail.BatchResultDetails["+ i +"].OperateDateStr");
				batchResultDetail.Line = context.StringValue("DescribeBatchResultDetail.BatchResultDetails["+ i +"].Line");
				batchResultDetail.Priority = context.StringValue("DescribeBatchResultDetail.BatchResultDetails["+ i +"].Priority");
				batchResultDetail.Ttl = context.StringValue("DescribeBatchResultDetail.BatchResultDetails["+ i +"].Ttl");
				batchResultDetail.RecordId = context.StringValue("DescribeBatchResultDetail.BatchResultDetails["+ i +"].RecordId");
				batchResultDetail.Remark = context.StringValue("DescribeBatchResultDetail.BatchResultDetails["+ i +"].Remark");
				batchResultDetail.RrStatus = context.StringValue("DescribeBatchResultDetail.BatchResultDetails["+ i +"].RrStatus");

				describeBatchResultDetailResponse_batchResultDetails.Add(batchResultDetail);
			}
			describeBatchResultDetailResponse.BatchResultDetails = describeBatchResultDetailResponse_batchResultDetails;
        
			return describeBatchResultDetailResponse;
        }
    }
}
