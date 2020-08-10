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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class ListFaceAlgorithmResultsResponseUnmarshaller
    {
        public static ListFaceAlgorithmResultsResponse Unmarshall(UnmarshallerContext context)
        {
			ListFaceAlgorithmResultsResponse listFaceAlgorithmResultsResponse = new ListFaceAlgorithmResultsResponse();

			listFaceAlgorithmResultsResponse.HttpResponse = context.HttpResponse;
			listFaceAlgorithmResultsResponse.Code = context.StringValue("ListFaceAlgorithmResults.Code");
			listFaceAlgorithmResultsResponse.Message = context.StringValue("ListFaceAlgorithmResults.Message");
			listFaceAlgorithmResultsResponse.RequestId = context.StringValue("ListFaceAlgorithmResults.RequestId");

			ListFaceAlgorithmResultsResponse.ListFaceAlgorithmResults_Data data = new ListFaceAlgorithmResultsResponse.ListFaceAlgorithmResults_Data();
			data.PageNumber = context.IntegerValue("ListFaceAlgorithmResults.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListFaceAlgorithmResults.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListFaceAlgorithmResults.Data.TotalCount");
			data.TotalPage = context.IntegerValue("ListFaceAlgorithmResults.Data.TotalPage");

			List<ListFaceAlgorithmResultsResponse.ListFaceAlgorithmResults_Data.ListFaceAlgorithmResults_RecordsItem> data_records = new List<ListFaceAlgorithmResultsResponse.ListFaceAlgorithmResults_Data.ListFaceAlgorithmResults_RecordsItem>();
			for (int i = 0; i < context.Length("ListFaceAlgorithmResults.Data.Records.Length"); i++) {
				ListFaceAlgorithmResultsResponse.ListFaceAlgorithmResults_Data.ListFaceAlgorithmResults_RecordsItem recordsItem = new ListFaceAlgorithmResultsResponse.ListFaceAlgorithmResults_Data.ListFaceAlgorithmResults_RecordsItem();
				recordsItem.FaceId = context.StringValue("ListFaceAlgorithmResults.Data.Records["+ i +"].FaceId");
				recordsItem.CorpId = context.StringValue("ListFaceAlgorithmResults.Data.Records["+ i +"].CorpId");
				recordsItem.DataSourceId = context.StringValue("ListFaceAlgorithmResults.Data.Records["+ i +"].DataSourceId");
				recordsItem.ShotTime = context.StringValue("ListFaceAlgorithmResults.Data.Records["+ i +"].ShotTime");
				recordsItem.GenderCode = context.StringValue("ListFaceAlgorithmResults.Data.Records["+ i +"].GenderCode");
				recordsItem.MinAge = context.StringValue("ListFaceAlgorithmResults.Data.Records["+ i +"].MinAge");
				recordsItem.MaxAge = context.StringValue("ListFaceAlgorithmResults.Data.Records["+ i +"].MaxAge");
				recordsItem.CapStyle = context.StringValue("ListFaceAlgorithmResults.Data.Records["+ i +"].CapStyle");
				recordsItem.HairStyle = context.StringValue("ListFaceAlgorithmResults.Data.Records["+ i +"].HairStyle");
				recordsItem.LeftTopX = context.FloatValue("ListFaceAlgorithmResults.Data.Records["+ i +"].LeftTopX");
				recordsItem.LeftTopY = context.FloatValue("ListFaceAlgorithmResults.Data.Records["+ i +"].LeftTopY");
				recordsItem.RightBottomX = context.FloatValue("ListFaceAlgorithmResults.Data.Records["+ i +"].RightBottomX");
				recordsItem.RightBottomY = context.FloatValue("ListFaceAlgorithmResults.Data.Records["+ i +"].RightBottomY");
				recordsItem.PicUrlPath = context.StringValue("ListFaceAlgorithmResults.Data.Records["+ i +"].PicUrlPath");
				recordsItem.TargetPicUrlPath = context.StringValue("ListFaceAlgorithmResults.Data.Records["+ i +"].TargetPicUrlPath");
				recordsItem.SourceId = context.StringValue("ListFaceAlgorithmResults.Data.Records["+ i +"].SourceId");

				data_records.Add(recordsItem);
			}
			data.Records = data_records;
			listFaceAlgorithmResultsResponse.Data = data;
        
			return listFaceAlgorithmResultsResponse;
        }
    }
}
