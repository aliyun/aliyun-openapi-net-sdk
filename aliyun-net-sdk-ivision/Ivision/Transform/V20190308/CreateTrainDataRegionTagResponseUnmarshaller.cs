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
    public class CreateTrainDataRegionTagResponseUnmarshaller
    {
        public static CreateTrainDataRegionTagResponse Unmarshall(UnmarshallerContext context)
        {
			CreateTrainDataRegionTagResponse createTrainDataRegionTagResponse = new CreateTrainDataRegionTagResponse();

			createTrainDataRegionTagResponse.HttpResponse = context.HttpResponse;
			createTrainDataRegionTagResponse.RequestId = context.StringValue("CreateTrainDataRegionTag.RequestId");

			CreateTrainDataRegionTagResponse.CreateTrainDataRegionTag_TrainData trainData = new CreateTrainDataRegionTagResponse.CreateTrainDataRegionTag_TrainData();
			trainData.ProjectId = context.StringValue("CreateTrainDataRegionTag.TrainData.ProjectId");
			trainData.IterationId = context.StringValue("CreateTrainDataRegionTag.TrainData.IterationId");
			trainData.DataId = context.StringValue("CreateTrainDataRegionTag.TrainData.DataId");
			trainData.DataName = context.StringValue("CreateTrainDataRegionTag.TrainData.DataName");
			trainData.DataUrl = context.StringValue("CreateTrainDataRegionTag.TrainData.DataUrl");
			trainData.CreationTime = context.StringValue("CreateTrainDataRegionTag.TrainData.CreationTime");
			trainData.Status = context.StringValue("CreateTrainDataRegionTag.TrainData.Status");
			trainData.TagStatus = context.StringValue("CreateTrainDataRegionTag.TrainData.TagStatus");

			List<CreateTrainDataRegionTagResponse.CreateTrainDataRegionTag_TrainData.CreateTrainDataRegionTag_TagItem> trainData_tagItems = new List<CreateTrainDataRegionTagResponse.CreateTrainDataRegionTag_TrainData.CreateTrainDataRegionTag_TagItem>();
			for (int i = 0; i < context.Length("CreateTrainDataRegionTag.TrainData.TagItems.Length"); i++) {
				CreateTrainDataRegionTagResponse.CreateTrainDataRegionTag_TrainData.CreateTrainDataRegionTag_TagItem tagItem = new CreateTrainDataRegionTagResponse.CreateTrainDataRegionTag_TrainData.CreateTrainDataRegionTag_TagItem();
				tagItem.TagId = context.StringValue("CreateTrainDataRegionTag.TrainData.TagItems["+ i +"].TagId");
				tagItem.RegionType = context.StringValue("CreateTrainDataRegionTag.TrainData.TagItems["+ i +"].RegionType");

				CreateTrainDataRegionTagResponse.CreateTrainDataRegionTag_TrainData.CreateTrainDataRegionTag_TagItem.CreateTrainDataRegionTag_Region region = new CreateTrainDataRegionTagResponse.CreateTrainDataRegionTag_TrainData.CreateTrainDataRegionTag_TagItem.CreateTrainDataRegionTag_Region();
				region.Left = context.StringValue("CreateTrainDataRegionTag.TrainData.TagItems["+ i +"].Region.Left");
				region.Top = context.StringValue("CreateTrainDataRegionTag.TrainData.TagItems["+ i +"].Region.Top");
				region.Width = context.StringValue("CreateTrainDataRegionTag.TrainData.TagItems["+ i +"].Region.Width");
				region.Height = context.StringValue("CreateTrainDataRegionTag.TrainData.TagItems["+ i +"].Region.Height");
				tagItem.Region = region;

				trainData_tagItems.Add(tagItem);
			}
			trainData.TagItems = trainData_tagItems;
			createTrainDataRegionTagResponse.TrainData = trainData;
        
			return createTrainDataRegionTagResponse;
        }
    }
}
