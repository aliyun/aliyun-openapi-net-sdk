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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeSecureSuggestionResponseUnmarshaller
    {
        public static DescribeSecureSuggestionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSecureSuggestionResponse describeSecureSuggestionResponse = new DescribeSecureSuggestionResponse();

			describeSecureSuggestionResponse.HttpResponse = _ctx.HttpResponse;
			describeSecureSuggestionResponse.RequestId = _ctx.StringValue("DescribeSecureSuggestion.RequestId");
			describeSecureSuggestionResponse.TotalCount = _ctx.IntegerValue("DescribeSecureSuggestion.TotalCount");

			List<DescribeSecureSuggestionResponse.DescribeSecureSuggestion_Suggestion> describeSecureSuggestionResponse_suggestions = new List<DescribeSecureSuggestionResponse.DescribeSecureSuggestion_Suggestion>();
			for (int i = 0; i < _ctx.Length("DescribeSecureSuggestion.Suggestions.Length"); i++) {
				DescribeSecureSuggestionResponse.DescribeSecureSuggestion_Suggestion suggestion = new DescribeSecureSuggestionResponse.DescribeSecureSuggestion_Suggestion();
				suggestion.SuggestType = _ctx.StringValue("DescribeSecureSuggestion.Suggestions["+ i +"].SuggestType");
				suggestion.Points = _ctx.IntegerValue("DescribeSecureSuggestion.Suggestions["+ i +"].Points");

				List<DescribeSecureSuggestionResponse.DescribeSecureSuggestion_Suggestion.DescribeSecureSuggestion_DetailItem> suggestion_detail = new List<DescribeSecureSuggestionResponse.DescribeSecureSuggestion_Suggestion.DescribeSecureSuggestion_DetailItem>();
				for (int j = 0; j < _ctx.Length("DescribeSecureSuggestion.Suggestions["+ i +"].Detail.Length"); j++) {
					DescribeSecureSuggestionResponse.DescribeSecureSuggestion_Suggestion.DescribeSecureSuggestion_DetailItem detailItem = new DescribeSecureSuggestionResponse.DescribeSecureSuggestion_Suggestion.DescribeSecureSuggestion_DetailItem();
					detailItem.Description = _ctx.StringValue("DescribeSecureSuggestion.Suggestions["+ i +"].Detail["+ j +"].Description");
					detailItem.SubType = _ctx.StringValue("DescribeSecureSuggestion.Suggestions["+ i +"].Detail["+ j +"].SubType");
					detailItem.Title = _ctx.StringValue("DescribeSecureSuggestion.Suggestions["+ i +"].Detail["+ j +"].Title");

					suggestion_detail.Add(detailItem);
				}
				suggestion.Detail = suggestion_detail;

				describeSecureSuggestionResponse_suggestions.Add(suggestion);
			}
			describeSecureSuggestionResponse.Suggestions = describeSecureSuggestionResponse_suggestions;
        
			return describeSecureSuggestionResponse;
        }
    }
}
