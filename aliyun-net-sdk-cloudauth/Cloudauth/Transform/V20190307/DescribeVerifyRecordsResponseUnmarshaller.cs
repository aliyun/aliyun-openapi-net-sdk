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
using Aliyun.Acs.Cloudauth.Model.V20190307;

namespace Aliyun.Acs.Cloudauth.Transform.V20190307
{
    public class DescribeVerifyRecordsResponseUnmarshaller
    {
        public static DescribeVerifyRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVerifyRecordsResponse describeVerifyRecordsResponse = new DescribeVerifyRecordsResponse();

			describeVerifyRecordsResponse.HttpResponse = context.HttpResponse;
			describeVerifyRecordsResponse.RequestId = context.StringValue("DescribeVerifyRecords.RequestId");
			describeVerifyRecordsResponse.TotalCount = context.IntegerValue("DescribeVerifyRecords.TotalCount");
			describeVerifyRecordsResponse.PageSize = context.IntegerValue("DescribeVerifyRecords.PageSize");
			describeVerifyRecordsResponse.CurrentPage = context.IntegerValue("DescribeVerifyRecords.CurrentPage");
			describeVerifyRecordsResponse.QueryId = context.StringValue("DescribeVerifyRecords.QueryId");

			List<DescribeVerifyRecordsResponse.DescribeVerifyRecords_Records> describeVerifyRecordsResponse_recordsList = new List<DescribeVerifyRecordsResponse.DescribeVerifyRecords_Records>();
			for (int i = 0; i < context.Length("DescribeVerifyRecords.RecordsList.Length"); i++) {
				DescribeVerifyRecordsResponse.DescribeVerifyRecords_Records records = new DescribeVerifyRecordsResponse.DescribeVerifyRecords_Records();
				records.BizType = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].BizType");
				records.BizId = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].BizId");
				records.DataStats = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].DataStats");
				records.VerifyId = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].VerifyId");
				records.FinishTime = context.LongValue("DescribeVerifyRecords.RecordsList["+ i +"].FinishTime");
				records.Status = context.IntegerValue("DescribeVerifyRecords.RecordsList["+ i +"].Status");
				records.IdCardFaceComparisonScore = context.FloatValue("DescribeVerifyRecords.RecordsList["+ i +"].IdCardFaceComparisonScore");
				records.AuthorityComparisonScore = context.FloatValue("DescribeVerifyRecords.RecordsList["+ i +"].AuthorityComparisonScore");

				DescribeVerifyRecordsResponse.DescribeVerifyRecords_Records.DescribeVerifyRecords_Material material = new DescribeVerifyRecordsResponse.DescribeVerifyRecords_Records.DescribeVerifyRecords_Material();
				material.FaceImageUrl = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.FaceImageUrl");
				material.IdCardName = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardName");
				material.IdCardNumber = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardNumber");

				DescribeVerifyRecordsResponse.DescribeVerifyRecords_Records.DescribeVerifyRecords_Material.DescribeVerifyRecords_IdCardInfo idCardInfo = new DescribeVerifyRecordsResponse.DescribeVerifyRecords_Records.DescribeVerifyRecords_Material.DescribeVerifyRecords_IdCardInfo();
				idCardInfo.FrontImageUrl = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.FrontImageUrl");
				idCardInfo.BackImageUrl = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.BackImageUrl");
				idCardInfo.Name = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.Name");
				idCardInfo.Number = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.Number");
				idCardInfo.Address = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.Address");
				idCardInfo.Birth = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.Birth");
				idCardInfo.Sex = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.Sex");
				idCardInfo.Nationality = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.Nationality");
				idCardInfo.Authority = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.Authority");
				idCardInfo.StartDate = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.StartDate");
				idCardInfo.EndDate = context.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.EndDate");
				material.IdCardInfo = idCardInfo;
				records.Material = material;

				describeVerifyRecordsResponse_recordsList.Add(records);
			}
			describeVerifyRecordsResponse.RecordsList = describeVerifyRecordsResponse_recordsList;
        
			return describeVerifyRecordsResponse;
        }
    }
}
