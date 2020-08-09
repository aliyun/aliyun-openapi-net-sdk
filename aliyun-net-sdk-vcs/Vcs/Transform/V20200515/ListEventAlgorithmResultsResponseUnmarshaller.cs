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
    public class ListEventAlgorithmResultsResponseUnmarshaller
    {
        public static ListEventAlgorithmResultsResponse Unmarshall(UnmarshallerContext context)
        {
			ListEventAlgorithmResultsResponse listEventAlgorithmResultsResponse = new ListEventAlgorithmResultsResponse();

			listEventAlgorithmResultsResponse.HttpResponse = context.HttpResponse;
			listEventAlgorithmResultsResponse.Code = context.StringValue("ListEventAlgorithmResults.Code");
			listEventAlgorithmResultsResponse.Message = context.StringValue("ListEventAlgorithmResults.Message");
			listEventAlgorithmResultsResponse.RequestId = context.StringValue("ListEventAlgorithmResults.RequestId");
			listEventAlgorithmResultsResponse.ExtendValue = context.StringValue("ListEventAlgorithmResults.ExtendValue");

			ListEventAlgorithmResultsResponse.ListEventAlgorithmResults_Data data = new ListEventAlgorithmResultsResponse.ListEventAlgorithmResults_Data();
			data.PageNumber = context.IntegerValue("ListEventAlgorithmResults.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListEventAlgorithmResults.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListEventAlgorithmResults.Data.TotalCount");
			data.TotalPage = context.IntegerValue("ListEventAlgorithmResults.Data.TotalPage");

			List<ListEventAlgorithmResultsResponse.ListEventAlgorithmResults_Data.ListEventAlgorithmResults_RecordsItem> data_records = new List<ListEventAlgorithmResultsResponse.ListEventAlgorithmResults_Data.ListEventAlgorithmResults_RecordsItem>();
			for (int i = 0; i < context.Length("ListEventAlgorithmResults.Data.Records.Length"); i++) {
				ListEventAlgorithmResultsResponse.ListEventAlgorithmResults_Data.ListEventAlgorithmResults_RecordsItem recordsItem = new ListEventAlgorithmResultsResponse.ListEventAlgorithmResults_Data.ListEventAlgorithmResults_RecordsItem();
				recordsItem.CapStyle = context.StringValue("ListEventAlgorithmResults.Data.Records["+ i +"].CapStyle");
				recordsItem.CorpId = context.StringValue("ListEventAlgorithmResults.Data.Records["+ i +"].CorpId");
				recordsItem.DataSourceId = context.StringValue("ListEventAlgorithmResults.Data.Records["+ i +"].DataSourceId");
				recordsItem.EventType = context.StringValue("ListEventAlgorithmResults.Data.Records["+ i +"].EventType");
				recordsItem.FaceCount = context.StringValue("ListEventAlgorithmResults.Data.Records["+ i +"].FaceCount");
				recordsItem.PicUrlPath = context.StringValue("ListEventAlgorithmResults.Data.Records["+ i +"].PicUrlPath");
				recordsItem.ShotTime = context.StringValue("ListEventAlgorithmResults.Data.Records["+ i +"].ShotTime");
				recordsItem.TargetPicUrlPath = context.StringValue("ListEventAlgorithmResults.Data.Records["+ i +"].TargetPicUrlPath");
				recordsItem.RecordId = context.StringValue("ListEventAlgorithmResults.Data.Records["+ i +"].RecordId");
				recordsItem.ExtendValue = context.StringValue("ListEventAlgorithmResults.Data.Records["+ i +"].ExtendValue");
				recordsItem.ExtendValueTwo = context.StringValue("ListEventAlgorithmResults.Data.Records["+ i +"].ExtendValueTwo");
				recordsItem.ExtendValueThree = context.StringValue("ListEventAlgorithmResults.Data.Records["+ i +"].ExtendValueThree");

				data_records.Add(recordsItem);
			}
			data.Records = data_records;
			listEventAlgorithmResultsResponse.Data = data;
        
			return listEventAlgorithmResultsResponse;
        }
    }
}
