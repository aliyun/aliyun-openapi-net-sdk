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
    public class PredictImageResponseUnmarshaller
    {
        public static PredictImageResponse Unmarshall(UnmarshallerContext context)
        {
			PredictImageResponse predictImageResponse = new PredictImageResponse();

			predictImageResponse.HttpResponse = context.HttpResponse;
			predictImageResponse.RequestId = context.StringValue("PredictImage.RequestId");

			List<PredictImageResponse.PredictImage_PredictData> predictImageResponse_predictDatas = new List<PredictImageResponse.PredictImage_PredictData>();
			for (int i = 0; i < context.Length("PredictImage.PredictDatas.Length"); i++) {
				PredictImageResponse.PredictImage_PredictData predictData = new PredictImageResponse.PredictImage_PredictData();
				predictData.ProjectId = context.StringValue("PredictImage.PredictDatas["+ i +"].ProjectId");
				predictData.IterationId = context.StringValue("PredictImage.PredictDatas["+ i +"].IterationId");
				predictData.DataId = context.StringValue("PredictImage.PredictDatas["+ i +"].DataId");
				predictData.DataName = context.StringValue("PredictImage.PredictDatas["+ i +"].DataName");
				predictData.DataUrl = context.StringValue("PredictImage.PredictDatas["+ i +"].DataUrl");
				predictData.CreationTime = context.StringValue("PredictImage.PredictDatas["+ i +"].CreationTime");
				predictData.Status = context.StringValue("PredictImage.PredictDatas["+ i +"].Status");
				predictData.ErrorCode = context.StringValue("PredictImage.PredictDatas["+ i +"].ErrorCode");
				predictData.ErrorMessage = context.StringValue("PredictImage.PredictDatas["+ i +"].ErrorMessage");

				List<PredictImageResponse.PredictImage_PredictData.PredictImage_PredictionResult> predictData_predictionResults = new List<PredictImageResponse.PredictImage_PredictData.PredictImage_PredictionResult>();
				for (int j = 0; j < context.Length("PredictImage.PredictDatas["+ i +"].PredictionResults.Length"); j++) {
					PredictImageResponse.PredictImage_PredictData.PredictImage_PredictionResult predictionResult = new PredictImageResponse.PredictImage_PredictData.PredictImage_PredictionResult();
					predictionResult.TagId = context.StringValue("PredictImage.PredictDatas["+ i +"].PredictionResults["+ j +"].TagId");
					predictionResult.TagName = context.StringValue("PredictImage.PredictDatas["+ i +"].PredictionResults["+ j +"].TagName");
					predictionResult.Probability = context.StringValue("PredictImage.PredictDatas["+ i +"].PredictionResults["+ j +"].Probability");
					predictionResult.Overlap = context.StringValue("PredictImage.PredictDatas["+ i +"].PredictionResults["+ j +"].Overlap");
					predictionResult.RegionType = context.StringValue("PredictImage.PredictDatas["+ i +"].PredictionResults["+ j +"].RegionType");
					predictionResult.Properties = context.StringValue("PredictImage.PredictDatas["+ i +"].PredictionResults["+ j +"].Properties");

					PredictImageResponse.PredictImage_PredictData.PredictImage_PredictionResult.PredictImage_Region region = new PredictImageResponse.PredictImage_PredictData.PredictImage_PredictionResult.PredictImage_Region();
					region.Left = context.StringValue("PredictImage.PredictDatas["+ i +"].PredictionResults["+ j +"].Region.Left");
					region.Top = context.StringValue("PredictImage.PredictDatas["+ i +"].PredictionResults["+ j +"].Region.Top");
					region.Width = context.StringValue("PredictImage.PredictDatas["+ i +"].PredictionResults["+ j +"].Region.Width");
					region.Height = context.StringValue("PredictImage.PredictDatas["+ i +"].PredictionResults["+ j +"].Region.Height");
					predictionResult.Region = region;

					predictData_predictionResults.Add(predictionResult);
				}
				predictData.PredictionResults = predictData_predictionResults;

				predictImageResponse_predictDatas.Add(predictData);
			}
			predictImageResponse.PredictDatas = predictImageResponse_predictDatas;
        
			return predictImageResponse;
        }
    }
}
