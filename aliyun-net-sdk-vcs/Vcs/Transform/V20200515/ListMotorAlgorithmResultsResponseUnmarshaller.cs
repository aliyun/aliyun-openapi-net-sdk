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
    public class ListMotorAlgorithmResultsResponseUnmarshaller
    {
        public static ListMotorAlgorithmResultsResponse Unmarshall(UnmarshallerContext context)
        {
			ListMotorAlgorithmResultsResponse listMotorAlgorithmResultsResponse = new ListMotorAlgorithmResultsResponse();

			listMotorAlgorithmResultsResponse.HttpResponse = context.HttpResponse;
			listMotorAlgorithmResultsResponse.Code = context.StringValue("ListMotorAlgorithmResults.Code");
			listMotorAlgorithmResultsResponse.Message = context.StringValue("ListMotorAlgorithmResults.Message");
			listMotorAlgorithmResultsResponse.RequestId = context.StringValue("ListMotorAlgorithmResults.RequestId");

			ListMotorAlgorithmResultsResponse.ListMotorAlgorithmResults_Data data = new ListMotorAlgorithmResultsResponse.ListMotorAlgorithmResults_Data();
			data.PageNumber = context.IntegerValue("ListMotorAlgorithmResults.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListMotorAlgorithmResults.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListMotorAlgorithmResults.Data.TotalCount");
			data.TotalPage = context.IntegerValue("ListMotorAlgorithmResults.Data.TotalPage");

			List<ListMotorAlgorithmResultsResponse.ListMotorAlgorithmResults_Data.ListMotorAlgorithmResults_RecordsItem> data_records = new List<ListMotorAlgorithmResultsResponse.ListMotorAlgorithmResults_Data.ListMotorAlgorithmResults_RecordsItem>();
			for (int i = 0; i < context.Length("ListMotorAlgorithmResults.Data.Records.Length"); i++) {
				ListMotorAlgorithmResultsResponse.ListMotorAlgorithmResults_Data.ListMotorAlgorithmResults_RecordsItem recordsItem = new ListMotorAlgorithmResultsResponse.ListMotorAlgorithmResults_Data.ListMotorAlgorithmResults_RecordsItem();
				recordsItem.CorpId = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].CorpId");
				recordsItem.DataSourceId = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].DataSourceId");
				recordsItem.LeftTopX = context.FloatValue("ListMotorAlgorithmResults.Data.Records["+ i +"].LeftTopX");
				recordsItem.LeftTopY = context.FloatValue("ListMotorAlgorithmResults.Data.Records["+ i +"].LeftTopY");
				recordsItem.MotorId = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].MotorId");
				recordsItem.PicUrlPath = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].PicUrlPath");
				recordsItem.PlateNumber = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].PlateNumber");
				recordsItem.RightBottomX = context.FloatValue("ListMotorAlgorithmResults.Data.Records["+ i +"].RightBottomX");
				recordsItem.RightBottomY = context.FloatValue("ListMotorAlgorithmResults.Data.Records["+ i +"].RightBottomY");
				recordsItem.ShotTime = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].ShotTime");
				recordsItem.TargetPicUrlPath = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].TargetPicUrlPath");
				recordsItem.MotorStyle = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].MotorStyle");
				recordsItem.MotorModel = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].MotorModel");
				recordsItem.MotorColor = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].MotorColor");
				recordsItem.MotorClass = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].MotorClass");
				recordsItem.MotorBrand = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].MotorBrand");
				recordsItem.PlateColor = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].PlateColor");
				recordsItem.PlateClass = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].PlateClass");
				recordsItem.SafetyBelt = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].SafetyBelt");
				recordsItem.Calling = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].Calling");
				recordsItem.SourceId = context.StringValue("ListMotorAlgorithmResults.Data.Records["+ i +"].SourceId");

				data_records.Add(recordsItem);
			}
			data.Records = data_records;
			listMotorAlgorithmResultsResponse.Data = data;
        
			return listMotorAlgorithmResultsResponse;
        }
    }
}
