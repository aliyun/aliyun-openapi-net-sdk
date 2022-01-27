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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListK8sPvcResponseUnmarshaller
    {
        public static ListK8sPvcResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListK8sPvcResponse listK8sPvcResponse = new ListK8sPvcResponse();

			listK8sPvcResponse.HttpResponse = _ctx.HttpResponse;
			listK8sPvcResponse.Code = _ctx.IntegerValue("ListK8sPvc.Code");
			listK8sPvcResponse.Message = _ctx.StringValue("ListK8sPvc.Message");
			listK8sPvcResponse.RequestId = _ctx.StringValue("ListK8sPvc.RequestId");

			List<ListK8sPvcResponse.ListK8sPvc_K8sPvcListItem> listK8sPvcResponse_k8sPvcList = new List<ListK8sPvcResponse.ListK8sPvc_K8sPvcListItem>();
			for (int i = 0; i < _ctx.Length("ListK8sPvc.K8sPvcList.Length"); i++) {
				ListK8sPvcResponse.ListK8sPvc_K8sPvcListItem k8sPvcListItem = new ListK8sPvcResponse.ListK8sPvc_K8sPvcListItem();
				k8sPvcListItem.Name = _ctx.StringValue("ListK8sPvc.K8sPvcList["+ i +"].Name");
				k8sPvcListItem._Namespace = _ctx.StringValue("ListK8sPvc.K8sPvcList["+ i +"].Namespace");
				k8sPvcListItem.CreationTime = _ctx.StringValue("ListK8sPvc.K8sPvcList["+ i +"].CreationTime");
				k8sPvcListItem.VolumeName = _ctx.StringValue("ListK8sPvc.K8sPvcList["+ i +"].VolumeName");
				k8sPvcListItem.VolumeMode = _ctx.StringValue("ListK8sPvc.K8sPvcList["+ i +"].VolumeMode");

				listK8sPvcResponse_k8sPvcList.Add(k8sPvcListItem);
			}
			listK8sPvcResponse.K8sPvcList = listK8sPvcResponse_k8sPvcList;
        
			return listK8sPvcResponse;
        }
    }
}
