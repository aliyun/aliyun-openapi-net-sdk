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
using Aliyun.Acs.grace.Model.V20220606;

namespace Aliyun.Acs.grace.Transform.V20220606
{
    public class GetFileResponseUnmarshaller
    {
        public static GetFileResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetFileResponse getFileResponse = new GetFileResponse();

			getFileResponse.HttpResponse = _ctx.HttpResponse;
			getFileResponse.Type = _ctx.StringValue("GetFile.type");
			getFileResponse.Size = _ctx.LongValue("GetFile.size");
			getFileResponse.CreationTime = _ctx.LongValue("GetFile.creationTime");
			getFileResponse.DisplayName = _ctx.StringValue("GetFile.displayName");
			getFileResponse.Labels = _ctx.StringValue("GetFile.labels");
			getFileResponse.Shared = _ctx.BooleanValue("GetFile.shared");
			getFileResponse.TransferState = _ctx.StringValue("GetFile.transferState");
			getFileResponse.Name = _ctx.StringValue("GetFile.name");
			getFileResponse.RequestId = _ctx.StringValue("GetFile.requestId");

			GetFileResponse.GetFile_AnalyzeProgress analyzeProgress = new GetFileResponse.GetFile_AnalyzeProgress();
			analyzeProgress.Message = _ctx.StringValue("GetFile.AnalyzeProgress.message");
			analyzeProgress.Percent = _ctx.DoubleValue("GetFile.AnalyzeProgress.percent");
			analyzeProgress.State = _ctx.StringValue("GetFile.AnalyzeProgress.state");
			getFileResponse.AnalyzeProgress = analyzeProgress;

			GetFileResponse.GetFile_TransferProgress transferProgress = new GetFileResponse.GetFile_TransferProgress();
			transferProgress.TotalSize = _ctx.LongValue("GetFile.TransferProgress.totalSize");
			transferProgress.TransferredSize = _ctx.LongValue("GetFile.TransferProgress.transferredSize");
			getFileResponse.TransferProgress = transferProgress;
        
			return getFileResponse;
        }
    }
}
