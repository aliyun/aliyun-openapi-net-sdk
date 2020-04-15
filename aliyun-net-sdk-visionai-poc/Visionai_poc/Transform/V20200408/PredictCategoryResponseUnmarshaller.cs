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
using Aliyun.Acs.visionai_poc.Model.V20200408;

namespace Aliyun.Acs.visionai_poc.Transform.V20200408
{
    public class PredictCategoryResponseUnmarshaller
    {
        public static PredictCategoryResponse Unmarshall(UnmarshallerContext context)
        {
			PredictCategoryResponse predictCategoryResponse = new PredictCategoryResponse();

			predictCategoryResponse.HttpResponse = context.HttpResponse;
			predictCategoryResponse.Code = context.IntegerValue("PredictCategory.Code");
			predictCategoryResponse.Message = context.StringValue("PredictCategory.Message");
			predictCategoryResponse.Success = context.BooleanValue("PredictCategory.Success");

			PredictCategoryResponse.PredictCategory_Response response = new PredictCategoryResponse.PredictCategory_Response();
			response.Success = context.BooleanValue("PredictCategory.Response.Success");
			response.Url = context.StringValue("PredictCategory.Response.Url");
			response.RequestId = context.StringValue("PredictCategory.Response.RequestId");
			response.ErrorCode = context.StringValue("PredictCategory.Response.ErrorCode");
			response.ErrorMessage = context.StringValue("PredictCategory.Response.ErrorMessage");

			List<PredictCategoryResponse.PredictCategory_Response.PredictCategory_Node> response_data = new List<PredictCategoryResponse.PredictCategory_Response.PredictCategory_Node>();
			for (int i = 0; i < context.Length("PredictCategory.Response.Data.Length"); i++) {
				PredictCategoryResponse.PredictCategory_Response.PredictCategory_Node node = new PredictCategoryResponse.PredictCategory_Response.PredictCategory_Node();
				node.CateId = context.StringValue("PredictCategory.Response.Data["+ i +"].CateId");

				PredictCategoryResponse.PredictCategory_Response.PredictCategory_Node.PredictCategory_Category category = new PredictCategoryResponse.PredictCategory_Response.PredictCategory_Node.PredictCategory_Category();
				category.CateLevelFOURName = context.StringValue("PredictCategory.Response.Data["+ i +"].Category.CateLevelFOURName");
				category.CateLevelTwoId = context.IntegerValue("PredictCategory.Response.Data["+ i +"].Category.CateLevelTwoId");
				category.CateLevelOneId = context.IntegerValue("PredictCategory.Response.Data["+ i +"].Category.CateLevelOneId");
				category.CateLevelOneName = context.StringValue("PredictCategory.Response.Data["+ i +"].Category.CateLevelOneName");
				category.CateLevelFourId = context.IntegerValue("PredictCategory.Response.Data["+ i +"].Category.CateLevelFourId");
				category.CateLevel = context.IntegerValue("PredictCategory.Response.Data["+ i +"].Category.CateLevel");
				category.CateLevelThreeId = context.IntegerValue("PredictCategory.Response.Data["+ i +"].Category.CateLevelThreeId");
				category.CateLevelFiveId = context.IntegerValue("PredictCategory.Response.Data["+ i +"].Category.CateLevelFiveId");
				category.CateLevelFiveName = context.StringValue("PredictCategory.Response.Data["+ i +"].Category.CateLevelFiveName");
				category.CateName = context.StringValue("PredictCategory.Response.Data["+ i +"].Category.CateName");
				category.CateLevelTwoName = context.StringValue("PredictCategory.Response.Data["+ i +"].Category.CateLevelTwoName");
				category.Score = context.FloatValue("PredictCategory.Response.Data["+ i +"].Category.Score");
				category.CateId = context.IntegerValue("PredictCategory.Response.Data["+ i +"].Category.CateId");
				category.CateLevelThreeName = context.StringValue("PredictCategory.Response.Data["+ i +"].Category.CateLevelThreeName");
				node.Category = category;

				response_data.Add(node);
			}
			response.Data = response_data;
			predictCategoryResponse.Response = response;
        
			return predictCategoryResponse;
        }
    }
}
