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
    public class DetectImageCelebrityResponseUnmarshaller
    {
        public static DetectImageCelebrityResponse Unmarshall(UnmarshallerContext context)
        {
			DetectImageCelebrityResponse detectImageCelebrityResponse = new DetectImageCelebrityResponse();

			detectImageCelebrityResponse.HttpResponse = context.HttpResponse;
			detectImageCelebrityResponse.RequestId = context.StringValue("DetectImageCelebrity.RequestId");
			detectImageCelebrityResponse.ImageUri = context.StringValue("DetectImageCelebrity.ImageUri");

			List<DetectImageCelebrityResponse.DetectImageCelebrity_CelebrityItem> detectImageCelebrityResponse_celebrity = new List<DetectImageCelebrityResponse.DetectImageCelebrity_CelebrityItem>();
			for (int i = 0; i < context.Length("DetectImageCelebrity.Celebrity.Length"); i++) {
				DetectImageCelebrityResponse.DetectImageCelebrity_CelebrityItem celebrityItem = new DetectImageCelebrityResponse.DetectImageCelebrity_CelebrityItem();
				celebrityItem.CelebrityName = context.StringValue("DetectImageCelebrity.Celebrity["+ i +"].CelebrityName");
				celebrityItem.CelebrityGender = context.StringValue("DetectImageCelebrity.Celebrity["+ i +"].CelebrityGender");
				celebrityItem.CelebrityConfidence = context.FloatValue("DetectImageCelebrity.Celebrity["+ i +"].CelebrityConfidence");
				celebrityItem.CelebrityLibraryName = context.StringValue("DetectImageCelebrity.Celebrity["+ i +"].CelebrityLibraryName");

				DetectImageCelebrityResponse.DetectImageCelebrity_CelebrityItem.DetectImageCelebrity_CelebrityBoundary celebrityBoundary = new DetectImageCelebrityResponse.DetectImageCelebrity_CelebrityItem.DetectImageCelebrity_CelebrityBoundary();
				celebrityBoundary.Left = context.IntegerValue("DetectImageCelebrity.Celebrity["+ i +"].CelebrityBoundary.Left");
				celebrityBoundary.Top = context.IntegerValue("DetectImageCelebrity.Celebrity["+ i +"].CelebrityBoundary.Top");
				celebrityBoundary.Width = context.IntegerValue("DetectImageCelebrity.Celebrity["+ i +"].CelebrityBoundary.Width");
				celebrityBoundary.Height = context.IntegerValue("DetectImageCelebrity.Celebrity["+ i +"].CelebrityBoundary.Height");
				celebrityItem.CelebrityBoundary = celebrityBoundary;

				detectImageCelebrityResponse_celebrity.Add(celebrityItem);
			}
			detectImageCelebrityResponse.Celebrity = detectImageCelebrityResponse_celebrity;
        
			return detectImageCelebrityResponse;
        }
    }
}