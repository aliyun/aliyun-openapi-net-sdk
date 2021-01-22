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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class RecognizeImageResponseUnmarshaller
    {
        public static RecognizeImageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizeImageResponse recognizeImageResponse = new RecognizeImageResponse();

			recognizeImageResponse.HttpResponse = _ctx.HttpResponse;
			recognizeImageResponse.Code = _ctx.StringValue("RecognizeImage.Code");
			recognizeImageResponse.Message = _ctx.StringValue("RecognizeImage.Message");
			recognizeImageResponse.RequestId = _ctx.StringValue("RecognizeImage.RequestId");
			recognizeImageResponse.Success = _ctx.StringValue("RecognizeImage.Success");

			RecognizeImageResponse.RecognizeImage_Data data = new RecognizeImageResponse.RecognizeImage_Data();

			List<RecognizeImageResponse.RecognizeImage_Data.RecognizeImage_BodyListItem> data_bodyList = new List<RecognizeImageResponse.RecognizeImage_Data.RecognizeImage_BodyListItem>();
			for (int i = 0; i < _ctx.Length("RecognizeImage.Data.BodyList.Length"); i++) {
				RecognizeImageResponse.RecognizeImage_Data.RecognizeImage_BodyListItem bodyListItem = new RecognizeImageResponse.RecognizeImage_Data.RecognizeImage_BodyListItem();
				bodyListItem.LeftTopX = _ctx.IntegerValue("RecognizeImage.Data.BodyList["+ i +"].LeftTopX");
				bodyListItem.LeftTopY = _ctx.IntegerValue("RecognizeImage.Data.BodyList["+ i +"].LeftTopY");
				bodyListItem.RightBottomX = _ctx.IntegerValue("RecognizeImage.Data.BodyList["+ i +"].RightBottomX");
				bodyListItem.RightBottomY = _ctx.IntegerValue("RecognizeImage.Data.BodyList["+ i +"].RightBottomY");
				bodyListItem.Feature = _ctx.StringValue("RecognizeImage.Data.BodyList["+ i +"].Feature");
				bodyListItem.TargetImageContent = _ctx.StringValue("RecognizeImage.Data.BodyList["+ i +"].TargetImageContent");
				bodyListItem.CropAlgorithmCode = _ctx.StringValue("RecognizeImage.Data.BodyList["+ i +"].CropAlgorithmCode");

				data_bodyList.Add(bodyListItem);
			}
			data.BodyList = data_bodyList;

			List<RecognizeImageResponse.RecognizeImage_Data.RecognizeImage_FaceListItem> data_faceList = new List<RecognizeImageResponse.RecognizeImage_Data.RecognizeImage_FaceListItem>();
			for (int i = 0; i < _ctx.Length("RecognizeImage.Data.FaceList.Length"); i++) {
				RecognizeImageResponse.RecognizeImage_Data.RecognizeImage_FaceListItem faceListItem = new RecognizeImageResponse.RecognizeImage_Data.RecognizeImage_FaceListItem();
				faceListItem.LeftTopX = _ctx.IntegerValue("RecognizeImage.Data.FaceList["+ i +"].LeftTopX");
				faceListItem.LeftTopY = _ctx.IntegerValue("RecognizeImage.Data.FaceList["+ i +"].LeftTopY");
				faceListItem.RightBottomX = _ctx.IntegerValue("RecognizeImage.Data.FaceList["+ i +"].RightBottomX");
				faceListItem.RightBottomY = _ctx.IntegerValue("RecognizeImage.Data.FaceList["+ i +"].RightBottomY");
				faceListItem.FaceQuality = _ctx.FloatValue("RecognizeImage.Data.FaceList["+ i +"].FaceQuality");
				faceListItem.FaceKeyPointQuality = _ctx.FloatValue("RecognizeImage.Data.FaceList["+ i +"].FaceKeyPointQuality");
				faceListItem.Feature = _ctx.StringValue("RecognizeImage.Data.FaceList["+ i +"].Feature");
				faceListItem.TargetImageContent = _ctx.StringValue("RecognizeImage.Data.FaceList["+ i +"].TargetImageContent");
				faceListItem.CropAlgorithmCode = _ctx.StringValue("RecognizeImage.Data.FaceList["+ i +"].CropAlgorithmCode");

				data_faceList.Add(faceListItem);
			}
			data.FaceList = data_faceList;
			recognizeImageResponse.Data = data;
        
			return recognizeImageResponse;
        }
    }
}
