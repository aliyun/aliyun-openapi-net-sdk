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
    public class ListApplicationResponseUnmarshaller
    {
        public static ListApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListApplicationResponse listApplicationResponse = new ListApplicationResponse();

			listApplicationResponse.HttpResponse = _ctx.HttpResponse;
			listApplicationResponse.Code = _ctx.IntegerValue("ListApplication.Code");
			listApplicationResponse.Message = _ctx.StringValue("ListApplication.Message");
			listApplicationResponse.RequestId = _ctx.StringValue("ListApplication.RequestId");

			List<ListApplicationResponse.ListApplication_Application> listApplicationResponse_applicationList = new List<ListApplicationResponse.ListApplication_Application>();
			for (int i = 0; i < _ctx.Length("ListApplication.ApplicationList.Length"); i++) {
				ListApplicationResponse.ListApplication_Application application = new ListApplicationResponse.ListApplication_Application();
				application.AppId = _ctx.StringValue("ListApplication.ApplicationList["+ i +"].AppId");
				application.Name = _ctx.StringValue("ListApplication.ApplicationList["+ i +"].Name");
				application.RegionId = _ctx.StringValue("ListApplication.ApplicationList["+ i +"].RegionId");
				application.ApplicationType = _ctx.StringValue("ListApplication.ApplicationList["+ i +"].ApplicationType");
				application.ClusterType = _ctx.IntegerValue("ListApplication.ApplicationList["+ i +"].ClusterType");
				application.ClusterId = _ctx.StringValue("ListApplication.ApplicationList["+ i +"].ClusterId");
				application.BuildPackageId = _ctx.LongValue("ListApplication.ApplicationList["+ i +"].BuildPackageId");
				application.RunningInstanceCount = _ctx.IntegerValue("ListApplication.ApplicationList["+ i +"].RunningInstanceCount");
				application.ResourceGroupId = _ctx.StringValue("ListApplication.ApplicationList["+ i +"].ResourceGroupId");

				listApplicationResponse_applicationList.Add(application);
			}
			listApplicationResponse.ApplicationList = listApplicationResponse_applicationList;
        
			return listApplicationResponse;
        }
    }
}
