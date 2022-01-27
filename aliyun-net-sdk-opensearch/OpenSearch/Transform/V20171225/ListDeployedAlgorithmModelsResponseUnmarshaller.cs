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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class ListDeployedAlgorithmModelsResponseUnmarshaller
    {
        public static ListDeployedAlgorithmModelsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeployedAlgorithmModelsResponse listDeployedAlgorithmModelsResponse = new ListDeployedAlgorithmModelsResponse();

			listDeployedAlgorithmModelsResponse.HttpResponse = _ctx.HttpResponse;
			listDeployedAlgorithmModelsResponse.RequestId = _ctx.StringValue("ListDeployedAlgorithmModels.requestId");

			List<ListDeployedAlgorithmModelsResponse.ListDeployedAlgorithmModels_ResultItem> listDeployedAlgorithmModelsResponse_result = new List<ListDeployedAlgorithmModelsResponse.ListDeployedAlgorithmModels_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListDeployedAlgorithmModels.Result.Length"); i++) {
				ListDeployedAlgorithmModelsResponse.ListDeployedAlgorithmModels_ResultItem resultItem = new ListDeployedAlgorithmModelsResponse.ListDeployedAlgorithmModels_ResultItem();
				resultItem.Id = _ctx.StringValue("ListDeployedAlgorithmModels.Result["+ i +"].id");
				resultItem.AppGroupName = _ctx.StringValue("ListDeployedAlgorithmModels.Result["+ i +"].appGroupName");
				resultItem.Scene = _ctx.StringValue("ListDeployedAlgorithmModels.Result["+ i +"].scene");
				resultItem.Desc = _ctx.StringValue("ListDeployedAlgorithmModels.Result["+ i +"].desc");
				resultItem.GmtCreate = _ctx.StringValue("ListDeployedAlgorithmModels.Result["+ i +"].gmtCreate");
				resultItem.GmtModified = _ctx.StringValue("ListDeployedAlgorithmModels.Result["+ i +"].gmtModified");
				resultItem.Status = _ctx.StringValue("ListDeployedAlgorithmModels.Result["+ i +"].status");

				List<string> resultItem_apps = new List<string>();
				for (int j = 0; j < _ctx.Length("ListDeployedAlgorithmModels.Result["+ i +"].Apps.Length"); j++) {
					resultItem_apps.Add(_ctx.StringValue("ListDeployedAlgorithmModels.Result["+ i +"].Apps["+ j +"]"));
				}
				resultItem.Apps = resultItem_apps;

				List<ListDeployedAlgorithmModelsResponse.ListDeployedAlgorithmModels_ResultItem.ListDeployedAlgorithmModels_ModelsItem> resultItem_models = new List<ListDeployedAlgorithmModelsResponse.ListDeployedAlgorithmModels_ResultItem.ListDeployedAlgorithmModels_ModelsItem>();
				for (int j = 0; j < _ctx.Length("ListDeployedAlgorithmModels.Result["+ i +"].Models.Length"); j++) {
					ListDeployedAlgorithmModelsResponse.ListDeployedAlgorithmModels_ResultItem.ListDeployedAlgorithmModels_ModelsItem modelsItem = new ListDeployedAlgorithmModelsResponse.ListDeployedAlgorithmModels_ResultItem.ListDeployedAlgorithmModels_ModelsItem();
					modelsItem.ModelName = _ctx.StringValue("ListDeployedAlgorithmModels.Result["+ i +"].Models["+ j +"].modelName");
					modelsItem.ModelId = _ctx.IntegerValue("ListDeployedAlgorithmModels.Result["+ i +"].Models["+ j +"].modelId");
					modelsItem.Progress = _ctx.IntegerValue("ListDeployedAlgorithmModels.Result["+ i +"].Models["+ j +"].progress");
					modelsItem.Status = _ctx.StringValue("ListDeployedAlgorithmModels.Result["+ i +"].Models["+ j +"].status");
					modelsItem.ProjectId = _ctx.IntegerValue("ListDeployedAlgorithmModels.Result["+ i +"].Models["+ j +"].projectId");
					modelsItem.AlgorithmType = _ctx.StringValue("ListDeployedAlgorithmModels.Result["+ i +"].Models["+ j +"].algorithmType");

					resultItem_models.Add(modelsItem);
				}
				resultItem.Models = resultItem_models;

				listDeployedAlgorithmModelsResponse_result.Add(resultItem);
			}
			listDeployedAlgorithmModelsResponse.Result = listDeployedAlgorithmModelsResponse_result;
        
			return listDeployedAlgorithmModelsResponse;
        }
    }
}
