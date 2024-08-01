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
    public class Personalizedtxt2imgAddModelTrainJobResponseUnmarshaller
    {
        public static Personalizedtxt2imgAddModelTrainJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			Personalizedtxt2imgAddModelTrainJobResponse personalizedtxt2imgAddModelTrainJobResponse = new Personalizedtxt2imgAddModelTrainJobResponse();

			personalizedtxt2imgAddModelTrainJobResponse.HttpResponse = _ctx.HttpResponse;
			personalizedtxt2imgAddModelTrainJobResponse.RequestId = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.requestId");
			personalizedtxt2imgAddModelTrainJobResponse.Success = _ctx.BooleanValue("Personalizedtxt2imgAddModelTrainJob.success");
			personalizedtxt2imgAddModelTrainJobResponse.ErrCode = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.errCode");
			personalizedtxt2imgAddModelTrainJobResponse.ErrMessage = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.errMessage");
			personalizedtxt2imgAddModelTrainJobResponse.HttpStatusCode = _ctx.IntegerValue("Personalizedtxt2imgAddModelTrainJob.httpStatusCode");

			Personalizedtxt2imgAddModelTrainJobResponse.Personalizedtxt2imgAddModelTrainJob_Data data = new Personalizedtxt2imgAddModelTrainJobResponse.Personalizedtxt2imgAddModelTrainJob_Data();
			data.Id = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.Data.id");
			data.ModelId = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.Data.modelId");
			data.Name = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.Data.name");
			data.ObjectType = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.Data.objectType");
			data.JobStatus = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.Data.jobStatus");
			data.JobTrainProgress = _ctx.DoubleValue("Personalizedtxt2imgAddModelTrainJob.Data.jobTrainProgress");
			data.InferenceImageCount = _ctx.IntegerValue("Personalizedtxt2imgAddModelTrainJob.Data.inferenceImageCount");
			data.CreateTime = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.Data.createTime");

			List<string> data_imageUrl = new List<string>();
			for (int i = 0; i < _ctx.Length("Personalizedtxt2imgAddModelTrainJob.Data.ImageUrl.Length"); i++) {
				data_imageUrl.Add(_ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.Data.ImageUrl["+ i +"]"));
			}
			data.ImageUrl = data_imageUrl;

			List<Personalizedtxt2imgAddModelTrainJobResponse.Personalizedtxt2imgAddModelTrainJob_Data.Personalizedtxt2imgAddModelTrainJob_InferenceJobListItem> data_inferenceJobList = new List<Personalizedtxt2imgAddModelTrainJobResponse.Personalizedtxt2imgAddModelTrainJob_Data.Personalizedtxt2imgAddModelTrainJob_InferenceJobListItem>();
			for (int i = 0; i < _ctx.Length("Personalizedtxt2imgAddModelTrainJob.Data.InferenceJobList.Length"); i++) {
				Personalizedtxt2imgAddModelTrainJobResponse.Personalizedtxt2imgAddModelTrainJob_Data.Personalizedtxt2imgAddModelTrainJob_InferenceJobListItem inferenceJobListItem = new Personalizedtxt2imgAddModelTrainJobResponse.Personalizedtxt2imgAddModelTrainJob_Data.Personalizedtxt2imgAddModelTrainJob_InferenceJobListItem();
				inferenceJobListItem.Id = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.Data.InferenceJobList["+ i +"].id");
				inferenceJobListItem.PromptId = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.Data.InferenceJobList["+ i +"].promptId");
				inferenceJobListItem.ModelId = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.Data.InferenceJobList["+ i +"].modelId");
				inferenceJobListItem.JobStatus = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.Data.InferenceJobList["+ i +"].jobStatus");
				inferenceJobListItem.JobTrainProgress = _ctx.DoubleValue("Personalizedtxt2imgAddModelTrainJob.Data.InferenceJobList["+ i +"].jobTrainProgress");
				inferenceJobListItem.CreateTime = _ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.Data.InferenceJobList["+ i +"].createTime");

				List<string> inferenceJobListItem_resultImageUrl = new List<string>();
				for (int j = 0; j < _ctx.Length("Personalizedtxt2imgAddModelTrainJob.Data.InferenceJobList["+ i +"].ResultImageUrl.Length"); j++) {
					inferenceJobListItem_resultImageUrl.Add(_ctx.StringValue("Personalizedtxt2imgAddModelTrainJob.Data.InferenceJobList["+ i +"].ResultImageUrl["+ j +"]"));
				}
				inferenceJobListItem.ResultImageUrl = inferenceJobListItem_resultImageUrl;

				data_inferenceJobList.Add(inferenceJobListItem);
			}
			data.InferenceJobList = data_inferenceJobList;
			personalizedtxt2imgAddModelTrainJobResponse.Data = data;
        
			return personalizedtxt2imgAddModelTrainJobResponse;
        }
    }
}
