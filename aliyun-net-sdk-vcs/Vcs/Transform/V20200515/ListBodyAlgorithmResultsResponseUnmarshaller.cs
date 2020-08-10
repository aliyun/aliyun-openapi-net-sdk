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
    public class ListBodyAlgorithmResultsResponseUnmarshaller
    {
        public static ListBodyAlgorithmResultsResponse Unmarshall(UnmarshallerContext context)
        {
			ListBodyAlgorithmResultsResponse listBodyAlgorithmResultsResponse = new ListBodyAlgorithmResultsResponse();

			listBodyAlgorithmResultsResponse.HttpResponse = context.HttpResponse;
			listBodyAlgorithmResultsResponse.Code = context.StringValue("ListBodyAlgorithmResults.Code");
			listBodyAlgorithmResultsResponse.Message = context.StringValue("ListBodyAlgorithmResults.Message");
			listBodyAlgorithmResultsResponse.RequestId = context.StringValue("ListBodyAlgorithmResults.RequestId");

			ListBodyAlgorithmResultsResponse.ListBodyAlgorithmResults_Data data = new ListBodyAlgorithmResultsResponse.ListBodyAlgorithmResults_Data();
			data.PageNumber = context.IntegerValue("ListBodyAlgorithmResults.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListBodyAlgorithmResults.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListBodyAlgorithmResults.Data.TotalCount");
			data.TotalPage = context.IntegerValue("ListBodyAlgorithmResults.Data.TotalPage");

			List<ListBodyAlgorithmResultsResponse.ListBodyAlgorithmResults_Data.ListBodyAlgorithmResults_RecordsItem> data_records = new List<ListBodyAlgorithmResultsResponse.ListBodyAlgorithmResults_Data.ListBodyAlgorithmResults_RecordsItem>();
			for (int i = 0; i < context.Length("ListBodyAlgorithmResults.Data.Records.Length"); i++) {
				ListBodyAlgorithmResultsResponse.ListBodyAlgorithmResults_Data.ListBodyAlgorithmResults_RecordsItem recordsItem = new ListBodyAlgorithmResultsResponse.ListBodyAlgorithmResults_Data.ListBodyAlgorithmResults_RecordsItem();
				recordsItem.CapStyle = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].CapStyle");
				recordsItem.CorpId = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].CorpId");
				recordsItem.DataSourceId = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].DataSourceId");
				recordsItem.PersonId = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].PersonId");
				recordsItem.GenderCode = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].GenderCode");
				recordsItem.HairStyle = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].HairStyle");
				recordsItem.LeftTopX = context.FloatValue("ListBodyAlgorithmResults.Data.Records["+ i +"].LeftTopX");
				recordsItem.LeftTopY = context.FloatValue("ListBodyAlgorithmResults.Data.Records["+ i +"].LeftTopY");
				recordsItem.MaxAge = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].MaxAge");
				recordsItem.MinAge = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].MinAge");
				recordsItem.PicUrlPath = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].PicUrlPath");
				recordsItem.RightBottomX = context.FloatValue("ListBodyAlgorithmResults.Data.Records["+ i +"].RightBottomX");
				recordsItem.RightBottomY = context.FloatValue("ListBodyAlgorithmResults.Data.Records["+ i +"].RightBottomY");
				recordsItem.ShotTime = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].ShotTime");
				recordsItem.TargetPicUrlPath = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].TargetPicUrlPath");
				recordsItem.CoatLength = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].CoatLength");
				recordsItem.CoatStyle = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].CoatStyle");
				recordsItem.TrousersLength = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].TrousersLength");
				recordsItem.TrousersStyle = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].TrousersStyle");
				recordsItem.CoatColor = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].CoatColor");
				recordsItem.TrousersColor = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].TrousersColor");
				recordsItem.SourceId = context.StringValue("ListBodyAlgorithmResults.Data.Records["+ i +"].SourceId");

				data_records.Add(recordsItem);
			}
			data.Records = data_records;
			listBodyAlgorithmResultsResponse.Data = data;
        
			return listBodyAlgorithmResultsResponse;
        }
    }
}
