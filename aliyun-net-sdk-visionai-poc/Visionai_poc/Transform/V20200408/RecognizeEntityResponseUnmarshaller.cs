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
    public class RecognizeEntityResponseUnmarshaller
    {
        public static RecognizeEntityResponse Unmarshall(UnmarshallerContext context)
        {
			RecognizeEntityResponse recognizeEntityResponse = new RecognizeEntityResponse();

			recognizeEntityResponse.HttpResponse = context.HttpResponse;
			recognizeEntityResponse.Code = context.IntegerValue("RecognizeEntity.Code");
			recognizeEntityResponse.Message = context.StringValue("RecognizeEntity.Message");
			recognizeEntityResponse.Success = context.BooleanValue("RecognizeEntity.Success");

			RecognizeEntityResponse.RecognizeEntity_Response response = new RecognizeEntityResponse.RecognizeEntity_Response();
			response.Success = context.BooleanValue("RecognizeEntity.Response.Success");
			response.Url = context.StringValue("RecognizeEntity.Response.Url");
			response.RequestId = context.StringValue("RecognizeEntity.Response.RequestId");
			response.ErrorCode = context.StringValue("RecognizeEntity.Response.ErrorCode");
			response.ErrorMessage = context.StringValue("RecognizeEntity.Response.ErrorMessage");

			RecognizeEntityResponse.RecognizeEntity_Response.RecognizeEntity_Data data = new RecognizeEntityResponse.RecognizeEntity_Response.RecognizeEntity_Data();
			data.CallSubModelApi = context.IntegerValue("RecognizeEntity.Response.Data.CallSubModelApi");
			data.RequestId = context.StringValue("RecognizeEntity.Response.Data.RequestId");
			data.UseSubModelResult = context.IntegerValue("RecognizeEntity.Response.Data.UseSubModelResult");

			List<RecognizeEntityResponse.RecognizeEntity_Response.RecognizeEntity_Data.RecognizeEntity_Node> data_result = new List<RecognizeEntityResponse.RecognizeEntity_Response.RecognizeEntity_Data.RecognizeEntity_Node>();
			for (int i = 0; i < context.Length("RecognizeEntity.Response.Data.Result.Length"); i++) {
				RecognizeEntityResponse.RecognizeEntity_Response.RecognizeEntity_Data.RecognizeEntity_Node node = new RecognizeEntityResponse.RecognizeEntity_Response.RecognizeEntity_Data.RecognizeEntity_Node();
				node.Score = context.StringValue("RecognizeEntity.Response.Data.Result["+ i +"].Score");
				node.Tag = context.StringValue("RecognizeEntity.Response.Data.Result["+ i +"].Tag");

				data_result.Add(node);
			}
			data.Result = data_result;
			response.Data = data;
			recognizeEntityResponse.Response = response;
        
			return recognizeEntityResponse;
        }
    }
}
