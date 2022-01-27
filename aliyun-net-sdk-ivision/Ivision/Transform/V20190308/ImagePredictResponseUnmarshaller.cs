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
        public static ImagePredictResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ImagePredictResponse imagePredictResponse = new ImagePredictResponse();

			imagePredictResponse.HttpResponse = _ctx.HttpResponse;
			imagePredictResponse.RequestId = _ctx.StringValue("ImagePredict.RequestId");

			ImagePredictResponse.ImagePredict_ImagePredict imagePredict = new ImagePredictResponse.ImagePredict_ImagePredict();
			imagePredict.Status = _ctx.StringValue("ImagePredict.ImagePredict.Status");
			imagePredict.PredictResult = _ctx.StringValue("ImagePredict.ImagePredict.PredictResult");
			imagePredict.PredictId = _ctx.StringValue("ImagePredict.ImagePredict.PredictId");
			imagePredict.PredictTime = _ctx.StringValue("ImagePredict.ImagePredict.PredictTime");
			imagePredict.DataUrl = _ctx.StringValue("ImagePredict.ImagePredict.DataUrl");
			imagePredict.Code = _ctx.StringValue("ImagePredict.ImagePredict.Code");
			imagePredict.Message = _ctx.StringValue("ImagePredict.ImagePredict.Message");
			imagePredict.ModelId = _ctx.StringValue("ImagePredict.ImagePredict.ModelId");
			imagePredictResponse.ImagePredict = imagePredict;
        
			return imagePredictResponse;
        }
    }
}
