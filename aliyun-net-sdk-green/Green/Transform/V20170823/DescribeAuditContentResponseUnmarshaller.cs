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
    public class DescribeAuditContentResponseUnmarshaller
    {
        public static DescribeAuditContentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAuditContentResponse describeAuditContentResponse = new DescribeAuditContentResponse();

			describeAuditContentResponse.HttpResponse = _ctx.HttpResponse;
			describeAuditContentResponse.CurrentPage = _ctx.IntegerValue("DescribeAuditContent.CurrentPage");
			describeAuditContentResponse.RequestId = _ctx.StringValue("DescribeAuditContent.RequestId");
			describeAuditContentResponse.PageSize = _ctx.IntegerValue("DescribeAuditContent.PageSize");
			describeAuditContentResponse.TotalCount = _ctx.IntegerValue("DescribeAuditContent.TotalCount");

			List<DescribeAuditContentResponse.DescribeAuditContent_AuditContent> describeAuditContentResponse_auditContentList = new List<DescribeAuditContentResponse.DescribeAuditContent_AuditContent>();
			for (int i = 0; i < _ctx.Length("DescribeAuditContent.AuditContentList.Length"); i++) {
				DescribeAuditContentResponse.DescribeAuditContent_AuditContent auditContent = new DescribeAuditContentResponse.DescribeAuditContent_AuditContent();
				auditContent.Suggestion = _ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].Suggestion");
				auditContent.Url = _ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].Url");
				auditContent.DataId = _ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].DataId");
				auditContent.BizType = _ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].BizType");
				auditContent.NewUrl = _ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].NewUrl");
				auditContent.ScanFinishedTime = _ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].ScanFinishedTime");
				auditContent.AuditResult = _ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].AuditResult");
				auditContent.TaskId = _ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].TaskId");
				auditContent.Content = _ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].Content");
				auditContent.Thumbnail = _ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].Thumbnail");
				auditContent.Audit = _ctx.IntegerValue("DescribeAuditContent.AuditContentList["+ i +"].Audit");
				auditContent.Id = _ctx.LongValue("DescribeAuditContent.AuditContentList["+ i +"].Id");
				auditContent.RequestTime = _ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].RequestTime");

				List<string> auditContent_auditIllegalReasons = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeAuditContent.AuditContentList["+ i +"].AuditIllegalReasons.Length"); j++) {
					auditContent_auditIllegalReasons.Add(_ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].AuditIllegalReasons["+ j +"]"));
				}
				auditContent.AuditIllegalReasons = auditContent_auditIllegalReasons;

				List<DescribeAuditContentResponse.DescribeAuditContent_AuditContent.DescribeAuditContent_Result> auditContent_results = new List<DescribeAuditContentResponse.DescribeAuditContent_AuditContent.DescribeAuditContent_Result>();
				for (int j = 0; j < _ctx.Length("DescribeAuditContent.AuditContentList["+ i +"].Results.Length"); j++) {
					DescribeAuditContentResponse.DescribeAuditContent_AuditContent.DescribeAuditContent_Result result = new DescribeAuditContentResponse.DescribeAuditContent_AuditContent.DescribeAuditContent_Result();
					result.Suggestion = _ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].Results["+ j +"].Suggestion");
					result.Label = _ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].Results["+ j +"].Label");
					result.Scene = _ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].Results["+ j +"].Scene");

					auditContent_results.Add(result);
				}
				auditContent.Results = auditContent_results;

				List<DescribeAuditContentResponse.DescribeAuditContent_AuditContent.DescribeAuditContent_FrameResult> auditContent_frameResults = new List<DescribeAuditContentResponse.DescribeAuditContent_AuditContent.DescribeAuditContent_FrameResult>();
				for (int j = 0; j < _ctx.Length("DescribeAuditContent.AuditContentList["+ i +"].FrameResults.Length"); j++) {
					DescribeAuditContentResponse.DescribeAuditContent_AuditContent.DescribeAuditContent_FrameResult frameResult = new DescribeAuditContentResponse.DescribeAuditContent_AuditContent.DescribeAuditContent_FrameResult();
					frameResult.Offset = _ctx.IntegerValue("DescribeAuditContent.AuditContentList["+ i +"].FrameResults["+ j +"].Offset");
					frameResult.Url = _ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].FrameResults["+ j +"].Url");
					frameResult.Label = _ctx.StringValue("DescribeAuditContent.AuditContentList["+ i +"].FrameResults["+ j +"].Label");

					auditContent_frameResults.Add(frameResult);
				}
				auditContent.FrameResults = auditContent_frameResults;

				describeAuditContentResponse_auditContentList.Add(auditContent);
			}
			describeAuditContentResponse.AuditContentList = describeAuditContentResponse_auditContentList;
        
			return describeAuditContentResponse;
        }
    }
}
