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
using Aliyun.Acs.Mts.Model.V20140618;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class SearchMediaWorkflowResponseUnmarshaller
    {
        public static SearchMediaWorkflowResponse Unmarshall(UnmarshallerContext context)
        {
            SearchMediaWorkflowResponse searchMediaWorkflowResponse = new SearchMediaWorkflowResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("SearchMediaWorkflow.RequestId"),
                TotalCount = context.LongValue("SearchMediaWorkflow.TotalCount"),
                PageNumber = context.LongValue("SearchMediaWorkflow.PageNumber"),
                PageSize = context.LongValue("SearchMediaWorkflow.PageSize")
            };
            List<SearchMediaWorkflowResponse.MediaWorkflow> mediaWorkflowList = new List<SearchMediaWorkflowResponse.MediaWorkflow>();
			for (int i = 0; i < context.Length("SearchMediaWorkflow.MediaWorkflowList.Length"); i++) {
                SearchMediaWorkflowResponse.MediaWorkflow mediaWorkflow = new SearchMediaWorkflowResponse.MediaWorkflow()
                {
                    MediaWorkflowId = context.StringValue($"SearchMediaWorkflow.MediaWorkflowList[{i}].MediaWorkflowId"),
                    Name = context.StringValue($"SearchMediaWorkflow.MediaWorkflowList[{i}].Name"),
                    Topology = context.StringValue($"SearchMediaWorkflow.MediaWorkflowList[{i}].Topology"),
                    State = context.StringValue($"SearchMediaWorkflow.MediaWorkflowList[{i}].State"),
                    CreationTime = context.StringValue($"SearchMediaWorkflow.MediaWorkflowList[{i}].CreationTime")
                };
                mediaWorkflowList.Add(mediaWorkflow);
			}
			searchMediaWorkflowResponse.MediaWorkflowList = mediaWorkflowList;
        
			return searchMediaWorkflowResponse;
        }
    }
}