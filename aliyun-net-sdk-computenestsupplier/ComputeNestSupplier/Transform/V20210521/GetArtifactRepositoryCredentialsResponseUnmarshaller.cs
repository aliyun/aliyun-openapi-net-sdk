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
    public class GetArtifactRepositoryCredentialsResponseUnmarshaller
    {
        public static GetArtifactRepositoryCredentialsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetArtifactRepositoryCredentialsResponse getArtifactRepositoryCredentialsResponse = new GetArtifactRepositoryCredentialsResponse();

			getArtifactRepositoryCredentialsResponse.HttpResponse = _ctx.HttpResponse;
			getArtifactRepositoryCredentialsResponse.RequestId = _ctx.StringValue("GetArtifactRepositoryCredentials.RequestId");
			getArtifactRepositoryCredentialsResponse.ExpireDate = _ctx.StringValue("GetArtifactRepositoryCredentials.ExpireDate");

			GetArtifactRepositoryCredentialsResponse.GetArtifactRepositoryCredentials_Credentials credentials = new GetArtifactRepositoryCredentialsResponse.GetArtifactRepositoryCredentials_Credentials();
			credentials.Username = _ctx.StringValue("GetArtifactRepositoryCredentials.Credentials.Username");
			credentials.Password = _ctx.StringValue("GetArtifactRepositoryCredentials.Credentials.Password");
			credentials.AccessKeyId = _ctx.StringValue("GetArtifactRepositoryCredentials.Credentials.AccessKeyId");
			credentials.AccessKeySecret = _ctx.StringValue("GetArtifactRepositoryCredentials.Credentials.AccessKeySecret");
			credentials.SecurityToken = _ctx.StringValue("GetArtifactRepositoryCredentials.Credentials.SecurityToken");
			getArtifactRepositoryCredentialsResponse.Credentials = credentials;

			List<GetArtifactRepositoryCredentialsResponse.GetArtifactRepositoryCredentials_AvailableResourcesItem> getArtifactRepositoryCredentialsResponse_availableResources = new List<GetArtifactRepositoryCredentialsResponse.GetArtifactRepositoryCredentials_AvailableResourcesItem>();
			for (int i = 0; i < _ctx.Length("GetArtifactRepositoryCredentials.AvailableResources.Length"); i++) {
				GetArtifactRepositoryCredentialsResponse.GetArtifactRepositoryCredentials_AvailableResourcesItem availableResourcesItem = new GetArtifactRepositoryCredentialsResponse.GetArtifactRepositoryCredentials_AvailableResourcesItem();
				availableResourcesItem.RegionId = _ctx.StringValue("GetArtifactRepositoryCredentials.AvailableResources["+ i +"].RegionId");
				availableResourcesItem.RepositoryName = _ctx.StringValue("GetArtifactRepositoryCredentials.AvailableResources["+ i +"].RepositoryName");
				availableResourcesItem.Path = _ctx.StringValue("GetArtifactRepositoryCredentials.AvailableResources["+ i +"].Path");

				getArtifactRepositoryCredentialsResponse_availableResources.Add(availableResourcesItem);
			}
			getArtifactRepositoryCredentialsResponse.AvailableResources = getArtifactRepositoryCredentialsResponse_availableResources;
        
			return getArtifactRepositoryCredentialsResponse;
        }
    }
}
