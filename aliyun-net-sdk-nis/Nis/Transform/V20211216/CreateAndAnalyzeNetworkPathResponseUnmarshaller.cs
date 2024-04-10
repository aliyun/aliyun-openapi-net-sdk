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
using Aliyun.Acs.nis.Model.V20211216;

namespace Aliyun.Acs.nis.Transform.V20211216
{
    public class CreateAndAnalyzeNetworkPathResponseUnmarshaller
    {
        public static CreateAndAnalyzeNetworkPathResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateAndAnalyzeNetworkPathResponse createAndAnalyzeNetworkPathResponse = new CreateAndAnalyzeNetworkPathResponse();

			createAndAnalyzeNetworkPathResponse.HttpResponse = _ctx.HttpResponse;
			createAndAnalyzeNetworkPathResponse.RequestId = _ctx.StringValue("CreateAndAnalyzeNetworkPath.RequestId");
			createAndAnalyzeNetworkPathResponse.NetworkReachableAnalysisId = _ctx.StringValue("CreateAndAnalyzeNetworkPath.NetworkReachableAnalysisId");
			createAndAnalyzeNetworkPathResponse.SourceId = _ctx.StringValue("CreateAndAnalyzeNetworkPath.SourceId");
			createAndAnalyzeNetworkPathResponse.TargetId = _ctx.StringValue("CreateAndAnalyzeNetworkPath.TargetId");
			createAndAnalyzeNetworkPathResponse.SourceType = _ctx.StringValue("CreateAndAnalyzeNetworkPath.SourceType");
			createAndAnalyzeNetworkPathResponse.TargetType = _ctx.StringValue("CreateAndAnalyzeNetworkPath.TargetType");
			createAndAnalyzeNetworkPathResponse.SourcePort = _ctx.StringValue("CreateAndAnalyzeNetworkPath.SourcePort");
			createAndAnalyzeNetworkPathResponse.TargetPort = _ctx.StringValue("CreateAndAnalyzeNetworkPath.TargetPort");
			createAndAnalyzeNetworkPathResponse.Protocol = _ctx.StringValue("CreateAndAnalyzeNetworkPath.Protocol");
			createAndAnalyzeNetworkPathResponse.SourceIpAddress = _ctx.StringValue("CreateAndAnalyzeNetworkPath.SourceIpAddress");
			createAndAnalyzeNetworkPathResponse.TargetIpAddress = _ctx.StringValue("CreateAndAnalyzeNetworkPath.TargetIpAddress");
        
			return createAndAnalyzeNetworkPathResponse;
        }
    }
}
