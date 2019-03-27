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
    public class CreateTrainDatasTagResponseUnmarshaller
    {
        public static CreateTrainDatasTagResponse Unmarshall(UnmarshallerContext context)
        {
			CreateTrainDatasTagResponse createTrainDatasTagResponse = new CreateTrainDatasTagResponse();

			createTrainDatasTagResponse.HttpResponse = context.HttpResponse;
			createTrainDatasTagResponse.RequestId = context.StringValue("CreateTrainDatasTag.RequestId");

			CreateTrainDatasTagResponse.CreateTrainDatasTag_TrainData trainData = new CreateTrainDatasTagResponse.CreateTrainDatasTag_TrainData();
			trainData.ProjectId = context.StringValue("CreateTrainDatasTag.TrainData.ProjectId");
			trainData.IterationId = context.StringValue("CreateTrainDatasTag.TrainData.IterationId");
			trainData.DataId = context.StringValue("CreateTrainDatasTag.TrainData.DataId");
			trainData.DataName = context.StringValue("CreateTrainDatasTag.TrainData.DataName");
			trainData.DataUrl = context.StringValue("CreateTrainDatasTag.TrainData.DataUrl");
			trainData.CreationTime = context.StringValue("CreateTrainDatasTag.TrainData.CreationTime");
			trainData.Status = context.StringValue("CreateTrainDatasTag.TrainData.Status");
			trainData.TagStatus = context.StringValue("CreateTrainDatasTag.TrainData.TagStatus");

			List<CreateTrainDatasTagResponse.CreateTrainDatasTag_TrainData.CreateTrainDatasTag_TagItem> trainData_tagItems = new List<CreateTrainDatasTagResponse.CreateTrainDatasTag_TrainData.CreateTrainDatasTag_TagItem>();
			for (int i = 0; i < context.Length("CreateTrainDatasTag.TrainData.TagItems.Length"); i++) {
				CreateTrainDatasTagResponse.CreateTrainDatasTag_TrainData.CreateTrainDatasTag_TagItem tagItem = new CreateTrainDatasTagResponse.CreateTrainDatasTag_TrainData.CreateTrainDatasTag_TagItem();
				tagItem.TagId = context.StringValue("CreateTrainDatasTag.TrainData.TagItems["+ i +"].TagId");
				tagItem.RegionType = context.StringValue("CreateTrainDatasTag.TrainData.TagItems["+ i +"].RegionType");

				CreateTrainDatasTagResponse.CreateTrainDatasTag_TrainData.CreateTrainDatasTag_TagItem.CreateTrainDatasTag_Region region = new CreateTrainDatasTagResponse.CreateTrainDatasTag_TrainData.CreateTrainDatasTag_TagItem.CreateTrainDatasTag_Region();
				region.Left = context.StringValue("CreateTrainDatasTag.TrainData.TagItems["+ i +"].Region.Left");
				region.Top = context.StringValue("CreateTrainDatasTag.TrainData.TagItems["+ i +"].Region.Top");
				region.Width = context.StringValue("CreateTrainDatasTag.TrainData.TagItems["+ i +"].Region.Width");
				region.Height = context.StringValue("CreateTrainDatasTag.TrainData.TagItems["+ i +"].Region.Height");
				tagItem.Region = region;

				trainData_tagItems.Add(tagItem);
			}
			trainData.TagItems = trainData_tagItems;
			createTrainDatasTagResponse.TrainData = trainData;
        
			return createTrainDatasTagResponse;
        }
    }
}
