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
using Aliyun.Acs.ComputeNestSupplier.Model.V20210521;

namespace Aliyun.Acs.ComputeNestSupplier.Transform.V20210521
{
    public class GetArtifactResponseUnmarshaller
    {
        public static GetArtifactResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetArtifactResponse getArtifactResponse = new GetArtifactResponse();

			getArtifactResponse.HttpResponse = _ctx.HttpResponse;
			getArtifactResponse.RequestId = _ctx.StringValue("GetArtifact.RequestId");
			getArtifactResponse.ArtifactId = _ctx.StringValue("GetArtifact.ArtifactId");
			getArtifactResponse.ArtifactType = _ctx.StringValue("GetArtifact.ArtifactType");
			getArtifactResponse.Name = _ctx.StringValue("GetArtifact.Name");
			getArtifactResponse.VersionName = _ctx.StringValue("GetArtifact.VersionName");
			getArtifactResponse.ArtifactVersion = _ctx.StringValue("GetArtifact.ArtifactVersion");
			getArtifactResponse.Description = _ctx.StringValue("GetArtifact.Description");
			getArtifactResponse.GmtModified = _ctx.StringValue("GetArtifact.GmtModified");
			getArtifactResponse.Status = _ctx.StringValue("GetArtifact.Status");
			getArtifactResponse.MaxVersion = _ctx.LongValue("GetArtifact.MaxVersion");
			getArtifactResponse.ArtifactProperty = _ctx.StringValue("GetArtifact.ArtifactProperty");
			getArtifactResponse.SupportRegionIds = _ctx.StringValue("GetArtifact.SupportRegionIds");
			getArtifactResponse.Progress = _ctx.StringValue("GetArtifact.Progress");
        
			return getArtifactResponse;
        }
    }
}
