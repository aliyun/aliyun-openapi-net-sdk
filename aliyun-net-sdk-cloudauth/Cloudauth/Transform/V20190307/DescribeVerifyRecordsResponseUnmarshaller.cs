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
        public static DescribeVerifyRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVerifyRecordsResponse describeVerifyRecordsResponse = new DescribeVerifyRecordsResponse();

			describeVerifyRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeVerifyRecordsResponse.RequestId = _ctx.StringValue("DescribeVerifyRecords.RequestId");
			describeVerifyRecordsResponse.TotalCount = _ctx.IntegerValue("DescribeVerifyRecords.TotalCount");
			describeVerifyRecordsResponse.PageSize = _ctx.IntegerValue("DescribeVerifyRecords.PageSize");
			describeVerifyRecordsResponse.CurrentPage = _ctx.IntegerValue("DescribeVerifyRecords.CurrentPage");
			describeVerifyRecordsResponse.QueryId = _ctx.StringValue("DescribeVerifyRecords.QueryId");

			List<DescribeVerifyRecordsResponse.DescribeVerifyRecords_Records> describeVerifyRecordsResponse_recordsList = new List<DescribeVerifyRecordsResponse.DescribeVerifyRecords_Records>();
			for (int i = 0; i < _ctx.Length("DescribeVerifyRecords.RecordsList.Length"); i++) {
				DescribeVerifyRecordsResponse.DescribeVerifyRecords_Records records = new DescribeVerifyRecordsResponse.DescribeVerifyRecords_Records();
				records.BizType = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].BizType");
				records.BizId = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].BizId");
				records.DataStats = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].DataStats");
				records.VerifyId = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].VerifyId");
				records.FinishTime = _ctx.LongValue("DescribeVerifyRecords.RecordsList["+ i +"].FinishTime");
				records.Status = _ctx.IntegerValue("DescribeVerifyRecords.RecordsList["+ i +"].Status");
				records.IdCardFaceComparisonScore = _ctx.FloatValue("DescribeVerifyRecords.RecordsList["+ i +"].IdCardFaceComparisonScore");
				records.AuthorityComparisonScore = _ctx.FloatValue("DescribeVerifyRecords.RecordsList["+ i +"].AuthorityComparisonScore");

				DescribeVerifyRecordsResponse.DescribeVerifyRecords_Records.DescribeVerifyRecords_Material material = new DescribeVerifyRecordsResponse.DescribeVerifyRecords_Records.DescribeVerifyRecords_Material();
				material.FaceImageUrl = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.FaceImageUrl");
				material.IdCardName = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardName");
				material.IdCardNumber = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardNumber");

				DescribeVerifyRecordsResponse.DescribeVerifyRecords_Records.DescribeVerifyRecords_Material.DescribeVerifyRecords_IdCardInfo idCardInfo = new DescribeVerifyRecordsResponse.DescribeVerifyRecords_Records.DescribeVerifyRecords_Material.DescribeVerifyRecords_IdCardInfo();
				idCardInfo.FrontImageUrl = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.FrontImageUrl");
				idCardInfo.BackImageUrl = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.BackImageUrl");
				idCardInfo.Name = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.Name");
				idCardInfo.Number = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.Number");
				idCardInfo.Address = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.Address");
				idCardInfo.Birth = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.Birth");
				idCardInfo.Sex = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.Sex");
				idCardInfo.Nationality = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.Nationality");
				idCardInfo.Authority = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.Authority");
				idCardInfo.StartDate = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.StartDate");
				idCardInfo.EndDate = _ctx.StringValue("DescribeVerifyRecords.RecordsList["+ i +"].Material.IdCardInfo.EndDate");
				material.IdCardInfo = idCardInfo;
				records.Material = material;

				describeVerifyRecordsResponse_recordsList.Add(records);
			}
			describeVerifyRecordsResponse.RecordsList = describeVerifyRecordsResponse_recordsList;
        
			return describeVerifyRecordsResponse;
        }
    }
}
