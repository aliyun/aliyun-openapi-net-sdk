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
    public class RecognizePetResponseUnmarshaller
    {
        public static RecognizePetResponse Unmarshall(UnmarshallerContext context)
        {
			RecognizePetResponse recognizePetResponse = new RecognizePetResponse();

			recognizePetResponse.HttpResponse = context.HttpResponse;
			recognizePetResponse.Code = context.StringValue("RecognizePet.Code");
			recognizePetResponse.Success = context.BooleanValue("RecognizePet.Success");
			recognizePetResponse.Message = context.StringValue("RecognizePet.Message");

			RecognizePetResponse.RecognizePet_Response response = new RecognizePetResponse.RecognizePet_Response();
			response.Success = context.BooleanValue("RecognizePet.Response.Success");
			response.Url = context.StringValue("RecognizePet.Response.Url");
			response.RequestId = context.StringValue("RecognizePet.Response.RequestId");
			response.ErrorCode = context.StringValue("RecognizePet.Response.ErrorCode");
			response.ErrorMessage = context.StringValue("RecognizePet.Response.ErrorMessage");

			RecognizePetResponse.RecognizePet_Response.RecognizePet_Data data = new RecognizePetResponse.RecognizePet_Response.RecognizePet_Data();
			data.External = context.StringValue("RecognizePet.Response.Data.External");
			data.ModelName = context.StringValue("RecognizePet.Response.Data.ModelName");
			data.Confidence = context.StringValue("RecognizePet.Response.Data.Confidence");
			data.Prop = context.StringValue("RecognizePet.Response.Data.Prop");
			data.Name = context.StringValue("RecognizePet.Response.Data.Name");
			data.PicUrl = context.StringValue("RecognizePet.Response.Data.PicUrl");
			data.SptId = context.StringValue("RecognizePet.Response.Data.SptId");
			data.Roid = context.StringValue("RecognizePet.Response.Data.Roid");
			data.Tips = context.StringValue("RecognizePet.Response.Data.Tips");
			data.Description = context.StringValue("RecognizePet.Response.Data.Description");
			data.PredictRes = context.StringValue("RecognizePet.Response.Data.PredictRes");

			List<RecognizePetResponse.RecognizePet_Response.RecognizePet_Data.RecognizePet_Node> data_predictability = new List<RecognizePetResponse.RecognizePet_Response.RecognizePet_Data.RecognizePet_Node>();
			for (int i = 0; i < context.Length("RecognizePet.Response.Data.Predictability.Length"); i++) {
				RecognizePetResponse.RecognizePet_Response.RecognizePet_Data.RecognizePet_Node node = new RecognizePetResponse.RecognizePet_Response.RecognizePet_Data.RecognizePet_Node();
				node.Score = context.StringValue("RecognizePet.Response.Data.Predictability["+ i +"].Score");
				node.Tag = context.StringValue("RecognizePet.Response.Data.Predictability["+ i +"].Tag");

				data_predictability.Add(node);
			}
			data.Predictability = data_predictability;
			response.Data = data;
			recognizePetResponse.Response = response;
        
			return recognizePetResponse;
        }
    }
}
