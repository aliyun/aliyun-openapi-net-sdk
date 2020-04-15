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
    public class RecognizeFlowerResponseUnmarshaller
    {
        public static RecognizeFlowerResponse Unmarshall(UnmarshallerContext context)
        {
			RecognizeFlowerResponse recognizeFlowerResponse = new RecognizeFlowerResponse();

			recognizeFlowerResponse.HttpResponse = context.HttpResponse;
			recognizeFlowerResponse.Code = context.IntegerValue("RecognizeFlower.Code");
			recognizeFlowerResponse.Message = context.StringValue("RecognizeFlower.Message");
			recognizeFlowerResponse.Success = context.BooleanValue("RecognizeFlower.Success");

			RecognizeFlowerResponse.RecognizeFlower_Response response = new RecognizeFlowerResponse.RecognizeFlower_Response();
			response.Success = context.BooleanValue("RecognizeFlower.Response.Success");
			response.Url = context.StringValue("RecognizeFlower.Response.Url");
			response.RequestId = context.StringValue("RecognizeFlower.Response.RequestId");
			response.ErrorCode = context.StringValue("RecognizeFlower.Response.ErrorCode");
			response.ErrorMessage = context.StringValue("RecognizeFlower.Response.ErrorMessage");

			RecognizeFlowerResponse.RecognizeFlower_Response.RecognizeFlower_Data data = new RecognizeFlowerResponse.RecognizeFlower_Response.RecognizeFlower_Data();
			data.External = context.StringValue("RecognizeFlower.Response.Data.External");
			data.Confidence = context.StringValue("RecognizeFlower.Response.Data.Confidence");
			data.Roid = context.StringValue("RecognizeFlower.Response.Data.Roid");
			data.Version = context.StringValue("RecognizeFlower.Response.Data.Version");
			data.Tips = context.StringValue("RecognizeFlower.Response.Data.Tips");
			data.ModelName = context.StringValue("RecognizeFlower.Response.Data.ModelName");
			data.Prop = context.StringValue("RecognizeFlower.Response.Data.Prop");
			data.Name = context.StringValue("RecognizeFlower.Response.Data.Name");
			data.PicUrl = context.StringValue("RecognizeFlower.Response.Data.PicUrl");
			data.SptId = context.StringValue("RecognizeFlower.Response.Data.SptId");
			data.Description = context.StringValue("RecognizeFlower.Response.Data.Description");
			data.PredictRes = context.StringValue("RecognizeFlower.Response.Data.PredictRes");

			List<RecognizeFlowerResponse.RecognizeFlower_Response.RecognizeFlower_Data.RecognizeFlower_Node> data_predictability = new List<RecognizeFlowerResponse.RecognizeFlower_Response.RecognizeFlower_Data.RecognizeFlower_Node>();
			for (int i = 0; i < context.Length("RecognizeFlower.Response.Data.Predictability.Length"); i++) {
				RecognizeFlowerResponse.RecognizeFlower_Response.RecognizeFlower_Data.RecognizeFlower_Node node = new RecognizeFlowerResponse.RecognizeFlower_Response.RecognizeFlower_Data.RecognizeFlower_Node();
				node.Score = context.StringValue("RecognizeFlower.Response.Data.Predictability["+ i +"].Score");
				node.Tag = context.StringValue("RecognizeFlower.Response.Data.Predictability["+ i +"].Tag");

				data_predictability.Add(node);
			}
			data.Predictability = data_predictability;
			response.Data = data;
			recognizeFlowerResponse.Response = response;
        
			return recognizeFlowerResponse;
        }
    }
}
