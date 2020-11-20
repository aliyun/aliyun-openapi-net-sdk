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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeViewContentResponseUnmarshaller
    {
        public static DescribeViewContentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeViewContentResponse describeViewContentResponse = new DescribeViewContentResponse();

			describeViewContentResponse.HttpResponse = _ctx.HttpResponse;
			describeViewContentResponse.RequestId = _ctx.StringValue("DescribeViewContent.RequestId");
			describeViewContentResponse.PageSize = _ctx.IntegerValue("DescribeViewContent.PageSize");
			describeViewContentResponse.CurrentPage = _ctx.IntegerValue("DescribeViewContent.CurrentPage");
			describeViewContentResponse.TotalCount = _ctx.IntegerValue("DescribeViewContent.TotalCount");

			List<DescribeViewContentResponse.DescribeViewContent_ViewContent> describeViewContentResponse_viewContentList = new List<DescribeViewContentResponse.DescribeViewContent_ViewContent>();
			for (int i = 0; i < _ctx.Length("DescribeViewContent.ViewContentList.Length"); i++) {
				DescribeViewContentResponse.DescribeViewContent_ViewContent viewContent = new DescribeViewContentResponse.DescribeViewContent_ViewContent();
				viewContent.TaskId = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].TaskId");
				viewContent.DataId = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].DataId");
				viewContent.BizType = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].BizType");
				viewContent.Content = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Content");
				viewContent.Url = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Url");
				viewContent.NewUrl = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].NewUrl");
				viewContent.Thumbnail = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Thumbnail");
				viewContent.RequestTime = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].RequestTime");
				viewContent.ScanFinishedTime = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].ScanFinishedTime");
				viewContent.Suggestion = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Suggestion");
				viewContent.Id = _ctx.LongValue("DescribeViewContent.ViewContentList["+ i +"].Id");
				viewContent.ScanResult = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].ScanResult");

				List<DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_Result> viewContent_results = new List<DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_Result>();
				for (int j = 0; j < _ctx.Length("DescribeViewContent.ViewContentList["+ i +"].Results.Length"); j++) {
					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_Result result = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_Result();
					result.Suggestion = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Results["+ j +"].Suggestion");
					result.Label = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Results["+ j +"].Label");
					result.Scene = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].Results["+ j +"].Scene");

					viewContent_results.Add(result);
				}
				viewContent.Results = viewContent_results;

				List<DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FrameResult> viewContent_frameResults = new List<DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FrameResult>();
				for (int j = 0; j < _ctx.Length("DescribeViewContent.ViewContentList["+ i +"].FrameResults.Length"); j++) {
					DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FrameResult frameResult = new DescribeViewContentResponse.DescribeViewContent_ViewContent.DescribeViewContent_FrameResult();
					frameResult.Url = _ctx.StringValue("DescribeViewContent.ViewContentList["+ i +"].FrameResults["+ j +"].Url");
					frameResult.Offset = _ctx.IntegerValue("DescribeViewContent.ViewContentList["+ i +"].FrameResults["+ j +"].Offset");

					viewContent_frameResults.Add(frameResult);
				}
				viewContent.FrameResults = viewContent_frameResults;

				describeViewContentResponse_viewContentList.Add(viewContent);
			}
			describeViewContentResponse.ViewContentList = describeViewContentResponse_viewContentList;
        
			return describeViewContentResponse;
        }
    }
}
