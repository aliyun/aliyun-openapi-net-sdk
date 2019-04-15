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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeSecureSuggestionResponseUnmarshaller
    {
        public static DescribeSecureSuggestionResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSecureSuggestionResponse describeSecureSuggestionResponse = new DescribeSecureSuggestionResponse();

			describeSecureSuggestionResponse.HttpResponse = context.HttpResponse;
			describeSecureSuggestionResponse.RequestId = context.StringValue("DescribeSecureSuggestion.RequestId");
			describeSecureSuggestionResponse.TotalCount = context.IntegerValue("DescribeSecureSuggestion.TotalCount");

			List<DescribeSecureSuggestionResponse.DescribeSecureSuggestion_Suggestion> describeSecureSuggestionResponse_suggestions = new List<DescribeSecureSuggestionResponse.DescribeSecureSuggestion_Suggestion>();
			for (int i = 0; i < context.Length("DescribeSecureSuggestion.Suggestions.Length"); i++) {
				DescribeSecureSuggestionResponse.DescribeSecureSuggestion_Suggestion suggestion = new DescribeSecureSuggestionResponse.DescribeSecureSuggestion_Suggestion();
				suggestion.SuggestType = context.StringValue("DescribeSecureSuggestion.Suggestions["+ i +"].SuggestType");
				suggestion.Points = context.IntegerValue("DescribeSecureSuggestion.Suggestions["+ i +"].Points");

				List<DescribeSecureSuggestionResponse.DescribeSecureSuggestion_Suggestion.DescribeSecureSuggestion_DetailItem> suggestion_detail = new List<DescribeSecureSuggestionResponse.DescribeSecureSuggestion_Suggestion.DescribeSecureSuggestion_DetailItem>();
				for (int j = 0; j < context.Length("DescribeSecureSuggestion.Suggestions["+ i +"].Detail.Length"); j++) {
					DescribeSecureSuggestionResponse.DescribeSecureSuggestion_Suggestion.DescribeSecureSuggestion_DetailItem detailItem = new DescribeSecureSuggestionResponse.DescribeSecureSuggestion_Suggestion.DescribeSecureSuggestion_DetailItem();
					detailItem.Description = context.StringValue("DescribeSecureSuggestion.Suggestions["+ i +"].Detail["+ j +"].Description");
					detailItem.SubType = context.StringValue("DescribeSecureSuggestion.Suggestions["+ i +"].Detail["+ j +"].SubType");
					detailItem.Title = context.StringValue("DescribeSecureSuggestion.Suggestions["+ i +"].Detail["+ j +"].Title");

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
