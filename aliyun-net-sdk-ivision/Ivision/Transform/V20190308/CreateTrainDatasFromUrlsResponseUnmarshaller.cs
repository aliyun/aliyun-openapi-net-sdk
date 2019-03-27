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
    public class CreateTrainDatasFromUrlsResponseUnmarshaller
    {
        public static CreateTrainDatasFromUrlsResponse Unmarshall(UnmarshallerContext context)
        {
			CreateTrainDatasFromUrlsResponse createTrainDatasFromUrlsResponse = new CreateTrainDatasFromUrlsResponse();

			createTrainDatasFromUrlsResponse.HttpResponse = context.HttpResponse;
			createTrainDatasFromUrlsResponse.RequestId = context.StringValue("CreateTrainDatasFromUrls.RequestId");

			List<CreateTrainDatasFromUrlsResponse.CreateTrainDatasFromUrls_TrainData> createTrainDatasFromUrlsResponse_trainDatas = new List<CreateTrainDatasFromUrlsResponse.CreateTrainDatasFromUrls_TrainData>();
			for (int i = 0; i < context.Length("CreateTrainDatasFromUrls.TrainDatas.Length"); i++) {
				CreateTrainDatasFromUrlsResponse.CreateTrainDatasFromUrls_TrainData trainData = new CreateTrainDatasFromUrlsResponse.CreateTrainDatasFromUrls_TrainData();
				trainData.ProjectId = context.StringValue("CreateTrainDatasFromUrls.TrainDatas["+ i +"].ProjectId");
				trainData.IterationId = context.StringValue("CreateTrainDatasFromUrls.TrainDatas["+ i +"].IterationId");
				trainData.DataId = context.StringValue("CreateTrainDatasFromUrls.TrainDatas["+ i +"].DataId");
				trainData.DataName = context.StringValue("CreateTrainDatasFromUrls.TrainDatas["+ i +"].DataName");
				trainData.DataUrl = context.StringValue("CreateTrainDatasFromUrls.TrainDatas["+ i +"].DataUrl");
				trainData.CreationTime = context.StringValue("CreateTrainDatasFromUrls.TrainDatas["+ i +"].CreationTime");
				trainData.Status = context.StringValue("CreateTrainDatasFromUrls.TrainDatas["+ i +"].Status");
				trainData.TagStatus = context.StringValue("CreateTrainDatasFromUrls.TrainDatas["+ i +"].TagStatus");

				List<CreateTrainDatasFromUrlsResponse.CreateTrainDatasFromUrls_TrainData.CreateTrainDatasFromUrls_TagItem> trainData_tagItems = new List<CreateTrainDatasFromUrlsResponse.CreateTrainDatasFromUrls_TrainData.CreateTrainDatasFromUrls_TagItem>();
				for (int j = 0; j < context.Length("CreateTrainDatasFromUrls.TrainDatas["+ i +"].TagItems.Length"); j++) {
					CreateTrainDatasFromUrlsResponse.CreateTrainDatasFromUrls_TrainData.CreateTrainDatasFromUrls_TagItem tagItem = new CreateTrainDatasFromUrlsResponse.CreateTrainDatasFromUrls_TrainData.CreateTrainDatasFromUrls_TagItem();
					tagItem.TagId = context.StringValue("CreateTrainDatasFromUrls.TrainDatas["+ i +"].TagItems["+ j +"].TagId");
					tagItem.RegionType = context.StringValue("CreateTrainDatasFromUrls.TrainDatas["+ i +"].TagItems["+ j +"].RegionType");

					CreateTrainDatasFromUrlsResponse.CreateTrainDatasFromUrls_TrainData.CreateTrainDatasFromUrls_TagItem.CreateTrainDatasFromUrls_Region region = new CreateTrainDatasFromUrlsResponse.CreateTrainDatasFromUrls_TrainData.CreateTrainDatasFromUrls_TagItem.CreateTrainDatasFromUrls_Region();
					region.Left = context.StringValue("CreateTrainDatasFromUrls.TrainDatas["+ i +"].TagItems["+ j +"].Region.Left");
					region.Top = context.StringValue("CreateTrainDatasFromUrls.TrainDatas["+ i +"].TagItems["+ j +"].Region.Top");
					region.Width = context.StringValue("CreateTrainDatasFromUrls.TrainDatas["+ i +"].TagItems["+ j +"].Region.Width");
					region.Height = context.StringValue("CreateTrainDatasFromUrls.TrainDatas["+ i +"].TagItems["+ j +"].Region.Height");
					tagItem.Region = region;

					trainData_tagItems.Add(tagItem);
				}
				trainData.TagItems = trainData_tagItems;

				createTrainDatasFromUrlsResponse_trainDatas.Add(trainData);
			}
			createTrainDatasFromUrlsResponse.TrainDatas = createTrainDatasFromUrlsResponse_trainDatas;
        
			return createTrainDatasFromUrlsResponse;
        }
    }
}
