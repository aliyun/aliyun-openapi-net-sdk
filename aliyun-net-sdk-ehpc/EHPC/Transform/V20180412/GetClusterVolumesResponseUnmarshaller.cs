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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class GetClusterVolumesResponseUnmarshaller
    {
        public static GetClusterVolumesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetClusterVolumesResponse getClusterVolumesResponse = new GetClusterVolumesResponse();

			getClusterVolumesResponse.HttpResponse = _ctx.HttpResponse;
			getClusterVolumesResponse.RequestId = _ctx.StringValue("GetClusterVolumes.RequestId");
			getClusterVolumesResponse.RegionId = _ctx.StringValue("GetClusterVolumes.RegionId");

			List<GetClusterVolumesResponse.GetClusterVolumes_VolumeInfo> getClusterVolumesResponse_volumes = new List<GetClusterVolumesResponse.GetClusterVolumes_VolumeInfo>();
			for (int i = 0; i < _ctx.Length("GetClusterVolumes.Volumes.Length"); i++) {
				GetClusterVolumesResponse.GetClusterVolumes_VolumeInfo volumeInfo = new GetClusterVolumesResponse.GetClusterVolumes_VolumeInfo();
				volumeInfo.VolumeId = _ctx.StringValue("GetClusterVolumes.Volumes["+ i +"].VolumeId");
				volumeInfo.VolumeType = _ctx.StringValue("GetClusterVolumes.Volumes["+ i +"].VolumeType");
				volumeInfo.VolumeProtocol = _ctx.StringValue("GetClusterVolumes.Volumes["+ i +"].VolumeProtocol");
				volumeInfo.VolumeMountpoint = _ctx.StringValue("GetClusterVolumes.Volumes["+ i +"].VolumeMountpoint");
				volumeInfo.RemoteDirectory = _ctx.StringValue("GetClusterVolumes.Volumes["+ i +"].RemoteDirectory");
				volumeInfo.LocalDirectory = _ctx.StringValue("GetClusterVolumes.Volumes["+ i +"].LocalDirectory");
				volumeInfo.Location = _ctx.StringValue("GetClusterVolumes.Volumes["+ i +"].Location");
				volumeInfo.JobQueue = _ctx.StringValue("GetClusterVolumes.Volumes["+ i +"].JobQueue");
				volumeInfo.MustKeep = _ctx.BooleanValue("GetClusterVolumes.Volumes["+ i +"].MustKeep");

				List<GetClusterVolumesResponse.GetClusterVolumes_VolumeInfo.GetClusterVolumes_RoleInfo> volumeInfo_roles = new List<GetClusterVolumesResponse.GetClusterVolumes_VolumeInfo.GetClusterVolumes_RoleInfo>();
				for (int j = 0; j < _ctx.Length("GetClusterVolumes.Volumes["+ i +"].Roles.Length"); j++) {
					GetClusterVolumesResponse.GetClusterVolumes_VolumeInfo.GetClusterVolumes_RoleInfo roleInfo = new GetClusterVolumesResponse.GetClusterVolumes_VolumeInfo.GetClusterVolumes_RoleInfo();
					roleInfo.Name = _ctx.StringValue("GetClusterVolumes.Volumes["+ i +"].Roles["+ j +"].Name");

					volumeInfo_roles.Add(roleInfo);
				}
				volumeInfo.Roles = volumeInfo_roles;

				getClusterVolumesResponse_volumes.Add(volumeInfo);
			}
			getClusterVolumesResponse.Volumes = getClusterVolumesResponse_volumes;
        
			return getClusterVolumesResponse;
        }
    }
}
