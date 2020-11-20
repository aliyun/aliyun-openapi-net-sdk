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
using Aliyun.Acs.facebody.Model.V20191230;

namespace Aliyun.Acs.facebody.Transform.V20191230
{
    public class DetectCelebrityResponseUnmarshaller
    {
        public static DetectCelebrityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectCelebrityResponse detectCelebrityResponse = new DetectCelebrityResponse();

			detectCelebrityResponse.HttpResponse = _ctx.HttpResponse;
			detectCelebrityResponse.RequestId = _ctx.StringValue("DetectCelebrity.RequestId");

			DetectCelebrityResponse.DetectCelebrity_Data data = new DetectCelebrityResponse.DetectCelebrity_Data();
			data.Width = _ctx.IntegerValue("DetectCelebrity.Data.Width");
			data.Height = _ctx.IntegerValue("DetectCelebrity.Data.Height");

			List<DetectCelebrityResponse.DetectCelebrity_Data.DetectCelebrity_FaceRecognizeResult> data_faceRecognizeResults = new List<DetectCelebrityResponse.DetectCelebrity_Data.DetectCelebrity_FaceRecognizeResult>();
			for (int i = 0; i < _ctx.Length("DetectCelebrity.Data.FaceRecognizeResults.Length"); i++) {
				DetectCelebrityResponse.DetectCelebrity_Data.DetectCelebrity_FaceRecognizeResult faceRecognizeResult = new DetectCelebrityResponse.DetectCelebrity_Data.DetectCelebrity_FaceRecognizeResult();
				faceRecognizeResult.Name = _ctx.StringValue("DetectCelebrity.Data.FaceRecognizeResults["+ i +"].Name");

				List<string> faceRecognizeResult_faceBoxes = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectCelebrity.Data.FaceRecognizeResults["+ i +"].FaceBoxes.Length"); j++) {
					faceRecognizeResult_faceBoxes.Add(_ctx.StringValue("DetectCelebrity.Data.FaceRecognizeResults["+ i +"].FaceBoxes["+ j +"]"));
				}
				faceRecognizeResult.FaceBoxes = faceRecognizeResult_faceBoxes;

				data_faceRecognizeResults.Add(faceRecognizeResult);
			}
			data.FaceRecognizeResults = data_faceRecognizeResults;
			detectCelebrityResponse.Data = data;
        
			return detectCelebrityResponse;
        }
    }
}
