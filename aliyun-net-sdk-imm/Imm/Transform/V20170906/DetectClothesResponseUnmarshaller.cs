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
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class DetectClothesResponseUnmarshaller
    {
        public static DetectClothesResponse Unmarshall(UnmarshallerContext context)
        {
			DetectClothesResponse detectClothesResponse = new DetectClothesResponse();

			detectClothesResponse.HttpResponse = context.HttpResponse;
			detectClothesResponse.RequestId = context.StringValue("DetectClothes.RequestId");

			List<string> detectClothesResponse_srcUris = new List<string>();
			for (int i = 0; i < context.Length("DetectClothes.SrcUris.Length"); i++) {
				detectClothesResponse_srcUris.Add(context.StringValue("DetectClothes.SrcUris["+ i +"]"));
			}
			detectClothesResponse.SrcUris = detectClothesResponse_srcUris;

			List<DetectClothesResponse.DetectClothes_SuccessDetailsItem> detectClothesResponse_successDetails = new List<DetectClothesResponse.DetectClothes_SuccessDetailsItem>();
			for (int i = 0; i < context.Length("DetectClothes.SuccessDetails.Length"); i++) {
				DetectClothesResponse.DetectClothes_SuccessDetailsItem successDetailsItem = new DetectClothesResponse.DetectClothes_SuccessDetailsItem();
				successDetailsItem.SrcUri = context.StringValue("DetectClothes.SuccessDetails["+ i +"].SrcUri");
				successDetailsItem.Time = context.StringValue("DetectClothes.SuccessDetails["+ i +"].Time");
				successDetailsItem.GetImageTime = context.StringValue("DetectClothes.SuccessDetails["+ i +"].GetImageTime");
				successDetailsItem.DetectTime = context.StringValue("DetectClothes.SuccessDetails["+ i +"].DetectTime");

				List<DetectClothesResponse.DetectClothes_SuccessDetailsItem.DetectClothes_ClothesBoxDetailItem> successDetailsItem_clothesBoxDetail = new List<DetectClothesResponse.DetectClothes_SuccessDetailsItem.DetectClothes_ClothesBoxDetailItem>();
				for (int j = 0; j < context.Length("DetectClothes.SuccessDetails["+ i +"].ClothesBoxDetail.Length"); j++) {
					DetectClothesResponse.DetectClothes_SuccessDetailsItem.DetectClothes_ClothesBoxDetailItem clothesBoxDetailItem = new DetectClothesResponse.DetectClothes_SuccessDetailsItem.DetectClothes_ClothesBoxDetailItem();
					clothesBoxDetailItem.PUID = context.StringValue("DetectClothes.SuccessDetails["+ i +"].ClothesBoxDetail["+ j +"].PUID");
					clothesBoxDetailItem.Type = context.StringValue("DetectClothes.SuccessDetails["+ i +"].ClothesBoxDetail["+ j +"].Type");
					clothesBoxDetailItem.Score = context.FloatValue("DetectClothes.SuccessDetails["+ i +"].ClothesBoxDetail["+ j +"].Score");

					List<string> clothesBoxDetailItem_box = new List<string>();
					for (int k = 0; k < context.Length("DetectClothes.SuccessDetails["+ i +"].ClothesBoxDetail["+ j +"].Box.Length"); k++) {
						clothesBoxDetailItem_box.Add(context.StringValue("DetectClothes.SuccessDetails["+ i +"].ClothesBoxDetail["+ j +"].Box["+ k +"]"));
					}
					clothesBoxDetailItem.Box = clothesBoxDetailItem_box;

					successDetailsItem_clothesBoxDetail.Add(clothesBoxDetailItem);
				}
				successDetailsItem.ClothesBoxDetail = successDetailsItem_clothesBoxDetail;

				detectClothesResponse_successDetails.Add(successDetailsItem);
			}
			detectClothesResponse.SuccessDetails = detectClothesResponse_successDetails;

			List<DetectClothesResponse.DetectClothes_FailDetailsItem> detectClothesResponse_failDetails = new List<DetectClothesResponse.DetectClothes_FailDetailsItem>();
			for (int i = 0; i < context.Length("DetectClothes.FailDetails.Length"); i++) {
				DetectClothesResponse.DetectClothes_FailDetailsItem failDetailsItem = new DetectClothesResponse.DetectClothes_FailDetailsItem();
				failDetailsItem.SrcUri = context.StringValue("DetectClothes.FailDetails["+ i +"].SrcUri");
				failDetailsItem.Reason = context.StringValue("DetectClothes.FailDetails["+ i +"].Reason");

				detectClothesResponse_failDetails.Add(failDetailsItem);
			}
			detectClothesResponse.FailDetails = detectClothesResponse_failDetails;
        
			return detectClothesResponse;
        }
    }
}