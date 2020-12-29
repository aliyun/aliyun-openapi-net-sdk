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
    public class ListVolumesResponseUnmarshaller
    {
        public static ListVolumesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVolumesResponse listVolumesResponse = new ListVolumesResponse();

			listVolumesResponse.HttpResponse = _ctx.HttpResponse;
			listVolumesResponse.RequestId = _ctx.StringValue("ListVolumes.RequestId");
			listVolumesResponse.TotalCount = _ctx.IntegerValue("ListVolumes.TotalCount");
			listVolumesResponse.PageNumber = _ctx.IntegerValue("ListVolumes.PageNumber");
			listVolumesResponse.PageSize = _ctx.IntegerValue("ListVolumes.PageSize");

			List<ListVolumesResponse.ListVolumes_VolumeInfo> listVolumesResponse_volumes = new List<ListVolumesResponse.ListVolumes_VolumeInfo>();
			for (int i = 0; i < _ctx.Length("ListVolumes.Volumes.Length"); i++) {
				ListVolumesResponse.ListVolumes_VolumeInfo volumeInfo = new ListVolumesResponse.ListVolumes_VolumeInfo();
				volumeInfo.RegionId = _ctx.StringValue("ListVolumes.Volumes["+ i +"].RegionId");
				volumeInfo.ClusterId = _ctx.StringValue("ListVolumes.Volumes["+ i +"].ClusterId");
				volumeInfo.ClusterName = _ctx.StringValue("ListVolumes.Volumes["+ i +"].ClusterName");
				volumeInfo.VolumeId = _ctx.StringValue("ListVolumes.Volumes["+ i +"].VolumeId");
				volumeInfo.VolumeType = _ctx.StringValue("ListVolumes.Volumes["+ i +"].VolumeType");
				volumeInfo.VolumeProtocol = _ctx.StringValue("ListVolumes.Volumes["+ i +"].VolumeProtocol");
				volumeInfo.VolumeMountpoint = _ctx.StringValue("ListVolumes.Volumes["+ i +"].VolumeMountpoint");
				volumeInfo.RemoteDirectory = _ctx.StringValue("ListVolumes.Volumes["+ i +"].RemoteDirectory");

				List<ListVolumesResponse.ListVolumes_VolumeInfo.ListVolumes_VolumeInfo1> volumeInfo_additionalVolumes = new List<ListVolumesResponse.ListVolumes_VolumeInfo.ListVolumes_VolumeInfo1>();
				for (int j = 0; j < _ctx.Length("ListVolumes.Volumes["+ i +"].AdditionalVolumes.Length"); j++) {
					ListVolumesResponse.ListVolumes_VolumeInfo.ListVolumes_VolumeInfo1 volumeInfo1 = new ListVolumesResponse.ListVolumes_VolumeInfo.ListVolumes_VolumeInfo1();
					volumeInfo1.VolumeType = _ctx.StringValue("ListVolumes.Volumes["+ i +"].AdditionalVolumes["+ j +"].VolumeType");
					volumeInfo1.VolumeId = _ctx.StringValue("ListVolumes.Volumes["+ i +"].AdditionalVolumes["+ j +"].VolumeId");
					volumeInfo1.VolumeProtocol = _ctx.StringValue("ListVolumes.Volumes["+ i +"].AdditionalVolumes["+ j +"].VolumeProtocol");
					volumeInfo1.VolumeMountpoint = _ctx.StringValue("ListVolumes.Volumes["+ i +"].AdditionalVolumes["+ j +"].VolumeMountpoint");
					volumeInfo1.RemoteDirectory = _ctx.StringValue("ListVolumes.Volumes["+ i +"].AdditionalVolumes["+ j +"].RemoteDirectory");
					volumeInfo1.LocalDirectory = _ctx.StringValue("ListVolumes.Volumes["+ i +"].AdditionalVolumes["+ j +"].LocalDirectory");
					volumeInfo1.Role = _ctx.StringValue("ListVolumes.Volumes["+ i +"].AdditionalVolumes["+ j +"].Role");
					volumeInfo1.Location = _ctx.StringValue("ListVolumes.Volumes["+ i +"].AdditionalVolumes["+ j +"].Location");
					volumeInfo1.JobQueue = _ctx.StringValue("ListVolumes.Volumes["+ i +"].AdditionalVolumes["+ j +"].JobQueue");

					volumeInfo_additionalVolumes.Add(volumeInfo1);
				}
				volumeInfo.AdditionalVolumes = volumeInfo_additionalVolumes;

				listVolumesResponse_volumes.Add(volumeInfo);
			}
			listVolumesResponse.Volumes = listVolumesResponse_volumes;
        
			return listVolumesResponse;
        }
    }
}
