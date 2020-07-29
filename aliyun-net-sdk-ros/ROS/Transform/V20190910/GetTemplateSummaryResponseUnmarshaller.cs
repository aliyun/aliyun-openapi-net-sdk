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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class GetTemplateSummaryResponseUnmarshaller
    {
        public static GetTemplateSummaryResponse Unmarshall(UnmarshallerContext context)
        {
			GetTemplateSummaryResponse getTemplateSummaryResponse = new GetTemplateSummaryResponse();

			getTemplateSummaryResponse.HttpResponse = context.HttpResponse;
			getTemplateSummaryResponse.RequestId = context.StringValue("GetTemplateSummary.RequestId");
			getTemplateSummaryResponse.Description = context.StringValue("GetTemplateSummary.Description");
			getTemplateSummaryResponse.Metadata = context.StringValue("GetTemplateSummary.Metadata");
			getTemplateSummaryResponse.Version = context.StringValue("GetTemplateSummary.Version");

			List<Dictionary<string, string>> getTemplateSummaryResponse_parameters = new List<Dictionary<string, string>>();
			for (int i = 0; i < context.Length("GetTemplateSummary.Parameters.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in context.ResponseDictionary){
					string prefix = "GetTemplateSummary.Parameters["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					getTemplateSummaryResponse_parameters.Add(tmp);
				}
			}
			getTemplateSummaryResponse.Parameters = getTemplateSummaryResponse_parameters;

			List<string> getTemplateSummaryResponse_resourceTypes = new List<string>();
			for (int i = 0; i < context.Length("GetTemplateSummary.ResourceTypes.Length"); i++) {
				getTemplateSummaryResponse_resourceTypes.Add(context.StringValue("GetTemplateSummary.ResourceTypes["+ i +"]"));
			}
			getTemplateSummaryResponse.ResourceTypes = getTemplateSummaryResponse_resourceTypes;

			List<GetTemplateSummaryResponse.GetTemplateSummary_ResourceIdentifierSummary> getTemplateSummaryResponse_resourceIdentifierSummaries = new List<GetTemplateSummaryResponse.GetTemplateSummary_ResourceIdentifierSummary>();
			for (int i = 0; i < context.Length("GetTemplateSummary.ResourceIdentifierSummaries.Length"); i++) {
				GetTemplateSummaryResponse.GetTemplateSummary_ResourceIdentifierSummary resourceIdentifierSummary = new GetTemplateSummaryResponse.GetTemplateSummary_ResourceIdentifierSummary();
				resourceIdentifierSummary.ResourceType = context.StringValue("GetTemplateSummary.ResourceIdentifierSummaries["+ i +"].ResourceType");

				List<string> resourceIdentifierSummary_logicalResourceIds = new List<string>();
				for (int j = 0; j < context.Length("GetTemplateSummary.ResourceIdentifierSummaries["+ i +"].LogicalResourceIds.Length"); j++) {
					resourceIdentifierSummary_logicalResourceIds.Add(context.StringValue("GetTemplateSummary.ResourceIdentifierSummaries["+ i +"].LogicalResourceIds["+ j +"]"));
				}
				resourceIdentifierSummary.LogicalResourceIds = resourceIdentifierSummary_logicalResourceIds;

				List<string> resourceIdentifierSummary_resourceIdentifiers = new List<string>();
				for (int j = 0; j < context.Length("GetTemplateSummary.ResourceIdentifierSummaries["+ i +"].ResourceIdentifiers.Length"); j++) {
					resourceIdentifierSummary_resourceIdentifiers.Add(context.StringValue("GetTemplateSummary.ResourceIdentifierSummaries["+ i +"].ResourceIdentifiers["+ j +"]"));
				}
				resourceIdentifierSummary.ResourceIdentifiers = resourceIdentifierSummary_resourceIdentifiers;

				getTemplateSummaryResponse_resourceIdentifierSummaries.Add(resourceIdentifierSummary);
			}
			getTemplateSummaryResponse.ResourceIdentifierSummaries = getTemplateSummaryResponse_resourceIdentifierSummaries;
        
			return getTemplateSummaryResponse;
        }
    }
}
