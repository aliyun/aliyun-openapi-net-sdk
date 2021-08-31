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
    public class InsertK8sApplicationResponseUnmarshaller
    {
        public static InsertK8sApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			InsertK8sApplicationResponse insertK8sApplicationResponse = new InsertK8sApplicationResponse();

			insertK8sApplicationResponse.HttpResponse = _ctx.HttpResponse;
			insertK8sApplicationResponse.Code = _ctx.IntegerValue("InsertK8sApplication.Code");
			insertK8sApplicationResponse.Message = _ctx.StringValue("InsertK8sApplication.Message");
			insertK8sApplicationResponse.RequestId = _ctx.StringValue("InsertK8sApplication.RequestId");

			InsertK8sApplicationResponse.InsertK8sApplication_ApplicationInfo applicationInfo = new InsertK8sApplicationResponse.InsertK8sApplication_ApplicationInfo();
			applicationInfo.AppName = _ctx.StringValue("InsertK8sApplication.ApplicationInfo.AppName");
			applicationInfo.AppId = _ctx.StringValue("InsertK8sApplication.ApplicationInfo.AppId");
			applicationInfo.UserId = _ctx.StringValue("InsertK8sApplication.ApplicationInfo.UserId");
			applicationInfo.EdasId = _ctx.StringValue("InsertK8sApplication.ApplicationInfo.EdasId");
			applicationInfo.Owner = _ctx.StringValue("InsertK8sApplication.ApplicationInfo.Owner");
			applicationInfo.Dockerize = _ctx.BooleanValue("InsertK8sApplication.ApplicationInfo.Dockerize");
			applicationInfo.ClusterType = _ctx.IntegerValue("InsertK8sApplication.ApplicationInfo.ClusterType");
			applicationInfo.RegionId = _ctx.StringValue("InsertK8sApplication.ApplicationInfo.RegionId");
			applicationInfo.ChangeOrderId = _ctx.StringValue("InsertK8sApplication.ApplicationInfo.ChangeOrderId");
			insertK8sApplicationResponse.ApplicationInfo = applicationInfo;
        
			return insertK8sApplicationResponse;
        }
    }
}
