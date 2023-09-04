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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class ListNodeInfosForPodResponseUnmarshaller
    {
        public static ListNodeInfosForPodResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodeInfosForPodResponse listNodeInfosForPodResponse = new ListNodeInfosForPodResponse();

			listNodeInfosForPodResponse.HttpResponse = _ctx.HttpResponse;
			listNodeInfosForPodResponse.Code = _ctx.IntegerValue("ListNodeInfosForPod.Code");
			listNodeInfosForPodResponse.Message = _ctx.StringValue("ListNodeInfosForPod.Message");
			listNodeInfosForPodResponse.RequestId = _ctx.StringValue("ListNodeInfosForPod.RequestId");

			List<ListNodeInfosForPodResponse.ListNodeInfosForPod_ContentItem> listNodeInfosForPodResponse_content = new List<ListNodeInfosForPodResponse.ListNodeInfosForPod_ContentItem>();
			for (int i = 0; i < _ctx.Length("ListNodeInfosForPod.Content.Length"); i++) {
				ListNodeInfosForPodResponse.ListNodeInfosForPod_ContentItem contentItem = new ListNodeInfosForPodResponse.ListNodeInfosForPod_ContentItem();
				contentItem.RegionId = _ctx.StringValue("ListNodeInfosForPod.Content["+ i +"].RegionId");
				contentItem.ClusterId = _ctx.StringValue("ListNodeInfosForPod.Content["+ i +"].ClusterId");
				contentItem.VpcId = _ctx.StringValue("ListNodeInfosForPod.Content["+ i +"].VpcId");
				contentItem.NodeId = _ctx.StringValue("ListNodeInfosForPod.Content["+ i +"].NodeId");
				contentItem.LeniQuota = _ctx.IntegerValue("ListNodeInfosForPod.Content["+ i +"].LeniQuota");
				contentItem.LniSipQuota = _ctx.IntegerValue("ListNodeInfosForPod.Content["+ i +"].LniSipQuota");

				List<string> contentItem_vSwitches = new List<string>();
				for (int j = 0; j < _ctx.Length("ListNodeInfosForPod.Content["+ i +"].VSwitches.Length"); j++) {
					contentItem_vSwitches.Add(_ctx.StringValue("ListNodeInfosForPod.Content["+ i +"].VSwitches["+ j +"]"));
				}
				contentItem.VSwitches = contentItem_vSwitches;

				listNodeInfosForPodResponse_content.Add(contentItem);
			}
			listNodeInfosForPodResponse.Content = listNodeInfosForPodResponse_content;
        
			return listNodeInfosForPodResponse;
        }
    }
}
