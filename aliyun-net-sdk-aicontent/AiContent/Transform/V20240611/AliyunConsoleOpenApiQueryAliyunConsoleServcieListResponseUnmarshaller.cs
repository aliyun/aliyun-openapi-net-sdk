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
    public class AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponseUnmarshaller
    {
        public static AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse = new AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse();

			aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.HttpResponse = _ctx.HttpResponse;
			aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.RequestId = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.requestId");
			aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.Success = _ctx.BooleanValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.success");
			aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.ErrCode = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.errCode");
			aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.ErrMessage = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.errMessage");

			List<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem> aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse_data = new List<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem>();
			for (int i = 0; i < _ctx.Length("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data.Length"); i++) {
				AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem dataItem = new AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem();
				dataItem.Id = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].id");
				dataItem.ModelId = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].modelId");
				dataItem.Name = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].name");
				dataItem.ObjectType = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].objectType");
				dataItem.JobStatus = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].jobStatus");
				dataItem.JobTrainProgress = _ctx.DoubleValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].jobTrainProgress");
				dataItem.InferenceImageCount = _ctx.IntegerValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].inferenceImageCount");
				dataItem.CreateTime = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].createTime");

				List<string> dataItem_imageUrl = new List<string>();
				for (int j = 0; j < _ctx.Length("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].ImageUrl.Length"); j++) {
					dataItem_imageUrl.Add(_ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].ImageUrl["+ j +"]"));
				}
				dataItem.ImageUrl = dataItem_imageUrl;

				List<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem.AliyunConsoleOpenApiQueryAliyunConsoleServcieList_InferenceJobListItem> dataItem_inferenceJobList = new List<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem.AliyunConsoleOpenApiQueryAliyunConsoleServcieList_InferenceJobListItem>();
				for (int j = 0; j < _ctx.Length("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].InferenceJobList.Length"); j++) {
					AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem.AliyunConsoleOpenApiQueryAliyunConsoleServcieList_InferenceJobListItem inferenceJobListItem = new AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem.AliyunConsoleOpenApiQueryAliyunConsoleServcieList_InferenceJobListItem();
					inferenceJobListItem.Id = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].InferenceJobList["+ j +"].id");
					inferenceJobListItem.PromptId = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].InferenceJobList["+ j +"].promptId");
					inferenceJobListItem.ModelId = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].InferenceJobList["+ j +"].modelId");
					inferenceJobListItem.JobStatus = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].InferenceJobList["+ j +"].jobStatus");
					inferenceJobListItem.JobTrainProgress = _ctx.DoubleValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].InferenceJobList["+ j +"].jobTrainProgress");
					inferenceJobListItem.CreateTime = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].InferenceJobList["+ j +"].createTime");

					List<string> inferenceJobListItem_resultImageUrl = new List<string>();
					for (int k = 0; k < _ctx.Length("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].InferenceJobList["+ j +"].ResultImageUrl.Length"); k++) {
						inferenceJobListItem_resultImageUrl.Add(_ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].InferenceJobList["+ j +"].ResultImageUrl["+ k +"]"));
					}
					inferenceJobListItem.ResultImageUrl = inferenceJobListItem_resultImageUrl;

					dataItem_inferenceJobList.Add(inferenceJobListItem);
				}
				dataItem.InferenceJobList = dataItem_inferenceJobList;

				aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse_data.Add(dataItem);
			}
			aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.Data = aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse_data;
        
			return aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse;
        }
    }
}
