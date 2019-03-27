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
    public class CreateTrainDataTagResponseUnmarshaller
    {
        public static CreateTrainDataTagResponse Unmarshall(UnmarshallerContext context)
        {
			CreateTrainDataTagResponse createTrainDataTagResponse = new CreateTrainDataTagResponse();

			createTrainDataTagResponse.HttpResponse = context.HttpResponse;
			createTrainDataTagResponse.RequestId = context.StringValue("CreateTrainDataTag.RequestId");

			CreateTrainDataTagResponse.CreateTrainDataTag_TrainData trainData = new CreateTrainDataTagResponse.CreateTrainDataTag_TrainData();
			trainData.ProjectId = context.StringValue("CreateTrainDataTag.TrainData.ProjectId");
			trainData.IterationId = context.StringValue("CreateTrainDataTag.TrainData.IterationId");
			trainData.DataId = context.StringValue("CreateTrainDataTag.TrainData.DataId");
			trainData.DataName = context.StringValue("CreateTrainDataTag.TrainData.DataName");
			trainData.DataUrl = context.StringValue("CreateTrainDataTag.TrainData.DataUrl");
			trainData.CreationTime = context.StringValue("CreateTrainDataTag.TrainData.CreationTime");
			trainData.Status = context.StringValue("CreateTrainDataTag.TrainData.Status");
			trainData.TagStatus = context.StringValue("CreateTrainDataTag.TrainData.TagStatus");

			List<CreateTrainDataTagResponse.CreateTrainDataTag_TrainData.CreateTrainDataTag_TagItem> trainData_tagItems = new List<CreateTrainDataTagResponse.CreateTrainDataTag_TrainData.CreateTrainDataTag_TagItem>();
			for (int i = 0; i < context.Length("CreateTrainDataTag.TrainData.TagItems.Length"); i++) {
				CreateTrainDataTagResponse.CreateTrainDataTag_TrainData.CreateTrainDataTag_TagItem tagItem = new CreateTrainDataTagResponse.CreateTrainDataTag_TrainData.CreateTrainDataTag_TagItem();
				tagItem.TagId = context.StringValue("CreateTrainDataTag.TrainData.TagItems["+ i +"].TagId");
				tagItem.RegionType = context.StringValue("CreateTrainDataTag.TrainData.TagItems["+ i +"].RegionType");

				CreateTrainDataTagResponse.CreateTrainDataTag_TrainData.CreateTrainDataTag_TagItem.CreateTrainDataTag_Region region = new CreateTrainDataTagResponse.CreateTrainDataTag_TrainData.CreateTrainDataTag_TagItem.CreateTrainDataTag_Region();
				region.Left = context.StringValue("CreateTrainDataTag.TrainData.TagItems["+ i +"].Region.Left");
				region.Top = context.StringValue("CreateTrainDataTag.TrainData.TagItems["+ i +"].Region.Top");
				region.Width = context.StringValue("CreateTrainDataTag.TrainData.TagItems["+ i +"].Region.Width");
				region.Height = context.StringValue("CreateTrainDataTag.TrainData.TagItems["+ i +"].Region.Height");
				tagItem.Region = region;

				trainData_tagItems.Add(tagItem);
			}
			trainData.TagItems = trainData_tagItems;
			createTrainDataTagResponse.TrainData = trainData;
        
			return createTrainDataTagResponse;
        }
    }
}
