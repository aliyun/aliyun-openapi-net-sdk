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
    public class ReleaseArtifactResponseUnmarshaller
    {
        public static ReleaseArtifactResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ReleaseArtifactResponse releaseArtifactResponse = new ReleaseArtifactResponse();

			releaseArtifactResponse.HttpResponse = _ctx.HttpResponse;
			releaseArtifactResponse.RequestId = _ctx.StringValue("ReleaseArtifact.RequestId");
			releaseArtifactResponse.ArtifactId = _ctx.StringValue("ReleaseArtifact.ArtifactId");
			releaseArtifactResponse.ArtifactType = _ctx.StringValue("ReleaseArtifact.ArtifactType");
			releaseArtifactResponse.VersionName = _ctx.StringValue("ReleaseArtifact.VersionName");
			releaseArtifactResponse.ArtifactVersion = _ctx.StringValue("ReleaseArtifact.ArtifactVersion");
			releaseArtifactResponse.Description = _ctx.StringValue("ReleaseArtifact.Description");
			releaseArtifactResponse.GmtModified = _ctx.StringValue("ReleaseArtifact.GmtModified");
			releaseArtifactResponse.Status = _ctx.StringValue("ReleaseArtifact.Status");
			releaseArtifactResponse.ArtifactProperty = _ctx.StringValue("ReleaseArtifact.ArtifactProperty");
        
			return releaseArtifactResponse;
        }
    }
}
