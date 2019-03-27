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
    public class ModifyTrainDataRegionTagAttributeResponseUnmarshaller
    {
        public static ModifyTrainDataRegionTagAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyTrainDataRegionTagAttributeResponse modifyTrainDataRegionTagAttributeResponse = new ModifyTrainDataRegionTagAttributeResponse();

			modifyTrainDataRegionTagAttributeResponse.HttpResponse = context.HttpResponse;
			modifyTrainDataRegionTagAttributeResponse.RequestId = context.StringValue("ModifyTrainDataRegionTagAttribute.RequestId");

			ModifyTrainDataRegionTagAttributeResponse.ModifyTrainDataRegionTagAttribute_TrainData trainData = new ModifyTrainDataRegionTagAttributeResponse.ModifyTrainDataRegionTagAttribute_TrainData();
			trainData.ProjectId = context.StringValue("ModifyTrainDataRegionTagAttribute.TrainData.ProjectId");
			trainData.IterationId = context.StringValue("ModifyTrainDataRegionTagAttribute.TrainData.IterationId");
			trainData.DataId = context.StringValue("ModifyTrainDataRegionTagAttribute.TrainData.DataId");
			trainData.DataName = context.StringValue("ModifyTrainDataRegionTagAttribute.TrainData.DataName");
			trainData.DataUrl = context.StringValue("ModifyTrainDataRegionTagAttribute.TrainData.DataUrl");
			trainData.CreationTime = context.StringValue("ModifyTrainDataRegionTagAttribute.TrainData.CreationTime");
			trainData.Status = context.StringValue("ModifyTrainDataRegionTagAttribute.TrainData.Status");
			trainData.TagStatus = context.StringValue("ModifyTrainDataRegionTagAttribute.TrainData.TagStatus");

			List<ModifyTrainDataRegionTagAttributeResponse.ModifyTrainDataRegionTagAttribute_TrainData.ModifyTrainDataRegionTagAttribute_TagItem> trainData_tagItems = new List<ModifyTrainDataRegionTagAttributeResponse.ModifyTrainDataRegionTagAttribute_TrainData.ModifyTrainDataRegionTagAttribute_TagItem>();
			for (int i = 0; i < context.Length("ModifyTrainDataRegionTagAttribute.TrainData.TagItems.Length"); i++) {
				ModifyTrainDataRegionTagAttributeResponse.ModifyTrainDataRegionTagAttribute_TrainData.ModifyTrainDataRegionTagAttribute_TagItem tagItem = new ModifyTrainDataRegionTagAttributeResponse.ModifyTrainDataRegionTagAttribute_TrainData.ModifyTrainDataRegionTagAttribute_TagItem();
				tagItem.TagId = context.StringValue("ModifyTrainDataRegionTagAttribute.TrainData.TagItems["+ i +"].TagId");
				tagItem.RegionType = context.StringValue("ModifyTrainDataRegionTagAttribute.TrainData.TagItems["+ i +"].RegionType");

				ModifyTrainDataRegionTagAttributeResponse.ModifyTrainDataRegionTagAttribute_TrainData.ModifyTrainDataRegionTagAttribute_TagItem.ModifyTrainDataRegionTagAttribute_Region region = new ModifyTrainDataRegionTagAttributeResponse.ModifyTrainDataRegionTagAttribute_TrainData.ModifyTrainDataRegionTagAttribute_TagItem.ModifyTrainDataRegionTagAttribute_Region();
				region.Left = context.StringValue("ModifyTrainDataRegionTagAttribute.TrainData.TagItems["+ i +"].Region.Left");
				region.Top = context.StringValue("ModifyTrainDataRegionTagAttribute.TrainData.TagItems["+ i +"].Region.Top");
				region.Width = context.StringValue("ModifyTrainDataRegionTagAttribute.TrainData.TagItems["+ i +"].Region.Width");
				region.Height = context.StringValue("ModifyTrainDataRegionTagAttribute.TrainData.TagItems["+ i +"].Region.Height");
				tagItem.Region = region;

				trainData_tagItems.Add(tagItem);
			}
			trainData.TagItems = trainData_tagItems;
			modifyTrainDataRegionTagAttributeResponse.TrainData = trainData;
        
			return modifyTrainDataRegionTagAttributeResponse;
        }
    }
}
