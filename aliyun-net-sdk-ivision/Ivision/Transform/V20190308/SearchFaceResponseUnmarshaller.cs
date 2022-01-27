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
    public class SearchFaceResponseUnmarshaller
    {
        public static SearchFaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchFaceResponse searchFaceResponse = new SearchFaceResponse();

			searchFaceResponse.HttpResponse = _ctx.HttpResponse;
			searchFaceResponse.RequestId = _ctx.StringValue("SearchFace.RequestId");
			searchFaceResponse.GroupId = _ctx.StringValue("SearchFace.GroupId");

			SearchFaceResponse.SearchFace_Rect rect = new SearchFaceResponse.SearchFace_Rect();
			rect.Top = _ctx.IntegerValue("SearchFace.Rect.Top");
			rect.Width = _ctx.IntegerValue("SearchFace.Rect.Width");
			rect.Height = _ctx.IntegerValue("SearchFace.Rect.Height");
			rect.Left = _ctx.IntegerValue("SearchFace.Rect.Left");
			searchFaceResponse.Rect = rect;

			List<SearchFaceResponse.SearchFace_FaceResult> searchFaceResponse_faceResults = new List<SearchFaceResponse.SearchFace_FaceResult>();
			for (int i = 0; i < _ctx.Length("SearchFace.FaceResults.Length"); i++) {
				SearchFaceResponse.SearchFace_FaceResult faceResult = new SearchFaceResponse.SearchFace_FaceResult();
				faceResult.FaceToken = _ctx.StringValue("SearchFace.FaceResults["+ i +"].FaceToken");
				faceResult.Probability = _ctx.FloatValue("SearchFace.FaceResults["+ i +"].Probability");

				searchFaceResponse_faceResults.Add(faceResult);
			}
			searchFaceResponse.FaceResults = searchFaceResponse_faceResults;
        
			return searchFaceResponse;
        }
    }
}
