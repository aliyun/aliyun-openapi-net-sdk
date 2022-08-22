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
using Aliyun.Acs.DBFS.Model.V20200418;

namespace Aliyun.Acs.DBFS.Transform.V20200418
{
    public class ListDbfsAttachedEcsInstancesResponseUnmarshaller
    {
        public static ListDbfsAttachedEcsInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDbfsAttachedEcsInstancesResponse listDbfsAttachedEcsInstancesResponse = new ListDbfsAttachedEcsInstancesResponse();

			listDbfsAttachedEcsInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listDbfsAttachedEcsInstancesResponse.RequestId = _ctx.StringValue("ListDbfsAttachedEcsInstances.RequestId");

			List<ListDbfsAttachedEcsInstancesResponse.ListDbfsAttachedEcsInstances_LabelInfo> listDbfsAttachedEcsInstancesResponse_ecsLabelInfo = new List<ListDbfsAttachedEcsInstancesResponse.ListDbfsAttachedEcsInstances_LabelInfo>();
			for (int i = 0; i < _ctx.Length("ListDbfsAttachedEcsInstances.EcsLabelInfo.Length"); i++) {
				ListDbfsAttachedEcsInstancesResponse.ListDbfsAttachedEcsInstances_LabelInfo labelInfo = new ListDbfsAttachedEcsInstancesResponse.ListDbfsAttachedEcsInstances_LabelInfo();
				labelInfo.MountPoint = _ctx.StringValue("ListDbfsAttachedEcsInstances.EcsLabelInfo["+ i +"].MountPoint");
				labelInfo._Value = _ctx.StringValue("ListDbfsAttachedEcsInstances.EcsLabelInfo["+ i +"].value");
				labelInfo.Label = _ctx.StringValue("ListDbfsAttachedEcsInstances.EcsLabelInfo["+ i +"].label");
				labelInfo.MountedTime = _ctx.StringValue("ListDbfsAttachedEcsInstances.EcsLabelInfo["+ i +"].MountedTime");
				labelInfo.InstanceTypeFamily = _ctx.StringValue("ListDbfsAttachedEcsInstances.EcsLabelInfo["+ i +"].InstanceTypeFamily");
				labelInfo.OSName = _ctx.StringValue("ListDbfsAttachedEcsInstances.EcsLabelInfo["+ i +"].OSName");

				listDbfsAttachedEcsInstancesResponse_ecsLabelInfo.Add(labelInfo);
			}
			listDbfsAttachedEcsInstancesResponse.EcsLabelInfo = listDbfsAttachedEcsInstancesResponse_ecsLabelInfo;
        
			return listDbfsAttachedEcsInstancesResponse;
        }
    }
}
