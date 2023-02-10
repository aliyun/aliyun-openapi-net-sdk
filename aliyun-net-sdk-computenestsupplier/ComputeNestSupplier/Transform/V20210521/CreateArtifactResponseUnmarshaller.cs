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
    public class CreateArtifactResponseUnmarshaller
    {
        public static CreateArtifactResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateArtifactResponse createArtifactResponse = new CreateArtifactResponse();

			createArtifactResponse.HttpResponse = _ctx.HttpResponse;
			createArtifactResponse.RequestId = _ctx.StringValue("CreateArtifact.RequestId");
			createArtifactResponse.ArtifactId = _ctx.StringValue("CreateArtifact.ArtifactId");
			createArtifactResponse.ArtifactType = _ctx.StringValue("CreateArtifact.ArtifactType");
			createArtifactResponse.Name = _ctx.StringValue("CreateArtifact.Name");
			createArtifactResponse.VersionName = _ctx.StringValue("CreateArtifact.VersionName");
			createArtifactResponse.ArtifactVersion = _ctx.StringValue("CreateArtifact.ArtifactVersion");
			createArtifactResponse.Description = _ctx.StringValue("CreateArtifact.Description");
			createArtifactResponse.GmtModified = _ctx.StringValue("CreateArtifact.GmtModified");
			createArtifactResponse.Status = _ctx.StringValue("CreateArtifact.Status");
			createArtifactResponse.MaxVersion = _ctx.LongValue("CreateArtifact.MaxVersion");
			createArtifactResponse.ArtifactProperty = _ctx.StringValue("CreateArtifact.ArtifactProperty");
			createArtifactResponse.SupportRegionIds = _ctx.StringValue("CreateArtifact.SupportRegionIds");
        
			return createArtifactResponse;
        }
    }
}
