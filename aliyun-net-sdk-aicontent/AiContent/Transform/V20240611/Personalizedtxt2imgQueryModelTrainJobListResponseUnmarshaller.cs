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
using Aliyun.Acs.AiContent.Model.V20240611;

namespace Aliyun.Acs.AiContent.Transform.V20240611
{
    public class Personalizedtxt2imgQueryModelTrainJobListResponseUnmarshaller
    {
        public static Personalizedtxt2imgQueryModelTrainJobListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			Personalizedtxt2imgQueryModelTrainJobListResponse personalizedtxt2imgQueryModelTrainJobListResponse = new Personalizedtxt2imgQueryModelTrainJobListResponse();

			personalizedtxt2imgQueryModelTrainJobListResponse.HttpResponse = _ctx.HttpResponse;
			personalizedtxt2imgQueryModelTrainJobListResponse.RequestId = _ctx.StringValue("Personalizedtxt2imgQueryModelTrainJobList.requestId");
			personalizedtxt2imgQueryModelTrainJobListResponse.Success = _ctx.BooleanValue("Personalizedtxt2imgQueryModelTrainJobList.success");
			personalizedtxt2imgQueryModelTrainJobListResponse.ErrCode = _ctx.StringValue("Personalizedtxt2imgQueryModelTrainJobList.errCode");
			personalizedtxt2imgQueryModelTrainJobListResponse.ErrMessage = _ctx.StringValue("Personalizedtxt2imgQueryModelTrainJobList.errMessage");
			personalizedtxt2imgQueryModelTrainJobListResponse.HttpStatusCode = _ctx.IntegerValue("Personalizedtxt2imgQueryModelTrainJobList.httpStatusCode");

			List<Personalizedtxt2imgQueryModelTrainJobListResponse.Personalizedtxt2imgQueryModelTrainJobList_DataItem> personalizedtxt2imgQueryModelTrainJobListResponse_data = new List<Personalizedtxt2imgQueryModelTrainJobListResponse.Personalizedtxt2imgQueryModelTrainJobList_DataItem>();
			for (int i = 0; i < _ctx.Length("Personalizedtxt2imgQueryModelTrainJobList.Data.Length"); i++) {
				Personalizedtxt2imgQueryModelTrainJobListResponse.Personalizedtxt2imgQueryModelTrainJobList_DataItem dataItem = new Personalizedtxt2imgQueryModelTrainJobListResponse.Personalizedtxt2imgQueryModelTrainJobList_DataItem();
				dataItem.Id = _ctx.StringValue("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].id");
				dataItem.ModelId = _ctx.StringValue("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].modelId");
				dataItem.Name = _ctx.StringValue("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].name");
				dataItem.ObjectType = _ctx.StringValue("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].objectType");
				dataItem.JobStatus = _ctx.StringValue("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].jobStatus");
				dataItem.JobTrainProgress = _ctx.DoubleValue("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].jobTrainProgress");
				dataItem.InferenceImageCount = _ctx.IntegerValue("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].inferenceImageCount");
				dataItem.CreateTime = _ctx.StringValue("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].createTime");

				List<string> dataItem_imageUrl = new List<string>();
				for (int j = 0; j < _ctx.Length("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].ImageUrl.Length"); j++) {
					dataItem_imageUrl.Add(_ctx.StringValue("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].ImageUrl["+ j +"]"));
				}
				dataItem.ImageUrl = dataItem_imageUrl;

				List<Personalizedtxt2imgQueryModelTrainJobListResponse.Personalizedtxt2imgQueryModelTrainJobList_DataItem.Personalizedtxt2imgQueryModelTrainJobList_InferenceJobListItem> dataItem_inferenceJobList = new List<Personalizedtxt2imgQueryModelTrainJobListResponse.Personalizedtxt2imgQueryModelTrainJobList_DataItem.Personalizedtxt2imgQueryModelTrainJobList_InferenceJobListItem>();
				for (int j = 0; j < _ctx.Length("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].InferenceJobList.Length"); j++) {
					Personalizedtxt2imgQueryModelTrainJobListResponse.Personalizedtxt2imgQueryModelTrainJobList_DataItem.Personalizedtxt2imgQueryModelTrainJobList_InferenceJobListItem inferenceJobListItem = new Personalizedtxt2imgQueryModelTrainJobListResponse.Personalizedtxt2imgQueryModelTrainJobList_DataItem.Personalizedtxt2imgQueryModelTrainJobList_InferenceJobListItem();
					inferenceJobListItem.Id = _ctx.StringValue("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].InferenceJobList["+ j +"].id");
					inferenceJobListItem.PromptId = _ctx.StringValue("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].InferenceJobList["+ j +"].promptId");
					inferenceJobListItem.ModelId = _ctx.StringValue("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].InferenceJobList["+ j +"].modelId");
					inferenceJobListItem.JobStatus = _ctx.StringValue("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].InferenceJobList["+ j +"].jobStatus");
					inferenceJobListItem.JobTrainProgress = _ctx.DoubleValue("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].InferenceJobList["+ j +"].jobTrainProgress");
					inferenceJobListItem.CreateTime = _ctx.StringValue("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].InferenceJobList["+ j +"].createTime");

					List<string> inferenceJobListItem_resultImageUrl = new List<string>();
					for (int k = 0; k < _ctx.Length("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].InferenceJobList["+ j +"].ResultImageUrl.Length"); k++) {
						inferenceJobListItem_resultImageUrl.Add(_ctx.StringValue("Personalizedtxt2imgQueryModelTrainJobList.Data["+ i +"].InferenceJobList["+ j +"].ResultImageUrl["+ k +"]"));
					}
					inferenceJobListItem.ResultImageUrl = inferenceJobListItem_resultImageUrl;

					dataItem_inferenceJobList.Add(inferenceJobListItem);
				}
				dataItem.InferenceJobList = dataItem_inferenceJobList;

				personalizedtxt2imgQueryModelTrainJobListResponse_data.Add(dataItem);
			}
			personalizedtxt2imgQueryModelTrainJobListResponse.Data = personalizedtxt2imgQueryModelTrainJobListResponse_data;
        
			return personalizedtxt2imgQueryModelTrainJobListResponse;
        }
    }
}
