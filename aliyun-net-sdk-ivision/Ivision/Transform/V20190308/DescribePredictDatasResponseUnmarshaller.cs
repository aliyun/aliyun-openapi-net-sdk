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
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class DescribePredictDatasResponseUnmarshaller
    {
        public static DescribePredictDatasResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePredictDatasResponse describePredictDatasResponse = new DescribePredictDatasResponse();

			describePredictDatasResponse.HttpResponse = context.HttpResponse;
			describePredictDatasResponse.RequestId = context.StringValue("DescribePredictDatas.RequestId");
			describePredictDatasResponse.TotalNum = context.LongValue("DescribePredictDatas.TotalNum");
			describePredictDatasResponse.CurrentPage = context.LongValue("DescribePredictDatas.CurrentPage");
			describePredictDatasResponse.PageSize = context.LongValue("DescribePredictDatas.PageSize");
			describePredictDatasResponse.NextPageToken = context.StringValue("DescribePredictDatas.NextPageToken");

			List<DescribePredictDatasResponse.DescribePredictDatas_PredictData> describePredictDatasResponse_predictDatas = new List<DescribePredictDatasResponse.DescribePredictDatas_PredictData>();
			for (int i = 0; i < context.Length("DescribePredictDatas.PredictDatas.Length"); i++) {
				DescribePredictDatasResponse.DescribePredictDatas_PredictData predictData = new DescribePredictDatasResponse.DescribePredictDatas_PredictData();
				predictData.ProjectId = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].ProjectId");
				predictData.IterationId = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].IterationId");
				predictData.DataId = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].DataId");
				predictData.DataName = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].DataName");
				predictData.DataUrl = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].DataUrl");
				predictData.CreationTime = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].CreationTime");
				predictData.Status = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].Status");
				predictData.ErrorCode = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].ErrorCode");
				predictData.ErrorMessage = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].ErrorMessage");

				List<DescribePredictDatasResponse.DescribePredictDatas_PredictData.DescribePredictDatas_PredictionResult> predictData_predictionResults = new List<DescribePredictDatasResponse.DescribePredictDatas_PredictData.DescribePredictDatas_PredictionResult>();
				for (int j = 0; j < context.Length("DescribePredictDatas.PredictDatas["+ i +"].PredictionResults.Length"); j++) {
					DescribePredictDatasResponse.DescribePredictDatas_PredictData.DescribePredictDatas_PredictionResult predictionResult = new DescribePredictDatasResponse.DescribePredictDatas_PredictData.DescribePredictDatas_PredictionResult();
					predictionResult.TagId = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].PredictionResults["+ j +"].TagId");
					predictionResult.TagName = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].PredictionResults["+ j +"].TagName");
					predictionResult.Probability = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].PredictionResults["+ j +"].Probability");
					predictionResult.Overlap = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].PredictionResults["+ j +"].Overlap");
					predictionResult.RegionType = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].PredictionResults["+ j +"].RegionType");
					predictionResult.Properties = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].PredictionResults["+ j +"].Properties");

					DescribePredictDatasResponse.DescribePredictDatas_PredictData.DescribePredictDatas_PredictionResult.DescribePredictDatas_Region region = new DescribePredictDatasResponse.DescribePredictDatas_PredictData.DescribePredictDatas_PredictionResult.DescribePredictDatas_Region();
					region.Left = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].PredictionResults["+ j +"].Region.Left");
					region.Top = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].PredictionResults["+ j +"].Region.Top");
					region.Width = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].PredictionResults["+ j +"].Region.Width");
					region.Height = context.StringValue("DescribePredictDatas.PredictDatas["+ i +"].PredictionResults["+ j +"].Region.Height");
					predictionResult.Region = region;

					predictData_predictionResults.Add(predictionResult);
				}
				predictData.PredictionResults = predictData_predictionResults;

				describePredictDatasResponse_predictDatas.Add(predictData);
			}
			describePredictDatasResponse.PredictDatas = describePredictDatasResponse_predictDatas;
        
			return describePredictDatasResponse;
        }
    }
}
