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
    public class ModifyTrainDataTagAttributeResponseUnmarshaller
    {
        public static ModifyTrainDataTagAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyTrainDataTagAttributeResponse modifyTrainDataTagAttributeResponse = new ModifyTrainDataTagAttributeResponse();

			modifyTrainDataTagAttributeResponse.HttpResponse = context.HttpResponse;
			modifyTrainDataTagAttributeResponse.RequestId = context.StringValue("ModifyTrainDataTagAttribute.RequestId");

			ModifyTrainDataTagAttributeResponse.ModifyTrainDataTagAttribute_TrainData trainData = new ModifyTrainDataTagAttributeResponse.ModifyTrainDataTagAttribute_TrainData();
			trainData.ProjectId = context.StringValue("ModifyTrainDataTagAttribute.TrainData.ProjectId");
			trainData.IterationId = context.StringValue("ModifyTrainDataTagAttribute.TrainData.IterationId");
			trainData.DataId = context.StringValue("ModifyTrainDataTagAttribute.TrainData.DataId");
			trainData.DataName = context.StringValue("ModifyTrainDataTagAttribute.TrainData.DataName");
			trainData.DataUrl = context.StringValue("ModifyTrainDataTagAttribute.TrainData.DataUrl");
			trainData.CreationTime = context.StringValue("ModifyTrainDataTagAttribute.TrainData.CreationTime");
			trainData.Status = context.StringValue("ModifyTrainDataTagAttribute.TrainData.Status");
			trainData.TagStatus = context.StringValue("ModifyTrainDataTagAttribute.TrainData.TagStatus");

			List<ModifyTrainDataTagAttributeResponse.ModifyTrainDataTagAttribute_TrainData.ModifyTrainDataTagAttribute_TagItem> trainData_tagItems = new List<ModifyTrainDataTagAttributeResponse.ModifyTrainDataTagAttribute_TrainData.ModifyTrainDataTagAttribute_TagItem>();
			for (int i = 0; i < context.Length("ModifyTrainDataTagAttribute.TrainData.TagItems.Length"); i++) {
				ModifyTrainDataTagAttributeResponse.ModifyTrainDataTagAttribute_TrainData.ModifyTrainDataTagAttribute_TagItem tagItem = new ModifyTrainDataTagAttributeResponse.ModifyTrainDataTagAttribute_TrainData.ModifyTrainDataTagAttribute_TagItem();
				tagItem.TagId = context.StringValue("ModifyTrainDataTagAttribute.TrainData.TagItems["+ i +"].TagId");
				tagItem.RegionType = context.StringValue("ModifyTrainDataTagAttribute.TrainData.TagItems["+ i +"].RegionType");

				ModifyTrainDataTagAttributeResponse.ModifyTrainDataTagAttribute_TrainData.ModifyTrainDataTagAttribute_TagItem.ModifyTrainDataTagAttribute_Region region = new ModifyTrainDataTagAttributeResponse.ModifyTrainDataTagAttribute_TrainData.ModifyTrainDataTagAttribute_TagItem.ModifyTrainDataTagAttribute_Region();
				region.Left = context.StringValue("ModifyTrainDataTagAttribute.TrainData.TagItems["+ i +"].Region.Left");
				region.Top = context.StringValue("ModifyTrainDataTagAttribute.TrainData.TagItems["+ i +"].Region.Top");
				region.Width = context.StringValue("ModifyTrainDataTagAttribute.TrainData.TagItems["+ i +"].Region.Width");
				region.Height = context.StringValue("ModifyTrainDataTagAttribute.TrainData.TagItems["+ i +"].Region.Height");
				tagItem.Region = region;

				trainData_tagItems.Add(tagItem);
			}
			trainData.TagItems = trainData_tagItems;
			modifyTrainDataTagAttributeResponse.TrainData = trainData;
        
			return modifyTrainDataTagAttributeResponse;
        }
    }
}
