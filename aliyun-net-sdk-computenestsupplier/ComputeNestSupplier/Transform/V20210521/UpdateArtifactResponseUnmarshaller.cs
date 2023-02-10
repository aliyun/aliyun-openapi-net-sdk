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
    public class UpdateArtifactResponseUnmarshaller
    {
        public static UpdateArtifactResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateArtifactResponse updateArtifactResponse = new UpdateArtifactResponse();

			updateArtifactResponse.HttpResponse = _ctx.HttpResponse;
			updateArtifactResponse.RequestId = _ctx.StringValue("UpdateArtifact.RequestId");
			updateArtifactResponse.ArtifactId = _ctx.StringValue("UpdateArtifact.ArtifactId");
			updateArtifactResponse.ArtifactType = _ctx.StringValue("UpdateArtifact.ArtifactType");
			updateArtifactResponse.VersionName = _ctx.StringValue("UpdateArtifact.VersionName");
			updateArtifactResponse.ArtifactVersion = _ctx.StringValue("UpdateArtifact.ArtifactVersion");
			updateArtifactResponse.Description = _ctx.StringValue("UpdateArtifact.Description");
			updateArtifactResponse.GmtModified = _ctx.StringValue("UpdateArtifact.GmtModified");
			updateArtifactResponse.Status = _ctx.StringValue("UpdateArtifact.Status");
			updateArtifactResponse.ArtifactProperty = _ctx.StringValue("UpdateArtifact.ArtifactProperty");
			updateArtifactResponse.SupportRegionIds = _ctx.StringValue("UpdateArtifact.SupportRegionIds");
        
			return updateArtifactResponse;
        }
    }
}
