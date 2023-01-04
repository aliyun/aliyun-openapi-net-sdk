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
    public class ListArtifactsResponseUnmarshaller
    {
        public static ListArtifactsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListArtifactsResponse listArtifactsResponse = new ListArtifactsResponse();

			listArtifactsResponse.HttpResponse = _ctx.HttpResponse;
			listArtifactsResponse.RequestId = _ctx.StringValue("ListArtifacts.RequestId");
			listArtifactsResponse.NextToken = _ctx.StringValue("ListArtifacts.NextToken");
			listArtifactsResponse.MaxResults = _ctx.StringValue("ListArtifacts.MaxResults");
			listArtifactsResponse.TotalCount = _ctx.StringValue("ListArtifacts.TotalCount");

			List<ListArtifactsResponse.ListArtifacts_Artifact> listArtifactsResponse_artifacts = new List<ListArtifactsResponse.ListArtifacts_Artifact>();
			for (int i = 0; i < _ctx.Length("ListArtifacts.Artifacts.Length"); i++) {
				ListArtifactsResponse.ListArtifacts_Artifact artifact = new ListArtifactsResponse.ListArtifacts_Artifact();
				artifact.ArtifactId = _ctx.StringValue("ListArtifacts.Artifacts["+ i +"].ArtifactId");
				artifact.ArtifactType = _ctx.StringValue("ListArtifacts.Artifacts["+ i +"].ArtifactType");
				artifact.Name = _ctx.StringValue("ListArtifacts.Artifacts["+ i +"].Name");
				artifact.MaxVersion = _ctx.StringValue("ListArtifacts.Artifacts["+ i +"].MaxVersion");
				artifact.Description = _ctx.StringValue("ListArtifacts.Artifacts["+ i +"].Description");
				artifact.GmtModified = _ctx.StringValue("ListArtifacts.Artifacts["+ i +"].GmtModified");
				artifact.Status = _ctx.StringValue("ListArtifacts.Artifacts["+ i +"].Status");

				listArtifactsResponse_artifacts.Add(artifact);
			}
			listArtifactsResponse.Artifacts = listArtifactsResponse_artifacts;
        
			return listArtifactsResponse;
        }
    }
}
