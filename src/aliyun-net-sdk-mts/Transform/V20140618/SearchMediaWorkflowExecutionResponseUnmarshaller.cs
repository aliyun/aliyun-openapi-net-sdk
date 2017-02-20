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
    public class SearchMediaWorkflowExecutionResponseUnmarshaller
    {
        public static SearchMediaWorkflowExecutionResponse Unmarshall(UnmarshallerContext context)
        {
            SearchMediaWorkflowExecutionResponse searchMediaWorkflowExecutionResponse = new SearchMediaWorkflowExecutionResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("SearchMediaWorkflowExecution.RequestId"),
                TotalCount = context.LongValue("SearchMediaWorkflowExecution.TotalCount"),
                PageNumber = context.LongValue("SearchMediaWorkflowExecution.PageNumber"),
                PageSize = context.LongValue("SearchMediaWorkflowExecution.PageSize")
            };
            List<SearchMediaWorkflowExecutionResponse.MediaWorkflowExecution> mediaWorkflowExecutionList = new List<SearchMediaWorkflowExecutionResponse.MediaWorkflowExecution>();
			for (int i = 0; i < context.Length("SearchMediaWorkflowExecution.MediaWorkflowExecutionList.Length"); i++) {
                SearchMediaWorkflowExecutionResponse.MediaWorkflowExecution mediaWorkflowExecution = new SearchMediaWorkflowExecutionResponse.MediaWorkflowExecution()
                {
                    RunId = context.StringValue($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].RunId"),
                    Name = context.StringValue($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].Name"),
                    State = context.StringValue($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].State"),
                    MediaId = context.StringValue($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].MediaId"),
                    CreationTime = context.StringValue($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].CreationTime")
                };
                SearchMediaWorkflowExecutionResponse.MediaWorkflowExecution.Input_ input = new SearchMediaWorkflowExecutionResponse.MediaWorkflowExecution.Input_();

                SearchMediaWorkflowExecutionResponse.MediaWorkflowExecution.Input_.InputFile_ inputFile = new SearchMediaWorkflowExecutionResponse.MediaWorkflowExecution.Input_.InputFile_()
                {
                    Bucket = context.StringValue($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].Input.InputFile.Bucket"),
                    Location = context.StringValue($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].Input.InputFile.Location"),
                    Object = context.StringValue($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].Input.InputFile.Object")
                };
                input.InputFile = inputFile;
				mediaWorkflowExecution.Input = input;

				List<SearchMediaWorkflowExecutionResponse.MediaWorkflowExecution.Activity> activityList = new List<SearchMediaWorkflowExecutionResponse.MediaWorkflowExecution.Activity>();
				for (int j = 0; j < context.Length($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].ActivityList.Length"); j++) {
                    SearchMediaWorkflowExecutionResponse.MediaWorkflowExecution.Activity activity = new SearchMediaWorkflowExecutionResponse.MediaWorkflowExecution.Activity()
                    {
                        Name = context.StringValue($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].ActivityList[{j}].Name"),
                        Type = context.StringValue($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].ActivityList[{j}].Type"),
                        JobId = context.StringValue($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].ActivityList[{j}].JobId"),
                        State = context.StringValue($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].ActivityList[{j}].State"),
                        Code = context.StringValue($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].ActivityList[{j}].Code"),
                        Message = context.StringValue($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].ActivityList[{j}].Message"),
                        StartTime = context.StringValue($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].ActivityList[{j}].StartTime"),
                        EndTime = context.StringValue($"SearchMediaWorkflowExecution.MediaWorkflowExecutionList[{i}].ActivityList[{j}].EndTime")
                    };
                    activityList.Add(activity);
				}
				mediaWorkflowExecution.ActivityList = activityList;

				mediaWorkflowExecutionList.Add(mediaWorkflowExecution);
			}
			searchMediaWorkflowExecutionResponse.MediaWorkflowExecutionList = mediaWorkflowExecutionList;
        
			return searchMediaWorkflowExecutionResponse;
        }
    }
}