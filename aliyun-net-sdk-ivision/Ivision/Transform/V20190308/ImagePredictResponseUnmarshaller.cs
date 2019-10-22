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
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class ImagePredictResponseUnmarshaller
    {
        public static ImagePredictResponse Unmarshall(UnmarshallerContext context)
        {
			ImagePredictResponse imagePredictResponse = new ImagePredictResponse();

			imagePredictResponse.HttpResponse = context.HttpResponse;
			imagePredictResponse.RequestId = context.StringValue("ImagePredict.RequestId");

			ImagePredictResponse.ImagePredict_ImagePredict imagePredict = new ImagePredictResponse.ImagePredict_ImagePredict();
			imagePredict.PredictId = context.StringValue("ImagePredict.ImagePredict.PredictId");
			imagePredict.ModelId = context.StringValue("ImagePredict.ImagePredict.ModelId");
			imagePredict.DataUrl = context.StringValue("ImagePredict.ImagePredict.DataUrl");
			imagePredict.PredictTime = context.StringValue("ImagePredict.ImagePredict.PredictTime");
			imagePredict.Status = context.StringValue("ImagePredict.ImagePredict.Status");
			imagePredict.Code = context.StringValue("ImagePredict.ImagePredict.Code");
			imagePredict.Message = context.StringValue("ImagePredict.ImagePredict.Message");
			imagePredict.PredictResult = context.StringValue("ImagePredict.ImagePredict.PredictResult");
			imagePredictResponse.ImagePredict = imagePredict;
        
			return imagePredictResponse;
        }
    }
}
