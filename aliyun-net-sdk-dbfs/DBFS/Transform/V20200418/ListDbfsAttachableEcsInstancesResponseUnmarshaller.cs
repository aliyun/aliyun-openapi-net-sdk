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
    public class ListDbfsAttachableEcsInstancesResponseUnmarshaller
    {
        public static ListDbfsAttachableEcsInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDbfsAttachableEcsInstancesResponse listDbfsAttachableEcsInstancesResponse = new ListDbfsAttachableEcsInstancesResponse();

			listDbfsAttachableEcsInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listDbfsAttachableEcsInstancesResponse.RequestId = _ctx.StringValue("ListDbfsAttachableEcsInstances.RequestId");
			listDbfsAttachableEcsInstancesResponse.TotalCount = _ctx.IntegerValue("ListDbfsAttachableEcsInstances.TotalCount");

			List<ListDbfsAttachableEcsInstancesResponse.ListDbfsAttachableEcsInstances_LabelInfo> listDbfsAttachableEcsInstancesResponse_ecsLabelInfo = new List<ListDbfsAttachableEcsInstancesResponse.ListDbfsAttachableEcsInstances_LabelInfo>();
			for (int i = 0; i < _ctx.Length("ListDbfsAttachableEcsInstances.EcsLabelInfo.Length"); i++) {
				ListDbfsAttachableEcsInstancesResponse.ListDbfsAttachableEcsInstances_LabelInfo labelInfo = new ListDbfsAttachableEcsInstancesResponse.ListDbfsAttachableEcsInstances_LabelInfo();
				labelInfo._Value = _ctx.StringValue("ListDbfsAttachableEcsInstances.EcsLabelInfo["+ i +"].value");
				labelInfo.Label = _ctx.StringValue("ListDbfsAttachableEcsInstances.EcsLabelInfo["+ i +"].label");
				labelInfo.InstanceTypeFamily = _ctx.StringValue("ListDbfsAttachableEcsInstances.EcsLabelInfo["+ i +"].InstanceTypeFamily");
				labelInfo.OSName = _ctx.StringValue("ListDbfsAttachableEcsInstances.EcsLabelInfo["+ i +"].OSName");
				labelInfo.Status = _ctx.StringValue("ListDbfsAttachableEcsInstances.EcsLabelInfo["+ i +"].Status");
				labelInfo.ZoneId = _ctx.StringValue("ListDbfsAttachableEcsInstances.EcsLabelInfo["+ i +"].ZoneId");
				labelInfo.ImageId = _ctx.StringValue("ListDbfsAttachableEcsInstances.EcsLabelInfo["+ i +"].ImageId");

				listDbfsAttachableEcsInstancesResponse_ecsLabelInfo.Add(labelInfo);
			}
			listDbfsAttachableEcsInstancesResponse.EcsLabelInfo = listDbfsAttachableEcsInstancesResponse_ecsLabelInfo;
        
			return listDbfsAttachableEcsInstancesResponse;
        }
    }
}
