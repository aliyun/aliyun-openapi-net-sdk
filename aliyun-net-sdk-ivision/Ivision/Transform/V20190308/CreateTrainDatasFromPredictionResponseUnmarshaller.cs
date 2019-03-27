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
    public class CreateTrainDatasFromPredictionResponseUnmarshaller
    {
        public static CreateTrainDatasFromPredictionResponse Unmarshall(UnmarshallerContext context)
        {
			CreateTrainDatasFromPredictionResponse createTrainDatasFromPredictionResponse = new CreateTrainDatasFromPredictionResponse();

			createTrainDatasFromPredictionResponse.HttpResponse = context.HttpResponse;
			createTrainDatasFromPredictionResponse.RequestId = context.StringValue("CreateTrainDatasFromPrediction.RequestId");

			List<CreateTrainDatasFromPredictionResponse.CreateTrainDatasFromPrediction_TrainData> createTrainDatasFromPredictionResponse_trainDatas = new List<CreateTrainDatasFromPredictionResponse.CreateTrainDatasFromPrediction_TrainData>();
			for (int i = 0; i < context.Length("CreateTrainDatasFromPrediction.TrainDatas.Length"); i++) {
				CreateTrainDatasFromPredictionResponse.CreateTrainDatasFromPrediction_TrainData trainData = new CreateTrainDatasFromPredictionResponse.CreateTrainDatasFromPrediction_TrainData();
				trainData.ProjectId = context.StringValue("CreateTrainDatasFromPrediction.TrainDatas["+ i +"].ProjectId");
				trainData.IterationId = context.StringValue("CreateTrainDatasFromPrediction.TrainDatas["+ i +"].IterationId");
				trainData.DataId = context.StringValue("CreateTrainDatasFromPrediction.TrainDatas["+ i +"].DataId");
				trainData.DataName = context.StringValue("CreateTrainDatasFromPrediction.TrainDatas["+ i +"].DataName");
				trainData.DataUrl = context.StringValue("CreateTrainDatasFromPrediction.TrainDatas["+ i +"].DataUrl");
				trainData.CreationTime = context.StringValue("CreateTrainDatasFromPrediction.TrainDatas["+ i +"].CreationTime");
				trainData.Status = context.StringValue("CreateTrainDatasFromPrediction.TrainDatas["+ i +"].Status");
				trainData.TagStatus = context.StringValue("CreateTrainDatasFromPrediction.TrainDatas["+ i +"].TagStatus");

				List<CreateTrainDatasFromPredictionResponse.CreateTrainDatasFromPrediction_TrainData.CreateTrainDatasFromPrediction_TagItem> trainData_tagItems = new List<CreateTrainDatasFromPredictionResponse.CreateTrainDatasFromPrediction_TrainData.CreateTrainDatasFromPrediction_TagItem>();
				for (int j = 0; j < context.Length("CreateTrainDatasFromPrediction.TrainDatas["+ i +"].TagItems.Length"); j++) {
					CreateTrainDatasFromPredictionResponse.CreateTrainDatasFromPrediction_TrainData.CreateTrainDatasFromPrediction_TagItem tagItem = new CreateTrainDatasFromPredictionResponse.CreateTrainDatasFromPrediction_TrainData.CreateTrainDatasFromPrediction_TagItem();
					tagItem.TagId = context.StringValue("CreateTrainDatasFromPrediction.TrainDatas["+ i +"].TagItems["+ j +"].TagId");
					tagItem.RegionType = context.StringValue("CreateTrainDatasFromPrediction.TrainDatas["+ i +"].TagItems["+ j +"].RegionType");

					CreateTrainDatasFromPredictionResponse.CreateTrainDatasFromPrediction_TrainData.CreateTrainDatasFromPrediction_TagItem.CreateTrainDatasFromPrediction_Region region = new CreateTrainDatasFromPredictionResponse.CreateTrainDatasFromPrediction_TrainData.CreateTrainDatasFromPrediction_TagItem.CreateTrainDatasFromPrediction_Region();
					region.Left = context.StringValue("CreateTrainDatasFromPrediction.TrainDatas["+ i +"].TagItems["+ j +"].Region.Left");
					region.Top = context.StringValue("CreateTrainDatasFromPrediction.TrainDatas["+ i +"].TagItems["+ j +"].Region.Top");
					region.Width = context.StringValue("CreateTrainDatasFromPrediction.TrainDatas["+ i +"].TagItems["+ j +"].Region.Width");
					region.Height = context.StringValue("CreateTrainDatasFromPrediction.TrainDatas["+ i +"].TagItems["+ j +"].Region.Height");
					tagItem.Region = region;

					trainData_tagItems.Add(tagItem);
				}
				trainData.TagItems = trainData_tagItems;

				createTrainDatasFromPredictionResponse_trainDatas.Add(trainData);
			}
			createTrainDatasFromPredictionResponse.TrainDatas = createTrainDatasFromPredictionResponse_trainDatas;
        
			return createTrainDatasFromPredictionResponse;
        }
    }
}
