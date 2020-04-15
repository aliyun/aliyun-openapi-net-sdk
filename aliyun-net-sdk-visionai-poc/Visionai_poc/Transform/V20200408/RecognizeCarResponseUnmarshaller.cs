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
    public class RecognizeCarResponseUnmarshaller
    {
        public static RecognizeCarResponse Unmarshall(UnmarshallerContext context)
        {
			RecognizeCarResponse recognizeCarResponse = new RecognizeCarResponse();

			recognizeCarResponse.HttpResponse = context.HttpResponse;
			recognizeCarResponse.Code = context.IntegerValue("RecognizeCar.Code");
			recognizeCarResponse.Message = context.StringValue("RecognizeCar.Message");
			recognizeCarResponse.Success = context.BooleanValue("RecognizeCar.Success");

			RecognizeCarResponse.RecognizeCar_Response response = new RecognizeCarResponse.RecognizeCar_Response();
			response.Success = context.BooleanValue("RecognizeCar.Response.Success");
			response.Url = context.StringValue("RecognizeCar.Response.Url");
			response.RequestId = context.StringValue("RecognizeCar.Response.RequestId");
			response.ErrorCode = context.StringValue("RecognizeCar.Response.ErrorCode");
			response.ErrorMessage = context.StringValue("RecognizeCar.Response.ErrorMessage");

			RecognizeCarResponse.RecognizeCar_Response.RecognizeCar_Data data = new RecognizeCarResponse.RecognizeCar_Response.RecognizeCar_Data();
			data.External = context.StringValue("RecognizeCar.Response.Data.External");
			data.ModelName = context.StringValue("RecognizeCar.Response.Data.ModelName");
			data.Confidence = context.StringValue("RecognizeCar.Response.Data.Confidence");
			data.Prop = context.StringValue("RecognizeCar.Response.Data.Prop");
			data.Name = context.StringValue("RecognizeCar.Response.Data.Name");
			data.PicUrl = context.StringValue("RecognizeCar.Response.Data.PicUrl");
			data.SptId = context.StringValue("RecognizeCar.Response.Data.SptId");
			data.Roid = context.StringValue("RecognizeCar.Response.Data.Roid");
			data.Tips = context.StringValue("RecognizeCar.Response.Data.Tips");
			data.Description = context.StringValue("RecognizeCar.Response.Data.Description");
			data.PredictRes = context.StringValue("RecognizeCar.Response.Data.PredictRes");
			response.Data = data;
			recognizeCarResponse.Response = response;
        
			return recognizeCarResponse;
        }
    }
}
