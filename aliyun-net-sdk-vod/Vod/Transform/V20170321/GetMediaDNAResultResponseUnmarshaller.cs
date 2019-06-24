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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetMediaDNAResultResponseUnmarshaller
    {
        public static GetMediaDNAResultResponse Unmarshall(UnmarshallerContext context)
        {
			GetMediaDNAResultResponse getMediaDNAResultResponse = new GetMediaDNAResultResponse();

			getMediaDNAResultResponse.HttpResponse = context.HttpResponse;
			getMediaDNAResultResponse.RequestId = context.StringValue("GetMediaDNAResult.RequestId");

			GetMediaDNAResultResponse.GetMediaDNAResult_DNAResult dNAResult = new GetMediaDNAResultResponse.GetMediaDNAResult_DNAResult();

			List<GetMediaDNAResultResponse.GetMediaDNAResult_DNAResult.GetMediaDNAResult_VideoDNAItem> dNAResult_videoDNA = new List<GetMediaDNAResultResponse.GetMediaDNAResult_DNAResult.GetMediaDNAResult_VideoDNAItem>();
			for (int i = 0; i < context.Length("GetMediaDNAResult.DNAResult.VideoDNA.Length"); i++) {
				GetMediaDNAResultResponse.GetMediaDNAResult_DNAResult.GetMediaDNAResult_VideoDNAItem videoDNAItem = new GetMediaDNAResultResponse.GetMediaDNAResult_DNAResult.GetMediaDNAResult_VideoDNAItem();
				videoDNAItem.PrimaryKey = context.StringValue("GetMediaDNAResult.DNAResult.VideoDNA["+ i +"].PrimaryKey");
				videoDNAItem.Similarity = context.StringValue("GetMediaDNAResult.DNAResult.VideoDNA["+ i +"].Similarity");

				List<GetMediaDNAResultResponse.GetMediaDNAResult_DNAResult.GetMediaDNAResult_VideoDNAItem.GetMediaDNAResult_DetailItem> videoDNAItem_detail = new List<GetMediaDNAResultResponse.GetMediaDNAResult_DNAResult.GetMediaDNAResult_VideoDNAItem.GetMediaDNAResult_DetailItem>();
				for (int j = 0; j < context.Length("GetMediaDNAResult.DNAResult.VideoDNA["+ i +"].Detail.Length"); j++) {
					GetMediaDNAResultResponse.GetMediaDNAResult_DNAResult.GetMediaDNAResult_VideoDNAItem.GetMediaDNAResult_DetailItem detailItem = new GetMediaDNAResultResponse.GetMediaDNAResult_DNAResult.GetMediaDNAResult_VideoDNAItem.GetMediaDNAResult_DetailItem();

					GetMediaDNAResultResponse.GetMediaDNAResult_DNAResult.GetMediaDNAResult_VideoDNAItem.GetMediaDNAResult_DetailItem.GetMediaDNAResult_Input input = new GetMediaDNAResultResponse.GetMediaDNAResult_DNAResult.GetMediaDNAResult_VideoDNAItem.GetMediaDNAResult_DetailItem.GetMediaDNAResult_Input();
					input.Start = context.StringValue("GetMediaDNAResult.DNAResult.VideoDNA["+ i +"].Detail["+ j +"].Input.Start");
					input.Duration = context.StringValue("GetMediaDNAResult.DNAResult.VideoDNA["+ i +"].Detail["+ j +"].Input.Duration");
					detailItem.Input = input;

					GetMediaDNAResultResponse.GetMediaDNAResult_DNAResult.GetMediaDNAResult_VideoDNAItem.GetMediaDNAResult_DetailItem.GetMediaDNAResult_Duplication duplication = new GetMediaDNAResultResponse.GetMediaDNAResult_DNAResult.GetMediaDNAResult_VideoDNAItem.GetMediaDNAResult_DetailItem.GetMediaDNAResult_Duplication();
					duplication.Start = context.StringValue("GetMediaDNAResult.DNAResult.VideoDNA["+ i +"].Detail["+ j +"].Duplication.Start");
					duplication.Duration = context.StringValue("GetMediaDNAResult.DNAResult.VideoDNA["+ i +"].Detail["+ j +"].Duplication.Duration");
					detailItem.Duplication = duplication;

					videoDNAItem_detail.Add(detailItem);
				}
				videoDNAItem.Detail = videoDNAItem_detail;

				dNAResult_videoDNA.Add(videoDNAItem);
			}
			dNAResult.VideoDNA = dNAResult_videoDNA;
			getMediaDNAResultResponse.DNAResult = dNAResult;
        
			return getMediaDNAResultResponse;
        }
    }
}
