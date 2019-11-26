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
        public static DescribeMountTargetsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMountTargetsResponse describeMountTargetsResponse = new DescribeMountTargetsResponse();

			describeMountTargetsResponse.HttpResponse = context.HttpResponse;
			describeMountTargetsResponse.RequestId = context.StringValue("DescribeMountTargets.RequestId");
			describeMountTargetsResponse.TotalCount = context.IntegerValue("DescribeMountTargets.TotalCount");
			describeMountTargetsResponse.PageSize = context.IntegerValue("DescribeMountTargets.PageSize");
			describeMountTargetsResponse.PageNumber = context.IntegerValue("DescribeMountTargets.PageNumber");

			List<DescribeMountTargetsResponse.DescribeMountTargets_MountTarget> describeMountTargetsResponse_mountTargets = new List<DescribeMountTargetsResponse.DescribeMountTargets_MountTarget>();
			for (int i = 0; i < context.Length("DescribeMountTargets.MountTargets.Length"); i++) {
				DescribeMountTargetsResponse.DescribeMountTargets_MountTarget mountTarget = new DescribeMountTargetsResponse.DescribeMountTargets_MountTarget();
				mountTarget.MountTargetDomain = context.StringValue("DescribeMountTargets.MountTargets["+ i +"].MountTargetDomain");
				mountTarget.NetworkType = context.StringValue("DescribeMountTargets.MountTargets["+ i +"].NetworkType");
				mountTarget.VpcId = context.StringValue("DescribeMountTargets.MountTargets["+ i +"].VpcId");
				mountTarget.VswId = context.StringValue("DescribeMountTargets.MountTargets["+ i +"].VswId");
				mountTarget.AccessGroup = context.StringValue("DescribeMountTargets.MountTargets["+ i +"].AccessGroup");
				mountTarget.Status = context.StringValue("DescribeMountTargets.MountTargets["+ i +"].Status");

				List<DescribeMountTargetsResponse.DescribeMountTargets_MountTarget.DescribeMountTargets_Tag> mountTarget_tags = new List<DescribeMountTargetsResponse.DescribeMountTargets_MountTarget.DescribeMountTargets_Tag>();
				for (int j = 0; j < context.Length("DescribeMountTargets.MountTargets["+ i +"].Tags.Length"); j++) {
					DescribeMountTargetsResponse.DescribeMountTargets_MountTarget.DescribeMountTargets_Tag tag = new DescribeMountTargetsResponse.DescribeMountTargets_MountTarget.DescribeMountTargets_Tag();
					tag.Key = context.StringValue("DescribeMountTargets.MountTargets["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("DescribeMountTargets.MountTargets["+ i +"].Tags["+ j +"].Value");

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
