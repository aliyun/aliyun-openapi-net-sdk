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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeMountTargetsResponseUnmarshaller
    {
        public static DescribeMountTargetsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMountTargetsResponse describeMountTargetsResponse = new DescribeMountTargetsResponse();

			describeMountTargetsResponse.HttpResponse = _ctx.HttpResponse;
			describeMountTargetsResponse.TotalCount = _ctx.IntegerValue("DescribeMountTargets.TotalCount");
			describeMountTargetsResponse.RequestId = _ctx.StringValue("DescribeMountTargets.RequestId");
			describeMountTargetsResponse.PageSize = _ctx.IntegerValue("DescribeMountTargets.PageSize");
			describeMountTargetsResponse.PageNumber = _ctx.IntegerValue("DescribeMountTargets.PageNumber");

			List<DescribeMountTargetsResponse.DescribeMountTargets_MountTarget> describeMountTargetsResponse_mountTargets = new List<DescribeMountTargetsResponse.DescribeMountTargets_MountTarget>();
			for (int i = 0; i < _ctx.Length("DescribeMountTargets.MountTargets.Length"); i++) {
				DescribeMountTargetsResponse.DescribeMountTargets_MountTarget mountTarget = new DescribeMountTargetsResponse.DescribeMountTargets_MountTarget();
				mountTarget.VpcId = _ctx.StringValue("DescribeMountTargets.MountTargets["+ i +"].VpcId");
				mountTarget.Status = _ctx.StringValue("DescribeMountTargets.MountTargets["+ i +"].Status");
				mountTarget.MountTargetDomain = _ctx.StringValue("DescribeMountTargets.MountTargets["+ i +"].MountTargetDomain");
				mountTarget.AccessGroup = _ctx.StringValue("DescribeMountTargets.MountTargets["+ i +"].AccessGroup");
				mountTarget.DualStackMountTargetDomain = _ctx.StringValue("DescribeMountTargets.MountTargets["+ i +"].DualStackMountTargetDomain");
				mountTarget.VswId = _ctx.StringValue("DescribeMountTargets.MountTargets["+ i +"].VswId");
				mountTarget.NetworkType = _ctx.StringValue("DescribeMountTargets.MountTargets["+ i +"].NetworkType");
				mountTarget.IPVersion = _ctx.StringValue("DescribeMountTargets.MountTargets["+ i +"].IPVersion");
				mountTarget.MountTargetIp = _ctx.StringValue("DescribeMountTargets.MountTargets["+ i +"].MountTargetIp");

				List<DescribeMountTargetsResponse.DescribeMountTargets_MountTarget.DescribeMountTargets_ClientMasterNode> mountTarget_clientMasterNodes = new List<DescribeMountTargetsResponse.DescribeMountTargets_MountTarget.DescribeMountTargets_ClientMasterNode>();
				for (int j = 0; j < _ctx.Length("DescribeMountTargets.MountTargets["+ i +"].ClientMasterNodes.Length"); j++) {
					DescribeMountTargetsResponse.DescribeMountTargets_MountTarget.DescribeMountTargets_ClientMasterNode clientMasterNode = new DescribeMountTargetsResponse.DescribeMountTargets_MountTarget.DescribeMountTargets_ClientMasterNode();
					clientMasterNode.EcsId = _ctx.StringValue("DescribeMountTargets.MountTargets["+ i +"].ClientMasterNodes["+ j +"].EcsId");
					clientMasterNode.DefaultPasswd = _ctx.StringValue("DescribeMountTargets.MountTargets["+ i +"].ClientMasterNodes["+ j +"].DefaultPasswd");
					clientMasterNode.EcsIp = _ctx.StringValue("DescribeMountTargets.MountTargets["+ i +"].ClientMasterNodes["+ j +"].EcsIp");

					mountTarget_clientMasterNodes.Add(clientMasterNode);
				}
				mountTarget.ClientMasterNodes = mountTarget_clientMasterNodes;

				List<DescribeMountTargetsResponse.DescribeMountTargets_MountTarget.DescribeMountTargets_Tag> mountTarget_tags = new List<DescribeMountTargetsResponse.DescribeMountTargets_MountTarget.DescribeMountTargets_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeMountTargets.MountTargets["+ i +"].Tags.Length"); j++) {
					DescribeMountTargetsResponse.DescribeMountTargets_MountTarget.DescribeMountTargets_Tag tag = new DescribeMountTargetsResponse.DescribeMountTargets_MountTarget.DescribeMountTargets_Tag();
					tag.Key = _ctx.StringValue("DescribeMountTargets.MountTargets["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeMountTargets.MountTargets["+ i +"].Tags["+ j +"].Value");

					mountTarget_tags.Add(tag);
				}
				mountTarget.Tags = mountTarget_tags;

				describeMountTargetsResponse_mountTargets.Add(mountTarget);
			}
			describeMountTargetsResponse.MountTargets = describeMountTargetsResponse_mountTargets;
        
			return describeMountTargetsResponse;
        }
    }
}
