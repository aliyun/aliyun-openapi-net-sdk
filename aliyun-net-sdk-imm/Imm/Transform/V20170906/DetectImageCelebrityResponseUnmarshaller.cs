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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class DetectImageCelebrityResponseUnmarshaller
    {
        public static DetectImageCelebrityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectImageCelebrityResponse detectImageCelebrityResponse = new DetectImageCelebrityResponse();

			detectImageCelebrityResponse.HttpResponse = _ctx.HttpResponse;
			detectImageCelebrityResponse.RequestId = _ctx.StringValue("DetectImageCelebrity.RequestId");
			detectImageCelebrityResponse.ImageUri = _ctx.StringValue("DetectImageCelebrity.ImageUri");

			List<DetectImageCelebrityResponse.DetectImageCelebrity_CelebrityItem> detectImageCelebrityResponse_celebrity = new List<DetectImageCelebrityResponse.DetectImageCelebrity_CelebrityItem>();
			for (int i = 0; i < _ctx.Length("DetectImageCelebrity.Celebrity.Length"); i++) {
				DetectImageCelebrityResponse.DetectImageCelebrity_CelebrityItem celebrityItem = new DetectImageCelebrityResponse.DetectImageCelebrity_CelebrityItem();
				celebrityItem.CelebrityName = _ctx.StringValue("DetectImageCelebrity.Celebrity["+ i +"].CelebrityName");
				celebrityItem.CelebrityGender = _ctx.StringValue("DetectImageCelebrity.Celebrity["+ i +"].CelebrityGender");
				celebrityItem.CelebrityConfidence = _ctx.FloatValue("DetectImageCelebrity.Celebrity["+ i +"].CelebrityConfidence");
				celebrityItem.CelebrityLibraryName = _ctx.StringValue("DetectImageCelebrity.Celebrity["+ i +"].CelebrityLibraryName");

				DetectImageCelebrityResponse.DetectImageCelebrity_CelebrityItem.DetectImageCelebrity_CelebrityBoundary celebrityBoundary = new DetectImageCelebrityResponse.DetectImageCelebrity_CelebrityItem.DetectImageCelebrity_CelebrityBoundary();
				celebrityBoundary.Left = _ctx.IntegerValue("DetectImageCelebrity.Celebrity["+ i +"].CelebrityBoundary.Left");
				celebrityBoundary.Top = _ctx.IntegerValue("DetectImageCelebrity.Celebrity["+ i +"].CelebrityBoundary.Top");
				celebrityBoundary.Width = _ctx.IntegerValue("DetectImageCelebrity.Celebrity["+ i +"].CelebrityBoundary.Width");
				celebrityBoundary.Height = _ctx.IntegerValue("DetectImageCelebrity.Celebrity["+ i +"].CelebrityBoundary.Height");
				celebrityItem.CelebrityBoundary = celebrityBoundary;

				detectImageCelebrityResponse_celebrity.Add(celebrityItem);
			}
			detectImageCelebrityResponse.Celebrity = detectImageCelebrityResponse_celebrity;
        
			return detectImageCelebrityResponse;
        }
    }
}
