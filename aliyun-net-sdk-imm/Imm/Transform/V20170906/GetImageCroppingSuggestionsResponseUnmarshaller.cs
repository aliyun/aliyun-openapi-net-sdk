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
    public class GetImageCroppingSuggestionsResponseUnmarshaller
    {
        public static GetImageCroppingSuggestionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetImageCroppingSuggestionsResponse getImageCroppingSuggestionsResponse = new GetImageCroppingSuggestionsResponse();

			getImageCroppingSuggestionsResponse.HttpResponse = _ctx.HttpResponse;
			getImageCroppingSuggestionsResponse.RequestId = _ctx.StringValue("GetImageCroppingSuggestions.RequestId");
			getImageCroppingSuggestionsResponse.ImageUri = _ctx.StringValue("GetImageCroppingSuggestions.ImageUri");

			List<GetImageCroppingSuggestionsResponse.GetImageCroppingSuggestions_CroppingSuggestionsItem> getImageCroppingSuggestionsResponse_croppingSuggestions = new List<GetImageCroppingSuggestionsResponse.GetImageCroppingSuggestions_CroppingSuggestionsItem>();
			for (int i = 0; i < _ctx.Length("GetImageCroppingSuggestions.CroppingSuggestions.Length"); i++) {
				GetImageCroppingSuggestionsResponse.GetImageCroppingSuggestions_CroppingSuggestionsItem croppingSuggestionsItem = new GetImageCroppingSuggestionsResponse.GetImageCroppingSuggestions_CroppingSuggestionsItem();
				croppingSuggestionsItem.Score = _ctx.FloatValue("GetImageCroppingSuggestions.CroppingSuggestions["+ i +"].Score");
				croppingSuggestionsItem.AspectRatio = _ctx.StringValue("GetImageCroppingSuggestions.CroppingSuggestions["+ i +"].AspectRatio");

				GetImageCroppingSuggestionsResponse.GetImageCroppingSuggestions_CroppingSuggestionsItem.GetImageCroppingSuggestions_CroppingBoundary croppingBoundary = new GetImageCroppingSuggestionsResponse.GetImageCroppingSuggestions_CroppingSuggestionsItem.GetImageCroppingSuggestions_CroppingBoundary();
				croppingBoundary.Left = _ctx.IntegerValue("GetImageCroppingSuggestions.CroppingSuggestions["+ i +"].CroppingBoundary.Left");
				croppingBoundary.Top = _ctx.IntegerValue("GetImageCroppingSuggestions.CroppingSuggestions["+ i +"].CroppingBoundary.Top");
				croppingBoundary.Width = _ctx.IntegerValue("GetImageCroppingSuggestions.CroppingSuggestions["+ i +"].CroppingBoundary.Width");
				croppingBoundary.Height = _ctx.IntegerValue("GetImageCroppingSuggestions.CroppingSuggestions["+ i +"].CroppingBoundary.Height");
				croppingSuggestionsItem.CroppingBoundary = croppingBoundary;

				getImageCroppingSuggestionsResponse_croppingSuggestions.Add(croppingSuggestionsItem);
			}
			getImageCroppingSuggestionsResponse.CroppingSuggestions = getImageCroppingSuggestionsResponse_croppingSuggestions;
        
			return getImageCroppingSuggestionsResponse;
        }
    }
}
