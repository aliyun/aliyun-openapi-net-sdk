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
    public class ListArtifactVersionsResponseUnmarshaller
    {
        public static ListArtifactVersionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListArtifactVersionsResponse listArtifactVersionsResponse = new ListArtifactVersionsResponse();

			listArtifactVersionsResponse.HttpResponse = _ctx.HttpResponse;
			listArtifactVersionsResponse.RequestId = _ctx.StringValue("ListArtifactVersions.RequestId");
			listArtifactVersionsResponse.NextToken = _ctx.StringValue("ListArtifactVersions.NextToken");
			listArtifactVersionsResponse.MaxResults = _ctx.StringValue("ListArtifactVersions.MaxResults");
			listArtifactVersionsResponse.TotalCount = _ctx.StringValue("ListArtifactVersions.TotalCount");

			List<ListArtifactVersionsResponse.ListArtifactVersions_Artifact> listArtifactVersionsResponse_artifacts = new List<ListArtifactVersionsResponse.ListArtifactVersions_Artifact>();
			for (int i = 0; i < _ctx.Length("ListArtifactVersions.Artifacts.Length"); i++) {
				ListArtifactVersionsResponse.ListArtifactVersions_Artifact artifact = new ListArtifactVersionsResponse.ListArtifactVersions_Artifact();
				artifact.ArtifactId = _ctx.StringValue("ListArtifactVersions.Artifacts["+ i +"].ArtifactId");
				artifact.ArtifactType = _ctx.StringValue("ListArtifactVersions.Artifacts["+ i +"].ArtifactType");
				artifact.VersionName = _ctx.StringValue("ListArtifactVersions.Artifacts["+ i +"].VersionName");
				artifact.ArtifactVersion = _ctx.StringValue("ListArtifactVersions.Artifacts["+ i +"].ArtifactVersion");
				artifact.Status = _ctx.StringValue("ListArtifactVersions.Artifacts["+ i +"].Status");
				artifact.ArtifactProperty = _ctx.StringValue("ListArtifactVersions.Artifacts["+ i +"].ArtifactProperty");
				artifact.SupportRegionIds = _ctx.StringValue("ListArtifactVersions.Artifacts["+ i +"].SupportRegionIds");
				artifact.GmtModified = _ctx.StringValue("ListArtifactVersions.Artifacts["+ i +"].GmtModified");
				artifact.Progress = _ctx.StringValue("ListArtifactVersions.Artifacts["+ i +"].Progress");
				artifact.GmtCreate = _ctx.StringValue("ListArtifactVersions.Artifacts["+ i +"].GmtCreate");
				artifact.ImageDelivery = _ctx.StringValue("ListArtifactVersions.Artifacts["+ i +"].ImageDelivery");
				artifact.SecurityAuditResult = _ctx.StringValue("ListArtifactVersions.Artifacts["+ i +"].SecurityAuditResult");
				artifact.ResultFile = _ctx.StringValue("ListArtifactVersions.Artifacts["+ i +"].ResultFile");

				listArtifactVersionsResponse_artifacts.Add(artifact);
			}
			listArtifactVersionsResponse.Artifacts = listArtifactVersionsResponse_artifacts;
        
			return listArtifactVersionsResponse;
        }
    }
}
