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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.MoPen.Model.V20180211;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.MoPen.Transform.V20180211
{
    public class MoPenDoRecognizeResponseUnmarshaller
    {
        public static MoPenDoRecognizeResponse Unmarshall(UnmarshallerContext context)
        {
			MoPenDoRecognizeResponse moPenDoRecognizeResponse = new MoPenDoRecognizeResponse();

			moPenDoRecognizeResponse.HttpResponse = context.HttpResponse;
			moPenDoRecognizeResponse.RequestId = context.StringValue("MoPenDoRecognize.RequestId");
			moPenDoRecognizeResponse.Code = context.StringValue("MoPenDoRecognize.Code");
			moPenDoRecognizeResponse.Message = context.StringValue("MoPenDoRecognize.Message");
			moPenDoRecognizeResponse.Success = context.BooleanValue("MoPenDoRecognize.Success");
			moPenDoRecognizeResponse.Description = context.StringValue("MoPenDoRecognize.Description");

			MoPenDoRecognizeResponse.MoPenDoRecognize_Data data = new MoPenDoRecognizeResponse.MoPenDoRecognize_Data();
			data.Result = context.StringValue("MoPenDoRecognize.Data.Result");
			data.ResultType = context.StringValue("MoPenDoRecognize.Data.ResultType");
			data.CanvasId = context.LongValue("MoPenDoRecognize.Data.CanvasId");
			moPenDoRecognizeResponse.Data = data;
        
			return moPenDoRecognizeResponse;
        }
    }
}